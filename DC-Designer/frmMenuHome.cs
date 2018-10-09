﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Designer
{
    public partial class frmMenuHome : Form
    {
        public frmMenuHome()
        {
            InitializeComponent();
            frmConnexion f = new frmConnexion();
            f.ShowDialog(this);
        }

        private void cmdCreateNewDC_Click(object sender, EventArgs e)
        {

            frmLayout f = new frmLayout();
            f.TopLevel = false;
            f.Show();

            tabLayout.Visible = true;
            TabPage newTab = new TabPage();
            newTab.Name = "tabPage"+tabLayout.TabPages.Count;
            newTab.Text = "New Layout"+ tabLayout.TabPages.Count;

            /*
            TableLayoutPanel dcPanel = new TableLayoutPanel();
            dcPanel.AutoSize = true;
            dcPanel.ColumnCount = 1;
            dcPanel.CellBorderStyle= TableLayoutPanelCellBorderStyle.InsetDouble; 
            dcPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            
            dcPanel.Width = 100;
            dcPanel.Height = 200;
            

            Button cmdAddRack = new Button();
            cmdAddRack.Name = "cmdAddRack";
            cmdAddRack.Text = "+";
            cmdAddRack.Font= new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdAddRack.ForeColor = SystemColors.HotTrack;
            cmdAddRack.Size = new Size(49, 51);
            cmdAddRack.TextAlign = ContentAlignment.MiddleCenter;
            cmdAddRack.AutoSize = true;
            cmdAddRack.Anchor = AnchorStyles.None;
            cmdAddRack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cmdAddRack.Click += new EventHandler(cmdAddRack_Click);

            dcPanel.Controls.Add(cmdAddRack,0,0);
            newTab.Controls.Add(dcPanel);*/
            //f.AutoSize = true;
            newTab.AllowDrop = true;
            
            newTab.Controls.Add(f);
            tabLayout.TabPages.Add(newTab);
           
         
        }


        private void cmdAddRack_Click(object sender, EventArgs e)
        {
            frmAjoutRack f = new frmAjoutRack();
            f.ShowDialog(this);
        }

        private void lstExistingDC_DoubleClick(object sender, EventArgs e)
        {
            int DcToOpen = lstExistingDC.SelectedIndex;

        }

        private void frmMenuHome_Resize(object sender, EventArgs e)
        {
            //foreach()
        }
    }
}
