using System;
using System.Collections.Generic;

namespace Bibliotheque.BOL
{
    [Serializable]
    public partial class Livre :EntityBase
    {
        public Livre()
        {
            Exemplaire = new HashSet<Exemplaire>();
        }

        public string Isbn { get; set; }
        public string Titre { get; set; }

        public virtual ICollection<Exemplaire> Exemplaire { get; set; }
    }
}
