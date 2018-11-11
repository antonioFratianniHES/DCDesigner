using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    internal class Login
    {
        static String user;
        static String company; 
        internal static void SetUser(string u) {
            //recupérer user dans la base
            user = u;
            company = "test";
        }
        internal static String GetUser() { return user; }

        internal static bool UserOk(String text)
        {
            return true;
        }
    }
}
