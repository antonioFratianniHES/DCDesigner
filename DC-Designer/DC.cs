using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    class DC
    {
        String nomDc;
        List<Row> rows = new List<Row>();
        String company;


        public DC(String nomDc, String company, List<Row> rows)
        {
            this.nomDc = nomDc;
            this.company = company;
            this.rows = rows;
            

        }

        public String GetNom() { return nomDc; }
        public List<Row> GetRows() { return rows; }

        public String GetCompany() { return company; }

        public void SetNom(String nomDc) { this.nomDc = nomDc; }

        public void Addrows(Row row) { rows.Add(row); }

        public void SetCompany(String company) { this.company = company; }
    }
}
