using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuWinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void nouvelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherPartie();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOptions frmOptions = new FrmOptions();
            if (frmOptions.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Main_Shown(object sender, EventArgs e)
        {
          //  AfficherPartie();
        }
        private void AfficherPartie()
        {
           
        }
        /// <summary>
        /// Sur fermeture du formulaire principal MDI
        /// Sauvergarde des paramètres de l'application
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
