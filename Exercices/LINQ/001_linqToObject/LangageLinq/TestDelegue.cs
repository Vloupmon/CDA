using System;
using System.Collections.Generic;
using System.Text;

namespace LangageLinq
{

    public static class TestDelegue
    {
        public delegate double Operation(double a, double b);
        static double Addition(double x, double y)
        {
            return x + y;
        }
        static double Multiplication(double x, double y)
        {
            return x * y;
        }
        public static void Tester()
        {
            double[] liste = new double[] { 1.0052, 2, 3, 4, 8, 89.25 };
            double r = Addition(2, 3);
            Resultat(liste, Addition);
            Resultat(liste, Multiplication);

            Resultat(liste, delegate (double e, double f) { return e * f; });


            Resultat(liste, ( e,  f) => e * f);

            ResultatGen(liste, (u, v) => u * v);

            definitions();
        }
        static void Resultat(double[] valeurs, Operation ope)
        {
            double[] res = new double[valeurs.Length-1];
            for (int i = 1; i < valeurs.Length; i++)
            {
                res[i-1] = ope(valeurs[i], valeurs[i - 1]);
            }
            Console.WriteLine("-- debut ----");
            Console.WriteLine("Liste des valeurs");
            for (int i = 0; i < valeurs.Length; i++)
            {
                Console.Write($"{valeurs[i]};");
            }
            Console.WriteLine();
            Console.WriteLine($"Résultat de l'opération");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]};");
            }
            Console.WriteLine("-- fin ----");
        }
        static void Operation_Delegue_Type2()
        {
            Func<int, int> operation = x => x * x;

            Console.WriteLine("Resultat multiplier entier {0}", operation(52));

            operation = x => x / x;
            Console.WriteLine("Resultat diviser entier 2 {0}", operation(5));

            Console.ReadLine();
        }
        static void ResultatGen(double[] valeurs, Func<double,double,double> ope)
        {
            double[] res = new double[valeurs.Length - 1];
            for (int i = 1; i < valeurs.Length; i++)
            {
                res[i - 1] = ope(valeurs[i], valeurs[i - 1]);
            }
            Console.WriteLine("-- debut ----");
            Console.WriteLine("Liste des valeurs");
            for (int i = 0; i < valeurs.Length; i++)
            {
                Console.Write($"{valeurs[i]};");
            }
            Console.WriteLine();
            Console.WriteLine($"Résultat de l'opération");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]};");
            }
            Console.WriteLine("-- fin ----");
        }
      
       

        static void definitions()
        {

            Action expSP = () => Console.WriteLine("Expression sans parametre");
            expSP();
            Action<string> expString = texte => Console.WriteLine($"Bonjour {texte}");
            expString("Conc Dev Application");

            Func<string, int, bool> testerLongueur = (texte, longueur) => texte.Length <= longueur;
            Console.WriteLine($"Resultat {testerLongueur("CDA", 3)}");

            Func<int, int, bool> instructionsCarreSup = (val, max) =>
            (val * val) == max;
           
            Console.WriteLine($"Resultat {instructionsCarreSup(3, 6)}");
        }
    }
}
