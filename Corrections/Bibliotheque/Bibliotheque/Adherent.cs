using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.BOL
{
    [Serializable]
    public class Adherent : EntityBase
    {
        private string _nom;
        private string _prenom;

        [Required(ErrorMessage = "L'identifiant est requis")]
        public string AdherentID { get; set; }
        [Required(ErrorMessage = "Le nom est requis")]
        [MinLength(2, ErrorMessage = "La longueur du nom est de 2 caractères au moins")]
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                if (_nom != value)
                {
                    _nom = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                if (_prenom != value)
                {
                    _prenom = value;
                    NotifyPropertyChanged();
                }
            }
        }
        /// <summary>
        /// Compare deux objets pour déterminer l'égalité
        /// De type Adherent et même matricule
        /// </summary>
        /// <returns>Vrai si les deux objets sont égaux</returns>
        public override bool Equals(Object obj)
        {
            Adherent adherentConverti = obj as Adherent;
            return adherentConverti == null ? false : adherentConverti.AdherentID == this.AdherentID;
        }

        /// <summary>
        /// Compare deux adherents pour déterminer l'égalité
        /// Même matricule
        /// </summary>
        /// <param name="adherent"></param>
        /// <returns></returns>
        public bool Equals(Adherent adherent)
        {
            return adherent == null ? false : adherent.AdherentID == this.AdherentID;
        }
        /// <summary>
        /// opérateur relationnel ==
        /// </summary>
        /// <param name="adhA">Instance adherent</param>
        /// <param name="adhB">Instance adherent</param>
        /// <returns>Vrai si égaux</returns>
        public static bool operator ==(Adherent adhA, Adherent adhB)
        {
            return adhA is null ? adhB is null : adhA.Equals(adhB);
        }
        /// <summary>
        ///  opérateur relationnel !=
        /// </summary>
        /// <param name="adhA">Instance adherent</param>
        /// <param name="adhB">Instance adherent</param>
        /// <returns>Vrai si différents</returns>
        public static bool operator !=(Adherent adhA, Adherent adhB)
        {
            return adhA is null ? !(adhB is null) : !adhA.Equals(adhB);
        }
        /// <summary>
        /// Une des règles de conception veut que l'on modifie la méthode GetHashCode
        /// Si la méthode Equals est modifiée
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // Uniquement si non nul
            return (AdherentID != null) ? AdherentID.GetHashCode() : 0;
        }
    }
}
