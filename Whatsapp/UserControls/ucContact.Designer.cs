namespace Whatsapp.UserControls
{
    partial class ucContact
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_lastSeen = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_lastSeen
            // 
            this.label_lastSeen.AutoSize = true;
            this.label_lastSeen.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastSeen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_lastSeen.Location = new System.Drawing.Point(256, 4);
            this.label_lastSeen.Name = "label_lastSeen";
            this.label_lastSeen.Size = new System.Drawing.Size(55, 13);
            this.label_lastSeen.TabIndex = 11;
            this.label_lastSeen.Text = "LastSeen";
            this.label_lastSeen.Click += new System.EventHandler(this.pictureBox_photo_Click);
            this.label_lastSeen.MouseEnter += new System.EventHandler(this.label_lastSeen_MouseEnter);
            this.label_lastSeen.MouseLeave += new System.EventHandler(this.label_lastSeen_MouseLeave);
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number.Location = new System.Drawing.Point(82, 30);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(43, 13);
            this.label_number.TabIndex = 10;
            this.label_number.Text = "Number";
            this.label_number.Click += new System.EventHandler(this.pictureBox_photo_Click);
            this.label_number.MouseEnter += new System.EventHandler(this.label_lastSeen_MouseEnter);
            this.label_number.MouseLeave += new System.EventHandler(this.label_lastSeen_MouseLeave);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(82, 4);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(55, 13);
            this.label_username.TabIndex = 9;
            this.label_username.Text = "Username";
            this.label_username.Click += new System.EventHandler(this.pictureBox_photo_Click);
            this.label_username.MouseEnter += new System.EventHandler(this.label_lastSeen_MouseEnter);
            this.label_username.MouseLeave += new System.EventHandler(this.label_lastSeen_MouseLeave);
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(75, 62);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 8;
            this.pictureBox_photo.TabStop = false;
            this.pictureBox_photo.Click += new System.EventHandler(this.pictureBox_photo_Click);
            this.pictureBox_photo.MouseEnter += new System.EventHandler(this.label_lastSeen_MouseEnter);
            this.pictureBox_photo.MouseLeave += new System.EventHandler(this.label_lastSeen_MouseLeave);
            // 
            // ucContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label_lastSeen);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox_photo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucContact";
            this.Size = new System.Drawing.Size(313, 70);
            this.Click += new System.EventHandler(this.ucContact_Click);
            this.MouseEnter += new System.EventHandler(this.ucAccount_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucAccount_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_lastSeen;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox_photo;
    }
}
