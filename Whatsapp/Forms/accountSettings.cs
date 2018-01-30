using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Whatsapp
{
    public partial class accountSettings : Form
    {
        public accountSettings()
        {
            InitializeComponent();

            pictureBox_photo.Image = Account.Photo;
            textBox_username.Text = Account.Username;
            textBox_number.Text = Account.Tel;
            textBox_about.Text = Account.About;

            toolTip_info.SetToolTip(pictureBox_usernameError, "Le nom d'utilisateur ne doit pas dépasser 30 caractères");
            toolTip_info.SetToolTip(pictureBox_numberError, "Le numéro de téléphone ne doit pas dépasser 10 nombres");
            toolTip_info.SetToolTip(pictureBox_aboutError, "A propos ne doit pas dépasser 100 caractères");
            toolTip_info.SetToolTip(pictureBox_passwordConError, "Le mot de passe ne doit pas dépasser 30 caractères");
            toolTip_info.SetToolTip(pictureBox_passwordNewError, "Le mot de passe ne doit pas dépasser 30 caractères");
            toolTip_info.SetToolTip(pictureBox_reponsSError, "La reponse ne doit pas dépasser 40 caractères");
        }

        private void pictureBox_usernameEdit_Click(object sender, EventArgs e)
        {
            if (textBox_username.ReadOnly == true)
            {
                pictureBox_usernameEdit.Image = Properties.Resources.icon_save;
                textBox_username.ReadOnly = false;
                textBox_username.BackColor = Color.Teal;
                textBox_username.Focus();
            }
            else
            {
                try
                {
                    if (textBox_username.Text.Length == 0) throw new Exception("Vous devez d'abord entrer un nom d'utilisateur");
                    if (textBox_username.Text.Length > 30) throw new Exception("Le nom d'utilisateur ne doit pas dépasser 30 caractères");

                    pictureBox_usernameEdit.Image = Properties.Resources.icon_modify;
                    textBox_username.ReadOnly = true;
                    textBox_username.BackColor = Color.DarkSlateGray;

                    Account.Username = textBox_username.Text;
                    Connection.sendQuery("UPDATE Accounts SET Username = '" + textBox_username.Text + "' WHERE AccountID = " + Account.Accid + ";");
                    MessageBox.Show("Vous avez changé votre nom d'utilisateur", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception expt)
                {
                    MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox_numberEdit_Click(object sender, EventArgs e)
        {
            if (textBox_number.ReadOnly == true)
            {
                pictureBox_numberEdit.Image = Properties.Resources.icon_save;
                textBox_number.ReadOnly = false;
                textBox_number.BackColor = Color.Teal;
                textBox_number.Focus();
            }
            else
            {
                try
                {
                    Regex phoneNum = new Regex(@"^(06)\d{8}$");
                    if (!phoneNum.IsMatch(textBox_number.Text)) throw new Exception("Vous avez entrez un invalide unméro de téléphone");

                    pictureBox_numberEdit.Image = Properties.Resources.icon_modify;
                    textBox_number.ReadOnly = true;
                    textBox_number.BackColor = Color.DarkSlateGray;

                    Account.Tel = textBox_number.Text;
                    Connection.sendQuery("UPDATE Accounts SET Tel = '" + textBox_number.Text + "' WHERE AccountID = " + Account.Accid + ";");
                    MessageBox.Show("Vous avez changé votre numéro de téléphone", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception expt)
                {
                    MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox_aboutEdit_Click(object sender, EventArgs e)
        {
            if (textBox_about.ReadOnly == true)
            {
                pictureBox_aboutEdit.Image = Properties.Resources.icon_save;
                textBox_about.ReadOnly = false;
                textBox_about.BackColor = Color.Teal;
                textBox_about.Focus();
            }
            else
            {
                try
                {
                    if (textBox_about.Text.Length == 0) throw new Exception("Vous devez d'abord entrer un text");
                    if (textBox_about.Text.Length > 100) throw new Exception("A propos ne doit pas dépasser 100 caractères");

                    pictureBox_aboutEdit.Image = Properties.Resources.icon_modify;
                    textBox_about.ReadOnly = true;
                    textBox_about.BackColor = Color.DarkSlateGray;

                    Account.About = textBox_about.Text;
                    Connection.sendQuery("UPDATE Accounts SET About = '" + textBox_about.Text + "' WHERE AccountID = " + Account.Accid + ";");
                    MessageBox.Show("Vous avez changé votre a propos", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception expt)
                {
                    MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            if (textBox_username.Text.Length > 30)
                pictureBox_usernameError.Visible = true;
            else
                pictureBox_usernameError.Visible = false;
        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {
            if (textBox_number.Text.Length > 10)
                pictureBox_numberError.Visible = true;
            else
                pictureBox_numberError.Visible = false;
        }

        private void textBox_about_TextChanged(object sender, EventArgs e)
        {
            if (textBox_about.Text.Length > 100)
                pictureBox_aboutError.Visible = true;
            else
                pictureBox_aboutError.Visible = false;
        }

        private void pictureBox_photoIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog() { Multiselect = false, Title = "Choisis une image", InitialDirectory = "C:\\Pictures", Filter = "Fichiers PNG (*.png)|*.png|Fichiers JPG (*.jpg)|*.jpg|Fichiers GIF (*.gif)|*.gif", FilterIndex = 2 };

            if (openF.ShowDialog() == DialogResult.OK)
            {
                pictureBox_photo.Image = Image.FromFile(openF.FileName);

                System.IO.MemoryStream memStream = new System.IO.MemoryStream();
                pictureBox_photo.Image.Save(memStream, pictureBox_photo.Image.RawFormat);
                byte[] pic = memStream.GetBuffer();
                memStream.Close();
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@photo", pic);
                Account.Photo = pictureBox_photo.Image;
                Connection.sendQuery("UPDATE Accounts SET photo = @photo WHERE AccountID = " + Account.Accid + ";");
                MessageBox.Show("Vous avez changé votre photo", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox_passwordConEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_passwordCon.Text.Length == 0) throw new Exception("Vous devez d'abord entrer votre mot de passe actuel pour confirmer vos actions");
                if (textBox_passwordCon.Text.Length > 30) throw new Exception("Le mot de passe ne doit pas dépasser 30 caractères");
                if (textBox_passwordCon.Text != Account.Password) throw new Exception ("Vous avez entré un mot de passe incorrect");

                comboBox_questionS.Text = Account.SecurityQ;
                textBox_reponsS.Text = Account.SecurityA;
                textBox_passwordCon.Enabled = false;
                pictureBox_passwordConEdit.Enabled = false;
                textBox_passwordNew.Enabled = true;
                comboBox_questionS.Enabled = true;
                textBox_reponsS.Enabled = true;
                pictureBox_passwordNewEdit.Visible = true;
                pictureBox_reponsSEdit.Visible = true;
                textBox_passwordNew.Focus();
                MessageBox.Show("Vous avez confirmé votre mot de passe", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception expt)
            {
                MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_passwordCon_TextChanged(object sender, EventArgs e)
        {
            if (textBox_passwordCon.Text.Length > 30)
            {
                pictureBox_passwordConError.Visible = true;
                pictureBox_passwordConEdit.Visible = false;
            }
            else
            {
                pictureBox_passwordConError.Visible = false;
                pictureBox_passwordConEdit.Visible = true;
            }

            button_showPassCon.Enabled = textBox_passwordCon.Text.Length == 0 ? false : true;
        }

        private void textBox_passwordNew_TextChanged(object sender, EventArgs e)
        {
            if (textBox_passwordNew.Text.Length > 30)
            {
                pictureBox_passwordNewError.Visible = true;
                pictureBox_passwordNewEdit.Visible = false;
            }
            else
            {
                pictureBox_passwordNewError.Visible = false;
                pictureBox_passwordNewEdit.Visible = true;
            }

            button_showPassNew.Enabled = textBox_passwordNew.Text.Length == 0 ? false : true;
        }

        private void textBox_reponsS_TextChanged(object sender, EventArgs e)
        {
            if (textBox_reponsS.Text.Length > 40)
            {
                pictureBox_reponsSError.Visible = true;
                pictureBox_reponsSEdit.Visible = false;
            }
            else
            {
                pictureBox_reponsSError.Visible = false;
                pictureBox_reponsSEdit.Visible = true;
            }
        }

        private void pictureBox_passwordNewEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_passwordNew.Text.Length == 0) throw new Exception("Vous devez d'abord entrer un nouveau mot de passe");
                if (textBox_passwordNew.Text.Length > 30) throw new Exception("Le mot de passe ne doit pas dépasser 30 caractères");
                if (textBox_passwordNew.Text == Account.Password) throw new Exception("Ce mot de passe est identique à votre mot de passe actuel");

                Account.Password = textBox_passwordNew.Text;
                Connection.sendQuery("UPDATE Accounts SET Password = '" + textBox_passwordNew.Text + "' WHERE AccountID = " + Account.Accid + ";");
                MessageBox.Show("Vous avez changé votre mot de passe", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_reponsSEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_reponsS.Text.Length == 0) throw new Exception("Vous devez d'abord entrer une reponse pour la question de sécurité");
                if (textBox_reponsS.Text.Length > 40) throw new Exception("La reponse ne doit pas dépasser 40 caractères");
                if (comboBox_questionS.Text == Account.SecurityQ && textBox_reponsS.Text == Account.SecurityA ) throw new Exception("Cette question de sécurité et/ou réponse est/est identique à votre/vos actuel(s)");

                Account.SecurityQ = comboBox_questionS.Text;
                Account.SecurityA = textBox_reponsS.Text;
                Connection.sendQuery("UPDATE Accounts SET SecurityQ = '" + comboBox_questionS.Text + "', SecurityR = '" + textBox_reponsS.Text + "' WHERE AccountID = " + Account.Accid + ";");
                MessageBox.Show("Vous avez changé votre question et/ou reponse de sécurité", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accountSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings settForm = new settings(new whatsapp());
            settForm.Show();
        }

        private void button_showPassCon_Click(object sender, EventArgs e)
        {
            if (textBox_passwordCon.UseSystemPasswordChar == false)
                textBox_passwordCon.UseSystemPasswordChar = true;
            else
                textBox_passwordCon.UseSystemPasswordChar = false;
        }

        private void button_showPassNew_Click(object sender, EventArgs e)
        {
            if (textBox_passwordNew.UseSystemPasswordChar == false)
                textBox_passwordNew.UseSystemPasswordChar = true;
            else
                textBox_passwordNew.UseSystemPasswordChar = false;
        }
    }
}
