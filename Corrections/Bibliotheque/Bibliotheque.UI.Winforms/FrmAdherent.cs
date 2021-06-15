using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.BOL;

namespace Bibliotheque.UI.Winforms
{

    public partial class FrmAdherent : Form
    {
        /*  HashSet<Adherent> Adherents;
         Des conflits entre l'usage d'une HashSet en source de données de liaison 
        et l'implémentation de IEditable 
        Résolution en utilisant une BindingList qui prend mieux en compte ces 
        comportements*/

        BindingList<Adherent> adherents;
        enum Contexte
        {
            Initial,
            Affichage,
            Edition,
            Nouveau
        }
        private Contexte contexteActuel;
        public FrmAdherent()
        {

            adherents = new BindingList<Adherent>(Global.Sauvegarde.Load<Adherent>(Global.Repertoire).ToList<Adherent>());
            InitializeComponent();
            adherentBindingSource.AllowNew = true;
            adherentBindingSource.DataSource = adherents;
            GererContextes(Contexte.Initial);


        }
        private void GererContextes(Contexte contexte)
        {
            contexteActuel = contexte;
            switch (contexte)
            {
                case Contexte.Initial:
                    AdherentEP.Clear();
                    txtAdherentID.Clear();
                    txtDebNom.Clear();
                    gbRecherche.Visible = true;
                    gbDetails.Visible = false;
                    btnAnnuler.Visible = false;
                    btnEditer.Visible = false;
                    btnValider.Visible = false;
                    btnNouveau.Visible = true;
                    break;
                case Contexte.Affichage:
                    gbRecherche.Visible = true;
                    gbDetails.Visible = true;
                    btnAnnuler.Visible = false;
                    btnEditer.Visible = true;
                    gbDetails.Enabled = false;
                    btnValider.Visible = false;
                    btnNouveau.Visible = true;
                    break;
                case Contexte.Edition:
                    gbRecherche.Visible = false;
                    gbDetails.Enabled = true;
                    adherentIDTextBox.ReadOnly = true;
                    btnAnnuler.Visible = true;
                    btnEditer.Visible = false;
                    btnValider.Visible = true;
                    btnNouveau.Visible = false;
                    break;
                case Contexte.Nouveau:
                    gbRecherche.Visible = false;
                    gbDetails.Visible = true;
                    gbDetails.Enabled = true;
                    adherentIDTextBox.ReadOnly = false;
                    btnAnnuler.Visible = true;
                    btnEditer.Visible = false;
                    btnValider.Visible = true;
                    btnNouveau.Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            RechercherAdherent();
        }
        private int SelectionnerAdherentByID(string adherentID)
        {
            // La source de données n'est pas searchable ... 
            // donc la méthode Find n'est pas implémentée dans ce contexte
            // utilisation de Linq sur liste sous jaccente
            Adherent adh = adherentBindingSource.List.OfType<Adherent>().FirstOrDefault(a => a.AdherentID == adherentID);
            return (adh == null) ? -1 : adherentBindingSource.IndexOf(adh);
        }
        private int SelectionnerAdherent(string debNom)
        {
            FrmRecAdherent dialog = new FrmRecAdherent(debNom);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return SelectionnerAdherentByID(dialog.AdherentID);
            }
            else
            {
                return -1;
            }
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            GererContextes(Contexte.Edition);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Adherent adherent = adherentBindingSource.Current as Adherent;

            if (adherent.IsValid)
            {
                adherent.EndEdit();
                Global.Sauvegarde.Save<Adherent>(Global.Repertoire, adherents);
                GererContextes(Contexte.Initial);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            adherentBindingSource.CancelEdit();
            GererContextes(Contexte.Initial);
        }

        private void RechercherAdherent()
        {
            int posAdh;
            if (!string.IsNullOrEmpty(txtAdherentID.Text))
            {
                posAdh = SelectionnerAdherentByID(txtAdherentID.Text);
            }
            else
            {
                posAdh = SelectionnerAdherent(txtDebNom.Text);
            }
            if (posAdh == -1)
            {
                AdherentEP.SetError(txtAdherentID, "Identifiant inconnu");
            }
            else
            {
                adherentBindingSource.Position = posAdh;
                GererContextes(Contexte.Affichage);
            }

        }

        private void txtAdherentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RechercherAdherent();
            }
        }

        private void txtDebNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RechercherAdherent();
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            GererContextes(Contexte.Nouveau);
            adherentBindingSource.AddNew();
            AdherentEP.Clear();
        }
    }
}


