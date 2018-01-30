using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp.Forms;

namespace Whatsapp.UserControls
{
    public partial class ucChat : UserControl
    {
        private int messageID;
        private int contactID;
        private PictureBox photo;
        private Label number;
        private Label dateS;
        private Label message;
        private Label spokenBy;
        private Button messageCount;

        public ucChat(int MessageID, int ContactID)
        {
            InitializeComponent();

            this.MessageID = MessageID;
            this.ContactID = ContactID;
            Photo = pictureBox_photo;
            Number = label_number;
            DateS = label_messageDate;
            Message = label_message;
            SpokenBy = label_spokenBy;
            MessageCount = button_messageCount;

            System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
            gPath.AddEllipse(photo.DisplayRectangle);
            photo.Region = new Region(gPath);

            gPath = new System.Drawing.Drawing2D.GraphicsPath();
            gPath.AddEllipse(button_messageCount.DisplayRectangle);
            button_messageCount.Region = new Region(gPath);

            pictureBox_photo.MouseEnter += new System.EventHandler(this.ucChat_MouseEnter);
            pictureBox_photo.MouseLeave += new System.EventHandler(this.ucChat_MouseLeave);
            label_number.MouseEnter += new System.EventHandler(this.ucChat_MouseEnter);
            label_number.MouseLeave += new System.EventHandler(this.ucChat_MouseLeave);
            label_message.MouseEnter += new System.EventHandler(this.ucChat_MouseEnter);
            label_message.MouseLeave += new System.EventHandler(this.ucChat_MouseLeave);
            label_spokenBy.MouseEnter += new System.EventHandler(this.ucChat_MouseEnter);
            label_spokenBy.MouseLeave += new System.EventHandler(this.ucChat_MouseLeave);
            label_messageDate.MouseEnter += new System.EventHandler(this.ucChat_MouseEnter);
            label_messageDate.MouseLeave += new System.EventHandler(this.ucChat_MouseLeave);
            button_messageCount.MouseEnter += new System.EventHandler(this.ucChat_MouseEnter);
            button_messageCount.MouseLeave += new System.EventHandler(this.ucChat_MouseLeave);

            pictureBox_photo.Click += new System.EventHandler(this.ucChat_Click);
            label_number.Click += new System.EventHandler(this.ucChat_Click);
            label_messageDate.Click += new System.EventHandler(this.ucChat_Click);
            label_spokenBy.Click += new System.EventHandler(this.ucChat_Click);
            label_message.Click += new System.EventHandler(this.ucChat_Click);
        }

        public int MessageID { get { return messageID; } set { messageID = value; } }
        public int ContactID { get { return contactID; } set { contactID = value; } }
        public PictureBox Photo { get { return photo; } set { photo = value; } }
        public Label Number { get { return number; } set { number = value; } }
        public Label DateS { get { return dateS; } set { dateS = value; } }
        public Label Message { get { return message; } set { message = value; } }
        public Label SpokenBy { get { return spokenBy; } set { spokenBy = value; } }
        public Button MessageCount { get { return messageCount; } set { messageCount = value; } }

        private void ucChat_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ucChat_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void ucChat_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            chat chForm = new chat(ContactID);
            chForm.Show();
            chForm.Text = SpokenBy.Text.EndsWith(":") ? SpokenBy.Text.Substring(0, spokenBy.Text.Length - 1) : SpokenBy.Text;
        }

        private void label_spokenBy_MouseEnter(object sender, EventArgs e) { }

        private void label_spokenBy_MouseLeave(object sender, EventArgs e) { }

        private void label_spokenBy_Click(object sender, EventArgs e) { }
    }
}
