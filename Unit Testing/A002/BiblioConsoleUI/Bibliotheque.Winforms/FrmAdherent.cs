using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Windows.Forms;
using Bibliotheque.BLL;
using Bibliotheque.BOL;
using Bibliotheque.Repository;

namespace Bibliotheque.Winforms
{
    public partial class FrmAdherent : Form
    {
       
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
            InitializeComponent();
            GererContextes(Contexte.Initial);
         
        }
        private void GererContextes(Contexte contexte)
        {
            contexteActuel = contexte;
            switch (contexte)
            {
                case Contexte.Initial:
                    adherentBindingSource.Clear();
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
        private Adherent SelectionnerAdherentByID(string adherentID)
        {
            AdherentManager adhMan = new AdherentManager(Configuration._serviceProvider.GetService<IAdherentRepository>());
            return  adhMan.Lister().Where(a=>a.IdAdherent==adherentID).FirstOrDefault();
        }
        private Adherent SelectionnerAdherent(string debNom)
        {
            FrmRecAdherent dialog = new FrmRecAdherent(debNom, adherentBindingSource);
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                return adherentBindingSource.Current as Adherent;
            }
            else
            {
                return null;
            }

        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            GererContextes(Contexte.Edition);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Vérifier la validité 
            Adherent adherent = adherentBindingSource.Current as Adherent;
            if (adherent.IsValid)
            {
            adherentBindingSource.EndEdit();
            if (contexteActuel == Contexte.Nouveau)
            {
            // Create
            AdherentManager adhMan = new AdherentManager(Configuration._serviceProvider.GetService<IAdherentRepository>());
            adhMan.CreerAdherent(adherent);
            }
            if (contexteActuel == Contexte.Edition)
            {
               // Update
            }

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
            adherentBindingSource.Clear();
            Adherent adherent = null;
            if (!string.IsNullOrEmpty(txtAdherentID.Text))
            {
                adherent = SelectionnerAdherentByID(txtAdherentID.Text);
                if (adherent == null)
                {
                    AdherentEP.SetError(txtAdherentID, "Identifiant inconnu");
                }
            }
            else
            {
                adherent = SelectionnerAdherent(txtDebNom.Text);
            }
            if (adherent != null)
            {
                adherentBindingSource.DataSource = adherent;
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

