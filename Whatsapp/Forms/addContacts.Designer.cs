namespace Whatsapp.Forms
{
    partial class addContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addContacts));
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_searchBar = new System.Windows.Forms.Panel();
            this.richTextBox_searchBar = new System.Windows.Forms.RichTextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_result = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_searchBar.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_header.Controls.Add(this.panel_searchBar);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(317, 62);
            this.panel_header.TabIndex = 1;
            // 
            // panel_searchBar
            // 
            this.panel_searchBar.BackColor = System.Drawing.Color.Teal;
            this.panel_searchBar.Controls.Add(this.richTextBox_searchBar);
            this.panel_searchBar.Location = new System.Drawing.Point(24, 10);
            this.panel_searchBar.Name = "panel_searchBar";
            this.panel_searchBar.Padding = new System.Windows.Forms.Padding(3);
            this.panel_searchBar.Size = new System.Drawing.Size(270, 40);
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
            this.richTextBox_searchBar.Location = new System.Drawing.Point(11, 9);
            this.richTextBox_searchBar.Multiline = false;
            this.richTextBox_searchBar.Name = "richTextBox_searchBar";
            this.richTextBox_searchBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox_searchBar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_searchBar.Size = new System.Drawing.Size(248, 34);
            this.richTextBox_searchBar.TabIndex = 1;
            this.richTextBox_searchBar.Text = "Recherche";
            this.richTextBox_searchBar.Click += new System.EventHandler(this.richTextBox_searchBar_Click);
            this.richTextBox_searchBar.TextChanged += new System.EventHandler(this.richTextBox_searchBar_TextChanged);
            this.richTextBox_searchBar.Leave += new System.EventHandler(this.richTextBox_searchBar_Leave);
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.Controls.Add(this.label_result);
            this.panel_main.Location = new System.Drawing.Point(0, 63);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(317, 360);
            this.panel_main.TabIndex = 2;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(46, 28);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(213, 32);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "Il n\'y a aucun résultat correspondant \r\nà votre recherche";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_result.Visible = false;
            // 
            // addContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter de nouveaux contacts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addContacts_FormClosed);
            this.panel_header.ResumeLayout(false);
            this.panel_searchBar.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_searchBar;
        private System.Windows.Forms.RichTextBox richTextBox_searchBar;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_result;
    }
}