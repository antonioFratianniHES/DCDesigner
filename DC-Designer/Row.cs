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
        private String rowName;
        private TableLayoutPanel row;
        public TableLayoutPanel EmptyRow(String rowName)
        {
            row.Name = rowName;
            row.ColumnCount = 1;
            row.AutoSize = true;

            return row;
        }


    }
}
