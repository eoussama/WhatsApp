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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

            toolTip_info.SetToolTip(pictureBox_nomError, "Le nom d'utilisateur ne doit pas dépasser 30 caractères");
            toolTip_info.SetToolTip(pictureBox_numeroError, "Le numéro de téléphone ne doit pas dépasser 10 nombres");
            toolTip_info.SetToolTip(pictureBox_aboutError, "A propos ne doit pas dépasser 100 caractères");
            toolTip_info.SetToolTip(pictureBox_passwordError, "La mot de passe ne doit pas dépasser 30 caractères");
            toolTip_info.SetToolTip(pictureBox_reponseError, "La réponse de sécurité ne doit pas dépasser 40 caractères");
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                Regex phoneNum = new Regex(@"^(06)\d{8}$");
                if (!phoneNum.IsMatch(textBox_numero.Text)) throw new Exception("Vous avez entrez un invalide unméro de téléphone");
                if (textBox_about.Text.Length > 100) throw new Exception("A propos ne doit pas dépasser 100 caractères");
                if (textBox_password.Text.Length > 30) throw new Exception("Le mot de passe ne doit pas dépasser 30 caractères");
                if (textBox_reponseS.Text.Length > 40) throw new Exception("La réponse de sécurité ne doit pas dépasser 40 caractères");
                if (Connection.getReader("SELECT AccountID FROM Accounts WHERE Tel = '" + textBox_numero.Text + "';").HasRows) throw new Exception("Un compte avec le même numéro de téléphone existe déjà");

                Connection.closeCon();
                System.IO.MemoryStream memStream = new System.IO.MemoryStream();
                pictureBox_photo.Image.Save(memStream, pictureBox_photo.Image.RawFormat);
                byte[] pic = memStream.GetBuffer();
                memStream.Close();
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@photo", pic);
                Connection.cmd.Parameters.AddWithValue("@about", textBox_about.Text);
                Connection.sendQuery("INSERT INTO Accounts(Username, Password, Tel, About, Photo, SecurityQ, SecurityR) VALUES('" + textBox_name.Text + "', '" + textBox_password.Text + "', '" + textBox_numero.Text + "', @about, @photo, '" + comboBox_questionS.Text + "', '" + textBox_reponseS.Text + "');");
                MessageBox.Show("Compte enregistré avec succès", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch(Exception expt)
            {
                MessageBox.Show(expt.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.closeCon();
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtB in this.Controls.OfType<TextBox>())
                txtB.Clear();

            comboBox_questionS.SelectedIndex = -1;
            pictureBox_photo.Image = Properties.Resources.Pic_Placeholder_Male;
            updateClearBtn();
        }

        private void pictureBox_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog() { Multiselect = false, Title = "Choisis une image", InitialDirectory = "C:\\Pictures", Filter = "Fichiers PNG (*.png)|*.png|Fichiers JPG (*.jpg)|*.jpg|Fichiers GIF (*.gif)|*.gif", FilterIndex = 2};

            if (openF.ShowDialog() == DialogResult.OK)
            {
                pictureBox_photo.Image = Image.FromFile(openF.FileName);
                updateClearBtn();
            }
        }

        private void textBox_numero_TextChanged(object sender, EventArgs e)
        {
            if (textBox_numero.Text.Length > 10)
                pictureBox_numeroError.Visible = true;
            else
                pictureBox_numeroError.Visible = false;

            updateRegBtn();
            updateClearBtn();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (textBox_name.Text.Length > 30)
                pictureBox_nomError.Visible = true;
            else
                pictureBox_nomError.Visible = false;

            updateRegBtn();
            updateClearBtn();
        }

        private void textBox_about_TextChanged(object sender, EventArgs e)
        {
            if (textBox_about.Text.Length > 100)
                pictureBox_aboutError.Visible = true;
            else
                pictureBox_aboutError.Visible = false;

            updateRegBtn();
            updateClearBtn();
        }

        private void comboBox_questionS_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateRegBtn();
            updateClearBtn();
        }

        private void textBox_reponseS_TextChanged(object sender, EventArgs e)
        {
            if (textBox_reponseS.Text.Length > 40)
                pictureBox_reponseError.Visible = true;
            else
                pictureBox_reponseError.Visible = false;

            updateRegBtn();
            updateClearBtn();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_password.Text.Length > 40)
                pictureBox_passwordError.Visible = true;
            else
                pictureBox_passwordError.Visible = false;

            button_showPass.Enabled = textBox_password.Text.Length > 0 ? true : false;
            updateRegBtn();
            updateClearBtn();
        }

        public void updateRegBtn()
        {
            button_register.Enabled = textBox_password.Text.Length > 0 && textBox_name.Text.Length > 0 && textBox_numero.Text.Length > 0 && textBox_about.Text.Length > 0 && comboBox_questionS.SelectedIndex != -1 && textBox_reponseS.Text.Length > 0 ? true : false;
        }

        public void updateClearBtn()
        {
            button_reset.Enabled = pictureBox_photo.Image != Properties.Resources.Pic_Placeholder_Male || textBox_name.Text.Length > 0 || textBox_numero.Text.Length > 0 || textBox_password.Text.Length > 0 || textBox_about.Text.Length > 0 || comboBox_questionS.SelectedIndex != -1 || textBox_reponseS.Text.Length > 0 ? true : false;
        }

        private void button_showPass_Click(object sender, EventArgs e)
        {
            if (textBox_password.UseSystemPasswordChar == false && textBox_password.Text != "Mot de passe")
                textBox_password.UseSystemPasswordChar = true;
            else
                textBox_password.UseSystemPasswordChar = false; ;
        }

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            login logForm = new login();
            logForm.Show();
        }
    }
}
