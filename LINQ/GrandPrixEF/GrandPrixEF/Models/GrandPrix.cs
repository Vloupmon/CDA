using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class GrandPrix
    {
        public GrandPrix()
        {
            PlanificationGp = new HashSet<PlanificationGp>();
        }

        public string CodeGp { get; set; }
        public string NomGrandPrix { get; set; }

        public virtual ICollection<PlanificationGp> PlanificationGp { get; set; }
    }
}
