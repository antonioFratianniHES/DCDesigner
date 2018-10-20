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
    public partial class FrmSaveLayout : Form
    {
        public FrmSaveLayout()
        {
            InitializeComponent();
            
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //enoye la donnée save à home remet à zero
            Close();
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void CmdDontSave_Click(object sender, EventArgs e)
        {
            //remet à zero sans sauver
            Close();
            Dispose();
        }
    }
}
