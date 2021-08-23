using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class ResultatCourse
    {
        public int CodePilote { get; set; }
        public int NumVoiture { get; set; }
        public string CodeCircuit { get; set; }
        public string CodeGp { get; set; }
        public int? PositionGrille { get; set; }
        public bool Qualifie { get; set; }
        public bool Abandon { get; set; }
        public int? Place { get; set; }
        public decimal? NombrePointsMarques { get; set; }
        public TimeSpan? TempsCourse { get; set; }

        public virtual PlanificationGp Code { get; set; }
        public virtual Pilote CodePiloteNavigation { get; set; }
        public virtual Voiture NumVoitureNavigation { get; set; }
    }
}
