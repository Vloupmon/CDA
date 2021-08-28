using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class SoutenirPilote
    {
        public string CodeSponsor { get; set; }
        public int CodePilote { get; set; }
        public decimal MontantUsd { get; set; }
        public int NumAgrementFia { get; set; }

        public virtual Pilote CodePiloteNavigation { get; set; }
        public virtual Sponsor CodeSponsorNavigation { get; set; }
    }
}
