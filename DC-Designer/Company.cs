using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    class Company
    {
        private String name;
        private String address;
        private String tel;

        public Company(string name, string address, string tel)
        {
            this.name = name;
            this.address = address;
            this.tel = tel;
        }

        public String getName() { return name; }
        public String getAddress() { return address; }
        public String getTel() { return tel; }
        public void setName(String name) { this.name = name; }
        public void setAddress(String address) { this.address = address; }
        public void setTel(String tel) { this.tel = tel; }
    }
}
