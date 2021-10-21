using System;
using System.Collections.Generic;

namespace Bibliotheque.BOL
{
    [Serializable]
    public partial class Exemplaire : EntityBase
    {
        public Exemplaire()
        {
            Pret = new HashSet<Pret>();
        }

        public int IdExemplaire { get; set; }
        public bool Empruntable { get; set; }
        public string Isbn { get; set; }

        public virtual Livre IsbnNavigation { get; set; }
        public virtual ICollection<Pret> Pret { get; set; }
    }
}
