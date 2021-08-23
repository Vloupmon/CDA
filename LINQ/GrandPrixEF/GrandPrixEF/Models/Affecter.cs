using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class Affecter
    {
        public int CodePilote { get; set; }
        public int NumVoiture { get; set; }
        public int NumContrat { get; set; }

        public virtual Pilote CodePiloteNavigation { get; set; }
        public virtual Voiture NumVoitureNavigation { get; set; }
    }
}
