using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp.UserControls;

namespace Whatsapp.Forms
{
    public partial class addContacts : Form
    {
        private List<AccS> accList = new List<AccS>();

        public addContacts()
        {
            InitializeComponent();

            loadAccounts();
        }

        private void addContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings settForm = new settings(new whatsapp());
            settForm.Show();
        }

        private void richTextBox_searchBar_Click(object sender, EventArgs e)
        {
            if (richTextBox_searchBar.Text == "Recherche")
            {
                richTextBox_searchBar.Clear();
                richTextBox_searchBar.ForeColor = Color.White;
            }
        }

        private void richTextBox_searchBar_Leave(object sender, EventArgs e)
        {
            if (richTextBox_searchBar.Text.Length == 0 && richTextBox_searchBar.Text != "Recherche")
            {
                richTextBox_searchBar.Text = "Recherche";
                richTextBox_searchBar.ForeColor = Color.LightSeaGreen;
            }
        }

        public void loadAccounts()
        {
            System.Data.SqlClient.SqlDataReader dataR = Connection.getReader("SELECT acc.AccountID, acc.About, acc.Photo FROM Accounts acc WHERE acc.AccountID <> " + Account.Accid + " AND acc.AccountID NOT IN(SELECT con.ContactID FROM Contacts con WHERE con.AccountID = " + Account.Accid + ");");
            while(dataR.Read())
            {
                ucAccount ucA = new ucAccount(int.Parse(dataR.GetValue(0).ToString()));
                System.IO.MemoryStream memStream = new System.IO.MemoryStream((byte[])dataR.GetValue(2));
                ucA.Photo.Image = Image.FromStream(memStream);
                ucA.About.Text = dataR.GetString(1);
                ucA.Left = 3;
                ucA.Top = (ucA.Height * panel_main.Controls.OfType<ucAccount>().Count<ucAccount>());
                panel_main.Controls.Add(ucA);
                ucA.AccountAdd += UcA_AccountAdd;

                accList.Add(new AccS(int.Parse(dataR.GetValue(0).ToString()), dataR.GetString(1).ToLower(), Image.FromStream(memStream)));
            }
            dataR.Close();
            Connection.closeCon();

            if(panel_main.Controls.OfType<ucAccount>().Count<ucAccount>() <= 5)
            {
                foreach(ucAccount ucA in panel_main.Controls.OfType<ucAccount>())
                {
                    ucA.Width += 18;
                    ucA.About.Width += 5;
                    ucA.Add.Left = (ucA.Width - ucA.Add.Width) - 5;
                }
            }
        }

        private void richTextBox_searchBar_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox_searchBar.Text != "Recherche" && richTextBox_searchBar.Text.Length > 0)
            {
                panel_main.Controls.Clear();

                foreach(AccS account in accList)
                {
                    if(account.About.Contains(richTextBox_searchBar.Text.ToLower()))
                    {
                        ucAccount ucA = new ucAccount(account.AccountID);
                        ucA.Photo.Image = account.Photo;
                        ucA.About.Text = account.About;
                        ucA.Left = 3;
                        ucA.Top = (ucA.Height * panel_main.Controls.OfType<ucAccount>().Count<ucAccount>());
                        panel_main.Controls.Add(ucA);
                    }
                }

                if (panel_main.Controls.OfType<ucAccount>().Count<ucAccount>() <= 5)
                {
                    foreach (ucAccount ucA in panel_main.Controls.OfType<ucAccount>())
                    {
                        ucA.Width += 18;
                        ucA.About.Width += 5;
                        ucA.Add.Left = (ucA.Width - ucA.Add.Width) - 5;
                    }
                }
            }

            else
            {
                panel_main.Controls.Clear();

                foreach (AccS account in accList)
                {
                    ucAccount ucA = new ucAccount(account.AccountID);
                    ucA.Photo.Image = account.Photo;
                    ucA.About.Text = account.About;
                    ucA.Left = 3;
                    ucA.Top = (ucA.Height * panel_main.Controls.OfType<ucAccount>().Count<ucAccount>());
                    panel_main.Controls.Add(ucA);
                }

                if (panel_main.Controls.OfType<ucAccount>().Count<ucAccount>() <= 5)
                {
                    foreach (ucAccount ucA in panel_main.Controls.OfType<ucAccount>())
                    {
                        ucA.Width += 18;
                        ucA.About.Width += 5;
                        ucA.Add.Left = (ucA.Width - ucA.Add.Width) - 5;
                    }
                }
            }
        }

        private void UcA_AccountAdd(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();

            loadAccounts();
        }
    }

    class AccS
    {
        public int AccountID;
        public string About;
        public Image Photo;

        public AccS(int AccountID, string About, Image Photo)
        {
            this.AccountID = AccountID;
            this.About = About;
            this.Photo = Photo;
        }
    }
}
