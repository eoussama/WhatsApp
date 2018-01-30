namespace Whatsapp
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.panel_account = new System.Windows.Forms.Panel();
            this.richTextBox_about = new System.Windows.Forms.RichTextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.button_account = new System.Windows.Forms.Button();
            this.button_app = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_contacts = new System.Windows.Forms.Button();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.label_registrationDate = new System.Windows.Forms.Label();
            this.panel_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_account
            // 
            this.panel_account.BackColor = System.Drawing.Color.Teal;
            this.panel_account.Controls.Add(this.richTextBox_about);
            this.panel_account.Controls.Add(this.label_username);
            this.panel_account.Controls.Add(this.pictureBox_photo);
            this.panel_account.Location = new System.Drawing.Point(0, 0);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(317, 100);
            this.panel_account.TabIndex = 0;
            // 
            // richTextBox_about
            // 
            this.richTextBox_about.BackColor = System.Drawing.Color.Teal;
            this.richTextBox_about.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_about.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_about.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_about.ForeColor = System.Drawing.Color.White;
            this.richTextBox_about.HideSelection = false;
            this.richTextBox_about.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox_about.Location = new System.Drawing.Point(117, 41);
            this.richTextBox_about.Name = "richTextBox_about";
            this.richTextBox_about.ReadOnly = true;
            this.richTextBox_about.Size = new System.Drawing.Size(188, 56);
            this.richTextBox_about.TabIndex = 2;
            this.richTextBox_about.Text = "About";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(113, 9);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(81, 19);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_photo.Image = global::Whatsapp.Properties.Resources.Pic_Placeholder_Male;
            this.pictureBox_photo.Location = new System.Drawing.Point(2, 3);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(108, 94);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 0;
            this.pictureBox_photo.TabStop = false;
            // 
            // button_account
            // 
            this.button_account.BackColor = System.Drawing.Color.Transparent;
            this.button_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_account.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account.Image = global::Whatsapp.Properties.Resources.icon_accout1;
            this.button_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account.Location = new System.Drawing.Point(0, 100);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(317, 59);
            this.button_account.TabIndex = 1;
            this.button_account.Text = "    Paramètres du compte";
            this.button_account.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_account.UseVisualStyleBackColor = false;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // button_app
            // 
            this.button_app.BackColor = System.Drawing.Color.Transparent;
            this.button_app.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_app.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_app.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_app.Image = ((System.Drawing.Image)(resources.GetObject("button_app.Image")));
            this.button_app.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_app.Location = new System.Drawing.Point(0, 216);
            this.button_app.Name = "button_app";
            this.button_app.Size = new System.Drawing.Size(317, 59);
            this.button_app.TabIndex = 2;
            this.button_app.Text = "    Paramètres de l\'application";
            this.button_app.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_app.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_app.UseVisualStyleBackColor = false;
            this.button_app.Click += new System.EventHandler(this.button_app_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Image = global::Whatsapp.Properties.Resources.icon_delete;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.Location = new System.Drawing.Point(0, 274);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(317, 59);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "       Supprimer mon compte";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.Color.Transparent;
            this.button_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_about.Image = global::Whatsapp.Properties.Resources.if_about_2639759;
            this.button_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_about.Location = new System.Drawing.Point(0, 332);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(317, 59);
            this.button_about.TabIndex = 4;
            this.button_about.Text = "    À propos";
            this.button_about.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_contacts
            // 
            this.button_contacts.BackColor = System.Drawing.Color.Transparent;
            this.button_contacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_contacts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contacts.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contacts.Image = ((System.Drawing.Image)(resources.GetObject("button_contacts.Image")));
            this.button_contacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_contacts.Location = new System.Drawing.Point(0, 158);
            this.button_contacts.Name = "button_contacts";
            this.button_contacts.Size = new System.Drawing.Size(317, 59);
            this.button_contacts.TabIndex = 5;
            this.button_contacts.Text = "   Ajouter de nouveaux contacts";
            this.button_contacts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_contacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_contacts.UseVisualStyleBackColor = false;
            this.button_contacts.Click += new System.EventHandler(this.button_contacts_Click);
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.Teal;
            this.panel_footer.Controls.Add(this.label_registrationDate);
            this.panel_footer.Location = new System.Drawing.Point(0, 391);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(317, 33);
            this.panel_footer.TabIndex = 6;
            // 
            // label_registrationDate
            // 
            this.label_registrationDate.AutoSize = true;
            this.label_registrationDate.BackColor = System.Drawing.Color.Transparent;
            this.label_registrationDate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registrationDate.ForeColor = System.Drawing.Color.White;
            this.label_registrationDate.Location = new System.Drawing.Point(3, 10);
            this.label_registrationDate.Name = "label_registrationDate";
            this.label_registrationDate.Size = new System.Drawing.Size(151, 13);
            this.label_registrationDate.TabIndex = 0;
            this.label_registrationDate.Text = "Enregistré le xx/xx/xxxx";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Whatsapp.Properties.Resources.genBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.button_contacts);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_app);
            this.Controls.Add(this.button_account);
            this.Controls.Add(this.panel_account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.settings_FormClosed);
            this.panel_account.ResumeLayout(false);
            this.panel_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_account;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.RichTextBox richTextBox_about;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button button_app;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_contacts;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label label_registrationDate;
    }
}