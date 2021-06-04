using SalariesDll;
using System;

namespace SalarieTest {

    internal class Program {

        private static void Main(string[] args) {
            Salarie stagiaire = new();
            Salarie stagiaire2 = new();
            Commercial commercial;

            stagiaire.Matricule = "11DDD13";
            stagiaire.Prenom = "Vincent";
            stagiaire.Nom = "Loupmon";
            stagiaire.DateNaissance = new DateTime(1990, 8, 14);
            stagiaire.SalaireBrut = 1337;
            stagiaire.TauxCs = 0.3f;

            stagiaire2.Matricule = "11DDD13";
            stagiaire2.Prenom = "Vincent";
            stagiaire2.Nom = "Loupmon";
            stagiaire2.DateNaissance = new DateTime(1990, 8, 14);
            stagiaire2.SalaireBrut = 13379;
            stagiaire2.TauxCs = 0.3f;

            commercial = new(stagiaire, 100000, 20);

            Console.WriteLine("Commercial : {0}", commercial.ToString());
        }
    }
}