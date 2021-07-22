using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSingleton
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void fenetreXInstancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXInstances oXInstances = new FrmXInstances();
            oXInstances.MdiParent = this;
            oXInstances.Show();
        }
        /// <summary>
        ///  A compléter en faisant en sorte d'afficher toujours la même fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void singletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSingleton oSingleton = new FrmSingleton();
            oSingleton.MdiParent = this;
            oSingleton.Show();
        }
    }
}
