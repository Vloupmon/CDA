using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class PlanificationGp
    {
        public PlanificationGp()
        {
            ResultatCourse = new HashSet<ResultatCourse>();
        }

        public string CodeCircuit { get; set; }
        public string CodeGp { get; set; }
        public DateTime DateGp { get; set; }
        public int NombreTours { get; set; }

        public virtual Circuit CodeCircuitNavigation { get; set; }
        public virtual GrandPrix CodeGpNavigation { get; set; }
        public virtual ICollection<ResultatCourse> ResultatCourse { get; set; }
    }
}
