using Bibliotheque.BOL;
using Bibliotheque.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque.DALEF
{
    class LivreEF : ILivreRepository
    {
        BibliothequeEF contexte = new BibliothequeEF();
        public Livre AjouterLivre(Livre livre)
        {
            if (livre.IsValid)
            {
                contexte.Entry(livre).State = EntityState.Added;
                contexte.SaveChanges();
            }
            return livre;

        }

        public IList<Livre> ListerLivres()
        {
            return contexte.Livre.ToList();
        }

        public Adherent SelectionnerAdherentByID(string IdAdherent)
        {
            return contexte.Adherent.Find(IdAdherent);
        }

        public Livre SelectionnerLivreByIsbn(string Isbn)
        {
            return contexte.Livre.Find(Isbn);
        }
    }
}

