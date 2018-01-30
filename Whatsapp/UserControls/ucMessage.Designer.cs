namespace Whatsapp.UserControls
{
    partial class ucMessage
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
            this.label_info = new System.Windows.Forms.Label();
            this.richTextBox_message = new System.Windows.Forms.RichTextBox();
            this.pictureBox_msgState = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_msgState)).BeginInit();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(3, 4);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(97, 13);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "Username • Date";
            // 
            // richTextBox_message
            // 
            this.richTextBox_message.BackColor = System.Drawing.Color.White;
            this.richTextBox_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_message.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_message.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_message.HideSelection = false;
            this.richTextBox_message.Location = new System.Drawing.Point(6, 24);
            this.richTextBox_message.Name = "richTextBox_message";
            this.richTextBox_message.ReadOnly = true;
            this.richTextBox_message.Size = new System.Drawing.Size(205, 13);
            this.richTextBox_message.TabIndex = 1;
            this.richTextBox_message.Text = "Message...";
            // 
            // pictureBox_msgState
            // 
            this.pictureBox_msgState.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox_msgState.Image = global::Whatsapp.Properties.Resources.icon_messageSent;
            this.pictureBox_msgState.Location = new System.Drawing.Point(194, 22);
            this.pictureBox_msgState.Name = "pictureBox_msgState";
            this.pictureBox_msgState.Size = new System.Drawing.Size(15, 15);
            this.pictureBox_msgState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_msgState.TabIndex = 2;
            this.pictureBox_msgState.TabStop = false;
            this.pictureBox_msgState.Visible = false;
            // 
            // ucMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox_msgState);
            this.Controls.Add(this.richTextBox_message);
            this.Controls.Add(this.label_info);
            this.Name = "ucMessage";
            this.Size = new System.Drawing.Size(212, 42);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_msgState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.RichTextBox richTextBox_message;
        private System.Windows.Forms.PictureBox pictureBox_msgState;
    }
}
