using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace A001 {

    public partial class FrmLectureDonnees : Form {
        private SqlConnection sqlConnect = null;
        private SqlCommand sqlCmd = null;
        private SqlDataReader sqlRdr = null;

        public FrmLectureDonnees() {
            InitializeComponent();
        }

        /// <summary>
        /// Exécution de la méthode ExecuteReader
        /// Chargement de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommandeParametree_Click(object sender, EventArgs e) {
            string cmdTxt = txtRequete.Text;
            using (sqlConnect = new SqlConnection {
                ConnectionString = Properties.Settings.Default.ComptoirAnglais_V1
            }) {
                sqlCmd = new SqlCommand(cmdTxt, sqlConnect);
                sqlCmd.Parameters.Add("@CustomerID", SqlDbType.VarChar, 5);
                sqlCmd.Parameters["@CustomerID"].Value = txtCustomerID.Text.PadRight(5).Substring(0, 5);
                try {
                    sqlConnect.Open();
                    sqlRdr = sqlCmd.ExecuteReader();

                    while (sqlRdr.Read()) {
                        lstDernieresCommandes.Text += sqlRdr.GetString(0);
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
                }
            }
        }
    }
}