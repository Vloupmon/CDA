using System;
using System.Windows.Forms;

namespace GestionSalaraies {

    public partial class FrmMain : Form {

        public FrmMain() {
            InitializeComponent();
        }

        private void formShown(object sender, EventArgs e) {
            DialConnexion login = new DialConnexion();
            this.Hide();
            DialogResult result = login.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    this.Show();
                    login.Hide();
                    break;

                case DialogResult.Cancel:
                    Application.Exit();
                    break;
            }
        }

        private void menuGestionUtilisateurs_Click(object sender, EventArgs e) {
            FrmUtilisateurs frmUtilisateurs = new FrmUtilisateurs();
            frmUtilisateurs.MdiParent = this;
            frmUtilisateurs.Show();
        }

        private void menuGestionSalaries_Click(object sender, EventArgs e) {
            FrmSalaries frmSalaries = new FrmSalaries();
            frmSalaries.MdiParent = this;
            frmSalaries.Show();
        }
    }
}