namespace Whatsapp.Forms
{
    partial class chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.label_number = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.ucClock1 = new Whatsapp.ucClock();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_noMessages = new System.Windows.Forms.Label();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.button_emojiList = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_chatBox = new System.Windows.Forms.TextBox();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Teal;
            this.panel_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_header.Controls.Add(this.pictureBox_photo);
            this.panel_header.Controls.Add(this.label_number);
            this.panel_header.Controls.Add(this.label_username);
            this.panel_header.Controls.Add(this.ucClock1);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(317, 48);
            this.panel_header.TabIndex = 0;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Location = new System.Drawing.Point(2, 2);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(45, 43);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 3;
            this.pictureBox_photo.TabStop = false;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.BackColor = System.Drawing.Color.Transparent;
            this.label_number.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number.ForeColor = System.Drawing.Color.White;
            this.label_number.Location = new System.Drawing.Point(50, 31);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(59, 13);
            this.label_number.TabIndex = 2;
            this.label_number.Text = "06xxxxxxxx";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.White;
            this.label_username.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.Teal;
            this.label_username.Location = new System.Drawing.Point(52, 4);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(96, 23);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            // 
            // ucClock1
            // 
            this.ucClock1.BackColor = System.Drawing.Color.Transparent;
            this.ucClock1.Location = new System.Drawing.Point(190, -5);
            this.ucClock1.Name = "ucClock1";
            this.ucClock1.Size = new System.Drawing.Size(123, 24);
            this.ucClock1.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.Controls.Add(this.label_noMessages);
            this.panel_main.Location = new System.Drawing.Point(0, 47);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(317, 336);
            this.panel_main.TabIndex = 1;
            this.panel_main.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_main_Scroll);
            // 
            // label_noMessages
            // 
            this.label_noMessages.AutoSize = true;
            this.label_noMessages.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noMessages.Location = new System.Drawing.Point(59, 28);
            this.label_noMessages.Name = "label_noMessages";
            this.label_noMessages.Size = new System.Drawing.Size(195, 16);
            this.label_noMessages.TabIndex = 2;
            this.label_noMessages.Text = "Ce chat n\'a pas encore commencé";
            this.label_noMessages.Visible = false;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.Teal;
            this.panel_footer.Controls.Add(this.button_emojiList);
            this.panel_footer.Controls.Add(this.button_send);
            this.panel_footer.Controls.Add(this.textBox_chatBox);
            this.panel_footer.Location = new System.Drawing.Point(0, 384);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(317, 40);
            this.panel_footer.TabIndex = 1;
            // 
            // button_emojiList
            // 
            this.button_emojiList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_emojiList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_emojiList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_emojiList.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_emojiList.Location = new System.Drawing.Point(250, 8);
            this.button_emojiList.Name = "button_emojiList";
            this.button_emojiList.Size = new System.Drawing.Size(30, 26);
            this.button_emojiList.TabIndex = 1;
            this.button_emojiList.Text = "😀";
            this.button_emojiList.UseVisualStyleBackColor = true;
            this.button_emojiList.Click += new System.EventHandler(this.button_emojiList_Click);
            // 
            // button_send
            // 
            this.button_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send.Image = global::Whatsapp.Properties.Resources.icon_apply;
            this.button_send.Location = new System.Drawing.Point(283, 8);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(30, 26);
            this.button_send.TabIndex = 0;
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_chatBox
            // 
            this.textBox_chatBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_chatBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_chatBox.ForeColor = System.Drawing.Color.White;
            this.textBox_chatBox.Location = new System.Drawing.Point(5, 8);
            this.textBox_chatBox.Name = "textBox_chatBox";
            this.textBox_chatBox.Size = new System.Drawing.Size(242, 25);
            this.textBox_chatBox.TabIndex = 0;
            this.textBox_chatBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_chatBox_KeyPress);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversation avec x";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.chat_FormClosed);
            this.Shown += new System.EventHandler(this.chat_Shown);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.TextBox textBox_chatBox;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label_username;
        private ucClock ucClock1;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label_noMessages;
        private System.Windows.Forms.Button button_emojiList;
    }
}