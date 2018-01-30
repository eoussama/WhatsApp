using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp.UserControls;

namespace Whatsapp
{
    public partial class ucTabs : UserControl
    {
        private int tabID = 0;
        public int test;

        public ucTabs()
        {
            InitializeComponent();
            this.HorizontalScroll.Enabled = false;

            loadChats();
            loadContacts();
            updateTabs(tabID = 1);
        }

        private void button_chats_Click(object sender, EventArgs e)
        {
            updateTabs(tabID = 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateTabs(tabID = 2);
        }

        private void updateTabs(int tabID)
        {
            timer_animation.Start();
        }

        private void timer_animation_Tick(object sender, EventArgs e)
        {
            switch (tabID)
            {
                case 1:
                    {
                        if (panel_selectedPanel.Left > button_chats.Left)
                        {
                            panel_selectedPanel.Left = panel_selectedPanel.Left - 10;
                            panel_main.Left = panel_main.Left + 20;
                        }

                        else
                        {
                            timer_animation.Stop();

                            if (panel_selectedPanel.Left != button_chats.Left)
                                panel_selectedPanel.Left = button_chats.Left;

                            if (panel_main.Left != button_chats.Left)
                                panel_main.Left = button_chats.Left;
                        }

                        break;
                    }

                case 2:
                    {
                        if (panel_selectedPanel.Left < button_contacts.Left)
                        {
                            panel_selectedPanel.Left = panel_selectedPanel.Left + 10;
                            panel_main.Left = panel_main.Left - 20;
                        }

                        else
                        {
                            timer_animation.Stop();

                            if (panel_selectedPanel.Left != button_contacts.Left)
                                panel_selectedPanel.Left = button_contacts.Left;

                            if (panel_main.Right != button_contacts.Left)
                                panel_main.Left = -(panel_main.Width / 2);
                        }

                        break;
                    }
            }
        }

        public void loadContacts()
        {
            System.Data.SqlClient.SqlDataReader dataR;

            if ((dataR = Connection.getReader("SELECT acc_2.AccountID, acc_2.Username, acc_2.Tel, acc_2.LastSeen, acc_2.Photo FROM Accounts acc_1 INNER JOIN Contacts ON acc_1.AccountID = Contacts.AccountID INNER JOIN Accounts acc_2 ON acc_2.AccountID = Contacts.ContactID WHERE acc_1.AccountID = " + Account.Accid + " ORDER BY acc_2.LastSeen DESC;")).HasRows)
            {
                while (dataR.Read())
                {
                    ucContact ucA = new ucContact();
                    ucA.AccID = int.Parse(dataR.GetValue(0).ToString());
                    ucA.Username.Text = dataR[1].ToString();
                    ucA.Number.Text = dataR[2].ToString();
                    ucA.LastSeen.Text = ((DateTime.Now - DateTime.Parse(dataR.GetValue(3).ToString())).TotalHours > 24) ? DateTime.Parse(dataR.GetValue(3).ToString()).ToShortDateString() : DateTime.Parse(dataR.GetValue(3).ToString()).ToShortTimeString();
                    System.IO.MemoryStream memStream = new System.IO.MemoryStream((byte[])dataR.GetValue(4));
                    ucA.Photo.Image = Image.FromStream(memStream);
                    ucA.LastSeen.Left = ucA.Width - ucA.LastSeen.Width - 15;
                    ucA.Left = 2;
                    ucA.Top = ucA.Height * panel_contacts.Controls.OfType<ucContact>().Count<ucContact>();
                    panel_contacts.Controls.Add(ucA);
                }
                dataR.Close();
            }
            else
                label_noContacts.Visible = true;

            Connection.closeCon();
        }

        public void loadChats()
        {
            System.Data.SqlClient.SqlDataReader dataR;
            if ((dataR = Connection.getReader("SELECT DISTINCT ISNULL(m.MessageID, -1), ContactID, m.DateS FROM Contacts c OUTER APPLY (SELECT TOP 1  Msgs.MessageID, Msgs.DateS FROM Msgs WHERE c.ContactID IN (SenderID, RecieverID) AND AccountID IN (SenderID, RecieverID) ORDER BY DateS DESC) m WHERE AccountID = " + Account.Accid+ " ORDER BY m.DateS DESC;")).HasRows)
            {
                while (dataR.Read())
                {
                    ucChat ucC = new ucChat(int.Parse(dataR.GetValue(0).ToString()), int.Parse(dataR.GetValue(1).ToString()));
                    ucC.MessageID = int.Parse(dataR.GetValue(0).ToString());
                    ucC.DateS.Left = ucC.Width - ucC.DateS.Width - 15;
                    ucC.Left = 2;
                    ucC.Top = ucC.Height * panel_chats.Controls.OfType<ucChat>().Count<ucChat>();

                    if(ucC.MessageID == -1)
                    {
                        ucC.Message.Text = "Ce chat n'a pas encore commencé";
                        ucC.SpokenBy.Visible = false;
                        ucC.DateS.Visible = false;
                    }

                    panel_chats.Controls.Add(ucC);
                }
                dataR.Close();
            }
            else
                label_noMessages.Visible = true;

            Connection.closeCon();
            if (panel_chats.Controls.OfType<ucChat>().Count<ucChat>() > 0)
            {
                foreach (ucChat ucC in panel_chats.Controls.OfType<ucChat>())
                {
                    if (ucC.MessageID != -1)
                    {
                        dataR = Connection.getReader("SELECT SenderID, Username, Tel, Photo, DateS, Message FROM Accounts INNER JOIN Msgs ON AccountID IN(Msgs.SenderID, Msgs.RecieverID) WHERE AccountID <> " + Account.Accid + " AND MessageID = " + ucC.MessageID + ";");
                        while (dataR.Read())
                        {
                            ucC.Number.Text = dataR.GetString(2);
                            ucC.SpokenBy.Text = int.Parse(dataR.GetValue(0).ToString()) == Account.Accid ? "You:" : dataR.GetString(1) + ":";
                            ucC.DateS.Text = (DateTime.Now - DateTime.Parse(dataR.GetValue(4).ToString())).TotalHours > 24 ? 48 >= (DateTime.Now - DateTime.Parse(dataR.GetValue(4).ToString())).TotalHours && (DateTime.Now - DateTime.Parse(dataR.GetValue(4).ToString())).TotalHours > 24 ? "Hier" : DateTime.Parse(dataR.GetValue(4).ToString()).ToShortDateString() : DateTime.Parse(dataR.GetValue(4).ToString()).ToShortTimeString();
                            ucC.DateS.Left = ucC.Width - ucC.DateS.Width - 15;
                            ucC.Message.Text = dataR.GetString(5).Length > 25 ? dataR.GetString(5).Substring(0, 25) + "..." : dataR.GetString(5);
                            System.IO.MemoryStream memStream = new System.IO.MemoryStream((byte[])dataR.GetValue(3));
                            ucC.Photo.Image = Image.FromStream(memStream);
                        }
                        dataR.Close();
                        Connection.closeCon();
                    }
                    else
                    {
                        dataR = Connection.getReader("SELECT Tel, Photo, Username FROM Accounts WHERE AccountID = " + ucC.ContactID + ";");
                        while (dataR.Read())
                        {
                            ucC.Number.Text = dataR.GetString(0);
                            ucC.SpokenBy.Text = dataR.GetString(2);
                            System.IO.MemoryStream memStream = new System.IO.MemoryStream((byte[])dataR.GetValue(1));
                            ucC.Photo.Image = Image.FromStream(memStream);
                        }
                        dataR.Close();
                        Connection.closeCon();
                    }
                }

                foreach (ucChat ucC in panel_chats.Controls.OfType<ucChat>())
                {
                    if (ucC.MessageID != -1)
                    {
                        int messageCount = (int)Connection.getScalar("SELECT COUNT(*) FROM Msgs WHERE State = 0 AND SenderID = " + ucC.ContactID + " AND RecieverID = " + Account.Accid + ";");
                        ucC.MessageCount.Text = messageCount == 0 ? "✔" : messageCount.ToString();
                        ucC.MessageCount.BackColor = messageCount == 0 ? Color.Transparent : Color.Green;
                        if (panel_chats.Controls.OfType<ucChat>().Count<ucChat>() > 4)
                        {
                            ucC.MessageCount.Left = ucC.Width - ucC.MessageCount.Width - 17;
                            ucC.DateS.Padding = new Padding(0, 3, 15, 0);
                        }
                        Connection.closeCon();
                    }

                    else
                        ucC.MessageCount.Visible = false;
                }
            }
        }
    }
}
