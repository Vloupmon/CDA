using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace A003 {

    public partial class FrmTransaction : Form {

        public FrmTransaction() {
            InitializeComponent();
        }

        /// <summary>
        /// Gestion des ajouts avec transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransaction_Click(object sender, EventArgs e) {
            if (rdbLocale.Checked) {
                GererTransactionLocale();
            } else {
                GererTransactionScope();
            }
        }

        private void GererTransactionScope() {
            int idMere;
            if (int.TryParse(txtIdFille.Text, out int idFille) == false) {
                throw new FormatException();
            }
            if (int.TryParse(txtIdFille2.Text, out int idFille2) == false) {
                throw new FormatException();
            }
            using (TransactionScope transactionScope = new TransactionScope()) {
                using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.Ado_NetConnectionString)) {
                    sqlConnection.Open();
                    SqlCommand cmd = Transactions.CreerCommandeMere(sqlConnection);
                    Transactions.ExecuterCommandeMere(cmd, txtNomMere.Text.Trim());
                    idMere = (int)cmd.Parameters["@IdMere"].Value;
                    txtIdMere.Text = idMere.ToString();
                    cmd = Transactions.CreerCommandeFille(sqlConnection);
                    Transactions.ExecuterCommandeFille(cmd, idMere, idFille, txtNomFille.Text.Trim()).ToString();
                    Transactions.ExecuterCommandeFille(cmd, idMere, idFille2, txtNomFille2.Text.Trim()).ToString();
                    if (sqlConnection.State == ConnectionState.Open) {
                        sqlConnection.Close();
                    }
                }
                transactionScope.Complete();
            }
        }

        private void GererTransactionLocale() {
            // Transaction locale
            // Pour des transactions simples portant sur une seule connexion
            // Choix de la connexion et des commandes gérées au sein de cette transaction
            // Toutes les instructions exécutées avec les connexions ouvertes dans cette portée
            // seront pilotées par cette transaction (dans cette portée bien entendu).
        }
    }
}