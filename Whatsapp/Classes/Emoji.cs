using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatsapp.Classes
{
    public class Emoji
    {
        private string emojiText;
        private string emojiName;

        public Emoji(string EmojiText, string EmojiName)
        {
            this.EmojiText = EmojiText;
            this.EmojiName = EmojiName;
        }

        public string EmojiText { get { return emojiText; } set { emojiText = value; } }
        public string EmojiName { get { return emojiName; } set { emojiName = value; } }
    }
}
