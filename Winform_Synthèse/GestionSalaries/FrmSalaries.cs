using SalariesDll;
using System;
using System.Globalization;

//using System.Linq;
using System.Windows.Forms;
using Utilitaires;

namespace GestionSalaraies {

    public partial class FrmSalaries : Form {
        private Salarie salarie;
        private Salaries salaries;

        public FrmSalaries() {
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
            ChargerValeursSalarie();
            GestionnaireContextes(Contextes.ModificationAnnuler);
        }

        private void btnModifier_Click(object sender, EventArgs e) {
            GestionnaireContextes(Contextes.ModificationInitiale);
        }

        private void btnValider_Click(object sender, EventArgs e) {
            ModifierSalarie();
            ChargerSalaries();
            ChargerValeursSalarie();
            GestionnaireContextes(Contextes.ModificationValider);
        }

        private void btnNouveau_Click(object sender, EventArgs e) {
            salarie = new Salarie();
            txtMatricule.Clear();
            txtDate.Clear();
            txtPrenom.Clear();
            txtNom.Clear();
            txtSalaireBrut.Clear();
            txtSalaireNet.Clear();
            txtTauxCs.Clear();
            GestionnaireContextes(Contextes.AjoutInitial);
        }

        private void cbSalaries_SelectedIndexChanged(object sender, EventArgs e) {
            salarie = salaries.ExtraireSalarie(cbSalaries.Items[cbSalaries.SelectedIndex].ToString());
            ChargerValeursSalarie();
            GestionnaireContextes(Contextes.Consultation);
        }

        private void ChargerSalaries() {
            cbSalaries.Items.Clear();
            salaries = new Salaries();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Salarie item in salaries) {
                cbSalaries.Items.Add(item.Matricule);
            }
        }

        private void ChargerValeursSalarie() {
            txtMatricule.Text = salarie.Matricule;
            txtDate.Text = salarie.DateNaissance.ToString();
            txtPrenom.Text = salarie.Prenom;
            txtNom.Text = salarie.Nom;
            txtSalaireBrut.Text = salarie.SalaireBrut.ToString() + "€";
            txtSalaireNet.Text = salarie.SalaireNet.ToString() + "€";
            txtTauxCs.Text = (salarie.TauxCS * 100).ToString() + "%";
        }

        private void ModifierSalarie() {
            if (IsValidChamps()) {
                try {
                    salarie.Matricule = txtMatricule.Text;
                    salarie.DateNaissance = DateTime.Parse(txtDate.Text, CultureInfo.CurrentCulture);
                    salarie.Prenom = txtPrenom.Text;
                    salarie.Nom = txtNom.Text;
                    salarie.SalaireBrut = Decimal.Parse(txtSalaireBrut.Text.Remove(txtSalaireBrut.Text.Length - 1), CultureInfo.CurrentCulture);
                    salarie.TauxCS = Decimal.Parse(txtTauxCs.Text.Remove(txtTauxCs.Text.Length - 1), CultureInfo.CurrentCulture) / 100;
                    if (!salaries.Contains(salarie)) {
                        salaries.Add(salarie);
                    }
                } catch (Exception e) {
                    MessageBox.Show(e.Source + "\n"
                        + e.Message + "\n"
                        + "Stack Trace :\n"
                        + e.StackTrace);
                }
                ISauvegarde sauvegarde = new SauvegardeXML();
                salaries.Save(sauvegarde, Properties.Settings.Default.AppData);
            }
        }

        private void FrmSalaries_Load(object sender, EventArgs e) {
            ChargerSalaries();
            GestionnaireContextes(Contextes.Initial);
        }

        private void GestionnaireContextes(Contextes contexte) {
            switch (contexte) {
                case Contextes.Initial:
                    cbSalaries.Enabled = (cbSalaries.Items.Count > 0);
                    btnNouveau.Enabled = true;
                    gbDetailSalarie.Visible = false;
                    break;

                case Contextes.Consultation:
                    cbSalaries.Enabled = (cbSalaries.Items.Count > 0);
                    btnNouveau.Enabled = true;
                    gbDetailSalarie.Visible = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    txtMatricule.ReadOnly = true;
                    txtDate.ReadOnly = true;
                    txtPrenom.ReadOnly = true;
                    txtNom.ReadOnly = true;
                    txtSalaireNet.ReadOnly = true;
                    break;

                case Contextes.ModificationInitiale:
                    btnNouveau.Enabled = false;
                    gbDetailSalarie.Visible = true;
                    cbSalaries.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtMatricule.ReadOnly = true;
                    txtDate.ReadOnly = false;
                    txtPrenom.ReadOnly = false;
                    txtNom.ReadOnly = false;
                    break;

                case Contextes.ModificationAnnuler:
                    GestionnaireContextes(Contextes.Consultation);
                    break;

                case Contextes.ModificationValider:
                    GestionnaireContextes(Contextes.Consultation);
                    break;

                case Contextes.AjoutInitial:
                    btnNouveau.Enabled = false;
                    gbDetailSalarie.Visible = true;
                    cbSalaries.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtMatricule.ReadOnly = false;
                    txtNom.ReadOnly = false;
                    break;

                case Contextes.AjoutValider:
                    break;

                default:
                    break;
            }
        }

        private bool IsValidChamps() {
            bool valid = true;

            if (!Salarie.IsMatriculeValide(txtMatricule.Text)) {
                valid = false;
                epSalarie.SetError(txtMatricule, "L'identifiant n'est pas valide");
            } else {
                epSalarie.SetError(txtMatricule, string.Empty);
            }

            return valid;
        }
    }
}