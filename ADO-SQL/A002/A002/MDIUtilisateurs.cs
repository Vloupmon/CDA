using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A002
{
    public partial class MDIUtilisateurs : Form
    {
      

        public MDIUtilisateurs()
        {
            InitializeComponent();
            this.statusStrip.Items[0].Text =string.Format("Bienvenue sur l'application {0}",Properties.Settings.Default.NomApplication); 
        }

               
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Lors du premier affichage de la fenêtre MDI
        /// Chargement du formulaire de connexion
        /// Si connexion OK, affichage du menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MDIUtilisateurs_Shown(object sender, EventArgs e)
        {
            FrmConnexion oConnexion = new FrmConnexion();
            DialogResult oResult = oConnexion.ShowDialog();
            if (oResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
           
        }

        private void MDIUtilisateurs_Load(object sender, EventArgs e)
        {

        }

       
       
       

        

       
        
    }
}
