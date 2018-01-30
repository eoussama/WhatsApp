namespace Whatsapp
{
    partial class whatsapp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(whatsapp));
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_searchBar = new System.Windows.Forms.Panel();
            this.richTextBox_searchBar = new System.Windows.Forms.RichTextBox();
            this.ucTabs1 = new Whatsapp.ucTabs();
            this.button_settings = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_searchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_header.Controls.Add(this.button_settings);
            this.panel_header.Controls.Add(this.panel_searchBar);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(317, 62);
            this.panel_header.TabIndex = 0;
            // 
            // panel_searchBar
            // 
            this.panel_searchBar.BackColor = System.Drawing.Color.Teal;
            this.panel_searchBar.Controls.Add(this.richTextBox_searchBar);
            this.panel_searchBar.Location = new System.Drawing.Point(8, 9);
            this.panel_searchBar.Name = "panel_searchBar";
            this.panel_searchBar.Padding = new System.Windows.Forms.Padding(3);
            this.panel_searchBar.Size = new System.Drawing.Size(265, 40);
            this.panel_searchBar.TabIndex = 0;
            // 
            // richTextBox_searchBar
            // 
            this.richTextBox_searchBar.BackColor = System.Drawing.Color.Teal;
            this.richTextBox_searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_searchBar.BulletIndent = 5;
            this.richTextBox_searchBar.DetectUrls = false;
            this.richTextBox_searchBar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_searchBar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.richTextBox_searchBar.Location = new System.Drawing.Point(8, 8);
            this.richTextBox_searchBar.Multiline = false;
            this.richTextBox_searchBar.Name = "richTextBox_searchBar";
            this.richTextBox_searchBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox_searchBar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_searchBar.Size = new System.Drawing.Size(248, 34);
            this.richTextBox_searchBar.TabIndex = 1;
            this.richTextBox_searchBar.Text = "Recherche";
            this.richTextBox_searchBar.Click += new System.EventHandler(this.richTextBox_searchBar_Click_1);
            this.richTextBox_searchBar.Leave += new System.EventHandler(this.richTextBox_searchBar_Leave);
            // 
            // ucTabs1
            // 
            this.ucTabs1.BackColor = System.Drawing.Color.Transparent;
            this.ucTabs1.Location = new System.Drawing.Point(0, 61);
            this.ucTabs1.Name = "ucTabs1";
            this.ucTabs1.Size = new System.Drawing.Size(317, 363);
            this.ucTabs1.TabIndex = 1;
            // 
            // button_settings
            // 
            this.button_settings.BackgroundImage = global::Whatsapp.Properties.Resources.icon_settings_hoverOff;
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Location = new System.Drawing.Point(279, 9);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(34, 40);
            this.button_settings.TabIndex = 1;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // whatsapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.ucTabs1);
            this.Controls.Add(this.panel_header);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "whatsapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.whatsapp_FormClosing);
            this.panel_header.ResumeLayout(false);
            this.panel_searchBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.RichTextBox richTextBox_searchBar;
        private System.Windows.Forms.Panel panel_searchBar;
        private ucTabs ucTabs1;
    }
}

