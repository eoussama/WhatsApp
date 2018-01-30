using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp.Classes;

namespace Whatsapp.UserControls
{
    public partial class ucEmoji : UserControl
    {
        public delegate void EmojiClickEventHandler(object sender, EventArgs e);
        public event EmojiClickEventHandler EmojiClick;
        List<Emoji> emojiList = new List<Emoji>();

        public ucEmoji()
        {
            InitializeComponent();

            CreateEmojiList();
        }

        public void CreateAllEmojis()
        {
            emojiList.Add(new Emoji(":)", "Sourire"));
            emojiList.Add(new Emoji(":D", "Content"));
            emojiList.Add(new Emoji(":(", "Triste"));
            emojiList.Add(new Emoji(":'(", "Pleure"));
            emojiList.Add(new Emoji(";)", "Clin d'œil"));
            emojiList.Add(new Emoji("XD", "Rire"));
            emojiList.Add(new Emoji(";(", "En colère"));
            emojiList.Add(new Emoji(":@", "Rage"));
            emojiList.Add(new Emoji(":3", "Mignonne"));
            emojiList.Add(new Emoji(">:", "Agacé"));
            emojiList.Add(new Emoji(":-|", "Visage palm"));
            emojiList.Add(new Emoji("B-D", "Lunettes"));
            emojiList.Add(new Emoji(":S", "Malade"));
            emojiList.Add(new Emoji("._.", "Désappointé"));
            emojiList.Add(new Emoji("O.o", "Choqué"));
            emojiList.Add(new Emoji("O_O", "Surpris"));
            emojiList.Add(new Emoji("X.X", "Mort"));
            emojiList.Add(new Emoji("°__°", "Robot"));
            emojiList.Add(new Emoji("$_$", "Riches"));
            emojiList.Add(new Emoji(":-J", "Langue sur la joue"));
            emojiList.Add(new Emoji("=^_^=", "Rougir"));
            emojiList.Add(new Emoji(":-o", "Alarmé"));
            emojiList.Add(new Emoji(">_<", "Stressé"));
            emojiList.Add(new Emoji("(*_*)", "Amoureux"));
            emojiList.Add(new Emoji("(-_-)", "Ennuyé"));
            emojiList.Add(new Emoji("8[+]", "Cadeau"));
            emojiList.Add(new Emoji("(*V*)", "Oiseau"));
            emojiList.Add(new Emoji(":o3", "Chien"));
            emojiList.Add(new Emoji("ʕ•́ᴥ•̀ʔ", "Chiot"));
            emojiList.Add(new Emoji("=^.^=", "Chat"));
            emojiList.Add(new Emoji("<>< ", "Poisson"));
            emojiList.Add(new Emoji("^o,o^", "Hibou"));
            emojiList.Add(new Emoji("( *)>", "Manchot"));
            emojiList.Add(new Emoji("(‘.’)", "Lapin"));
            emojiList.Add(new Emoji("_@_v", "Escargot"));
            emojiList.Add(new Emoji("♥", "Cœur"));
        }

        public void CreateEmojiList()
        {
            CreateAllEmojis();
            int btnCount = 0;

            foreach(Emoji emoji in emojiList)
            {
                Button btnEmoji = new Button();
                btnEmoji.Size = new Size(40, 36);
                btnEmoji.FlatStyle = FlatStyle.Flat;
                btnEmoji.FlatAppearance.MouseDownBackColor = Color.Cyan;
                btnEmoji.Cursor = Cursors.Hand;
                btnEmoji.Font = new Font("Bahnschrift", 6.75f);
                btnEmoji.Text = emoji.EmojiText;
                btnEmoji.Top = (panel_main.Controls.OfType<Button>().Count<Button>() / 4) * (1 + btnEmoji.Height) + 23;
                btnEmoji.Left = (btnEmoji.Width + 1) * btnCount + 6;
                panel_main.Controls.Add(btnEmoji);
                btnEmoji.Tag = emoji;
                toolTip_info.SetToolTip(btnEmoji, emoji.EmojiName);
                btnEmoji.Click += new EventHandler(OnEmojiClick);
                btnCount++;

                if (btnCount == 4)
                    btnCount = 0;
            }
        }

        protected virtual void OnEmojiClick(object sender, EventArgs e)
        {
            if (this.EmojiClick != null)
                EmojiClick(sender, EventArgs.Empty);
        }
    }    
}
