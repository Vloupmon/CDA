using System;
using System.Collections.Generic;
using Bibliotheque.BOL;
using Bibliotheque.Repository;

namespace Bibliotheque.BLL
{
           public class AdherentManager
        {
            readonly IAdherentRepository _adherentRepository;

            public AdherentManager(IAdherentRepository AdherentRepository)
            {
                this._adherentRepository = AdherentRepository;
            }
            public IList<Adherent> Lister()
            {
                return _adherentRepository.ListerAdherents();
            }
            public Adherent GetAdherentByID(string ID)
            {
                return _adherentRepository.SelectionnerAdherentByID(ID);
            }
            public Adherent CreerAdherent(Adherent adherent)
            {
                return _adherentRepository.AjouterAdherent(adherent);
            }
        }
    }
