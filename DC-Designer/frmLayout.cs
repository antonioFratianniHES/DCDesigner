using System;
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
    public partial class frmLayout : Form
    {
        public frmLayout()
        {
            InitializeComponent();
                   
        }

        private void cmdAddRack_Click(object sender, EventArgs e)
        {
            frmAjoutRack f = new frmAjoutRack();
            f.ShowDialog(this);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.DoDragDrop(button1.Text, DragDropEffects.Copy |
      DragDropEffects.Move);
        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
