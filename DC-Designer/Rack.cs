using Oracle.ManagedDataAccess.Client;
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
        private int id;
        private String rackName;
        private int nbU;
        private int rowId;
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

        public Rack(int id,String nom, int nbU) { //création d'un rack vide
            this.id = id;
            EmptyRack(nbU,nom);
            this.nbU = nbU;
        }

        public Rack(String rackName, List<Equipement> listEquipement) //création d'un rack avec équipement
        {
            this.rackName = rackName;
            this.listEquipement = listEquipement;
            rackDesign = EmptyRack(listEquipement.Count, rackName);
            rackDesign.Controls[0].Text = rackName;
            for (int i = 0; i < listEquipement.Count; i++)
            {
                
                rackDesign.Controls[i + 1].Text = listEquipement[i].GetNom();
            }
        }

        internal void Save(int rangeeposition,int rowId)
        {
            int rackId;
            this.rowId = rowId;
            OracleConnection con = new OracleConnection
            {
                ConnectionString = "DATA SOURCE=XE;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA"
            };
            con.Open();
            
            OracleCommand cmdAddRack = new OracleCommand("insert into vw_rack(rackname,racksize,rangeeid,rangeeposition) VALUES('" + rackName + "'," + nbU + "," + rowId + "," + rangeeposition + ")", con);
            OracleCommand cmdgetDcId = new OracleCommand("select rackid from vw_datacenter where rackname='" + rackName + "' and rangeeid= '"+ rowId + "'", con);
            OracleDataReader dr2 = cmdgetDcId.ExecuteReader();
            rackId = dr2.GetInt32(0);
            con.Close();
            foreach (Equipement equipement in listEquipement)
            {
                
                equipement.Save(rackId);
            }
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
                    Name = String.Concat("cmdEquipe", i),
                    Size = new Size(20, 20),
                    Text = "Empty",
                    AutoSize = true,
                    Enabled = true,
                    AllowDrop = true,
                    ForeColor = SystemColors.ButtonFace,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                };
                b.Click += new EventHandler(CmdEquip_Click);
               // b.MouseDown += new MouseEventHandler(CmdEquip_MouseDown);
                rackDesign.Controls.Add(b, 0, i);
                listEquipement.Add(new Equipement(b.Text,""));
                
            }
            return rackDesign;
        }
        //fonction de drag and drop pas encore au point
       /* private void CmdEquip_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);
        }
        */
        public TableLayoutPanel GetRackDesign() {
            return rackDesign;
        }

        private void CmdEquip_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            int i = s.Parent.Controls.IndexOf(s)-1;
            
            Equipement equip = (Equipement)listEquipement[i];
            GestionAjoutEquip.SetEquipement(equip);
            frmEquipement f = new frmEquipement();
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
