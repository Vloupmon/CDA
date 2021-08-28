using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class Voiture
    {
        public Voiture()
        {
            Affecter = new HashSet<Affecter>();
            ResultatCourse = new HashSet<ResultatCourse>();
        }

        public int NumVoiture { get; set; }
        public string TypeVoiture { get; set; }
        public string CodeEcurie { get; set; }

        public virtual Ecurie CodeEcurieNavigation { get; set; }
        public virtual ICollection<Affecter> Affecter { get; set; }
        public virtual ICollection<ResultatCourse> ResultatCourse { get; set; }
    }
}
