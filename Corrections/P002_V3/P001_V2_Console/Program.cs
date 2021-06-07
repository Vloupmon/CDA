using System;
using P001_V2;

namespace P001_V2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestObject();
            testerCollection();
           /* Test();
        
            Console.WriteLine("Etape 2 Le nombre d'instances en mémoire de salariés est toujours de {0}", Salarie.NombreInstances);
            Console.WriteLine("Appuyez sur la touche Entrée pour demander au Garbage Collector de nettoyer le tas");
            Console.ReadLine();
            GC.Collect();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Etape 3 Le nombre d'instances en mémoire de salariés est de {0}", Salarie.NombreInstances);*/
            Console.ReadLine();

        }
        static void testerCollection()
        {

            Salaries salaries = new Salaries();

            Salarie sal2 = new Salarie("Bost", "Vincent", "96AAA11")
            {
                SalaireBrut = 3500.00m,
                TauxCS = 0.35m
            };
            salaries.Add(sal2);

            Commercial com1 = new Commercial
            {
                Nom = "Capelle",
                Prenom = "Evelyne",
                Matricule="25FGF12",
                SalaireBrut = 3500.00m,
                TauxCS = 0.35m,
                ChiffreAffaire = 2000,
                Commission = 0.10m
            };
            salaries.Add(com1);


            Commercial com2 = new Commercial("Morillon", "Vincent", "96GBC11", 15000m, 0.5m);
            salaries.Add(com2);
            //
            Commercial com3 = new Commercial("Morillon", "Vincent", "96GBC11", 15000m, 0.5m);
            salaries.Add(com3);

            salaries.Remove(com1);

            salaries.Add(com2);
            salaries.Add(com3);

            Salarie sal = salaries.ExtraireSalarie("96GBC11");
            if (sal != null)
            {
                salaries.RemoveNom(sal.Nom);
            }

            Console.ReadLine();


        }
        private static void TestHeritage()
        {
            Console.WriteLine(null == null);


            // Préparation du test 
            Commercial com1 = new Commercial("Bost", "Vincent", "96GBC11", 10000m, 0.1m)
            {
                DateNaissance = new DateTime(1962, 01, 13),
                SalaireBrut = 3500.00m,
                TauxCS = .35m,
                GenreSalarie = Genre.Feminin
            };
            // Assertion et exécution
            Console.WriteLine("Salaire commercial attendu {0} obtenu {1} assertion {2} ", 3275, com1.SalaireNet, 3275 == com1.SalaireNet);
            Commercial com2 = new Commercial("Bost", "Vincent", "96GBC12", 15000m, 0.1m)
            {
                DateNaissance = new DateTime(1972, 01, 13),
                TauxCS = .45m,
                GenreSalarie = Genre.Feminin

            };
            Console.WriteLine("Commmerciaux différents attendu {0} obtenu {1}", true, com1 != com2);
            Console.WriteLine("Commmerciaux différents attendu {0} obtenu {1}", true, !com1.Equals(com2));
            Commercial com3 = new Commercial("Bost", "Vincent", "96GBC12", 15000m, 0.5m)
            {
                DateNaissance = new DateTime(1972, 01, 13),
                TauxCS = .35m
            };
            Console.WriteLine("Commmeriaux identiques attendu {0} obtenu {1}", true, com2 == com3);
            Commercial com4 = new Commercial(com3);
            Console.WriteLine($"valeurs : { com1.ToString()}");
            Console.WriteLine("Commmeriaux identiques attendu {0} obtenu {1}", true, com3 == com4);
            Console.ReadLine();
            Parent parent1 = new Parent();
            parent1.Valeur = 1000;
            Console.WriteLine("Parent Méthode 1 attendu {0} obtenu {1} Méthode 2 attendu {2} obtenu {3}",
                1000, parent1.Methode1(), 2000, parent1.Methode2());
            
            Enfant enfant1 = new Enfant();
            enfant1.Valeur = 1000;
            Console.WriteLine("Enfant Méthode 1 attendu {0} obtenu {1} Méthode 2 attendu {2} obtenu {3}",
                2000, enfant1.Methode1(), 4000, enfant1.Methode2());
            Parent enfantParent1 = new Enfant();
            enfantParent1.Valeur = 1000;
            Console.WriteLine("Enfant Parent Méthode 1 attendu {0} obtenu {1} Méthode 2 attendu {2} obtenu {3}",
                2000, enfantParent1.Methode1(), 4000, enfantParent1.Methode2());
            Console.WriteLine("Enfant Parent Méthode 1 attendu {0} obtenu {1} Méthode 2 attendu {2} obtenu {3}",
                2000, enfantParent1.Methode1(), 4000, ((Enfant)enfantParent1).Methode2());
            Console.ReadLine();

        }
    

        private static void TestObject()
        {
            object o = new Salarie();
            
            Salarie sal = o as Salarie;
            if (sal!=null)
            {
                
            }

        }

        private static void Test()
        {
            Console.WriteLine("Test de la méthode vérification Matricule");
            Console.WriteLine
                ($"Test nom vide {Salarie.IsMatriculeValide("") == false})");
            Console.WriteLine
                ($"Test longueur > 7 {Salarie.IsMatriculeValide("12345678") == false})");
            Console.WriteLine
               ($"Test caractère spécial {Salarie.IsMatriculeValide("12&FT78") == false})");
            Console.WriteLine
               ($"Test non digit {Salarie.IsMatriculeValide("A2EFT78") == false})");
            Console.WriteLine
              ($"Test nom vide {Salarie.IsMatriculeValide("12EFT78") == true})");

            try
            {
                Salarie sal4 = new Salarie() { Matricule = "123ABC34" };

                Salarie sal = new Salarie("Bost", "Vincent", "12aaa55");
                sal.DateNaissance = new DateTime(2000, 05, 29);
                sal.SalaireBrut = 1980.25m;
                sal.TauxCS = .30m;
                Salarie sal1 = new Salarie(sal);
                sal1.DateNaissance = new DateTime(2000, 05, 29);
                sal1.SalaireBrut = 1980.25m;
                sal1.TauxCS = .30m;
                Salarie sal2 = new Salarie("Bost", "Vincent", "12aaa55");
                sal2.DateNaissance = new DateTime(2000, 05, 29);
                sal2.SalaireBrut = 1980.25m;
                sal2.TauxCS = .30m;
                Console.WriteLine(@"Le salarié {0} {1} a été créé et son salaire net est de {2:n} euros", sal.Prenom, sal.Nom, sal.SalaireNet);
                Console.WriteLine("Etape 1 Le nombre d'instances en mémoire de salariés est de {0}", Salarie.NombreInstances);
                Console.WriteLine("Appuyez sur la touche Entrée pour détruire la référence au salarié");
                Console.ReadLine();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }

    public class Parent
    {
        private int _valeur;

        public int Valeur
        {
            get { return _valeur; }
            set { _valeur = value; }
        }
        public virtual int Methode1()
        {
            return this.Valeur * 1;
        }
        public int Methode2()
        {
            return this.Valeur * 2;
        }

    }

    public class Enfant : Parent
    {

        public override int Methode1()
        {
            return base.Methode1() * 2;
        }
        public new int Methode2()
        {
            return this.Valeur * 4;
        }
    }
}
