using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateurADO
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void generateurProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenProcStoc frm = new FrmGenProcStoc();
            frm.Show();
        }
    }
}
