using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace A003 {

    public partial class FrmMereFille : Form {

        public FrmMereFille() {
            InitializeComponent();
        }

        private void btnAjouterMereFille_Click(object sender, EventArgs e) {
            int idMere;

            if (int.TryParse(txtIdFille.Text, out int idFille) == false) {
                throw new FormatException();
            }
            using (SqlConnection sqlConnection = Transactions.CreerConnection(Properties.Settings.Default.Ado_NetConnectionString)) {
                sqlConnection.Open();
                SqlCommand cmd = Transactions.CreerCommandeMere(sqlConnection);
                try {
                    Transactions.ExecuterCommandeMere(cmd, txtNomMere.Text.Trim());
                    idMere = (int)cmd.Parameters["@IdMere"].Value;
                    txtIdMere.Text = idMere.ToString();
                    try {
                        cmd = Transactions.CreerCommandeFille(sqlConnection);
                        txtRowsAffected.Text = Transactions.ExecuterCommandeFille(cmd, idMere, idFille, txtNomFille.Text.Trim()).ToString();
                        txtReturnValue.Text = cmd.Parameters["@RETURN_VALUE"].Value.ToString();
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                if (sqlConnection.State == ConnectionState.Open) {
                    sqlConnection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) {
        }
    }
}