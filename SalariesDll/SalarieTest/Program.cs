using System;
using SalariesDll;

namespace SalarieTest {

    internal class Program {

        private static void Main(string[] args) {
            Salarie sal = new();
            Salarie sal2 = new();
            Salarie sal3 = new();
            Commercial commercial;
            Salaries salaries = new();

            sal.Matricule = "11DDD13";
            sal.Prenom = "Vincent";
            sal.Nom = "Loupmon";
            sal.DateNaissance = new DateTime(1990, 8, 14);
            sal.SalaireBrut = 1337;
            sal.TauxCs = 0.3f;

            sal2.Matricule = "11DDD14";
            sal2.Prenom = "Vincent";
            sal2.Nom = "Loupmont";
            sal2.DateNaissance = new DateTime(1990, 8, 14);
            sal2.SalaireBrut = 13379;
            sal2.TauxCs = 0.4f;

            sal3.Matricule = "11DDD15";
            sal3.Prenom = "Vincent";
            sal3.Nom = "Loupmond";
            sal3.DateNaissance = new DateTime(1990, 8, 14);
            sal3.SalaireBrut = 23379;
            sal3.TauxCs = 0.4f;

            IO.SaveText(sal, "sal3.csv");
            Console.WriteLine(IO.LoadText("sal3.csv").ToString());
        }
    }
}