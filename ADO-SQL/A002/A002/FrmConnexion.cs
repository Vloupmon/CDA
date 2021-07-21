using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace A002 {

    public enum InfosConnexion {
        ConnexionOK = 0,
        UtilisateurInconnu = -101,
        CompteBloque = -102,
        MotPasseInvalide = -103,
        ApplicationInexistante = -104,
        RoleInexistant = -105,
        ProblemeConnexion = -106
    }

    public partial class FrmConnexion : Form {

        public FrmConnexion() {
            InitializeComponent();
            this.Text = string.Format("{0}-Identifiez-vous", Properties.Settings.Default.NomApplication);
        }

        /// <summary>
        /// Demande de connexion
        /// Test des valeurs retournées par la procédure stockée
        /// appelée pour contrôler les informations de connexion
        /// au service de l'application des utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnValider_Click(object sender, EventArgs e) {
            bool connexionValide = false;
            erpConnexion.SetError(txtMotPasse, string.Empty);
            erpConnexion.SetError(txtIDUtilisateur, string.Empty);

            switch (ControlerInfosConnexion(txtIDUtilisateur.Text, txtMotPasse.Text, Properties.Settings.Default.NomApplication)) {
                case InfosConnexion.UtilisateurInconnu:
                    erpConnexion.SetError(txtIDUtilisateur, "L'identifiant saisi n'est pas valide. Corrigez S.V.P.");
                    txtIDUtilisateur.SelectAll();
                    txtIDUtilisateur.Focus();
                    break;

                case InfosConnexion.MotPasseInvalide:
                    erpConnexion.SetError(txtMotPasse, "Le mot de passe communiqué n'est pas valide. corrigez S.V.P.");
                    txtMotPasse.SelectAll();
                    txtMotPasse.Focus();
                    break;

                case InfosConnexion.CompteBloque:
                    erpConnexion.SetError(txtIDUtilisateur, "Votre compte utilisateur est bloqué.Prenez contact avec notre hotline.");
                    btnAbandonner.Focus();
                    break;

                case InfosConnexion.ApplicationInexistante:
                    erpConnexion.SetError(txtIDUtilisateur, "Application inexistante.");
                    btnAbandonner.Focus();
                    break;

                case InfosConnexion.RoleInexistant:
                    erpConnexion.SetError(txtIDUtilisateur, "Vous ne pouvez pas accéder à cette application. Voir votre administrateur.");
                    btnAbandonner.Focus();
                    break;

                case InfosConnexion.ProblemeConnexion:
                    erpConnexion.SetError(txtIDUtilisateur, "Problèmes de connexion.Vous ne pouvez accéder actuellement à l'application.");
                    btnAbandonner.Focus();
                    break;

                case InfosConnexion.ConnexionOK:
                    connexionValide = true;
                    break;

                default:
                    break;
            }
            if (!connexionValide) {
                this.DialogResult = DialogResult.None;
            } else {
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Cette fonction permet de déterminer l'exactitude des informations fournies
        /// pour la connexion au service de gestion des utilisateurs
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="MotPasse"></param>
        /// <returns></returns>
        private InfosConnexion ControlerInfosConnexion(string identifiant, string motPasse, string nomApplication) {
            // Création de la connexion et de la commande associée
            InfosConnexion ret = InfosConnexion.ProblemeConnexion;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.SecuriteConnection)) {
                using (SqlCommand command = connection.CreateCommand()) {
                    command.CommandText = "dbo.psUtilisateur_Authentifier";
                    command.CommandType = CommandType.StoredProcedure;

                    // Ajout des paramètres
                    SqlParameter parameter;
                    parameter = new SqlParameter();
                    parameter.ParameterName = "@RETURN_VALUE";
                    parameter.SqlDbType = SqlDbType.Int;
                    parameter.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter();
                    parameter.ParameterName = "@IDUtilisateur";
                    parameter.SqlDbType = SqlDbType.Char;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Size = 10;
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter();
                    parameter.ParameterName = "@MotPasseClair";
                    parameter.SqlDbType = SqlDbType.NVarChar;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Size = 50;
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter();
                    parameter.ParameterName = "@NomApplication";
                    parameter.SqlDbType = SqlDbType.NVarChar;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Size = 255;
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter();
                    parameter.ParameterName = "@IDRole";
                    parameter.SqlDbType = SqlDbType.UniqueIdentifier;
                    parameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parameter);

                    // Passage des valeurs

                    command.Parameters["@IDUtilisateur"].Value = identifiant;
                    command.Parameters["@MotPasseClair"].Value = motPasse;
                    command.Parameters["@NomApplication"].Value = nomApplication;

                    // Exécution de la commande

                    try {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ret = (InfosConnexion)command.Parameters["@RETURN_VALUE"].Value;
                        connection.Close();
                    } catch (Exception e) {
                        MessageBox.Show(e.Message + "\n" + e.StackTrace);
                    }
                    return (ret);
                }
            }
        }

        private void FrmConnexion_Shown(object sender, EventArgs e) {
            txtIDUtilisateur.Focus();
        }

        private void FrmConnexion_Load(object sender, EventArgs e) {
        }
    }
}