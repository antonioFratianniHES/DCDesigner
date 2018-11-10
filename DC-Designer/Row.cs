using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Designer
{
    class Row
    {
        private int rowNum;
        
        private List<Rack> lstRacks = new List<Rack>();

        public Row(int rowNum, List<Rack> lstRacks) {
            this.rowNum = rowNum;
            this.lstRacks = lstRacks;
        }

        public int GetRowNum() { return rowNum; }
        public List<Rack> GetRacks() { return lstRacks; }
        public void AddRack(Rack rack){ lstRacks.Add(rack);}
    }
}
