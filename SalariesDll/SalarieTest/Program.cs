using System;
using SalariesDll;

namespace SalarieTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie stagiaire = new Salarie();


            stagiaire.Matricule = "11DDD13";
            stagiaire.Prenom = "Vincent";
            stagiaire.Nom = "Loupmon";
            stagiaire.DateNaissance = new DateTime(1990, 8, 14);
            stagiaire.SalaireBrut = 1337;
            stagiaire.TauxCs = 0.3f;
            
            Console.WriteLine("Le matricule de {0} {1} est {2}\n", stagiaire.Prenom, stagiaire.Nom, stagiaire.Matricule);
            Console.WriteLine("La date de naissance de {0} {1} est le {2}\n", stagiaire.Prenom, stagiaire.Nom, stagiaire.DateNaissance);
            Console.WriteLine("Le salaire brut de {0} {1} est de {2} euros\n", stagiaire.Prenom, stagiaire.Nom, stagiaire.SalaireBrut);
            Console.WriteLine("Le taux de cotisations sociales de {0} {1} est de {2}%\n", stagiaire.Prenom, stagiaire.Nom, (int)(stagiaire.TauxCs * 100));
            Console.WriteLine("Le salaire net de {0} {1} est de {2} euros\n", stagiaire.Prenom, stagiaire.Nom, stagiaire.SalaireNet());

            Salarie stagiaire2 = new Salarie() { Nom = "Toto", Prenom = "Titi" };
            Console.WriteLine(stagiaire2.Prenom + " " + stagiaire2.Nom + "\n");
        }
    }
}
