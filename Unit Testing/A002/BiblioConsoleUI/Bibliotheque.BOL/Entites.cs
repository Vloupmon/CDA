using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bibliotheque.BOL
{
    public partial class Livre
    {
        public override bool Equals(object obj)
        {
            Livre livre = obj as Livre;
            return (livre == null ? false : livre.Isbn == this.Isbn);
        }
        public override int GetHashCode()
        {
            return (this.Isbn == null ? 0 : this.Isbn.GetHashCode());
        }
    }

  
    public partial class Adherent
    {

        public bool PeutEmprunter()
        {
            int nombrePretsEnCours = 0;
            foreach (Pret item in this.Prets)
            {
                if (!item.DateRetour.HasValue || item.DateRetour.Value == DateTime.MinValue)
                    nombrePretsEnCours++;
            }
            if (nombrePretsEnCours < 3) return true; else return false;
        }

    }

    

    public partial class Exemplaire
    {

    }
   
    public partial class Pret
    {

    }
   
}
