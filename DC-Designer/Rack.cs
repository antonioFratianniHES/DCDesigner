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
        private TextBox txtRackName;
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
            txtRackName = new TextBox();
            txtRackName.Name = "txtRackName";
            txtRackName.Size = new Size(20, 50);
            txtRackName.Text = "new Rack";
            txtRackName.Enabled = false;
            txtRackName.ForeColor= SystemColors.ButtonFace;
            txtRackName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            txtRackName.TextAlign = HorizontalAlignment.Center;
            r.Click += new EventHandler(rackClickEvent);
            r.Controls.Add(txtRackName,1,0);
            
            return r;
        }

        private void rackClickEvent(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if(c.Name== "txtRackName")
            { c.Enabled = true;
                c.Text = "test";
                Console.WriteLine("test");
            }
        }
    }
}
