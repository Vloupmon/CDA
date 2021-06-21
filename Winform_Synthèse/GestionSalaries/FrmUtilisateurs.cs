using SalariesDll;
using System;

//using System.Linq;
using System.Windows.Forms;
using Utilitaires;

namespace GestionSalaraies {
    public partial class FrmUtilisateurs : Form {
        private Roles roles;
        private Utilisateur utilisateur;
        private Utilisateurs utilisateurs;

        public FrmUtilisateurs() {
            InitializeComponent();
        }

        private enum Contextes {
            Initial = 0,
            Consultation = 1,
            ModificationInitiale = 2,
            ModificationAnnuler = 3,
            ModificationValider = 4,
            AjoutInitial = 5,
            AjoutValider = 6
        }

        private void btnAnnuler_Click(object sender, EventArgs e) {
            GestionnaireContextes(Contextes.ModificationAnnuler);
        }

        private void btnModifier_Click(object sender, EventArgs e) {
            GestionnaireContextes(Contextes.ModificationInitiale);
        }

        private void btnValider_Click(object sender, EventArgs e) {
            ModifierUtilisateur();
            ChargerUtilisateurs();
            ChargerValeursUtilisateur();
            GestionnaireContextes(Contextes.ModificationValider);
        }

        private void btnNouveau_Click(object sender, EventArgs e) {
            utilisateur = new Utilisateur();
            txtIdentifiant.Clear();
            txtMotDePasse.Clear();
            txtNom.Clear();
            chkCompteBloque.Checked = false;
            GestionnaireContextes(Contextes.AjoutInitial);
        }

        private void cbUtilisateurs_SelectedIndexChanged(object sender, EventArgs e) {
            utilisateur = utilisateurs.UtilisateurByMatricule(cbUtilisateurs.Items[cbUtilisateurs.SelectedIndex].ToString());
            ChargerValeursUtilisateur();
            GestionnaireContextes(Contextes.Consultation);
        }

        private void ChargerRoles() {
            roles = new Roles();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            roles.Load(serialiseur, Properties.Settings.Default.AppData);

            foreach (Role item in roles) {
                cbRoles.Items.Add(item.Identifiant);
            }
        }

        private void ChargerUtilisateurs() {
            cbUtilisateurs.Items.Clear();
            utilisateurs = new Utilisateurs();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utilisateurs.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Utilisateur item in utilisateurs) {
                cbUtilisateurs.Items.Add(item.Identifiant);
            }
        }

        private void ChargerValeursUtilisateur() {
            txtIdentifiant.Text = utilisateur.Identifiant;
            txtMotDePasse.Text = utilisateur.MotDePasse;
            txtNom.Text = utilisateur.Nom;
            chkCompteBloque.Checked = utilisateur.CompteBloque;
            foreach (var item in cbRoles.Items) {
                if (item.ToString() == utilisateur.Role.Identifiant) {
                    cbRoles.SelectedItem = item;
                    break;
                }
            }
        }

        private void ModifierUtilisateur() {
            if (IsValidChamps()) {
                try {
                    utilisateur.Identifiant = txtIdentifiant.Text;
                    utilisateur.MotDePasse = txtMotDePasse.Text;
                    utilisateur.Nom = txtNom.Text;
                    utilisateur.CompteBloque = chkCompteBloque.Checked;
                    utilisateur.Role = new Role();
                    if (cbRoles.SelectedItem.ToString() == "Utilisateur") {
                        utilisateur.Role.Identifiant = "Utilisateur";
                        utilisateur.Role.Description = "Utilisateur Application";
                    } else {
                        utilisateur.Role.Identifiant = "Administrateur";
                        utilisateur.Role.Description = "Administrateur Application";
                    }
                    if (!utilisateurs.Contains(utilisateur)) {
                        utilisateurs.Add(utilisateur);
                    }
                } catch (Exception e) {
                    MessageBox.Show(e.Source + "\n"
                        + e.Message + "\n"
                        + "Stack Trace :\n"
                        + e.StackTrace);
                }
                ISauvegarde sauvegarde = new SauvegardeXML();
                utilisateurs.Save(sauvegarde, Properties.Settings.Default.AppData);
            }
        }

        private void FrmUtilisateurs_Load(object sender, EventArgs e) {
            ChargerUtilisateurs();
            ChargerRoles();
            GestionnaireContextes(Contextes.Initial);
        }

        private void GestionnaireContextes(Contextes contexte) {
            switch (contexte) {
                case Contextes.Initial:
                    cbUtilisateurs.Enabled = (cbUtilisateurs.Items.Count > 0);
                    btnNouveau.Enabled = true;
                    gbDetailUtilisateur.Visible = false;
                    break;

                case Contextes.Consultation:
                    cbUtilisateurs.Enabled = (cbUtilisateurs.Items.Count > 0);
                    btnNouveau.Enabled = true;
                    gbDetailUtilisateur.Visible = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    txtIdentifiant.ReadOnly = true;
                    txtMotDePasse.ReadOnly = true;
                    txtNom.ReadOnly = true;
                    chkCompteBloque.Enabled = false;
                    cbRoles.Enabled = false;
                    break;

                case Contextes.ModificationInitiale:
                    btnNouveau.Enabled = false;
                    gbDetailUtilisateur.Visible = true;
                    cbUtilisateurs.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtIdentifiant.ReadOnly = true;
                    txtMotDePasse.ReadOnly = false;
                    chkCompteBloque.Enabled = true;
                    txtNom.ReadOnly = false;
                    cbRoles.Enabled = true;
                    break;

                case Contextes.ModificationAnnuler:
                    GestionnaireContextes(Contextes.Consultation);
                    break;

                case Contextes.ModificationValider:
                    GestionnaireContextes(Contextes.Consultation);
                    break;

                case Contextes.AjoutInitial:
                    btnNouveau.Enabled = false;
                    gbDetailUtilisateur.Visible = true;
                    cbUtilisateurs.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtIdentifiant.ReadOnly = false;
                    txtMotDePasse.ReadOnly = false;
                    chkCompteBloque.Enabled = true;
                    txtNom.ReadOnly = false;
                    cbRoles.Enabled = true;
                    break;

                case Contextes.AjoutValider:
                    break;

                default:
                    break;
            }
        }

        private bool IsValidChamps() {
            bool valid = true;

            if (!Utilisateur.IsIdentifiantValide(txtIdentifiant.Text)) {
                valid = false;
                epUtilisateur.SetError(txtIdentifiant, "L'identifiant n'est pas valide");
            } else {
                epUtilisateur.SetError(txtIdentifiant, string.Empty);
            }

            return valid;
        }
    }
}