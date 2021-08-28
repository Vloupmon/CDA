using GrandPrixEF.Models;
using System;
using System.Globalization;
using System.Linq;

namespace GrandPrixEF {

    internal class Program {
        private static readonly GPF1DBContext gPF1DBContext = new();

        private static void Main() {
            //R01_ListePilotes("a");
            //R02_ListePilotes_Paginee("a", 2, 3);
            //R03_ListeGP();
            //R04_ClassementPilotes();
            R05_ClassementEcuries();
            //R06_PilotesToujoursQualifies();
        }

        private static void R01_ListePilotes(string recherche) {
            var pilotes = gPF1DBContext.Pilote
                .Where(p => p.NomPilote
                .Contains(recherche))
                .Select(x => new {
                    x.CodePilote,
                    x.NomPilote,
                    NomEcurie = x.CodeEcurieNavigation.NomEcurie
                })
                .OrderBy(x => x.NomPilote);

            Console.WriteLine("Liste des pilotes dont nom contient {recherche}");
            foreach (var pilote in pilotes) {
                Console.WriteLine("Code - {0}, Nom - {1}, Ecurie - {2}", pilote.CodePilote, pilote.NomPilote, pilote.NomEcurie);
            }
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }

        private static void R02_ListePilotes_Paginee(string recherche, int page, int taillePage) {
            var pilotesPaged = gPF1DBContext.Pilote
                .Where(p => p.NomPilote
                .Contains(recherche))
                .Select(x => new {
                    x.CodePilote,
                    x.NomPilote,
                    NomEcurie = x.CodeEcurieNavigation.NomEcurie
                })
                .OrderBy(x => x.NomPilote)
                .Skip((page - 1) * taillePage)
                .Take(taillePage);

            Console.WriteLine($"Liste des pilotes nom contient {recherche} Page {page} taille page {taillePage}");
            foreach (var pilote in pilotesPaged) {
                Console.WriteLine("Code - {0}, Nom - {1}, Ecurie - {2}", pilote.CodePilote, pilote.NomPilote, pilote.NomEcurie);
            }
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }

        private static void R03_ListeGP() {
            var gps = gPF1DBContext.PlanificationGp
                .Select(pgp => new {
                    pgp.CodeGp,
                    pgp.CodeGpNavigation.NomGrandPrix,
                    pgp.DateGp,
                    pgp.CodeCircuitNavigation.NomCircuit,
                    distance = (pgp.CodeCircuitNavigation.LongueurPiste * pgp.NombreTours) / 1000f
                })
                .OrderBy(gp => gp.DateGp);

            Console.WriteLine("Liste des GP par Dates");
            foreach (var gp in gps) {
                Console.WriteLine("Code : {0}    Nom : {1}, Date : {2}, Circuit : {3}, Distance : {4}",
                    gp.CodeGp, gp.NomGrandPrix, gp.DateGp.ToString("D"), gp.NomCircuit, gp.distance);
            }
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }

        private static void R04_ClassementPilotes() {
            var rankings = gPF1DBContext.Pilote
                .Select(s => new {
                    s.CodePilote,
                    NomPilote = String.Join(" ", s.NomPilote, s.PrenomPilote),
                    Points = s.ResultatCourse.Sum(r => r.NombrePointsMarques)
                })
                .OrderByDescending(x => x.Points)
                .ToList();

            Console.WriteLine("Classement des pilotes");
            foreach (var pilote in rankings) {
                Console.WriteLine("Code : {0}, Nom : {1}, Points : {2}", pilote.CodePilote, pilote.NomPilote, pilote.Points);
            }
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }

        private static void R05_ClassementEcuries() {
            Console.WriteLine("Classement des écuries");

            var tmp = gPF1DBContext.Ecurie.Select(r => new {
                r.CodeEcurie,
                r.NomEcurie
            }).ToList();
            var rankings = gPF1DBContext.ResultatCourse.Select(r => new {
            })
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }

        private static void R06_PilotesToujoursQualifies() {
            Console.WriteLine("Pilotes toujours qualifiés et sans abandon");

            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
    }
}