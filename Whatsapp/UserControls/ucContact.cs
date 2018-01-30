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
    public partial class ucContact : UserControl
    {
        private int accID;
        private Label username;
        private Label number;
        private Label lastSeen;
        private PictureBox photo;

        public ucContact()
        {
            InitializeComponent();

            Username = label_username;
            Number = label_number;
            LastSeen = label_lastSeen;
            Photo = pictureBox_photo;

            System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
            gPath.AddEllipse(Photo.DisplayRectangle);
            Photo.Region = new Region(gPath);

            this.pictureBox_photo.MouseEnter += new System.EventHandler(this.ucAccount_MouseEnter);
            this.pictureBox_photo.MouseLeave += new System.EventHandler(this.ucAccount_MouseLeave);
            this.label_username.MouseEnter += new System.EventHandler(this.ucAccount_MouseEnter);
            this.label_username.MouseLeave += new System.EventHandler(this.ucAccount_MouseLeave);
            this.label_number.MouseEnter += new System.EventHandler(this.ucAccount_MouseEnter);
            this.label_number.MouseLeave += new System.EventHandler(this.ucAccount_MouseLeave);
            this.label_lastSeen.MouseEnter += new System.EventHandler(this.ucAccount_MouseEnter);
            this.label_lastSeen.MouseLeave += new System.EventHandler(this.ucAccount_MouseLeave);

            this.pictureBox_photo.Click += new System.EventHandler(this.ucContact_Click);
            this.label_username.Click += new System.EventHandler(this.ucContact_Click);
            this.label_number.Click += new System.EventHandler(this.ucContact_Click);
            this.label_lastSeen.Click += new System.EventHandler(this.ucContact_Click);
        }

        public int AccID { get { return accID; } set { accID = value; } }
        public Label Username { get { return username; } set { username = value; } }
        public Label Number { get { return number; } set { number = value; } }
        public Label LastSeen { get { return lastSeen; } set { lastSeen = value; } }
        public PictureBox Photo { get { return photo; } set { photo = value; } }

        private void ucAccount_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ucAccount_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void ucContact_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            accountPage apForm = new accountPage(accID);
            apForm.ShowDialog();
        }

        private void label_lastSeen_MouseEnter(object sender, EventArgs e) { }

        private void label_lastSeen_MouseLeave(object sender, EventArgs e) { }

        private void pictureBox_photo_Click(object sender, EventArgs e) { }
    }
}
