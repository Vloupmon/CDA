using Banque;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BanqueWindowsGUI {

    /// <summary>
    /// Création d'un nouveau compte  externe à la banque
    /// </summary>
    public partial class FrmNouveauCompte : Form {
        private Comptes listeComptes;
        private Compte nouveauCompte = new Compte();

        public FrmNouveauCompte() {
            InitializeComponent();
        }

        private void codeBanqueTextBox_Validating(object sender, CancelEventArgs args) {
            try {
                nouveauCompte.CodeBanque = (sender as TextBox).Text;
                args.Cancel = false;
                (sender as TextBox).Text = nouveauCompte.CodeBanque;
                errorProvider.SetError(codeBanqueTextBox, String.Empty);
            } catch (FormatException e) {
                args.Cancel = true;
                errorProvider.SetError(codeBanqueTextBox, e.Message);
            }
        }

        private void codeGuichetTextBox_Validating(object sender, CancelEventArgs args) {
            try {
                nouveauCompte.CodeGuichet = (sender as TextBox).Text;
                args.Cancel = false;
                (sender as TextBox).Text = nouveauCompte.CodeGuichet;
                errorProvider.SetError(codeGuichetTextBox, String.Empty);
            } catch (FormatException e) {
                args.Cancel = true;
                errorProvider.SetError(codeGuichetTextBox, e.Message);
            }
        }

        private void numeroCompteTextBox_Validating(object sender, CancelEventArgs args) {
            try {
                nouveauCompte.Numero = (sender as TextBox).Text;
                args.Cancel = false;
                (sender as TextBox).Text = nouveauCompte.Numero;
                errorProvider.SetError(numeroCompteTextBox, String.Empty);
            } catch (FormatException e) {
                args.Cancel = true;
                errorProvider.SetError(numeroCompteTextBox, e.Message);
            }
        }

        private void cleRIBTextBox_Validating(object sender, CancelEventArgs args) {
            try {
                nouveauCompte.CleRIB = (sender as TextBox).Text;
                args.Cancel = false;
                (sender as TextBox).Text = nouveauCompte.CleRIB;
                errorProvider.SetError(cleRIBTextBox, String.Empty);
            } catch (FormatException e) {
                args.Cancel = true;
                errorProvider.SetError(cleRIBTextBox, e.Message);
            }
        }

        private void libellécompteTextBox_Validating(object sender, CancelEventArgs args) {
            try {
                nouveauCompte.LibelleCompte = (sender as TextBox).Text;
                args.Cancel = false;
                (sender as TextBox).Text = nouveauCompte.LibelleCompte;
                errorProvider.SetError(libellécompteTextBox, String.Empty);
            } catch (FormatException e) {
                args.Cancel = true;
                errorProvider.SetError(libellécompteTextBox, e.Message);
            }
        }

        public FrmNouveauCompte(Comptes comptes) : this() {
            listeComptes = comptes;
        }

        /// <summary>
        /// Check if all fields are filled
        /// </summary>
        /// <returns>True is all fields are filled, False otherwise</returns>
        private bool FieldsAreSet() {
            return (codeBanqueTextBox.Text != string.Empty &&
                codeGuichetTextBox.Text != string.Empty &&
                numeroCompteTextBox.Text != string.Empty &&
                cleRIBTextBox.Text != string.Empty &&
                libellécompteTextBox.Text != string.Empty);
        }

        private void FrmNouveauCompte_Load(object sender, EventArgs e) {
        }

        private void BtnValider_Click(object sender, EventArgs e) {
            if (nouveauCompte.KeyCheck()) {
                AjouterCompte(nouveauCompte);
                if (FieldsAreSet()) {
                    DialogResult = DialogResult.OK;
                } else {
                    errorProvider.Clear();
                    errorProvider.SetError(btnValider, Properties.ErrorStrings.emptyFields);
                    DialogResult = DialogResult.None;
                }
            } else {
                errorProvider.SetError(cleRIBTextBox, Properties.ErrorStrings.keyCheckFailed);
                DialogResult = DialogResult.None;
            }
        }

        private void BtnAbandonner_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void AjouterCompte(Compte nouveauCompte) {
            listeComptes.Add(nouveauCompte);
        }
    }
}