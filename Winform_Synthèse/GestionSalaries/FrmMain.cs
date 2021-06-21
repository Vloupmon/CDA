using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalaraies {

    public partial class FrmMain : Form {

        public FrmMain() {
            InitializeComponent();
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