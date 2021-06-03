using SalariesDll;
using System;

namespace SalarieTest {

    internal class Program {

        private static void Main(string[] args) {
            Salarie stagiaire = new Salarie();
            Salarie stagiaire2 = new Salarie();

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

            if (stagiaire.Equals(stagiaire2)) {
                Console.WriteLine("Les deux stagiaires sont égaux");
            }
            else {
                Console.WriteLine("Les deux stagiaires ne sont pas égaux");
            }

            Console.WriteLine("Hashcode stagiaire 1 : {0}", stagiaire.GetHashCode().ToString());
            Console.WriteLine("Hashcode stagiaire 2 : {0}", stagiaire2.GetHashCode().ToString());

            Console.WriteLine("Stagiaire 1 str : {0}", stagiaire.ToString());
            Console.WriteLine("Stagiaire 2 str : {0}", stagiaire2.ToString());

            Console.WriteLine("Net stagiaire 1 : {0}", stagiaire.SalaireNet);
        }
    }
}