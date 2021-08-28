using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class Sponsor
    {
        public Sponsor()
        {
            SoutenirEcurie = new HashSet<SoutenirEcurie>();
            SoutenirPilote = new HashSet<SoutenirPilote>();
        }

        public string CodeSponsor { get; set; }
        public string NomSociete { get; set; }

        public virtual ICollection<SoutenirEcurie> SoutenirEcurie { get; set; }
        public virtual ICollection<SoutenirPilote> SoutenirPilote { get; set; }
    }
}
