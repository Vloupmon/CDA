using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace A003 {

    public partial class FrmMere : Form {

        public FrmMere() {
            InitializeComponent();
        }

        private void btnAjouterMere_Click(object sender, EventArgs e) {
            using (SqlConnection sqlConnection = Transactions.CreerConnection(Properties.Settings.Default.Ado_NetConnectionString)) {
                sqlConnection.Open();
                SqlCommand cmd = Transactions.CreerCommandeMere(sqlConnection);
                try {
                    txtRowsAffected.Text = Transactions.ExecuterCommandeMere(cmd, txtNomMere.Text.Trim()).ToString();
                    txtIdMere.Text = cmd.Parameters["@IdMere"].Value.ToString();
                    txtReturnValue.Text = cmd.Parameters["@RETURN_VALUE"].Value.ToString();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                if (sqlConnection.State == ConnectionState.Open) {
                    sqlConnection.Close();
                }
            }
        }
    }
}