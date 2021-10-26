using Microsoft.Extensions.DependencyInjection;
using System;
using Bibliotheque.Repository;
using Bibliotheque.BLL;
using Bibliotheque.BOL;

namespace BiblioConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.ConfigurerServices(args);
            GestionMenus();
            Configuration.DisposeServices();
        }

        private static void GestionMenus()
        {
            string Rep;
            do
            {
                Console.WriteLine("Choisir une options L pour Liste A pour Ajout S pour sortir");
                Rep = Console.ReadLine();
                switch (Rep)
                {

                    case "L":
                        AdherentManager adhMan = new AdherentManager(Configuration._serviceProvider.GetService<IAdherentRepository>());
                        foreach (Adherent adh in adhMan.Lister())
                        {
                            Console.WriteLine($"Code {adh.IdAdherent} Nom {adh.NomAdherent} prénom {adh.PrenomAdherent}");
                        }
                        break;
                    case "A":
                        Adherent adherent = new Adherent
                        {
                            Etat = EntityPOCOState.Added,
                            IdAdherent = "96GB011",
                            NomAdherent = "Boston",
                            PrenomAdherent = "Vicentico"
                        };
                        //Adherent adherent = new Adherent
                        //{
                        //    Etat = EntityPOCOState.Added,
                        //    NomAdherent = "B",
                        //    PrenomAdherent = "V"
                        //};
                        if (adherent.IsValid)
                        {
                            AdherentManager adhMan2 = new AdherentManager(Configuration._serviceProvider.GetService<IAdherentRepository>());
                            adhMan2.CreerAdherent(adherent);
                        }
                        else
                        {
                            Console.WriteLine($"Des erreurs subsistent {adherent.Error}");
                        }
                        break;
                    default:
                        break;
                }
            } while (Rep != "S");
        }
    }

}
