namespace Whatsapp
{
    partial class ucTabs
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
            this.components = new System.ComponentModel.Container();
            this.button_chats = new System.Windows.Forms.Button();
            this.button_contacts = new System.Windows.Forms.Button();
            this.panel_selectedPanel = new System.Windows.Forms.Panel();
            this.timer_animation = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_chats = new System.Windows.Forms.Panel();
            this.label_noMessages = new System.Windows.Forms.Label();
            this.panel_contacts = new System.Windows.Forms.Panel();
            this.label_noContacts = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_chats.SuspendLayout();
            this.panel_contacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_chats
            // 
            this.button_chats.BackColor = System.Drawing.Color.DarkCyan;
            this.button_chats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_chats.FlatAppearance.BorderSize = 0;
            this.button_chats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chats.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chats.ForeColor = System.Drawing.Color.White;
            this.button_chats.Location = new System.Drawing.Point(0, 0);
            this.button_chats.Name = "button_chats";
            this.button_chats.Size = new System.Drawing.Size(158, 46);
            this.button_chats.TabIndex = 0;
            this.button_chats.Text = "Chats";
            this.button_chats.UseVisualStyleBackColor = false;
            this.button_chats.Click += new System.EventHandler(this.button_chats_Click);
            // 
            // button_contacts
            // 
            this.button_contacts.BackColor = System.Drawing.Color.DarkCyan;
            this.button_contacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_contacts.FlatAppearance.BorderSize = 0;
            this.button_contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contacts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contacts.ForeColor = System.Drawing.Color.White;
            this.button_contacts.Location = new System.Drawing.Point(158, 0);
            this.button_contacts.Name = "button_contacts";
            this.button_contacts.Size = new System.Drawing.Size(159, 46);
            this.button_contacts.TabIndex = 1;
            this.button_contacts.Text = "Contacts";
            this.button_contacts.UseVisualStyleBackColor = false;
            this.button_contacts.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_selectedPanel
            // 
            this.panel_selectedPanel.BackColor = System.Drawing.Color.White;
            this.panel_selectedPanel.Location = new System.Drawing.Point(2, 43);
            this.panel_selectedPanel.Name = "panel_selectedPanel";
            this.panel_selectedPanel.Size = new System.Drawing.Size(159, 4);
            this.panel_selectedPanel.TabIndex = 0;
            // 
            // timer_animation
            // 
            this.timer_animation.Interval = 1;
            this.timer_animation.Tick += new System.EventHandler(this.timer_animation_Tick);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Controls.Add(this.panel_chats);
            this.panel_main.Controls.Add(this.panel_contacts);
            this.panel_main.Location = new System.Drawing.Point(0, 46);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(634, 317);
            this.panel_main.TabIndex = 2;
            // 
            // panel_chats
            // 
            this.panel_chats.AutoScroll = true;
            this.panel_chats.BackColor = System.Drawing.Color.Transparent;
            this.panel_chats.Controls.Add(this.label_noMessages);
            this.panel_chats.Location = new System.Drawing.Point(0, 0);
            this.panel_chats.Name = "panel_chats";
            this.panel_chats.Size = new System.Drawing.Size(317, 318);
            this.panel_chats.TabIndex = 1;
            // 
            // label_noMessages
            // 
            this.label_noMessages.AutoSize = true;
            this.label_noMessages.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noMessages.Location = new System.Drawing.Point(47, 32);
            this.label_noMessages.Name = "label_noMessages";
            this.label_noMessages.Size = new System.Drawing.Size(213, 16);
            this.label_noMessages.TabIndex = 1;
            this.label_noMessages.Text = "Vous n\'avez aucune discussion active";
            this.label_noMessages.Visible = false;
            // 
            // panel_contacts
            // 
            this.panel_contacts.AutoScroll = true;
            this.panel_contacts.BackColor = System.Drawing.Color.Transparent;
            this.panel_contacts.Controls.Add(this.label_noContacts);
            this.panel_contacts.Location = new System.Drawing.Point(317, 0);
            this.panel_contacts.Name = "panel_contacts";
            this.panel_contacts.Size = new System.Drawing.Size(317, 318);
            this.panel_contacts.TabIndex = 0;
            // 
            // label_noContacts
            // 
            this.label_noContacts.AutoSize = true;
            this.label_noContacts.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noContacts.Location = new System.Drawing.Point(83, 32);
            this.label_noContacts.Name = "label_noContacts";
            this.label_noContacts.Size = new System.Drawing.Size(153, 16);
            this.label_noContacts.TabIndex = 0;
            this.label_noContacts.Text = "Vous n\'avez aucun contact";
            this.label_noContacts.Visible = false;
            // 
            // ucTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_selectedPanel);
            this.Controls.Add(this.button_contacts);
            this.Controls.Add(this.button_chats);
            this.Name = "ucTabs";
            this.Size = new System.Drawing.Size(317, 363);
            this.panel_main.ResumeLayout(false);
            this.panel_chats.ResumeLayout(false);
            this.panel_chats.PerformLayout();
            this.panel_contacts.ResumeLayout(false);
            this.panel_contacts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_chats;
        private System.Windows.Forms.Button button_contacts;
        private System.Windows.Forms.Panel panel_selectedPanel;
        private System.Windows.Forms.Timer timer_animation;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_contacts;
        private System.Windows.Forms.Panel panel_chats;
        private System.Windows.Forms.Label label_noContacts;
        private System.Windows.Forms.Label label_noMessages;
    }
}
