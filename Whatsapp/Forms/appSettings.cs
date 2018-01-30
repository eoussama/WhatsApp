using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp.Classes;
namespace Whatsapp.Forms
{
    public partial class appSettings : Form
    {
        public appSettings()
        {
            InitializeComponent();

            pictureBox_bgImage.Image = AppSettings.BackgroundImage;
            panel_backgroundColor.BackColor = AppSettings.BackgroundColor;
            panel_textAccountColor.BackColor = AppSettings.AccountTextColor;
            panel_textContactColor.BackColor = AppSettings.ContactTextColor;
            panel_bgAccountColor.BackColor = AppSettings.AccountBackgroundColor;
            panel_bgContactColor.BackColor = AppSettings.ContactBackgroundColor;
        }

        private void pictureBox_bgImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog() { Multiselect = false, Title = "Choisis une image", InitialDirectory = "C:\\Pictures", Filter = "Fichiers PNG (*.png)|*.png|Fichiers JPG (*.jpg)|*.jpg", FilterIndex = 2 };

            if (openF.ShowDialog() == DialogResult.OK)
            {
                pictureBox_bgImage.Image = Image.FromFile(openF.FileName);
                AppSettings.BackgroundImage = pictureBox_bgImage.Image;
            }
        }

        private void panel_backgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog() { Color = panel_backgroundColor.BackColor };

            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                panel_backgroundColor.BackColor = cDialog.Color;
                AppSettings.BackgroundColor = cDialog.Color;
            }
        }

        private void panel_textAccountColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog() { Color = panel_textAccountColor.BackColor };

            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                panel_textAccountColor.BackColor = cDialog.Color;
                AppSettings.AccountTextColor = cDialog.Color;
            }
        }

        private void panel_textContactColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog() { Color = panel_textContactColor.BackColor };

            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                panel_textContactColor.BackColor = cDialog.Color;
                AppSettings.ContactTextColor = cDialog.Color;
            }
        }

        private void panel_bgAccountColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog() { Color = panel_bgAccountColor.BackColor };

            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                panel_bgAccountColor.BackColor = cDialog.Color;
                AppSettings.AccountBackgroundColor = cDialog.Color;
            }
        }

        private void panel_bgContactColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog() { Color = panel_bgContactColor.BackColor };

            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                panel_bgContactColor.BackColor = cDialog.Color;
                AppSettings.ContactBackgroundColor = cDialog.Color;
            }
        }

        private void button_resetImage_Click(object sender, EventArgs e)
        {
            pictureBox_bgImage.Image = null;
            AppSettings.BackgroundImage = null;
        }

        private void appSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            byte[] pic = null;
            if (pictureBox_bgImage.Image != null)
            {
                System.IO.MemoryStream memStream = new System.IO.MemoryStream();
                pictureBox_bgImage.Image.Save(memStream, pictureBox_bgImage.Image.RawFormat);
                pic = memStream.GetBuffer();
            }

            Connection.cmd.Parameters.Clear();
            Connection.cmd.Parameters.AddWithValue("@photo", pic == null ? (object)System.DBNull.Value : pic).SqlDbType = SqlDbType.Image;
            Connection.sendQuery("UPDATE appSettings SET BackgroundImage = @photo, BackgroundColorR = "+panel_backgroundColor.BackColor.R+", BackgroundColorG = "+ panel_backgroundColor.BackColor.G+ ", BackgroundColorB = "+ panel_backgroundColor.BackColor.B+ ", AccountBackgroundColorR = "+panel_bgAccountColor.BackColor.R+", AccountBackgroundColorG = "+panel_bgAccountColor.BackColor.G+", AccountBackgroundColorB = "+ panel_bgAccountColor.BackColor.B+ ", ContactBackgrounColorR = "+panel_bgContactColor.BackColor.R+", ContactBackgrounColorG = "+ panel_bgContactColor.BackColor.G+ ", ContactBackgrounColorB = "+ panel_bgContactColor.BackColor.B+ ", AccountTextColorR = "+panel_textAccountColor.BackColor.R+", AccountTextColorG = "+ panel_textAccountColor.BackColor.G+ ", AccountTextColorB = "+ panel_textAccountColor.BackColor.B+ ", ContactTextColorR = "+panel_textContactColor.BackColor.R+", ContactTextColorG = "+ panel_textContactColor.BackColor .G+ ", ContactTextColorB = "+ panel_textContactColor.BackColor.B+ " WHERE AccountID = "+Account.Accid+";");
            Connection.closeCon();

            settings settForm = new settings(new whatsapp());
            settForm.ShowDialog();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            AppSettings.BackgroundImage = pictureBox_bgImage.Image = null;
            AppSettings.BackgroundColor = panel_backgroundColor.BackColor = SystemColors.Control;
            AppSettings.AccountBackgroundColor = panel_bgAccountColor.BackColor = Color.DarkSlateGray;
            AppSettings.ContactBackgroundColor = panel_bgContactColor.BackColor = Color.White;
            AppSettings.AccountTextColor = panel_textAccountColor.BackColor = Color.Black;
            AppSettings.ContactTextColor = panel_textContactColor.BackColor = Color.Black;
        }
    }
}
