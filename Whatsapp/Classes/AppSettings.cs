using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Whatsapp.Classes
{
    class AppSettings
    {
        private static Color backgroundColor;
        private static Image backgroundImage;
        private static Color accountTextColor;
        private static Color contactTextColor;
        private static Color accountBackgroundColor;
        private static Color contactBackgroundColor;

        public static Color BackgroundColor { get { return backgroundColor; } set { backgroundColor = value; } }
        public static Image BackgroundImage { get { return backgroundImage; } set { backgroundImage = value; } }
        public static Color AccountTextColor { get { return accountTextColor; } set { accountTextColor = value; } }
        public static Color ContactTextColor { get { return contactTextColor; } set { contactTextColor = value; } }
        public static Color AccountBackgroundColor { get { return accountBackgroundColor; } set { accountBackgroundColor = value; } }
        public static Color ContactBackgroundColor { get { return contactBackgroundColor; } set { contactBackgroundColor = value; } }
    }
}
