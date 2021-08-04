using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObject_A1 {

    internal class Program {

        private static void Main(string[] args) {
            double Square(double x) => x * x;
            bool Even(int x) => x % 2 == 0;

            List<Stagiaire> stagiaires = JeuEssai.CreeListeStagiaire();
            IEnumerable<int> entiers = JeuEssai.CreeListeEntiers();

            Console.WriteLine("Min and Max int : {0}, {1}\n", entiers.Min().ToString(), entiers.Max().ToString());
            Console.WriteLine("Avg int : {0}\n", entiers.Average().ToString());
            Console.WriteLine("Sum of int[] : {0}\n", entiers.Sum().ToString());

            Console.WriteLine("Variante 3 - Pairs : {0}, impairs : {1}\n", (from n in entiers
                                                                            where Even(n)
                                                                            select n).Sum().ToString(),
                                                     (from n in entiers
                                                      where !Even(n)
                                                      select n).Sum().ToString());

            Console.WriteLine("Ordered int list : {0}\n", String.Join(", ", (from n in entiers
                                                                             select n).OrderBy(n => n)));

            Console.WriteLine("Int^2 > 5 : {0}\n", String.Join(", ", (from n in entiers
                                                                      where Square(n) > 5
                                                                      select n).OrderBy(n => n)));

            Console.WriteLine("Int^2 > Avg^2 : {0}\n", String.Join(", ", (from n in entiers
                                                                          where Square(n) > Square(entiers.Average())
                                                                          select n).OrderBy(n => n)));

            Console.WriteLine("Factorial of 1, 5 : {0}\n", Enumerable.Range(1, 5).Aggregate((x, y) => x * y));

            Console.WriteLine("Plus jeune stagiaire : {0}, plus vieux stagiaire : {1}\n",
                stagiaires.OrderBy(x => x.DateNaissance).First().Nom,
                stagiaires.OrderBy(x => x.DateNaissance).Last().Nom);

            Console.WriteLine("Nom le plus long : {0}\n",
                stagiaires.OrderBy(x => x.Nom.Length).Last().Nom);

            Console.WriteLine("Nombre caractères du nom: {0}\n", String.Join("; ",
                stagiaires.OrderBy(x => x.Nom.Length).Select(x => x.Nom + ", " + x.Nom.Length)));

            Console.WriteLine("Stagiaires ordonnés par age : {0}\n", String.Join(", ",
                stagiaires.OrderByDescending(x => x.DateNaissance).Select(x => x.Prenom + " " + x.Nom)));

            Console.WriteLine("Stagiaires dont le nom commence par \"J\" : {0}\n", String.Join(", ",
                stagiaires.Select(x => x.Prenom + " " + x.Nom).Where(x => x.StartsWith('J'))));

            Console.WriteLine("Stagiaires dont le nom contient \"an\" : {0}\n", String.Join(", ",
                stagiaires.Select(x => x.Prenom + " " + x.Nom).Where(x => x.Contains("an"))));

            Console.WriteLine("Stagiaires dont le rang est compris entre 3 et 6 : {0}\n", String.Join(", ",
                stagiaires.OrderBy(x => x.Nom).Select(x => x.Prenom + " " + x.Nom).Skip(3).Take(3)));

            Console.WriteLine("Age moyen des stagiaires : {0}\n", String.Join("; ",
              DateTime.Today.Year -
              // Conversion DateTime? -> DateTime -> long -> DateTime
              new DateTime((long)stagiaires.Select(x => x.DateNaissance.Value.Ticks).Average()).Year));
        }
    }
}