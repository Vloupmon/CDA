using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class SoutenirEcurie
    {
        public string CodeEcurie { get; set; }
        public string CodeSponsor { get; set; }
        public decimal MontantUsd { get; set; }
        public int NumAgrementFia { get; set; }

        public virtual Ecurie CodeEcurieNavigation { get; set; }
        public virtual Sponsor CodeSponsorNavigation { get; set; }
    }
}
