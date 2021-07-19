using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace A001 {

    public partial class FrmCommande : Form {
        private SqlConnection sqlConnect = null;
        private SqlCommand sqlCmd = null;
        private SqlDataReader sqlRdr = null;

        public FrmCommande() {
            InitializeComponent();
        }

        /// <summary>
        /// Requête exécutée avec la méthode ExecuteNonQuery
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNonQuery_Click(object sender, EventArgs e) {
            using (sqlConnect = new SqlConnection {
                ConnectionString = Properties.Settings.Default.ComptoirAnglais_V1
            }) {
                try {
                    sqlConnect.Open();
                    sqlCmd = new SqlCommand(txtRequeteNonQuery.Text, sqlConnect);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message + "/n" + ex.StackTrace);
                }
                txtResultatNonQuery.Text = sqlCmd.ExecuteNonQuery().ToString();
                txtResultatNonQuery.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Requête simple exécutée avec la méthode ExecuteScalar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSansParametre_Click(object sender, EventArgs e) {
            using (sqlConnect = new SqlConnection {
                ConnectionString = Properties.Settings.Default.ComptoirAnglais_V1
            }) {
                try {
                    sqlConnect.Open();
                    sqlCmd = new SqlCommand("Select Count(*) From Customers;", sqlConnect);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                txtResultatSansParametre.Text = sqlCmd.ExecuteScalar().ToString();
                txtResultatSansParametre.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Requête libre exécutée avec la méthode ExecuteScalar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecuterTexte_Click(object sender, EventArgs e) {
            using (sqlConnect = new SqlConnection {
                ConnectionString = Properties.Settings.Default.ComptoirAnglais_V1
            }) {
                try {
                    sqlConnect.Open();
                    sqlCmd = new SqlCommand(txtResultatRequeteLibre.Text, sqlConnect);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message + "/n" + ex.StackTrace);
                }
                txtResultatTexte.Text = sqlCmd.ExecuteScalar().ToString();
                txtResultatTexte.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Requête avec paramètre exécutée avec la méthode ExecuteScalar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAvecParametre_Click(object sender, EventArgs e) {
            string cmdTxt = "SELECT COUNT(*)\n" +
                "FROM dbo.Orders\n" +
                "WHERE CustomerID = @ID;";
            using (sqlConnect = new SqlConnection {
                ConnectionString = Properties.Settings.Default.ComptoirAnglais_V1
            }) {
                sqlCmd = new SqlCommand(cmdTxt, sqlConnect);
                sqlCmd.Parameters.Add("@ID", SqlDbType.VarChar, 5);
                sqlCmd.Parameters["@ID"].Value = txtCustomerID.Text.PadRight(5).Substring(0, 5);
                try {
                    sqlConnect.Open();
                    txtResultatAvecParametre.Text = sqlCmd.ExecuteScalar().ToString();
                    txtResultatAvecParametre.BackColor = Color.Green;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
                }
            }
        }
    }
}