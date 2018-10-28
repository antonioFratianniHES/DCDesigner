using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    internal class Login
    {
        static string user;
        internal static void SetUser(string u) { user = u; }
        internal static String GetUser() { return user; }

        internal static bool UserOk(string text)
        {
            return true;
        }
    }
}
