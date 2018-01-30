namespace Whatsapp.Forms
{
    partial class appSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appSettings));
            this.panel_background = new System.Windows.Forms.Panel();
            this.button_resetImage = new System.Windows.Forms.Button();
            this.panel_backgroundColor = new System.Windows.Forms.Panel();
            this.label_backgroundColor = new System.Windows.Forms.Label();
            this.pictureBox_bgImage = new System.Windows.Forms.PictureBox();
            this.label_backgroundImage = new System.Windows.Forms.Label();
            this.label_background = new System.Windows.Forms.Label();
            this.label_textAccountColor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_bgContactColor = new System.Windows.Forms.Panel();
            this.panel_bgAccountColor = new System.Windows.Forms.Panel();
            this.panel_textContactColor = new System.Windows.Forms.Panel();
            this.panel_textAccountColor = new System.Windows.Forms.Panel();
            this.label_bgContactColor = new System.Windows.Forms.Label();
            this.label_bgAccountColor = new System.Windows.Forms.Label();
            this.label_textContactColor = new System.Windows.Forms.Label();
            this.label_textColor = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bgImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.BackColor = System.Drawing.Color.Teal;
            this.panel_background.Controls.Add(this.button_resetImage);
            this.panel_background.Controls.Add(this.panel_backgroundColor);
            this.panel_background.Controls.Add(this.label_backgroundColor);
            this.panel_background.Controls.Add(this.pictureBox_bgImage);
            this.panel_background.Controls.Add(this.label_backgroundImage);
            this.panel_background.Location = new System.Drawing.Point(12, 65);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(293, 168);
            this.panel_background.TabIndex = 0;
            // 
            // button_resetImage
            // 
            this.button_resetImage.BackgroundImage = global::Whatsapp.Properties.Resources.icon_remove;
            this.button_resetImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_resetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resetImage.FlatAppearance.BorderSize = 0;
            this.button_resetImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_resetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetImage.Location = new System.Drawing.Point(245, 71);
            this.button_resetImage.Name = "button_resetImage";
            this.button_resetImage.Size = new System.Drawing.Size(32, 31);
            this.button_resetImage.TabIndex = 5;
            this.button_resetImage.UseVisualStyleBackColor = true;
            this.button_resetImage.Click += new System.EventHandler(this.button_resetImage_Click);
            // 
            // panel_backgroundColor
            // 
            this.panel_backgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_backgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_backgroundColor.Location = new System.Drawing.Point(172, 117);
            this.panel_backgroundColor.Name = "panel_backgroundColor";
            this.panel_backgroundColor.Size = new System.Drawing.Size(106, 37);
            this.panel_backgroundColor.TabIndex = 4;
            this.panel_backgroundColor.Click += new System.EventHandler(this.panel_backgroundColor_Click);
            // 
            // label_backgroundColor
            // 
            this.label_backgroundColor.AutoSize = true;
            this.label_backgroundColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backgroundColor.ForeColor = System.Drawing.Color.White;
            this.label_backgroundColor.Location = new System.Drawing.Point(9, 130);
            this.label_backgroundColor.Name = "label_backgroundColor";
            this.label_backgroundColor.Size = new System.Drawing.Size(139, 13);
            this.label_backgroundColor.TabIndex = 2;
            this.label_backgroundColor.Text = "Couleur d\'arrière plan";
            // 
            // pictureBox_bgImage
            // 
            this.pictureBox_bgImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_bgImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_bgImage.Location = new System.Drawing.Point(172, 12);
            this.pictureBox_bgImage.Name = "pictureBox_bgImage";
            this.pictureBox_bgImage.Size = new System.Drawing.Size(106, 96);
            this.pictureBox_bgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bgImage.TabIndex = 1;
            this.pictureBox_bgImage.TabStop = false;
            this.pictureBox_bgImage.Click += new System.EventHandler(this.pictureBox_bgImage_Click);
            // 
            // label_backgroundImage
            // 
            this.label_backgroundImage.AutoSize = true;
            this.label_backgroundImage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backgroundImage.ForeColor = System.Drawing.Color.White;
            this.label_backgroundImage.Location = new System.Drawing.Point(9, 15);
            this.label_backgroundImage.Name = "label_backgroundImage";
            this.label_backgroundImage.Size = new System.Drawing.Size(85, 13);
            this.label_backgroundImage.TabIndex = 0;
            this.label_backgroundImage.Text = "Image de fond";
            // 
            // label_background
            // 
            this.label_background.AutoSize = true;
            this.label_background.BackColor = System.Drawing.Color.White;
            this.label_background.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_background.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_background.Location = new System.Drawing.Point(20, 53);
            this.label_background.Name = "label_background";
            this.label_background.Size = new System.Drawing.Size(73, 19);
            this.label_background.TabIndex = 1;
            this.label_background.Text = "Contexte";
            // 
            // label_textAccountColor
            // 
            this.label_textAccountColor.AutoSize = true;
            this.label_textAccountColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textAccountColor.ForeColor = System.Drawing.Color.White;
            this.label_textAccountColor.Location = new System.Drawing.Point(9, 20);
            this.label_textAccountColor.Name = "label_textAccountColor";
            this.label_textAccountColor.Size = new System.Drawing.Size(121, 13);
            this.label_textAccountColor.TabIndex = 0;
            this.label_textAccountColor.Text = "Ma couleur de texte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel_bgContactColor);
            this.panel1.Controls.Add(this.panel_bgAccountColor);
            this.panel1.Controls.Add(this.panel_textContactColor);
            this.panel1.Controls.Add(this.panel_textAccountColor);
            this.panel1.Controls.Add(this.label_bgContactColor);
            this.panel1.Controls.Add(this.label_bgAccountColor);
            this.panel1.Controls.Add(this.label_textContactColor);
            this.panel1.Controls.Add(this.label_textAccountColor);
            this.panel1.Location = new System.Drawing.Point(12, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 157);
            this.panel1.TabIndex = 4;
            // 
            // panel_bgContactColor
            // 
            this.panel_bgContactColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bgContactColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_bgContactColor.Location = new System.Drawing.Point(232, 117);
            this.panel_bgContactColor.Name = "panel_bgContactColor";
            this.panel_bgContactColor.Size = new System.Drawing.Size(46, 26);
            this.panel_bgContactColor.TabIndex = 6;
            this.panel_bgContactColor.Click += new System.EventHandler(this.panel_bgContactColor_Click);
            // 
            // panel_bgAccountColor
            // 
            this.panel_bgAccountColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bgAccountColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_bgAccountColor.Location = new System.Drawing.Point(232, 82);
            this.panel_bgAccountColor.Name = "panel_bgAccountColor";
            this.panel_bgAccountColor.Size = new System.Drawing.Size(46, 26);
            this.panel_bgAccountColor.TabIndex = 6;
            this.panel_bgAccountColor.Click += new System.EventHandler(this.panel_bgAccountColor_Click);
            // 
            // panel_textContactColor
            // 
            this.panel_textContactColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_textContactColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_textContactColor.Location = new System.Drawing.Point(232, 47);
            this.panel_textContactColor.Name = "panel_textContactColor";
            this.panel_textContactColor.Size = new System.Drawing.Size(46, 26);
            this.panel_textContactColor.TabIndex = 6;
            this.panel_textContactColor.Click += new System.EventHandler(this.panel_textContactColor_Click);
            // 
            // panel_textAccountColor
            // 
            this.panel_textAccountColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_textAccountColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_textAccountColor.Location = new System.Drawing.Point(232, 12);
            this.panel_textAccountColor.Name = "panel_textAccountColor";
            this.panel_textAccountColor.Size = new System.Drawing.Size(46, 26);
            this.panel_textAccountColor.TabIndex = 5;
            this.panel_textAccountColor.Click += new System.EventHandler(this.panel_textAccountColor_Click);
            // 
            // label_bgContactColor
            // 
            this.label_bgContactColor.AutoSize = true;
            this.label_bgContactColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bgContactColor.ForeColor = System.Drawing.Color.White;
            this.label_bgContactColor.Location = new System.Drawing.Point(9, 124);
            this.label_bgContactColor.Name = "label_bgContactColor";
            this.label_bgContactColor.Size = new System.Drawing.Size(217, 13);
            this.label_bgContactColor.TabIndex = 3;
            this.label_bgContactColor.Text = "Couleur de bulle de chat de contact";
            // 
            // label_bgAccountColor
            // 
            this.label_bgAccountColor.AutoSize = true;
            this.label_bgAccountColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bgAccountColor.ForeColor = System.Drawing.Color.White;
            this.label_bgAccountColor.Location = new System.Drawing.Point(9, 90);
            this.label_bgAccountColor.Name = "label_bgAccountColor";
            this.label_bgAccountColor.Size = new System.Drawing.Size(205, 13);
            this.label_bgAccountColor.TabIndex = 2;
            this.label_bgAccountColor.Text = "Ma couleur de bulle de discussion";
            // 
            // label_textContactColor
            // 
            this.label_textContactColor.AutoSize = true;
            this.label_textContactColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textContactColor.ForeColor = System.Drawing.Color.White;
            this.label_textContactColor.Location = new System.Drawing.Point(9, 55);
            this.label_textContactColor.Name = "label_textContactColor";
            this.label_textContactColor.Size = new System.Drawing.Size(169, 13);
            this.label_textContactColor.TabIndex = 1;
            this.label_textContactColor.Text = "Couleur du texte du contact";
            // 
            // label_textColor
            // 
            this.label_textColor.AutoSize = true;
            this.label_textColor.BackColor = System.Drawing.Color.White;
            this.label_textColor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textColor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_textColor.Location = new System.Drawing.Point(20, 241);
            this.label_textColor.Name = "label_textColor";
            this.label_textColor.Size = new System.Drawing.Size(39, 19);
            this.label_textColor.TabIndex = 5;
            this.label_textColor.Text = "Text";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Transparent;
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(213, 13);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(92, 37);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // appSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Whatsapp.Properties.Resources.genBackground;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label_textColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_background);
            this.Controls.Add(this.panel_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "appSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres de l\'application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.appSettings_FormClosed);
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bgImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Label label_background;
        private System.Windows.Forms.Label label_backgroundImage;
        private System.Windows.Forms.PictureBox pictureBox_bgImage;
        private System.Windows.Forms.Label label_backgroundColor;
        private System.Windows.Forms.Label label_textAccountColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_textColor;
        private System.Windows.Forms.Label label_bgContactColor;
        private System.Windows.Forms.Label label_bgAccountColor;
        private System.Windows.Forms.Label label_textContactColor;
        private System.Windows.Forms.Panel panel_backgroundColor;
        private System.Windows.Forms.Panel panel_textAccountColor;
        private System.Windows.Forms.Panel panel_bgContactColor;
        private System.Windows.Forms.Panel panel_bgAccountColor;
        private System.Windows.Forms.Panel panel_textContactColor;
        private System.Windows.Forms.Button button_resetImage;
        private System.Windows.Forms.Button button_reset;
    }
}