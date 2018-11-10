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
        private String rackName;
        private TableLayoutPanel rackDesign= new TableLayoutPanel()
        {
            ColumnCount = 1,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble,
            Anchor = AnchorStyles.Left | AnchorStyles.Top,
            Width = 100,
            AllowDrop = true,
            AutoSize = true,
            ForeColor = SystemColors.ActiveCaption,
            BackColor = SystemColors.ActiveCaption
        };
        private List<Equipement> listEquipement= new List<Equipement>();

        public Rack(String nom, int nbU) { //création d'un rack vide
            EmptyRack(nbU,nom);
        }

        public Rack(string rackName, List<Equipement> listEquipement) //création d'un rack avec équipement
        {
            this.rackName = rackName;
            this.listEquipement = listEquipement;
            rackDesign = EmptyRack(listEquipement.Count, rackName);
        }

        public TableLayoutPanel EmptyRack(int taille,String nom) {
            rackDesign.RowCount = taille + 1;
            rackDesign.Height = 20 * (taille + 1);
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
            rackDesign.Controls.Add(cmdRackName, 0, 0);
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
                b.Click += new EventHandler(CmdEquip_Click);
                rackDesign.Controls.Add(b, 0, i);
                listEquipement.Add(new Equipement(b.Text,""));
            }
            return rackDesign;
        }




        public TableLayoutPanel GetRackDesign() {
            return rackDesign;
        }

        private void CmdEquip_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            int i = s.Parent.Controls.IndexOf(s)-1;
            frmEquipement f = new frmEquipement();
            Equipement equip = (Equipement)listEquipement[i];
            GestionAjoutEquip.SetEquipement(equip);
            f.ShowDialog(this.rackDesign.Parent);
            f.Dispose();
            equip = GestionAjoutEquip.GetEquipement();
            if (equip !=null)
            {
                listEquipement[i] = equip;
                s.Text = equip.GetNom();
                GestionAjoutEquip.SetEquipement(null);
            }
            
        }

    }
}
