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

        private void GenerateurProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenProcStoc frmProcStock = FrmGenProcStoc.CreateInstance();
            frmProcStock.MdiParent = this;
            frmProcStock.StartPosition = FormStartPosition.CenterScreen;
            frmProcStock.WindowState = FormWindowState.Maximized;
            frmProcStock.Show();
        }

        private void GenerateurCommandesSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenererCommande frmCommande = FrmGenererCommande.CreateInstance();
            frmCommande.MdiParent = this;
            frmCommande.StartPosition = FormStartPosition.CenterScreen;
            frmCommande.WindowState = FormWindowState.Maximized;
            frmCommande.Show();
        }
    }
}
