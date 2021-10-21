using System;
using System.Collections.Generic;
using Bibliotheque.BOL;

namespace Bibliotheque.Repository
{
    public interface IAdherentRepository
    {
        IList<Adherent> ListerAdherents();
        Adherent SelectionnerAdherentByID(string IdAdherent);
        Adherent AjouterAdherent(Adherent adherent);

    }
}
