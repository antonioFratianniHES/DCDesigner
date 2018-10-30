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
        private TableLayoutPanel rackDesign;

        public Rack(String nom, int nbU) {
            EmptyRack(nbU,nom);
        }

        public void EmptyRack(int taille,String nom) {
            rackDesign = new TableLayoutPanel
            {
                RowCount = taille + 1,
                ColumnCount = 1,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble,
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Width = 100,
                Height = 20 * (taille + 1),
                AllowDrop = true,
                AutoSize = true,
                ForeColor = SystemColors.ActiveCaption,
                BackColor = SystemColors.ActiveCaption
            };
            cmdRackName = CreateRackName(nom);
            rackDesign.Controls.Add(cmdRackName, 1, 0);
            rackDesign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / (taille + 1)));
            for (int i = 1; i < taille+1;i++)
            {
                rackDesign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / (taille + 1)));
                Button b = new Button
                {
                    Name = String.Concat("cmdEquipe",i),
                    Size = new Size(20, 20),
                    Text = "Empty",
                    AutoSize = true,
                    Enabled = true,
                    ForeColor = SystemColors.ButtonFace,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                };
                rackDesign.Controls.Add(b, 1, i);
            }


            
        }

        public Button CreateRackName(String nom)
        {
            Button cmdRackName = new Button
            {
                Name = "cmdRackName",
                Size = new Size(20, 20),
                Text = nom,
                AutoSize = true,
                Enabled = true,
                ForeColor = SystemColors.ButtonFace,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            };
            return cmdRackName;
        }

        public TableLayoutPanel GetRackDesign() {
            return rackDesign;
        }

        public Button GetCmdRackName() {
            return cmdRackName;
        }
    }
}
