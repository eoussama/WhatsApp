using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Whatsapp
{
    class Account
    {
        private static int accid;
        private static string username;
        private static string password;
        private static string tel;
        private static string about;
        private static Image photo;
        private static string securityQ;
        private static string securityA;
        private static DateTime lastSeen;
        private static DateTime registrationDate;

        public static int Accid { get { return accid; } set { accid = value; }}
        public static string Username { get { return username; } set { username = value; }}
        public static string Password { get { return password; } set { password = value; }}
        public static string Tel { get { return tel; } set { tel = value; }}
        public static string About { get { return about; } set { about = value; }}
        public static Image Photo { get { return photo; } set { photo = value; }}
        public static string SecurityQ { get { return securityQ; } set { securityQ = value; }}
        public static string SecurityA { get { return securityA; } set { securityA = value; }}
        public static DateTime LastSeen { get { return lastSeen; } set { lastSeen = value; }}
        public static DateTime RegistrationDate { get { return registrationDate; } set { registrationDate = value; } }

        public static int getMessageCount(int AccountID)
        {
            return (int)Connection.getScalar("SELECT COUNT(*) FROM Msgs WHERE SenderID = " + AccountID + ";");
        }
    }
}
