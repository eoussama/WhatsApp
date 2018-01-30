using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp.UserControls
{
    public partial class ucAccount : UserControl
    {
        public delegate void AccountAddEventHandler(object sender, EventArgs e);
        public event AccountAddEventHandler AccountAdd;

        private int accountID;
        private PictureBox photo;
        private RichTextBox about;
        private Button add;

        public ucAccount(int AccountID)
        {
            InitializeComponent();

            this.AccountID = AccountID;
            Photo = pictureBox_photo;
            About = richTextBox_about;
            Add = button_add;

            System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
            gPath.AddEllipse(Photo.DisplayRectangle);
            Photo.Region = new Region(gPath);
        }

        public int AccountID { get { return accountID; } set { accountID = value; } }
        public PictureBox Photo { get { return photo; } set { photo = value; } }
        public RichTextBox About { get { return about; } set { about = value; } }
        public Button Add { get { return add; } set { add = value; } }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (button_add.Text == "Ajouter")
            {
                Connection.sendQuery("INSERT INTO Contacts(AccountID, ContactID) VALUES(" + Account.Accid + ", " + this.AccountID + ");");
                Connection.closeCon();
                Connection.sendQuery("INSERT INTO Contacts(AccountID, ContactID) VALUES(" + this.AccountID + ", " + Account.Accid + ");");
                Connection.closeCon();
                MessageBox.Show("Vous avez ajouté ce compte à votre liste de contacts", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnAccountAdd(sender, e);
            }
        }

        protected virtual void OnAccountAdd(object sender, EventArgs e)
        {
            if (this.AccountAdd != null)
                this.AccountAdd(this, EventArgs.Empty);
        }
    }
}
