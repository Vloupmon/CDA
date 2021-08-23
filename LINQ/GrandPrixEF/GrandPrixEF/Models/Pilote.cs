using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class Pilote
    {
        public Pilote()
        {
            Affecter = new HashSet<Affecter>();
            ResultatCourse = new HashSet<ResultatCourse>();
            SoutenirPilote = new HashSet<SoutenirPilote>();
        }

        public int CodePilote { get; set; }
        public string NomPilote { get; set; }
        public string PrenomPilote { get; set; }
        public string CodeEcurie { get; set; }

        public virtual Ecurie CodeEcurieNavigation { get; set; }
        public virtual ICollection<Affecter> Affecter { get; set; }
        public virtual ICollection<ResultatCourse> ResultatCourse { get; set; }
        public virtual ICollection<SoutenirPilote> SoutenirPilote { get; set; }
    }
}
