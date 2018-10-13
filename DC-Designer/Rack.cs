using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DC_Designer
{
    class Rack
    {
        public TableLayoutPanel emptyRack(int taille) {
            TableLayoutPanel r = new TableLayoutPanel();
            r.RowCount = taille;
            r.ColumnCount = 1;
            r.AutoSize = true;
            r.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            r.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            r.Width = 100;
            r.Height = 200;
            r.AllowDrop = true;
            for (int i = 0; i < taille; i++)
            {
                r.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / taille)); 
            }
            

            return r;
        }
    }
}
