using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace A001 {

    public partial class FrmConnexion : Form {
        private SqlConnection sqlConnection = null;

        public FrmConnexion() {
            InitializeComponent();
        }

        /// <summary>
        /// Si la connexion n'existe pas, la créer
        /// et associer un gestionnaire d'événement au changement d'état
        /// Si son état est fermé, ouvrir la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnecter_Click(object sender, EventArgs e) {
            sqlConnection = new SqlConnection {
                ConnectionString = Properties.Settings.Default.ComptoirAnglais_V1
            };
            try {
                sqlConnection.Open();
            } catch (Exception ex) {
                MessageBox.Show("Erreur de connexion à la base.\n{" + ex.StackTrace, "Connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnConnecter.Enabled = false;
            btnDeconnecter.Enabled = true;
        }

        /// <summary>
        /// Afficher les propriétés
        /// Database
        /// Datasource
        /// Utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProprietes_Click(object sender, EventArgs e) {
            if (sqlConnection != null) {
                if (sqlConnection.State == ConnectionState.Broken) {
                    txtEtatConnexion.Text = "Broken";
                }
                if (sqlConnection.State == ConnectionState.Closed) {
                    txtEtatConnexion.Text = "Closed";
                }
                if (sqlConnection.State == ConnectionState.Connecting) {
                    txtEtatConnexion.Text = "Connecting";
                }
                if (sqlConnection.State == ConnectionState.Executing) {
                    txtEtatConnexion.Text = "Executing";
                }
                if (sqlConnection.State == ConnectionState.Fetching) {
                    txtEtatConnexion.Text = "Fetching";
                }
                if (sqlConnection.State == ConnectionState.Open) {
                    txtEtatConnexion.Text = "Open";
                }
            }
        }

        /// <summary>
        /// Si l'état de la connexion est ouvert, fermer la connexion
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeconnecter_Click(object sender, EventArgs e) {
            try {
                sqlConnection.Close();
            } catch (Exception ex) {
                MessageBox.Show("Impossible de fermer cette connexion.\n{" + ex.StackTrace, "Connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnDeconnecter.Enabled = false;
            btnConnecter.Enabled = true;
        }
    }
}