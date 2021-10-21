using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bibliotheque.BOL;
using Bibliotheque.Repository;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheque.DALEF
{
    public class AdherentEF : IAdherentRepository
    {
        BibliothequeEF contexte = new BibliothequeEF();
        public Adherent AjouterAdherent(Adherent adherent)
        {
            if (adherent.IsValid)
            {
                contexte.Entry(adherent).State = EntityState.Added;
                contexte.SaveChanges();
            }   
            return adherent;
          
        }

        public IList<Adherent> ListerAdherents()
        {
            return contexte.Adherent.ToList();
        }

        public Adherent SelectionnerAdherentByID(string IdAdherent)
        {
            return contexte.Adherent.Find(IdAdherent);
        }
    }
}
