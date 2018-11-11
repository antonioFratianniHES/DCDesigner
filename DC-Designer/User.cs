using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    class User
    {

        private String userName;
        private String Company;

        public User(string userName, string company)
        {
            this.userName = userName;
            Company = company;
        }

        public void SetUserName(String userName) {
            this.userName = userName;
        }

        public void SetCompany(String company)
        {
            this.Company = company;
        }

        public String GetUserName() { return userName; }
        public String GetCompany() { return Company; }
    }
}
