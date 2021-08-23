using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class Pays
    {
        public Pays()
        {
            Circuit = new HashSet<Circuit>();
        }

        public string IdPays2 { get; set; }
        public string IdPays3 { get; set; }
        public int IdPaysNum { get; set; }
        public string LibellePays { get; set; }

        public virtual ICollection<Circuit> Circuit { get; set; }
    }
}
