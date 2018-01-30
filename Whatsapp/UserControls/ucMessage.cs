using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp.UserControls
{
    public partial class ucMessage : UserControl
    {
        private int messageID;
        private Label info;
        private RichTextBox message;
        private PictureBox msgState;

        public ucMessage()
        {
            InitializeComponent();

            Info = label_info;
            Message = richTextBox_message;
            MsgState = pictureBox_msgState;
        }

        public int MessageID { get { return messageID; } set { messageID = value; } }
        public Label Info { get { return info; } set { info = value; } }
        public RichTextBox Message { get { return message; } set { message = value; } }
        public PictureBox MsgState { get { return msgState; } set { msgState = value; } }

    }
}
