using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHashSetHeritage
{
   public abstract class Personne
    {
        public int Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public override bool Equals(Object personne)
        {
            Personne personneRef = personne as Personne;
            if (personneRef == null) return false;
            return (personneRef.Code == this.Code);
        }

        public override int GetHashCode()
        {   
            return Code.GetHashCode(); ;
        }
        /// <summary>
        /// opérateur relationnel ==
        /// </summary>
        /// <param name="personneA">Instance Personne</param>
        /// <param name="personneB">Instance Personne</param>
        /// <returns>Vrai si égaux</returns>
        public static bool operator ==(Personne personneA, Personne personneB)
        {
            return personneA is null ? personneB is null : personneA.Equals(personneB);
        }
        /// <summary>
        ///  opérateur relationnel !=
        /// </summary>
        /// <param name="personneA">Instance Personne</param>
        /// <param name="personneB">Instance Personne</param>
        /// <returns>Vrai si différents</returns>
        public static bool operator !=(Personne personneA, Personne personneB)
        {
            return personneA is null ? !(personneB is null) : !personneA.Equals(personneB);
        }
    }
}
