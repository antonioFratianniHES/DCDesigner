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
        internal static void setUser(string u) { user = u; }
        internal static String getUser() { return user; }

        internal static bool UserOk(string text)
        {
            return true;
        }
    }
}
