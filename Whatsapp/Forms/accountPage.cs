using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp.Forms
{
    public partial class accountPage : Form
    {
        private int _accountID;

        public accountPage(int AccountID)
        {
            InitializeComponent();

            _accountID = AccountID;
            loadAccountData(AccountID);
            toolTip_info.SetToolTip(button_remove, "Supprimer cette personne de votre liste de contacts");
        }

        public void loadAccountData(int AccountID)
        {
            System.Data.SqlClient.SqlDataReader dataR = Connection.getReader("SELECT Username, Tel, About, Photo, LastSeen FROM Accounts WHERE AccountID = " + AccountID);
            while (dataR.Read())
            {
                Text = "Compte de " + dataR.GetString(0);
                System.IO.MemoryStream memStream = new System.IO.MemoryStream((byte[])dataR.GetValue(3));
                pictureBox_photo.Image = Image.FromStream(memStream);
                label_username.Text = dataR.GetString(0);
                label_number.Text = dataR.GetString(1);
                richTextBox_about.Text = dataR.GetString(2);
                label_lastSeen.Text = ((DateTime.Now - DateTime.Parse(dataR.GetValue(4).ToString())).TotalHours > 24) ? DateTime.Parse(dataR.GetValue(4).ToString()).ToShortDateString() : DateTime.Parse(dataR.GetValue(4).ToString()).ToShortTimeString();
            }
            dataR.Close();
            Connection.closeCon();

            label_friendSince.Text = DateTime.Parse(Connection.getScalar("SELECT DateF FROM Contacts WHERE AccountID = " + Account.Accid + " AND ContactID = " + AccountID + ";").ToString()).ToShortDateString();
            Connection.closeCon();

            int msgCount = Account.getMessageCount(AccountID);
            label_messages.Text = msgCount + " messages" + (msgCount > 1 ? "s" : "");
            Connection.closeCon();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Êtes-vous sûr de vouloir supprimer “"+ label_username.Text +"” de votre liste de contacts?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connection.sendQuery("DELETE FROM Contacts WHERE AccountID = "+ Account.Accid +" AND ContactID = "+ _accountID + ";");
                Connection.closeCon();

                Connection.sendQuery(" DELETE FROM Msgs WHERE SenderID IN(" + Account.Accid + ", " + _accountID + ") AND RecieverID IN(" + Account.Accid + ", " + _accountID + ");");
                Connection.closeCon();

                MessageBox.Show("Vous avez supprimé “"+label_username.Text+"” de votre liste de contacts", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void accountPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            whatsapp whattFor = new whatsapp();
            whattFor.Show();
        }
    }
}
