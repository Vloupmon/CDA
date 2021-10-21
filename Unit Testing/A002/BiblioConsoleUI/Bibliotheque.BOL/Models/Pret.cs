using System;
using System.Collections.Generic;

namespace Bibliotheque.BOL
{
    [Serializable]
    public partial class Pret : EntityBase
    {
        public string IdAdherent { get; set; }
        public int IdExemplaire { get; set; }
        public DateTime DateEmprunt { get; set; }
        public DateTime? DateRetour { get; set; }

        public virtual Adherent IdAdherentNavigation { get; set; }
        public virtual Exemplaire IdExemplaireNavigation { get; set; }
    }
}
