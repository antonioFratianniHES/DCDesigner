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
        
        private TableLayoutPanel rackDesign;
        private List<Equipement> listEquipement= new List<Equipement>();

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
            TextBox cmdRackName = new TextBox
            {
                Name = "cmdRackName",
                Size = new Size(20, 20),
                Text = nom,
                TextAlign = HorizontalAlignment.Center,
                AutoSize = true,
                Enabled = true,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            };
            rackDesign.Controls.Add(cmdRackName, 1, 0);
            rackDesign.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / (taille + 1)));
            for (int i = 1; i < taille+1;i++)
            {
                rackDesign.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / (taille + 1)));
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
                b.Click += new EventHandler(cmdEquip_Click);
                rackDesign.Controls.Add(b, 0, i);
                listEquipement.Add(new Equipement(b.Text,""));
            }


            
        }


        public TableLayoutPanel GetRackDesign() {
            return rackDesign;
        }

        private void cmdEquip_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            int i = s.Parent.Controls.IndexOf(s);
            frmEquipement f = new frmEquipement();
            f.ShowDialog(this.rackDesign.Parent);
            Equipement equip = (Equipement)listEquipement[i];
            equip = GestionAjoutEquip.getEquipement();
            s.Text = equip.getNom();
        }

    }
}
