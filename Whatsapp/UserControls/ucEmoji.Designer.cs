namespace Whatsapp.UserControls
{
    partial class ucEmoji
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.toolTip_info = new System.Windows.Forms.ToolTip(this.components);
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.Teal;
            this.panel_main.Controls.Add(this.label_title);
            this.panel_main.Location = new System.Drawing.Point(3, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(193, 134);
            this.panel_main.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(18, 4);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(140, 15);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Tablaux d\'émoticans";
            // 
            // toolTip_info
            // 
            this.toolTip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_info.ToolTipTitle = "Emoji";
            // 
            // ucEmoji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel_main);
            this.Name = "ucEmoji";
            this.Size = new System.Drawing.Size(199, 140);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ToolTip toolTip_info;
    }
}
