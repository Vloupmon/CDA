using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A001
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConnexion frmConnexion = new FrmConnexion();
            frmConnexion.MdiParent = this;
            frmConnexion.Show();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCommande frmCommande = new FrmCommande();
            frmCommande.MdiParent = this;
            frmCommande.Show();
        }

        private void lectureDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLectureDonnees frmLectureDonnees = new FrmLectureDonnees();
            frmLectureDonnees.MdiParent = this;
            frmLectureDonnees.Show();
        }
    }
}
