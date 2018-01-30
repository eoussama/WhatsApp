using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp.Classes;
using System.Text.RegularExpressions;

namespace Whatsapp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            toolTip_info.SetToolTip(pictureBox_passwordError, "Le mot de passe ne doit pas dépasser 30 nombres");

            AppSettings.BackgroundImage = null;
            AppSettings.BackgroundColor = SystemColors.Control;
            AppSettings.AccountBackgroundColor = Color.Teal;
            AppSettings.ContactBackgroundColor = Color.White;
            AppSettings.AccountTextColor = Color.Black;
            AppSettings.ContactTextColor = Color.Black;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                maskedTextBox_number.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string phN = maskedTextBox_number.Text;
                maskedTextBox_number.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                Regex phoneNum = new Regex(@"^(06)\d{8}$");
                if (!phoneNum.IsMatch(phN)) throw new Exception("Le numéro de téléphone entreé est invalid");
                if (textBox_password.Text.Length > 30) throw new Exception("Le mot de passe ne doit pas dépasser 30 caractères");
                if (!Connection.getReader("SELECT AccountID FROM Accounts WHERE Tel = '" + phN + "' AND Password = '"+textBox_password.Text+"';").HasRows) throw new Exception("Le numéro de téléphone ou le mot de passe est incorrect");

                Connection.closeCon();
                System.Data.SqlClient.SqlDataReader dataR = Connection.getReader("SELECT * FROM Accounts WHERE Tel = '" + phN + "' AND Password = '" + textBox_password.Text + "';");

                while (dataR.Read())
                {
                    Account.Accid = int.Parse(dataR.GetValue(0).ToString());
                    Account.Username = dataR.GetString(1);
                    Account.Password = dataR.GetString(2);
                    Account.Tel = dataR.GetString(3);
                    Account.About = dataR.GetString(4);
                    System.IO.MemoryStream memStream = new System.IO.MemoryStream((byte[])dataR.GetValue(5));
                    Account.Photo = Image.FromStream(memStream);
                    Account.SecurityQ = dataR.GetString(6);
                    Account.SecurityA = dataR.GetString(7);
                    Account.LastSeen = (DateTime)dataR.GetValue(8);
                    Account.RegistrationDate = (DateTime)dataR.GetValue(9);
                }

                dataR.Close();
                Connection.closeCon();
                Connection.sendQuery("UPDATE Accounts SET LastSeen = '" + DateTime.Now.ToString() + "' WHERE AccountID = " + Account.Accid + ";");
                dataR = Connection.getReader("SELECT * FROM appSettings WHERE AccountID = "+Account.Accid+";");
                while (dataR.Read())
                {
                    if (dataR.GetValue(1).GetType() != typeof(System.DBNull))
                    {
                        System.IO.MemoryStream memStream = new System.IO.MemoryStream((byte[])dataR.GetValue(1));
                        AppSettings.BackgroundImage = Image.FromStream(memStream);
                    }
                    else
                        AppSettings.BackgroundImage = null;
                    AppSettings.BackgroundColor = Color.FromArgb(int.Parse(dataR.GetValue(2).ToString()), int.Parse(dataR.GetValue(3).ToString()), int.Parse(dataR.GetValue(4).ToString()));
                    AppSettings.AccountBackgroundColor = Color.FromArgb(int.Parse(dataR.GetValue(5).ToString()), int.Parse(dataR.GetValue(6).ToString()), int.Parse(dataR.GetValue(7).ToString()));
                    AppSettings.ContactBackgroundColor = Color.FromArgb(int.Parse(dataR.GetValue(8).ToString()), int.Parse(dataR.GetValue(9).ToString()), int.Parse(dataR.GetValue(10).ToString()));
                    AppSettings.AccountTextColor = Color.FromArgb(int.Parse(dataR.GetValue(11).ToString()), int.Parse(dataR.GetValue(12).ToString()), int.Parse(dataR.GetValue(13).ToString()));
                    AppSettings.ContactTextColor = Color.FromArgb(int.Parse(dataR.GetValue(14).ToString()), int.Parse(dataR.GetValue(15).ToString()), int.Parse(dataR.GetValue(16).ToString()));
                }
                Connection.closeCon();
                whatsapp wtsForm = new whatsapp();
                wtsForm.Show();
                MessageBox.Show("Bienvenue sur votre compte\nvous vous êtes connecté la dernière fois le “ " + Account.LastSeen + " ”", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch(Exception expt)
            {
                MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.closeCon();
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register regForm = new register();
            regForm.ShowDialog();
        }

        private void button_showPass_Click(object sender, EventArgs e)
        {
            if (textBox_password.UseSystemPasswordChar == false && textBox_password.Text != "Mot de passe")
                textBox_password.UseSystemPasswordChar = true;
            else
                textBox_password.UseSystemPasswordChar = false;
        }

        private void linkLabel_recovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            recovery recForm = new recovery();
            recForm.ShowDialog();
        }

        public void updateLoginButton()
        {
            button_login.Enabled = (maskedTextBox_number.Text.Length > 0 && textBox_password.Text.Length > 0 && maskedTextBox_number.Text != "Numéro de téléphone" && textBox_password.Text != "Mot de passe") ? true : false;
        }

        private void textBox_numero_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_number.Text == "Numéro de téléphone")
            {
                maskedTextBox_number.Clear();
                maskedTextBox_number.ForeColor = Color.White;
            }
        }

        private void textBox_numero_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox_number.Text.Length == 0)
            {
                maskedTextBox_number.Text = "Numéro de téléphone";
                maskedTextBox_number.ForeColor = Color.LightSeaGreen;
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_password.Text.Length > 30 && textBox_password.Text != "Mot de passe")
                pictureBox_passwordError.Visible = true;
            else
                pictureBox_passwordError.Visible = false;

            updateLoginButton();
            button_showPass.Enabled = textBox_password.Text.Length > 0 && textBox_password.Text != "Mot de passe" ? true : false;
        }

        private void textBox_password_Click(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Mot de passe")
            {
                textBox_password.UseSystemPasswordChar = true;
                textBox_password.Clear();
                textBox_password.ForeColor = Color.White;
            }
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text.Length == 0)
            {
                textBox_password.UseSystemPasswordChar = false;
                textBox_password.Text = "Mot de passe";
                textBox_password.ForeColor = Color.LightSeaGreen;
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void maskedTextBox_number_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            updateLoginButton();
        }
    }
}
