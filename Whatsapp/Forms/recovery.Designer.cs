namespace Whatsapp
{
    partial class recovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recovery));
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.groupBox_security = new System.Windows.Forms.GroupBox();
            this.pictureBox_reponseError = new System.Windows.Forms.PictureBox();
            this.textBox_questionS = new System.Windows.Forms.TextBox();
            this.label_questionS = new System.Windows.Forms.Label();
            this.button_recover = new System.Windows.Forms.Button();
            this.textBox_reponseS = new System.Windows.Forms.TextBox();
            this.label_reponseS = new System.Windows.Forms.Label();
            this.button_account = new System.Windows.Forms.Button();
            this.label_number = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.pictureBox_numeroError = new System.Windows.Forms.PictureBox();
            this.pictureBox_nomError = new System.Windows.Forms.PictureBox();
            this.label_step1 = new System.Windows.Forms.Label();
            this.label_step2 = new System.Windows.Forms.Label();
            this.toolTip_info = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_security.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reponseError)).BeginInit();
            this.groupBox_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_numeroError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nomError)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_number
            // 
            this.textBox_number.BackColor = System.Drawing.Color.Teal;
            this.textBox_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_number.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_number.ForeColor = System.Drawing.Color.White;
            this.textBox_number.Location = new System.Drawing.Point(17, 90);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(130, 20);
            this.textBox_number.TabIndex = 2;
            this.textBox_number.TextChanged += new System.EventHandler(this.textBox_number_TextChanged);
            // 
            // groupBox_security
            // 
            this.groupBox_security.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_security.Controls.Add(this.pictureBox_reponseError);
            this.groupBox_security.Controls.Add(this.textBox_questionS);
            this.groupBox_security.Controls.Add(this.label_questionS);
            this.groupBox_security.Controls.Add(this.button_recover);
            this.groupBox_security.Controls.Add(this.textBox_reponseS);
            this.groupBox_security.Controls.Add(this.label_reponseS);
            this.groupBox_security.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_security.ForeColor = System.Drawing.Color.White;
            this.groupBox_security.Location = new System.Drawing.Point(29, 220);
            this.groupBox_security.Name = "groupBox_security";
            this.groupBox_security.Size = new System.Drawing.Size(259, 175);
            this.groupBox_security.TabIndex = 3;
            this.groupBox_security.TabStop = false;
            this.groupBox_security.Text = "Question de sécurité";
            this.groupBox_security.Visible = false;
            // 
            // pictureBox_reponseError
            // 
            this.pictureBox_reponseError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_reponseError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_reponseError.Image = global::Whatsapp.Properties.Resources.error_exclamation1;
            this.pictureBox_reponseError.Location = new System.Drawing.Point(240, 88);
            this.pictureBox_reponseError.Name = "pictureBox_reponseError";
            this.pictureBox_reponseError.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_reponseError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_reponseError.TabIndex = 17;
            this.pictureBox_reponseError.TabStop = false;
            this.pictureBox_reponseError.Visible = false;
            // 
            // textBox_questionS
            // 
            this.textBox_questionS.BackColor = System.Drawing.Color.Teal;
            this.textBox_questionS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_questionS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_questionS.ForeColor = System.Drawing.Color.White;
            this.textBox_questionS.Location = new System.Drawing.Point(17, 37);
            this.textBox_questionS.Name = "textBox_questionS";
            this.textBox_questionS.ReadOnly = true;
            this.textBox_questionS.Size = new System.Drawing.Size(223, 20);
            this.textBox_questionS.TabIndex = 11;
            // 
            // label_questionS
            // 
            this.label_questionS.AutoSize = true;
            this.label_questionS.BackColor = System.Drawing.Color.Transparent;
            this.label_questionS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_questionS.ForeColor = System.Drawing.Color.White;
            this.label_questionS.Location = new System.Drawing.Point(14, 21);
            this.label_questionS.Name = "label_questionS";
            this.label_questionS.Size = new System.Drawing.Size(127, 13);
            this.label_questionS.TabIndex = 12;
            this.label_questionS.Text = "Question de sécurité";
            // 
            // button_recover
            // 
            this.button_recover.BackColor = System.Drawing.Color.Transparent;
            this.button_recover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_recover.Enabled = false;
            this.button_recover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_recover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_recover.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recover.ForeColor = System.Drawing.Color.Black;
            this.button_recover.Location = new System.Drawing.Point(17, 123);
            this.button_recover.Name = "button_recover";
            this.button_recover.Size = new System.Drawing.Size(90, 36);
            this.button_recover.TabIndex = 9;
            this.button_recover.Text = "Récupérer";
            this.button_recover.UseVisualStyleBackColor = false;
            this.button_recover.Click += new System.EventHandler(this.button_recover_Click);
            // 
            // textBox_reponseS
            // 
            this.textBox_reponseS.BackColor = System.Drawing.Color.Teal;
            this.textBox_reponseS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_reponseS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reponseS.ForeColor = System.Drawing.Color.White;
            this.textBox_reponseS.Location = new System.Drawing.Point(17, 88);
            this.textBox_reponseS.Name = "textBox_reponseS";
            this.textBox_reponseS.Size = new System.Drawing.Size(223, 20);
            this.textBox_reponseS.TabIndex = 3;
            this.textBox_reponseS.TextChanged += new System.EventHandler(this.textBox_reponseS_TextChanged);
            // 
            // label_reponseS
            // 
            this.label_reponseS.AutoSize = true;
            this.label_reponseS.BackColor = System.Drawing.Color.Transparent;
            this.label_reponseS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reponseS.ForeColor = System.Drawing.Color.White;
            this.label_reponseS.Location = new System.Drawing.Point(14, 72);
            this.label_reponseS.Name = "label_reponseS";
            this.label_reponseS.Size = new System.Drawing.Size(121, 13);
            this.label_reponseS.TabIndex = 10;
            this.label_reponseS.Text = "Reponse de sécurité";
            // 
            // button_account
            // 
            this.button_account.BackColor = System.Drawing.Color.Transparent;
            this.button_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_account.Enabled = false;
            this.button_account.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account.ForeColor = System.Drawing.Color.Black;
            this.button_account.Location = new System.Drawing.Point(17, 125);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(90, 36);
            this.button_account.TabIndex = 4;
            this.button_account.Text = "Confirmer";
            this.button_account.UseVisualStyleBackColor = false;
            this.button_account.Click += new System.EventHandler(this.button_account_Click_1);
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.BackColor = System.Drawing.Color.Transparent;
            this.label_number.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number.ForeColor = System.Drawing.Color.White;
            this.label_number.Location = new System.Drawing.Point(14, 74);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(121, 13);
            this.label_number.TabIndex = 6;
            this.label_number.Text = "Numéro de telephone";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.BackColor = System.Drawing.Color.Transparent;
            this.label_nom.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.ForeColor = System.Drawing.Color.White;
            this.label_nom.Location = new System.Drawing.Point(14, 23);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(109, 13);
            this.label_nom.TabIndex = 8;
            this.label_nom.Text = "Nom d\'utilisateur";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.Teal;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.ForeColor = System.Drawing.Color.White;
            this.textBox_name.Location = new System.Drawing.Point(17, 39);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(130, 20);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // groupBox_info
            // 
            this.groupBox_info.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_info.Controls.Add(this.pictureBox_numeroError);
            this.groupBox_info.Controls.Add(this.pictureBox_nomError);
            this.groupBox_info.Controls.Add(this.textBox_name);
            this.groupBox_info.Controls.Add(this.label_nom);
            this.groupBox_info.Controls.Add(this.button_account);
            this.groupBox_info.Controls.Add(this.textBox_number);
            this.groupBox_info.Controls.Add(this.label_number);
            this.groupBox_info.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_info.ForeColor = System.Drawing.Color.White;
            this.groupBox_info.Location = new System.Drawing.Point(29, 25);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(259, 176);
            this.groupBox_info.TabIndex = 4;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Compte information";
            // 
            // pictureBox_numeroError
            // 
            this.pictureBox_numeroError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_numeroError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_numeroError.Image = global::Whatsapp.Properties.Resources.error_exclamation1;
            this.pictureBox_numeroError.Location = new System.Drawing.Point(148, 90);
            this.pictureBox_numeroError.Name = "pictureBox_numeroError";
            this.pictureBox_numeroError.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_numeroError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_numeroError.TabIndex = 16;
            this.pictureBox_numeroError.TabStop = false;
            this.pictureBox_numeroError.Visible = false;
            // 
            // pictureBox_nomError
            // 
            this.pictureBox_nomError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_nomError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_nomError.Image = global::Whatsapp.Properties.Resources.error_exclamation1;
            this.pictureBox_nomError.Location = new System.Drawing.Point(148, 39);
            this.pictureBox_nomError.Name = "pictureBox_nomError";
            this.pictureBox_nomError.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_nomError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_nomError.TabIndex = 15;
            this.pictureBox_nomError.TabStop = false;
            this.pictureBox_nomError.Visible = false;
            // 
            // label_step1
            // 
            this.label_step1.AutoSize = true;
            this.label_step1.BackColor = System.Drawing.Color.White;
            this.label_step1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_step1.ForeColor = System.Drawing.Color.Teal;
            this.label_step1.Location = new System.Drawing.Point(194, 19);
            this.label_step1.Name = "label_step1";
            this.label_step1.Padding = new System.Windows.Forms.Padding(5);
            this.label_step1.Size = new System.Drawing.Size(82, 29);
            this.label_step1.TabIndex = 9;
            this.label_step1.Text = "Étape 1";
            // 
            // label_step2
            // 
            this.label_step2.AutoSize = true;
            this.label_step2.BackColor = System.Drawing.Color.White;
            this.label_step2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_step2.ForeColor = System.Drawing.Color.Teal;
            this.label_step2.Location = new System.Drawing.Point(194, 214);
            this.label_step2.Name = "label_step2";
            this.label_step2.Padding = new System.Windows.Forms.Padding(5);
            this.label_step2.Size = new System.Drawing.Size(82, 29);
            this.label_step2.TabIndex = 10;
            this.label_step2.Text = "Étape 2";
            this.label_step2.Visible = false;
            // 
            // toolTip_info
            // 
            this.toolTip_info.BackColor = System.Drawing.Color.Teal;
            this.toolTip_info.ForeColor = System.Drawing.Color.White;
            this.toolTip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip_info.ToolTipTitle = "Erreur d\'entrée";
            // 
            // recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Whatsapp.Properties.Resources.genBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.label_step2);
            this.Controls.Add(this.label_step1);
            this.Controls.Add(this.groupBox_security);
            this.Controls.Add(this.groupBox_info);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "recovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Récupération du compte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.recovery_FormClosed);
            this.groupBox_security.ResumeLayout(false);
            this.groupBox_security.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reponseError)).EndInit();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_numeroError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nomError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.GroupBox groupBox_security;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.TextBox textBox_questionS;
        private System.Windows.Forms.Label label_questionS;
        private System.Windows.Forms.Button button_recover;
        private System.Windows.Forms.TextBox textBox_reponseS;
        private System.Windows.Forms.Label label_reponseS;
        private System.Windows.Forms.Label label_step1;
        private System.Windows.Forms.Label label_step2;
        private System.Windows.Forms.PictureBox pictureBox_reponseError;
        private System.Windows.Forms.PictureBox pictureBox_numeroError;
        private System.Windows.Forms.PictureBox pictureBox_nomError;
        private System.Windows.Forms.ToolTip toolTip_info;
    }
}