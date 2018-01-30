namespace Whatsapp
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_account = new System.Windows.Forms.Panel();
            this.pictureBox_passwordError = new System.Windows.Forms.PictureBox();
            this.button_showPass = new System.Windows.Forms.Button();
            this.linkLabel_recovery = new System.Windows.Forms.LinkLabel();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.toolTip_info = new System.Windows.Forms.ToolTip(this.components);
            this.timer_intro = new System.Windows.Forms.Timer(this.components);
            this.maskedTextBox_number = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passwordError)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Image = global::Whatsapp.Properties.Resources.whatsapp_logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(98, 36);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(129, 123);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(95, 162);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(135, 32);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "WhatsApp";
            // 
            // panel_account
            // 
            this.panel_account.BackColor = System.Drawing.Color.Transparent;
            this.panel_account.Controls.Add(this.maskedTextBox_number);
            this.panel_account.Controls.Add(this.pictureBox_passwordError);
            this.panel_account.Controls.Add(this.button_showPass);
            this.panel_account.Controls.Add(this.linkLabel_recovery);
            this.panel_account.Controls.Add(this.button_login);
            this.panel_account.Controls.Add(this.button_register);
            this.panel_account.Controls.Add(this.textBox_password);
            this.panel_account.Location = new System.Drawing.Point(40, 210);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(233, 170);
            this.panel_account.TabIndex = 2;
            // 
            // pictureBox_passwordError
            // 
            this.pictureBox_passwordError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_passwordError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_passwordError.Image = global::Whatsapp.Properties.Resources.error_exclamation1;
            this.pictureBox_passwordError.Location = new System.Drawing.Point(202, 64);
            this.pictureBox_passwordError.Name = "pictureBox_passwordError";
            this.pictureBox_passwordError.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_passwordError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_passwordError.TabIndex = 17;
            this.pictureBox_passwordError.TabStop = false;
            this.pictureBox_passwordError.Visible = false;
            // 
            // button_showPass
            // 
            this.button_showPass.BackColor = System.Drawing.Color.Transparent;
            this.button_showPass.BackgroundImage = global::Whatsapp.Properties.Resources.Lock;
            this.button_showPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showPass.Enabled = false;
            this.button_showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showPass.Location = new System.Drawing.Point(182, 66);
            this.button_showPass.Name = "button_showPass";
            this.button_showPass.Size = new System.Drawing.Size(15, 15);
            this.button_showPass.TabIndex = 5;
            this.button_showPass.UseVisualStyleBackColor = false;
            this.button_showPass.Click += new System.EventHandler(this.button_showPass_Click);
            // 
            // linkLabel_recovery
            // 
            this.linkLabel_recovery.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel_recovery.AutoSize = true;
            this.linkLabel_recovery.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_recovery.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel_recovery.Location = new System.Drawing.Point(46, 88);
            this.linkLabel_recovery.Name = "linkLabel_recovery";
            this.linkLabel_recovery.Size = new System.Drawing.Size(148, 14);
            this.linkLabel_recovery.TabIndex = 4;
            this.linkLabel_recovery.TabStop = true;
            this.linkLabel_recovery.Text = "J\'ai oublier mon mot de passe";
            this.linkLabel_recovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_recovery_LinkClicked);
            // 
            // button_login
            // 
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Enabled = false;
            this.button_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(36, 121);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 31);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.Location = new System.Drawing.Point(126, 121);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 31);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "S\'inscrire";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.Teal;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_password.Location = new System.Drawing.Point(36, 62);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(165, 23);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.Text = "Mot de passe";
            this.textBox_password.Click += new System.EventHandler(this.textBox_password_Click);
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            this.textBox_password.Leave += new System.EventHandler(this.textBox_password_Leave);
            // 
            // toolTip_info
            // 
            this.toolTip_info.BackColor = System.Drawing.Color.Teal;
            this.toolTip_info.ForeColor = System.Drawing.Color.White;
            this.toolTip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip_info.ToolTipTitle = "Erreur d\'entrée";
            // 
            // maskedTextBox_number
            // 
            this.maskedTextBox_number.BackColor = System.Drawing.Color.Teal;
            this.maskedTextBox_number.BeepOnError = true;
            this.maskedTextBox_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_number.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_number.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_number.Location = new System.Drawing.Point(36, 17);
            this.maskedTextBox_number.Mask = "00-00-00-00-00";
            this.maskedTextBox_number.Name = "maskedTextBox_number";
            this.maskedTextBox_number.Size = new System.Drawing.Size(165, 23);
            this.maskedTextBox_number.TabIndex = 1;
            this.maskedTextBox_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_info.SetToolTip(this.maskedTextBox_number, "Entrez un numéro de téléphone commençant par 06 et contenant 10 numéros");
            this.maskedTextBox_number.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_number_MaskInputRejected);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Whatsapp.Properties.Resources.genBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.panel_account);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_account.ResumeLayout(false);
            this.panel_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passwordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel_account;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.LinkLabel linkLabel_recovery;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_showPass;
        private System.Windows.Forms.PictureBox pictureBox_passwordError;
        private System.Windows.Forms.ToolTip toolTip_info;
        private System.Windows.Forms.Timer timer_intro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_number;
    }
}