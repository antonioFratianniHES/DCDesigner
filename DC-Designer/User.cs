using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    class User
    {
        private int id;
        private String userName;
        private String Company;

        public User(int id, string userName, string company)
        {
            this.id = id;
            this.userName = userName;
            this.Company = company;
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
        public int GetId() { return id; }
    }
}
