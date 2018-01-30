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
    public partial class recovery : Form
    {
        string securityA;

        public recovery()
        {
            InitializeComponent();

            toolTip_info.SetToolTip(pictureBox_nomError, "Le nom d'utilisateur ne doit pas dépasser 30 caractères");
            toolTip_info.SetToolTip(pictureBox_numeroError, "Le numéro de téléphone ne doit pas dépasser 10 nombres");
            toolTip_info.SetToolTip(pictureBox_reponseError, "La réponse de sécurité ne doit pas dépasser 40 caractères");
        }

        private void button_account_Click_1(object sender, EventArgs e)
        {
            try
            {
                Regex phoneNum = new Regex(@"^(06)\d{8}$");
                if (!phoneNum.IsMatch(textBox_number.Text)) throw new Exception("Vous avez entrez un invalide unméro de téléphone");
                if (textBox_reponseS.Text.Length > 40) throw new Exception("La réponse de sécurité ne doit pas dépasser 40 caractères");
                if (!Connection.getReader("SELECT AccountID FROM Accounts WHERE Tel = '" + textBox_number.Text + "' AND Username = '"+ textBox_name.Text + "';").HasRows) throw new Exception("Il n'y a pas de numéro de téléphone ou nom d'utiliateur correspondant à celui que vous avez entré");

                Connection.closeCon();
                groupBox_security.Visible = true;
                label_step2.Visible = true;

                System.Data.SqlClient.SqlDataReader dataR = Connection.getReader("SELECT SecurityQ, SecurityR FROM Accounts WHERE Tel = '" + textBox_number.Text + "' AND Username = '" + textBox_name.Text + "';");
                while (dataR.Read())
                {
                    textBox_questionS.Text = dataR.GetString(0);
                    securityA = dataR.GetString(1);
                }
                dataR.Close();
                Connection.closeCon();
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.closeCon();
            }
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (textBox_name.Text.Length > 30)
                pictureBox_nomError.Visible = true;
            else
                pictureBox_nomError.Visible = false;

            updateConBtn();
        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {
            if (textBox_number.Text.Length > 10)
                pictureBox_numeroError.Visible = true;
            else
                pictureBox_numeroError.Visible = false;

            updateConBtn();
        }

        private void textBox_reponseS_TextChanged(object sender, EventArgs e)
        {
            if (textBox_reponseS.Text.Length > 40)
                pictureBox_reponseError.Visible = true;
            else
                pictureBox_reponseError.Visible = false;

            button_recover.Enabled = textBox_reponseS.Text.Length > 0 ? true : false;
        }

        public void updateConBtn()
        {
            button_account.Enabled = textBox_name.Text.Length > 0 && textBox_number.Text.Length > 0 ? true : false;
        }

        private void button_recover_Click(object sender, EventArgs e)
        {
            if (textBox_reponseS.Text.ToLower() != securityA.ToLower()) MessageBox.Show("Vous avez entré la mauvaise réponse pour la question donnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string password = Connection.getScalar("SELECT Password FROM Accounts WHERE Tel = '" + textBox_number.Text + "' AND Username = '" + textBox_name.Text + "';").ToString();

                MessageBox.Show("La question de sécurité a été confirmée avec succès!\nvotre mot de passe est “"+password+"”\n\nAssurez - vous de le changer dès que possible", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void recovery_FormClosed(object sender, FormClosedEventArgs e)
        {
            login logForm = new login();
            logForm.Show();
        }
    }
}
