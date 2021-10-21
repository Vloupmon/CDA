using Bibliotheque.BOL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Repository
{
   public interface ILivreRepository
    {
        IList<Livre> ListerLivres();
        Livre SelectionnerLivreByIsbn(string Isbn);
        Livre AjouterLivre(Livre livre);
    }
}
