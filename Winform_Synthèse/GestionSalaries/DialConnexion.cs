using SalariesDll;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Utilitaires;

namespace GestionSalaraies {

    public partial class DialConnexion : Form {
        private readonly Roles userroles = new Roles();
        private readonly Utilisateurs users = new Utilisateurs();

        public DialConnexion() {
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            users.Load(serialiseur, Properties.Settings.Default.AppData);
            userroles.Load(serialiseur, Properties.Settings.Default.AppData);
            InitializeComponent();
        }

        public void UpdateUserErrorCounter(Utilisateur user) {
            user.NombreEchecsConsecutifs++;
            if (user.NombreEchecsConsecutifs == 3) {
                user.CompteBloque = true;
            }
            SerializeUsers();
        }

        public void SerializeUsers() {
            ISauvegarde sauvegarde = new SauvegardeXML();
            users.Save(sauvegarde, Properties.Settings.Default.AppData);
        }

        #region Gestionnaires Evenements Validation

        /// <summary>
        /// Validation ID Utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdentifiant_Validating(object sender, CancelEventArgs e) {
            if (IsIdCorrect(txtIdentifiant.Text)) {
                if (users.UtilisateurByMatricule(txtIdentifiant.Text).CompteBloque) {
                    epUtilisateur.SetError(txtIdentifiant, "Nombre d'échecs maximum atteint, utilisateur bloqué");
                    e.Cancel = true;
                } else {
                    epUtilisateur.SetError(txtIdentifiant, String.Empty);
                }
            } else {
                epUtilisateur.SetError(txtIdentifiant, "Identifiant invalide");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Interception du traitement de la touche
        /// Assignation de dialogResult Cancel sur Escap
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData) {
            if (keyData == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// Vérification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMDP_Validating(object sender, CancelEventArgs e) {
            if (users.UtilisateurByMatricule(txtIdentifiant.Text).CompteBloque) {
                epUtilisateur.SetError(txtMDP, "Nombre d'échecs maximum atteint, utilisateur bloqué");
                e.Cancel = true;
            } else {
                if (IsMotPasseCorrect(txtMDP.Text, txtIdentifiant.Text)) {
                    users.UtilisateurByMatricule(txtIdentifiant.Text).NombreEchecsConsecutifs = 0;
                    epUtilisateur.SetError(txtMDP, String.Empty);
                } else {
                    epUtilisateur.SetError(txtMDP, "Mot de passe incorrect");
                    e.Cancel = true;
                }
            }
        }

        #endregion Gestionnaires Evenements Validation

        private void btnQuitter_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool IsIdCorrect(string id) {
            if (String.IsNullOrEmpty(id))
                return false;
            if (!char.IsLetter(id[0]))
                return false;
            if (id.Length < 3)
                return false;
            foreach (Utilisateur user in users) {
                if (id == user.Identifiant) {
                    foreach (Role role in userroles) {
                        if (user.Role == role) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool IsMotPasseCorrect(string motPasse, string id) {
            if (String.IsNullOrEmpty(motPasse))
                return false;
            if (motPasse.Length < 5)
                return false;
            if (users.UtilisateurByMatricule(id).MotDePasse == motPasse) {
                return true;
            } else {
                UpdateUserErrorCounter(users.UtilisateurByMatricule(id));
                return false;
            }
        }
    }
}