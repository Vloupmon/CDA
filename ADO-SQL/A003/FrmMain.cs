using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A003
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        

        private void ajouterMereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMere frmMere = new FrmMere();
            frmMere.MdiParent = this;
            frmMere.Show();
        }

        private void ajouterMereFilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMereFille frmMereFille = new FrmMereFille();
            frmMereFille.MdiParent = this;
            frmMereFille.Show();
        }

        private void ajouterTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransaction frmTransaction = new FrmTransaction();
            frmTransaction.MdiParent = this;
            frmTransaction.Show();
        }
    }
}
