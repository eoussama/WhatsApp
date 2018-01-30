using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp.Forms;

namespace Whatsapp
{
    public partial class settings : Form
    {
        Form parentForm;

        public settings(whatsapp parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            pictureBox_photo.Image = Account.Photo;
            label_username.Text = Account.Username;
            richTextBox_about.Text = Account.About;
            label_registrationDate.Text = "Enregistré le " + Account.RegistrationDate.ToShortDateString();
        }

        private void button_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountSettings accSForm = new accountSettings();
            accSForm.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirmer cette action entraînera la suppression définitive de votre compte, il n'y aura pas de récupération de compte par la suite.\n\nÊtes-vous sûr de vouloir supprimer votre compte?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Connection.sendQuery("DELETE FROM Contacts WHERE AccountID = " + Account.Accid + " OR ContactID = " + Account.Accid + ";");
                Connection.sendQuery("DELETE FROM Msgs WHERE SenderID = " + Account.Accid + " OR RecieverID = " + Account.Accid + ";");
                Connection.sendQuery("DELETE FROM appSettings WHERE AccountID = " + Account.Accid + ";");
                Connection.sendQuery("DELETE FROM Accounts WHERE AccountID = " + Account.Accid + ";");

                login logForm = new login();
                logForm.Show();

                this.Close();
                //parentForm.Close();

                MessageBox.Show("Votre compte a bien été supprimé.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un projet de classe a commencé le 20/12/2017, il se concentre sur la réplication de la célèbre application de chat Whatsapp.\n\nUne application simple créée à partir de C# en utilisant Visual Studio et SQL Server pour stocker des données.", "À propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            whatsapp whattForm = new whatsapp();
            whattForm.Show();
        }

        private void button_contacts_Click(object sender, EventArgs e)
        {
            this.Hide();
            addContacts acForm = new addContacts();
            acForm.ShowDialog();
        }

        private void button_app_Click(object sender, EventArgs e)
        {
            this.Hide();
            appSettings appSForm = new appSettings();
            appSForm.ShowDialog();
        }
    }
}
