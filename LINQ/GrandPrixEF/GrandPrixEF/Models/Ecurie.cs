using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class Ecurie
    {
        public Ecurie()
        {
            Pilote = new HashSet<Pilote>();
            SoutenirEcurie = new HashSet<SoutenirEcurie>();
            Voiture = new HashSet<Voiture>();
        }

        public string CodeEcurie { get; set; }
        public string NomEcurie { get; set; }
        public string CodeFournisseurPneumatiques { get; set; }
        public string NomDirecteurEcurie { get; set; }

        public virtual Fournisseur CodeFournisseurPneumatiquesNavigation { get; set; }
        public virtual ICollection<Pilote> Pilote { get; set; }
        public virtual ICollection<SoutenirEcurie> SoutenirEcurie { get; set; }
        public virtual ICollection<Voiture> Voiture { get; set; }
    }
}
