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
using Whatsapp.Classes;

namespace Whatsapp.Forms
{
    public partial class chat : Form
    {
        private int ContactID;
        ucEmoji ucEmoji_ = new ucEmoji();

        public chat(int ContactID)
        {
            InitializeComponent();

            this.ContactID = ContactID;

            ucEmoji_.Size = new Size(199, 140);
            ucEmoji_.Location = new Point(81, 205);
            ucEmoji_.Top += 39;
            ucEmoji_.Visible = false;
            ucEmoji_.EmojiClick += new ucEmoji.EmojiClickEventHandler(OnEmojiClick);
            this.Controls.Add(ucEmoji_);
            ucEmoji_.BringToFront();

            customizeForm();
            loadContactData();
            loadMessages();

            Connection.sendQuery("UPDATE Msgs SET State = 1, DateR = '"+DateTime.Now+"' WHERE SenderID = "+ this.ContactID + " AND RecieverID = " + Account.Accid + " AND State = 0;");
        }

        private void chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            whatsapp whattForm = new whatsapp();
            whattForm.Show();
        }

        public void loadContactData()
        {
            System.Data.SqlClient.SqlDataReader dataR = Connection.getReader("SELECT Username, Tel, Photo FROM Accounts WHERE AccountID = " + ContactID + "");
            while (dataR.Read())
            {
                label_username.Text = dataR.GetString(0);
                label_number.Text = dataR.GetString(1);
                System.IO.MemoryStream memStream = new System.IO.MemoryStream((byte[])dataR.GetValue(2));
                pictureBox_photo.Image = Image.FromStream(memStream);
            }
            dataR.Close();
            Connection.closeCon();
        }

        public void loadMessages()
        {
            System.Data.SqlClient.SqlDataReader dataR  = Connection.getReader("SELECT SenderID, Message, DateS, MessageID, State, DateR FROM Msgs WHERE SenderID IN (" + Account.Accid+ ", " + this.ContactID + ") AND RecieverID IN (" + Account.Accid + ", "+this.ContactID+");");
            while (dataR.Read())
            {
                ucMessage ucM = new ucMessage();
                ucM.MessageID = int.Parse(dataR.GetValue(3).ToString());
                ucM.Info.Text = (int.Parse(dataR.GetValue(0).ToString()) == Account.Accid) ? Account.Username : label_username.Text;
                ucM.Info.Text += " • " + ((DateTime.Now - DateTime.Parse(dataR.GetValue(2).ToString())).TotalHours > 24 ? ((DateTime.Now - DateTime.Parse(dataR.GetValue(2).ToString())).TotalHours < 48 ? "Hier" : DateTime.Parse(dataR.GetValue(2).ToString()).ToShortDateString()) : DateTime.Parse(dataR.GetValue(2).ToString()).ToShortTimeString());
                ucM.Message.Text = dataR.GetString(1);
                ucM.Message.Height = getMessageHeigh(ucM.Message) * 15;
                ucM.Height += (getMessageHeigh(ucM.Message) * 15) - 10;
                ucM.Top = (5 + getPreviousHeights()) + panel_main.Controls.OfType<ucMessage>().Count<ucMessage>() * 5;
                ucM.Left = 20;
                ucM.BackColor = AppSettings.ContactBackgroundColor;
                ucM.Message.BackColor = AppSettings.ContactBackgroundColor;
                ucM.Message.ForeColor = AppSettings.ContactTextColor;
                ucM.Info.ForeColor = AppSettings.ContactTextColor;
                ucM.MsgState.Top = ucM.Message.Bottom - 10;
                ToolTip ttInfo = new ToolTip();
                ttInfo.ToolTipIcon = ToolTipIcon.Info;
                ttInfo.ToolTipTitle = "Message pas lu";
                ttInfo.SetToolTip(ucM.MsgState, "L'utilisateur n'a pas encore vu le message");

                if (int.Parse(dataR.GetValue(0).ToString()) == Account.Accid)
                {
                    ucM.Left = (panel_main.Width - ucM.Width) - 20;
                    ucM.BackColor = AppSettings.AccountBackgroundColor;
                    ucM.Message.BackColor = AppSettings.AccountBackgroundColor;
                    ucM.Message.ForeColor = AppSettings.AccountTextColor;
                    ucM.Info.ForeColor = AppSettings.AccountTextColor;
                    ucM.MsgState.Visible = true;
                    if (bool.Parse(dataR.GetValue(4).ToString()) == true)
                    {
                        ucM.MsgState.Image = Properties.Resources.icon_messageRead;
                        ttInfo.ToolTipTitle = "Message lu";
                        ttInfo.SetToolTip(ucM.MsgState, DateTime.Parse(dataR.GetValue(5).ToString()).ToShortTimeString());
                    }
                }

                panel_main.Controls.Add(ucM);
                ucM.Scroll += new ScrollEventHandler(panel_main_Scroll);
            }
            dataR.Close();
            Connection.closeCon();

            if (panel_main.Controls.OfType<ucMessage>().Count<ucMessage>() == 0)
                label_noMessages.Visible = true;
        }

