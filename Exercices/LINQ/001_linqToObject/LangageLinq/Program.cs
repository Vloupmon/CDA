using System;
using System.Collections.Generic;
using System.Linq;

namespace LangageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            TestDelegue.Tester();

            var f1 = GetPersonnes().Where( p => p.Age > 50).Where(o=>o.Genre==Sexe.Masculin).OrderByDescending(p => p.Nom).Skip(1).Take(5);
            f1.OrderBy(p => p.Nom).ToList().ForEach(o => Console.WriteLine(o.Nom));
            //var f2 = f1.Where(p => p.Genre == Sexe.Féminin).Where(o=>o.Nom.Contains('c'));

            //foreach (var item in f2)
            //{

            //}
            //List<Personne> femmes50plus = f2.ToList();



            List<Personne> personnes = GetPersonnes();
            Personne p1 = personnes.FirstOrDefault(p => p.Nom.StartsWith("Bost"));
            var personnesAgees = personnes.Where(p => p.Age > 50).ToList();
            Personne p2 = personnesAgees.FirstOrDefault(p => p.Nom.StartsWith("Bost"));
            p2.Nom = "BOSTI";
            Console.WriteLine($"P1 {p1.Nom}  P2 {p2.Nom}");
            

            //Personne p = personnes.FirstOrDefault(p => p.AdresseMail == "vincent.bost@afpa.fr");

            //var personnesAgees = personnes.Where(p => p.Age > 50).ToList();

            //var femmesAgees = personnes.Where(p =>
            //{
            //    bool age = (p.Age > 50);
            //    return age && p.Genre == Sexe.Féminin;
            //}).ToList();


            //var femmesAgees2 = personnes.Where(delegate (Personne p)
            //{
            //    bool age = (p.Age > 50);
            //    return age && p.Genre == Sexe.Féminin;
            //}).ToList();

            var femmesAgees3 = personnes.Where(p => p.Age > 50 && p.Genre == Sexe.Féminin);

            var femmesAgees4 = Filtrer(personnes, p => p.Age > 50 && p.Genre == Sexe.Féminin);


            var femmesAgees3R = femmesAgees3.ToList();


            var femmesAgees4R = femmesAgees4.ToList();

            foreach (var item in femmesAgees4R)
            {
                // opérations
            }

            femmesAgees4.ToList().
                ForEach(p => Console.WriteLine($"Madame {p.Nom} est une femme agée "));

            Personne plusVieuse = femmesAgees4.OrderByDescending(f => f.Age)
                .FirstOrDefault();

            plusVieuse = Filtrer(personnes, p => p.Age > 50 && p.Genre == Sexe.Féminin)
                .OrderByDescending(f => f.Age)
                .FirstOrDefault();

            var plusVieille = from pers
                              in Filtrer(personnes, p => p.Age > 50 && p.Genre == Sexe.Féminin)
                              orderby (pers.Age)
                              select pers;


            double[] liste = new double[] { 1.0052, 2, 3, 4, 8, 89.25 };

            Filtrer(liste, dob => dob > 3).ToList().ForEach(e => Console.WriteLine(e));


            var x = GetPersonnes().Where(p =>
            {
                int s = 1;
                int t = 2;
                return s == t;
            });
            // Création d'une fonction 
            TestDelegue.Tester();
            TesterExtension();

            IEnumerable<Personne> femmes = Filtrer(GetPersonnes(),
                p => p.Genre == Sexe.Féminin);

            List<Personne> listeFemmes = femmes.ToList();


            IEnumerable<Personne> hommesAges = Filtrer(GetPersonnes(),
                p => p.Genre == Sexe.Masculin && p.Age > 50);

            Personne[] listeVieux = hommesAges.ToArray();

            //  Personne plusVieuse = hommesAges.OrderByDescending(p => p.Age).First();

            var I1 = GetPersonnes().Where(p => p.Genre == Sexe.Masculin);
            var I2 = I1.Where(p => p.Age < 40);
            var I3 = I2.Where(p => p.Nom.StartsWith("f", ignoreCase: true, null));

            var I4 = GetPersonnes().Where(p => p.Genre == Sexe.Masculin).Where(p => p.Age < 40);

            I4 = I4.ToList();

            I3.ToList().ForEach(p =>
            Console.WriteLine($"Homme jeune dont le nom commence par f {p.Nom}"));

            Exemples.PartitionTri();
            Pagination();
            
        }

        public static List<Personne> GetPersonnes()
        => new List<Personne>
            {
                  new Personne{ Id = 1,Nom="Bost",Prenom="Vincent",Genre=Sexe.Masculin, AdresseMail = "vincent.bost@afpa.fr",DateNaissance=new DateTime(1962,01,13) },
                  new Personne{ Id = 2,Nom="Morillon",Prenom="Jean",Genre=Sexe.Masculin, AdresseMail = "jean.morillon@afpa.fr",DateNaissance=new DateTime(1959,10,20) },
                  new Personne{ Id = 3,Nom="Capelle",Prenom="Evelyne",Genre=Sexe.Féminin, AdresseMail = "evelyne.capelle@afpa.fr",DateNaissance=new DateTime(1963,02,10) },
                  new Personne{ Id = 4,Nom="Farnier",Prenom="Philippe",Genre=Sexe.Masculin, AdresseMail = "philippe.farnier@afpa.fr",DateNaissance=new DateTime(1990,10,11) },
                  new Personne{ Id = 5,Nom="Cérasoli",Prenom="Laeticia",Genre=Sexe.Féminin, AdresseMail = "laeticia.cerasoli@afpa.fr",DateNaissance=new DateTime(1978,02,10) },
                  new Personne{ Id = 6,Nom="Cornet",Prenom="Céline",Genre=Sexe.Féminin, AdresseMail = "celine.cornet@afpa.fr",DateNaissance=new DateTime(1980,03,11) }

        };

        static void TesterExtension()
        {

            List<int> entiers = new List<int> { 1, 3, 4, 5 };
            var carres = entiers.Select(i => i.Carre()).ToList();
            var carresSup9 = entiers.Where(i => i.Carre() > 9).ToList();
           

        }
        //static IEnumerable<Personne> Filtrer(IEnumerable<Personne> sequence, 
        //    Func<Personne,bool> predicat)
        //{
        //    IEnumerator<Personne> enumerator = sequence.GetEnumerator();
        //    while (enumerator.MoveNext())
        //    {
        //        var item = enumerator.Current;
        //        if (predicat(item))
        //        {
        //            yield return item;
        //        }


        //    }
        //}
        static IEnumerable<T> Filtrer<T>(IEnumerable<T> sequence,
           Func<T, bool> predicat)
        {
            IEnumerator<T> enumerator = sequence.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                if (predicat(item))
                {
                    yield return item;
                }
            }
        }
        public static void Projection()
        {
            var personnes = GetPersonnes();

            var anonyme1 = personnes.Select(p => new  { p.Id, p.Nom, Age = p.Age });
            anonyme1.ToList().ForEach(per => Console.WriteLine($"{per.Id};{per.Nom};{per.Age}"));

            var anonyme2 = personnes.Select(p => new
            {
                identifiant = p.Id,
                NomPersonne = p.Nom,
                Age = ((decimal)Math.Round(p.Age, 2))
            });
            anonyme2.ToList().
                ForEach(per => Console.WriteLine($"{per.identifiant};{per.NomPersonne};{per.Age}"));

            // var  listePersonnes = Get
        }
        public static void SelectionUnique()
        {
            var personnes = GetPersonnes();

            Personne personne = personnes.FirstOrDefault(p => p.Id == 1);

        }
        public static void Agregats()
        {
            List<int> entiers = new List<int> { 0, 0, 2, 3, 4, 4 };

            if (!entiers.Contains(5))
            {
                entiers.Add(5);
            }
            Console.WriteLine($"Nombre de valeurs distinctes  {entiers.Distinct().Count()}");



        }
        public static void Pagination()
        {
            List<Personne> personnes = GetPersonnes();
            int taillePage = 3;
            int numeroPage = 2;

            // Liste des personnes dont le nom contient un a

            List<Personne> pageDemandee =
                personnes.Where(p => p.AdresseMail!=null)
                .OrderBy(p => p.Nom)
                .Skip((numeroPage - 1) * taillePage)
                .Take(taillePage)
                .ToList();
                
           
        }
    }
}
