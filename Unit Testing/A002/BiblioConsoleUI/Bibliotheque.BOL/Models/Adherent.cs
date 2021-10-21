using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bibliotheque.BOL
{
    [Serializable]
    public partial class Adherent : EntityBase
    {
        public Adherent()
        {
            Prets = new HashSet<Pret>();
        }
        [Display(Name = "Identifiant", Description = "L'identifiant de l'adhérent")]
        [Required(ErrorMessage = "L'identifiant de l'adhérent est requis")]
        public string IdAdherent { get; set; }
        [Display(Name = "Nom Adhérent", Description = "Nom de l'adhérent")]
        [Required(ErrorMessage = "{0} est requis")]
        [StringLength(50, ErrorMessage = "Longueur de {0} invalide. Doit être comprise entre {2} et {1} ", MinimumLength = 2)]
        public string NomAdherent { get; set; }
        [Display(Name = "Prénom Adhérent", Description = "Prénom de l'adhérent")]
        [StringLength(50, ErrorMessage = "Longueur de {0} invalide. Doit être comprise entre {2} et {1} ", MinimumLength = 2)]
        public string PrenomAdherent { get; set; }

        public virtual ICollection<Pret> Prets { get; set; }
    }
}
