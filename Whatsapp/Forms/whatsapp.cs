using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp
{
    public partial class whatsapp : Form
    {
        public whatsapp()
        {
            InitializeComponent();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings settForm = new settings(this);
            settForm.ShowDialog();
        }

        private void richTextBox_searchBar_Click_1(object sender, EventArgs e)
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

        private void whatsapp_FormClosing(object sender, FormClosingEventArgs e)
        {
            login logForm = new login();
            if (!logForm.Visible && this.Visible)
            {
                logForm.Show();
                MessageBox.Show("Vous vous êtes déconnecté avec succès", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
