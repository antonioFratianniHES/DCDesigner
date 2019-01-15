using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    class Company
    {
        private int id;
        private String name;
        private String address;
        private String tel;

        public Company(int id,string name, string address, string tel)
        {
            this.id= id;
            this.name = name;
            this.address = address;
            this.tel = tel;
        }

        public String GetName() { return name; }
        public String GetAddress() { return address; }
        public String GetTel() { return tel; }
        public void SetName(String name) { this.name = name; }
        public void SetAddress(String address) { this.address = address; }
        public void SetTel(String tel) { this.tel = tel; }
        public int GetId() { return id; }
    }
}
