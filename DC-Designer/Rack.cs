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
        private Button cmdRackName;
        private TableLayoutPanel r;

        public TableLayoutPanel emptyRack(int taille) {
            r = new TableLayoutPanel();
            r.RowCount = taille+1;
            r.ColumnCount = 1;
            r.AutoSize = true;
            r.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            r.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            r.Width = 200;
            r.Height = 20*(taille+1);
            r.AllowDrop = true;
            r.ForeColor= SystemColors.ActiveCaption; 
            r.BackColor= SystemColors.ActiveCaption; 

            for (int i = 0; i < taille+1;i++)
            {
                r.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / (taille+1))); 
            }
            cmdRackName = new Button();
            cmdRackName.Name = "cmdRackName";
            cmdRackName.Size = new Size(20, 50);
            cmdRackName.Text = "new Rack";
            cmdRackName.Enabled = true;
            cmdRackName.ForeColor= SystemColors.ButtonFace;
            cmdRackName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            //txtRackName.TextAlign = HorizontalAlignment.Center;
            
            r.Controls.Add(cmdRackName, 1,0);
            
            return r;
        }

        public Button getCmdRackName() {
            return cmdRackName;
        }
    }
}
