using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class Fournisseur
    {
        public Fournisseur()
        {
            Ecurie = new HashSet<Ecurie>();
        }

        public string CodeFournisseurPneumatiques { get; set; }
        public string RaisonSocialeFournisseur { get; set; }
        public int NumAgrementFia { get; set; }

        public virtual ICollection<Ecurie> Ecurie { get; set; }
    }
}
