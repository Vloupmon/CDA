using Bibliotheque.BOL;
using Bibliotheque.DAL;
using System;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;

namespace Bibliotheque.WinUI {

    public partial class FrmAdherents : Form {
        private HashSet<Adherent> adherents;
        private HashSet<Pret> prets;
        private HashSet<Exemplaire> exemplaires;

        public FrmAdherents() {
            InitializeComponent();

            PullDBTables();
            RefreshFields();
            subBox.SelectedIndex = 0;
            if (!(subBox.SelectedItem as Adherent).PeutEmprunter()) {
                booksButton.Enabled = false;
            }
        }

        private void PullDBTables() {
            using (TransactionScope transactionScope = new TransactionScope()) {
                adherents = AdherentDAO.Instance.GetAll();
                prets = PretDAO.Instance.GetAll();
                exemplaires = ExemplaireDAO.Instance.GetAll();
                transactionScope.Complete();
            }
            foreach (Adherent adherent in adherents) {
                adherent.InitPrets(prets);
            }
        }

        private void RefreshFields() {
            PopulateSubs();
            PopulateLoans();
            PopulateBooks();
        }

        private void PopulateSubs() {
            BindingSource bs = new BindingSource {
                DataSource = adherents
            };
            subBox.DataSource = bs;
            subBox.DisplayMember = "Nom";
            subBox.ValueMember = "AdherentID";
        }

        private void PopulateLoans() {
            loanBox.Items.Clear();
            foreach (Pret pret in prets) {
                if (pret.AdherentID == (subBox.SelectedItem as Adherent).AdherentID
                    && pret.DateRetour == DateTime.MinValue) {
                    loanBox.Items.Add(pret.IdExemplaire);
                }
            }
        }

        private void PopulateBooks() {
            booksComboBox.Items.Clear();
            foreach (Exemplaire exemplaire in exemplaires) {
                if (exemplaire.Empruntable) {
                    booksComboBox.Items.Add(exemplaire);
                }
            }
            if (booksComboBox.Items.Count == 0) {
                booksButton.Enabled = false;
            } else {
                booksComboBox.SelectedIndex = 0;
                booksComboBox.DisplayMember = "IdExemplaire";
            }
        }

        private void subBox_SelectedIndexChanged(object sender, EventArgs e) {
            PopulateLoans();
            booksButton.Enabled = true;
            if (!(subBox.SelectedItem as Adherent).PeutEmprunter()) {
                booksButton.Enabled = false;
            }
        }

        private void booksButton_Click(object sender, EventArgs e) {
            if (booksComboBox.SelectedItem != null
                && (subBox.SelectedItem as Adherent).PeutEmprunter()) {
                Pret pret = new Pret {
                    AdherentID = (subBox.SelectedItem as Adherent).AdherentID,
                    IdExemplaire = (booksComboBox.SelectedItem as Exemplaire).IdExemplaire,
                    DateEmprunt = DateTime.Now,
                    DateRetour = DateTime.MinValue
                };
                (booksComboBox.SelectedItem as Exemplaire).Empruntable = false;
                using (TransactionScope scope = new TransactionScope()) {
                    PretDAO.Instance.Create(pret);
                    ExemplaireDAO.Instance.Update(booksComboBox.SelectedItem as Exemplaire);
                    scope.Complete();
                }
                (subBox.SelectedItem as Adherent).AjouterPret(pret, exemplaires);
                RefreshFields();
            }
        }
    }
}