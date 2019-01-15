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
        private bool editable=true;
        OracleConnection con = new OracleConnection
        {
            ConnectionString = "DATA SOURCE=HEGLOCAL;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA"
        };
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

        public Rack(int id,String rackName, List<Equipement> listEquipement) //création d'un rack avec équipement
        {
            this.id = id;
            this.rackName = rackName;
            this.listEquipement = listEquipement;
            rackDesign = EmptyRack(listEquipement.Count, rackName);
            int i = 0;
            while(i < listEquipement.Count)
            {
                rackDesign.Controls[i+1].Text = listEquipement[i].GetNom();
                i++;
            }
        }
        public void SetEditable(bool edit) { editable = edit; }

        public Rack(int id, String rackName, List<Equipement> listEquipement,bool edit) {
            
            new Rack(id, rackName, listEquipement);
            SetEditable(edit);
        }

        internal void Save(int rangeeposition,int rowId)
        {
            this.rowId = rowId;

            con.Open();
            
            OracleCommand cmdAddRack = new OracleCommand("insert into vw_rack(rackname,racksize,rangeeid,rangeeposition) VALUES('" + rackName + "'," + nbU + "," + rowId + "," + rangeeposition + ")", con);
            cmdAddRack.ExecuteNonQuery();
            OracleCommand cmdgetDcId = new OracleCommand("select rackid from vw_datacenter where rackname='" + rackName + "' and rangeeid= '"+ rowId + "'", con);
            OracleDataReader dr2 = cmdgetDcId.ExecuteReader();
            if (dr2.Read()) { 
                id = dr2.GetInt32(0);
            }
            con.Close();
            foreach (Equipement equipement in listEquipement)
            {
                
                equipement.Save(id);
            }
        }

        internal void Update() {
            foreach (Equipement equipement in listEquipement)
            {
                equipement.Update();
            }
            con.Open();
            OracleCommand cmdUpdateRack = new OracleCommand("UPDATE vw_Rack SET rackname = '" + rackName + "' , racksize= " + nbU + "  WHERE rackid =  " + id, con);
            cmdUpdateRack.ExecuteNonQuery();
            con.Close();
        }

        public TableLayoutPanel EmptyRack(int taille,String nom) {
            rackDesign.RowCount = taille + 1;
            rackDesign.Height = 20 * (taille + 1);
            List<Equipement> equirack = new List<Equipement>();
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
            rackDesign.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            for (int i = 1; i < taille+1;i++)
            {
                rackDesign.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
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
                if (editable)
                {
                    b.Click += new EventHandler(CmdEquip_Click);
                }
               // b.MouseDown += new MouseEventHandler(CmdEquip_MouseDown);
                rackDesign.Controls.Add(b, 0, i);
                equirack.Add(new Equipement(b.Text,""));
                
            }
            if (listEquipement.Count==0) { listEquipement = equirack; }
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
            GestionAjoutEquip.SetEditable(editable);
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
