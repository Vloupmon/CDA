using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class Circuit
    {
        public Circuit()
        {
            PlanificationGp = new HashSet<PlanificationGp>();
        }

        public string CodeCircuit { get; set; }
        public string NomCircuit { get; set; }
        public string Localisation { get; set; }
        public int LongueurPiste { get; set; }
        public int CapaciteAccueil { get; set; }

        public virtual Pays LocalisationNavigation { get; set; }
        public virtual ICollection<PlanificationGp> PlanificationGp { get; set; }
    }
}
