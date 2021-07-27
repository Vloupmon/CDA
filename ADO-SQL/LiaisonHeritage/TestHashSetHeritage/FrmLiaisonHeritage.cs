using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHashSetHeritage
{
    public partial class FrmLiaisonHeritage : Form
    {
        public FrmLiaisonHeritage()
        {
            InitializeComponent();


            foreach (var item in ChargerPersonnes())
            {
                personneBindingSource.Add(item);
            }

        }

        private HashSet<Personne> ChargerPersonnes()
        {
            // Création d'une liste de personnes --> salariés
            HashSet<Salarie> salaries = new HashSet<Salarie>
            {
                new Salarie() { Code = 123, Nom = "Bost", Prenom = "Vincent", Salaire = 4300 },
                new Salarie() { Code = 234, Nom = "Morillon", Prenom = "Jean", Salaire = 4300 },
                new Salarie() { Code = 345, Nom = "Bueno", Prenom = "Ange", Salaire = 4300 }
            };
            // Création d'une liste de personnes --> bénéficiaires
            HashSet<Beneficiaire> beneficiaires = new HashSet<Beneficiaire>
            {
                new Beneficiaire() { Code = 456, Nom = "Audivert", Prenom = "Alan", DateNaissance = new DateTime(2000, 10, 05) },
                new Beneficiaire() { Code = 567, Nom = "Carrey", Prenom = "Florian", DateNaissance = new DateTime(1999, 10, 05) },
                new Beneficiaire() { Code = 789, Nom = "Frugier", Prenom = "Nicolas", DateNaissance = new DateTime(1997, 10, 05) }
            };

            //  Création d'une liste de personnes Union des deux ensembles

            HashSet<Personne> personnes = new HashSet<Personne>();
            personnes.UnionWith(salaries);
            personnes.UnionWith(beneficiaires);
          //  personneBindingSource.DataSource = personnes;
            return personnes;

        }

        private void personneBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Personne personneCourante = personneBindingSource.Current as Personne;
            LblTypeSalarie.Text = personneCourante.GetType().Name;
            if (personneCourante is Salarie)
            {
                
                salarieBindingSource.DataSource = personneCourante;
                gbSalarie.Visible = true;
                gbBeneficiaire.Visible = false;
            }
            if (personneCourante is Beneficiaire)
            {
                beneficiaireBindingSource.DataSource = personneCourante;
                gbSalarie.Visible = false;
                gbBeneficiaire.Visible = true;
            }
        }
    }
}
