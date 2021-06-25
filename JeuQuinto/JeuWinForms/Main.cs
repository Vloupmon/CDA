using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuWinForms {

    public partial class Main : MaterialForm {

        public Main() {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Text = string.Empty;
        }

        private void nouvelleToolStripMenuItem_Click(object sender, EventArgs e) {
            AfficherPartie();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmOptions frmOptions = new FrmOptions();
            if (frmOptions.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
            }
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Main_Shown(object sender, EventArgs e) {
            //  AfficherPartie();
        }

        private void AfficherPartie() {
            FrmGame Quinto = new FrmGame();
            Quinto.Show();
        }

        /// <summary>
        /// Sur fermeture du formulaire principal MDI
        /// Sauvergarde des paramètres de l'application
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }
    }
}