        public int getMessageHeigh(RichTextBox richTextBox)
        {
            int charCount = 0, rowCount = 1;

            for(int i = 0; i<richTextBox.Text.Length; i++)
            {
                if (++charCount == 34)
                {
                    rowCount++;
                    charCount = 0;
                }
            }

            return rowCount;
        }

        public int getPreviousHeights()
        {
            int height = 0;

            foreach (ucMessage ucM in panel_main.Controls.OfType<ucMessage>())
                height += ucM.Height;

            return height;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            ucMessage ucM = new ucMessage();
            ucM.Info.Text = Account.Username + " • " + DateTime.Now.ToShortTimeString();
            ucM.Message.Text = textBox_chatBox.Text;
            ucM.Message.Height = getMessageHeigh(ucM.Message) * 15;
            ucM.Height += (getMessageHeigh(ucM.Message) * 15) - 15;
            ucM.Top = (panel_main.Controls.OfType<ucMessage>().Count<ucMessage>() == 0) ? 5 : panel_main.Controls.OfType<ucMessage>().Last<ucMessage>().Bottom + 5;
            ucM.Left = (panel_main.Width - ucM.Width) - 20;
            ucM.BackColor = AppSettings.AccountBackgroundColor;
            ucM.Message.BackColor = AppSettings.AccountBackgroundColor;
            ucM.Message.ForeColor = AppSettings.AccountTextColor;
            ucM.Info.ForeColor = AppSettings.AccountTextColor;
            ucM.MsgState.Top = ucM.Message.Bottom - 15;
            ucM.MsgState.Visible = true;
            ToolTip ttInfo = new ToolTip();
            ttInfo.ToolTipIcon = ToolTipIcon.Info;
            ttInfo.ToolTipTitle = "Message pas lu";
            ttInfo.SetToolTip(ucM.MsgState, "L'utilisateur n'a pas encore vu le message");

            panel_main.Controls.Add(ucM);
            ucM.Scroll += new ScrollEventHandler(panel_main_Scroll);

            if (panel_main.Controls.OfType<ucMessage>().Count<ucMessage>() == 0)
                label_noMessages.Visible = true;
            else
                label_noMessages.Visible = false;

            Connection.cmd.Parameters.Clear();
            Connection.cmd.Parameters.AddWithValue("@message", textBox_chatBox.Text);
            Connection.sendQuery("INSERT INTO Msgs VALUES("+Account.Accid+", "+this.ContactID+", @message, '"+DateTime.Now+"', 0, '"+DateTime.Now+"');");
            Connection.closeCon();

            ucEmoji_.Visible = false;
            panel_main.ScrollControlIntoView(ucM);
            textBox_chatBox.Clear();
        }

        private void textBox_chatBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                button_send_Click(this, EventArgs.Empty);
        }

        public void customizeForm()
        {
            panel_main.BackColor = AppSettings.BackgroundColor;
            if (AppSettings.BackgroundImage != null)
                panel_main.BackgroundImage = AppSettings.BackgroundImage;
        }

        private void panel_main_Scroll(object sender, ScrollEventArgs e) { }

        private void button_emojiList_Click(object sender, EventArgs e)
        {
            if(ucEmoji_.Visible == false)
                ucEmoji_.Visible = true;
            else
                ucEmoji_.Visible = false;
        }

        private void OnEmojiClick(object sender, EventArgs e)
        {
            textBox_chatBox.Text += ((Emoji)((Button)sender).Tag).EmojiText;
        }

        private void chat_Shown(object sender, EventArgs e)
        {
            if(panel_main.Controls.OfType<ucMessage>().Count<ucMessage>() > 0)
                panel_main.ScrollControlIntoView(panel_main.Controls.OfType<ucMessage>().Last<ucMessage>());
        }
    }
}
