using System;
using System.Collections.Generic;
using LinqToEntityCore_1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LinqToEntityCore_1 {

    public class Program {
        private static ComptoirAnglaisEntities dbcontexte = null;
        private static Stopwatch Chrono = new Stopwatch();

        private static void Main(string[] args) {
            dbcontexte = new ComptoirAnglaisEntities();

            //Requete1A("s");
            //Requete1B("s");
            //Requete2A("s");
            //Requete2B("s");
            //Requete3A("s");
            //    Requete3B("s");
            //  Requete4A("USA");
            //    Requete4B("USA");
            // Requete4C("USA");
            // Requete4D("USA");

            // Requete5A();
            // Requete5B();
            // Requete6(); //

            //Requete7A();
            //Requete7B();
            // Requete8A(2010);
            //Requete8B(2010);
            //Requete9A();
            //Requete9B();

            // Requete10A();
            // Requete10B();
            // Requete10C();
            // Requete10D();
            //Requete11();

            //Requete12A();
            //Requete12B();
            //Requete12C();
            Requete12D();
            Requete12E();
            Requete12F();
        }

        #region Requêtes simples sur une table

        /// <summary>
        /// Syntaxe selon l'approche des méthodes
        /// </summary>
        /// <param name="debNom"></param>
        private static void Requete1A(string debNom) {
            var req = dbcontexte.
                Customers.
                Where(c => c.CompanyName.StartsWith(debNom));
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        /// <summary>
        /// Syntaxe selon l'approche par requête plus proche du SQL
        /// </summary>
        /// <param name="debNom"></param>
        private static void Requete1B(string debNom) {
            IEnumerable<Customers> req = from c in dbcontexte.Customers
                                         where (c.CompanyName.StartsWith(debNom))
                                         select c;
            ObjectDumper.Write(req);
            Console.ReadLine();
            /*
            Attention aux paramètres de classement des chaînes sur le SGBD
            ici CIAS c'est à dire Insensible à la Casse Sensible aux Accents
            Vous ne pouvez pas préciser la manière dont doivent être comparées les chaînes
            en introduisant un paramètre complémentaire extrait de l'énumération StringComparison
            car il ne peut être traduit en SQL
            where (c.CompanyName.StartsWith(debNom,StringComparison.CurrentCulture))
             */
        }

        private class test {

            public string Nom {
                get; set;
            }
        }

        private static void Requete2A(string debNom) {
            var req = dbcontexte.Customers.
                Where(c => c.CompanyName.StartsWith(debNom)).Select(c => new test { Nom = c.CompanyName })
                .FirstOrDefault();
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        private static void Requete2B(string debNom) {
            var req = (from c in dbcontexte.Customers
                       where (c.CompanyName.StartsWith(debNom))
                       select c).FirstOrDefault();
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        /// <summary>
        /// Illustration ici du tri des éléments et de l'extraction d'un seul
        /// le premier.
        /// Au lieu de récupérer un objet typé associé à une classe Customers,
        ///  nous récupérons ici un objet de type anonyme par projection
        /// </summary>
        /// <param name="debNom"></param>
        private static void Requete3A(string debNom) {
            var req = dbcontexte.Customers
                .Where(c => c.CompanyName.StartsWith(debNom))
                .OrderBy(p => p.CompanyName)
                .Select(c => new { nom = c.CompanyName, id = c.CustomerId })
                .FirstOrDefault();
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        private static void Requete3B(string debNom) {
            var req = (from c in dbcontexte.Customers
                       where (c.CompanyName.StartsWith(debNom))
                       orderby (c.CompanyName)
                       select new {
                           nom = c.CompanyName
                       }).FirstOrDefault();
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        #endregion Requêtes simples sur une table

        #region Requêtes avec inclusion et filtre sur les propriétés de navigation

        /// <summary>
        /// Requêtes incluant des données issues des propriétés de navigation.
        /// Utiliser la méthode Include au premier niveau puis éventuellement
        /// ThenInclude sur les niveaux suivants.
        /// Point important : vous pouvez très bien faire des filtres
        /// à partir d'une clause Where sur les objets accessibles via les propriétés
        /// de navigation sans intégrer ces derniers dans le résultat.
        /// </summary>
        /// <param name="pays"></param>
        private static void Requete4A(string pays) {
            // Version les commandes de 2010
            // pour les employés ayant vendu en 2010
            // La clause Include complétée d'une clause Where permet d'inclure
            // uniquement les commandes de 2010
            var t = dbcontexte.Employees.Where(o => o.Orders.Any(o => o.OrderDate.Value.Year == 2010));
            t = t.Take(5);
            t = t.OrderByDescending(e => e.LastName);
            List<Employees> el = t.ToList();
            dbcontexte.Employees.
                Include(e => e.Orders.Where(o => o.OrderDate.Value.Year == 2010)).
                 Where(e => e.Country == pays)
                 .ToList().ForEach(e => {
                     Console.WriteLine($"Employe {e.EmployeeId}  {e.LastName}");
                     foreach (var item in e.Orders) {
                         Console.WriteLine($"date {item.OrderDate} " +
                             $"numero {item.OrderId} Annee {item.OrderDate.Value.Year}");
                     }
                 });
            Console.ReadLine();
        }/// <summary>

         /// Illustration dans cette requête de Include de nouveau mais avec toutes les
         /// commandes
         /// et de Any opérateur ensembliste appliqué
         /// sur la collection des enfants
         /// Il faut au moins une commande en 2010
         /// </summary>
         /// <param name="pays"></param>
        private static void Requete4B(string pays) {
            // Version avec toutes les commandes
            // pour les employés ayant vendu en 2010
            //
            dbcontexte.Employees.Include(e => e.Orders).
                 Where(e => e.Country == pays
                 && e.Orders.Any(o => o.OrderDate.Value.Year == 2010))
                 .ToList().ForEach(e => {
                     Console.WriteLine($"Employe {e.EmployeeId}  {e.LastName}");
                     foreach (var item in e.Orders) {
                         Console.WriteLine($" Annee {item.OrderDate.Value.Year}");
                     }
                 });
            Console.ReadLine();
        }

        /// <summary>
        /// Approche avec projection pour produire une liste d'objets anonymes
        /// Vous remarquerez le filtre sur propriété de navigation Orders
        /// et Projection associée pour ne retenir que le Numéro de commande
        /// et la date
        /// Ici, tous les employés que
        /// </summary>
        /// <param name="pays"></param>
        private static void Requete4C(string pays) {
            dbcontexte.Employees.Where(e => e.Country == pays)
            .Select(e => new {
                e.EmployeeId,
                e.LastName,
                cdes = e.Orders.Where(o => o.OrderDate.Value.Year == 2010)
                .Select(o => new { o.OrderDate, o.OrderId })
            }).ToList().ForEach(r => {
                Console.WriteLine($"Employe {r.EmployeeId}");
                foreach (var item in r.cdes) {
                    Console.WriteLine($"date {item.OrderDate} " +
                        $"numero {item.OrderId}");
                }
            });
            Console.ReadLine();
        }

        /// <summary>
        /// Requête retournant des données à plat
        /// une ligne présente des données de Employees et de Orders
        /// Cette approche ne respecte pas l'organisation hiérarchique du
        /// modèle objet
        /// </summary>
        /// <param name="pays"></param>
        private static void Requete4D(string pays) {
            // Retourne un jeu de données à plat comportant des infos employe et commande
            var req = from e in dbcontexte.Employees.Where(emp => emp.Country == pays)
                      join o in dbcontexte.Orders.Where(cde => cde.OrderDate.Value.Year == 2010)
                         on e.EmployeeId
                         equals o.EmployeeId
                      orderby e.EmployeeId
                      select new {
                          Prenom = e.FirstName,
                          Nom = e.LastName,
                          NumCde = o.OrderId,
                          DateCde = o.OrderDate
                      };

            foreach (var item in req) {
                Console.WriteLine($"Commandes de {item.Prenom} {item.Nom} Date : {item.DateCde} Numero : {item.NumCde}");
            }
            Console.ReadLine();
        }

        #endregion Requêtes avec inclusion et filtre sur les propriétés de navigation

        #region Requêtes méthodes ensemblistes All et Any sur propriétés de navigation

        private static void Requete5A() {
            // Catégories sans produit en rupture
            var req = from cat in dbcontexte.Categories
                      where (cat.Products.All(p => !p.Discontinued))
                      select new {
                          cat.CategoryId,
                          cat.CategoryName
                      };
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        private static void Requete5B() {
            // Catégories avec au moins un produit en rupture
            var req = dbcontexte.Categories.
                      Where(c => c.Products.Any(p => p.Discontinued))
                      .Select(c => new { c.CategoryId, c.CategoryName });
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        #endregion Requêtes méthodes ensemblistes All et Any sur propriétés de navigation

        #region Aggrégats sur propriété de navigation

        internal static void Requete6() {
            dbcontexte.Customers.
               Select(c => new {
                   c.CustomerId,
                   c.CompanyName,
                   nombre = c.Orders.Count
               }).
               ToList().
               ForEach(c =>
                Console.WriteLine($"Client {c.CustomerId} {c.CustomerId} " +
                $"nbre {c.nombre}")
                );
            Console.ReadLine();
        }

        private static void Requete7A() // clients sans commande Syntaxe Méthode
        {
            // Filtre sur valeur de l'agrégat
            dbcontexte.Customers.Where(c => c.Orders.Count == 0).ToList()
                .ForEach(c => Console.WriteLine($"Id : {c.CustomerId} {c.CompanyName}"));
        }

        private static void Requete7B() // clients sans commande Syntaxe Requete
        {
            // Filtre sur valeur de l'agrégat
            (from c in dbcontexte.Customers
             where c.Orders.Count == 0
             select c).ToList().ForEach(
                 c => Console.WriteLine($"Id : {c.CustomerId} {c.CompanyName}"));
            Console.ReadLine();
        }

        /// <summary>
        /// Opérateur All sur propriété de navigation
        /// Syntaxe Méthode
        /// </summary>
        /// <param name="anneeDerniereCommande"></param>
        private static void Requete8A(int anneeDerniereCommande) {
            var cde = dbcontexte.Customers.Where(c =>
             c.Orders.All(o => o.OrderDate.Value.Year < anneeDerniereCommande)).
             Select(c => new { c.CustomerId, c.CompanyName });

            ObjectDumper.Write(cde);
            Console.ReadLine();
        }

        /// <summary>
        /// Opérateur All sur propriété de navigation
        /// Syntaxe Requete avec projection
        /// </summary>
        /// <param name="anneeDerniereCommande"></param>
        private static void Requete8B(int anneeDerniereCommande) {
            var req = from c in dbcontexte.Customers
                      where (c.Orders.All(o => o.OrderDate.Value.Year < anneeDerniereCommande)
                      )
                      select new {
                          c.CustomerId,
                          c.CompanyName
                      };
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        private static void Requete9A() {
            var req = from cat in dbcontexte.Categories
                      where (cat.Products.All(p => !p.Discontinued))
                      select new {
                          cat.CategoryId,
                          cat.CategoryName
                      };
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        private static void Requete9B() {
            var req = dbcontexte.Categories.
                      Where(c => c.Products.All(p => !p.Discontinued)).
                      Select(c => new { c.CategoryId, c.CategoryName });
            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        #endregion Aggrégats sur propriété de navigation

        #region Calcul Agrégats complexes

        private static void Requete10A() // Pas OK
        {
            // Requête qui vient tout naturellement en premier lieu
            // Cette forme a pu fonctionner avec les versions
            // précédentes d'entity Framework
            // Ce n'est plus le cas aujourd'hui

            var req = from c in dbcontexte.Customers
                      where c.Country == "France"
                      select new {
                          c.CustomerId,
                          c.CompanyName,
                          ca = (c.Orders.Count == 0)
                          ? 0
                          : c.Orders.Sum(o => o.OrderDetails
                          .Sum(od => ((double)od.UnitPrice * (1.0 - od.Discount)) * od.Quantity))
                      };

            ObjectDumper.Write(req);
            Console.ReadLine();
        }

        private static void Requete10B() //
        {
            // Cette forme fonctionne mais ne permet pas de récupérer les clients sans commande.

            var CA2 = from C in dbcontexte.Customers.Where(c => c.Country == "France")
                      join O in dbcontexte.Orders on C.CustomerId equals O.CustomerId
                      join OD in dbcontexte.OrderDetails on O.OrderId equals OD.OrderId
                      select new {
                          C.CompanyName,
                          C.CustomerId,
                          TotalLigne = (double)OD.UnitPrice * (1.0 - OD.Discount) * OD.Quantity
                      };

            CA2.GroupBy(co => new { co.CustomerId, co.CompanyName }).Select(t =>
                  new {
                      t.Key.CustomerId,
                      t.Key.CompanyName,
                      CaTotal = t.Sum(o => o.TotalLigne)
                  }).ToList().ForEach(c => Console.WriteLine($"{c.CustomerId} CA = {c.CaTotal}"));

            Console.ReadLine();
        }

        private static void Requete10C() //
        {
            // Pour utiliser une jointure gauche, il convient d'utiliser
            // un regroupement into avec la mention DefaultIfEmpty()
            var CA2 = from C in dbcontexte.Customers.Where(c => c.Country == "France")
                      join O in dbcontexte.Orders on C.CustomerId equals O.CustomerId
                      into Co
                      from X in Co.DefaultIfEmpty()
                      join OD in dbcontexte.OrderDetails on X.OrderId equals OD.OrderId
                      into COD
                      from Y in COD.DefaultIfEmpty()
                      select new {
                          C.CompanyName,
                          C.CustomerId,
                          TotalLigne = (Y == null) ? 0 : (double)Y.UnitPrice * (1.0 - Y.Discount) * Y.Quantity
                      };

            CA2.GroupBy(co => new { co.CustomerId, co.CompanyName }).Select(t =>
                  new {
                      t.Key.CustomerId,
                      t.Key.CompanyName,
                      CaTotal = t.Sum(o => o.TotalLigne)
                  }).ToList().ForEach(c => Console.WriteLine($"{c.CustomerId} CA = {c.CaTotal}"));

            Console.ReadLine();
        }

        private static void Requete10D() //
        {
            // Pour utiliser une jointure gauche, il convient d'utiliser
            // un regroupement into avec la mention DefaultIfEmpty()
            var CA2 = dbcontexte.Customers.Where(c => c.Country == "France")
                .Include(o => o.Orders)
                .ThenInclude(od => od.OrderDetails)
                .Select(c => new { c.CustomerId, c.CompanyName, LignesCA = c.Orders.Select(o => o.OrderDetails.Select(od => new { CA = (double)od.UnitPrice * (1.0 - od.Discount) * od.Quantity })) });
            //CA2.GroupBy(co => new { co.CustomerId, co.CompanyName }).Select(t =>
            //      new
            //      {
            //          t.Key.CustomerId,
            //          t.Key.CompanyName,
            //          CaTotal = t. (o => o.LignesCA.Sum())
            //      }).ToList().ForEach(c => Console.WriteLine($"{c.CustomerId} CA = {c.CaTotal}"));

            //Console.ReadLine();
        }

        private static void Requete11() {
            var CA2 = from C in dbcontexte.Customers
                      join O in dbcontexte.Orders on C.CustomerId equals O.CustomerId
                      join OD in dbcontexte.OrderDetails on O.OrderId equals OD.OrderId
                      select new {
                          C.CompanyName,
                          C.CustomerId,
                          TotalLigne = (double)OD.UnitPrice * (1.0 - OD.Discount) * OD.Quantity
                      };

            var CA2B = CA2.GroupBy(co => new { co.CustomerId, co.CompanyName }).Select(t =>
                    new {
                        t.Key.CustomerId,
                        t.Key.CompanyName,
                        CaTotal = t.Sum(o => o.TotalLigne)
                    }).ToList();

            double Max = CA2B.Max(c => c.CaTotal);

            var MeilleursClients = CA2B.Where(c => Max == c.CaTotal).ToList();

            ObjectDumper.Write(MeilleursClients);
            Console.ReadLine();
        }

        private static void Requete12A() //  OK
        {
            var produitCherCat =
                from p in dbcontexte.Products
                group p by (p.CategoryId) into g
                select new {
                    IdCategorie = g.Key,
                    PrixMax = g.Max(p => p.UnitPrice)
                };
            ObjectDumper.Write(produitCherCat);
            Console.ReadLine();
        }

        private static void Requete12B() // Le prix le plus élevé par catégorie
        {
            var produitCherCat =
            from cat in dbcontexte.Categories
            select new {
                IdCategorie = cat.CategoryId,
                NomCategorie = cat.CategoryName,
                PrixMax = cat.Products.Max(p => p.UnitPrice)
            };
            ObjectDumper.Write(produitCherCat);
            Console.ReadLine();
        }

        private static void Requete12C() // Le prix le plus élevé par catégorie
        {
            var produitCherCat =
                dbcontexte.Categories.Select(cat => new {
                    IdCategorie = cat.CategoryId,
                    NomCategorie = cat.CategoryName,
                    PrixMax = cat.Products.Max(p => p.UnitPrice)
                });
            ObjectDumper.Write(produitCherCat);
            Console.ReadLine();
        }

        /// <summary>
        /// Les produits les plus chers de la catégorie
        /// </summary>
        private static void Requete12D() {
            Chrono.Restart();
            var produitCherCat =
                (from cat in dbcontexte.Categories
                 select new {
                     IdCategorie = cat.CategoryId,
                     NomCategorie = cat.CategoryName,
                     PrixMax = cat.Products.Max(p => p.UnitPrice)
                 } into CM
                 join p in dbcontexte.Products
                             on CM.IdCategorie equals p.CategoryId
                 where (CM.PrixMax == p.UnitPrice)
                 select new {
                     categorie = CM.IdCategorie,
                     categorieNom = CM.NomCategorie,
                     produitNom = p.ProductName,
                     prixMax = CM.PrixMax
                 }).OrderBy(cat => cat.categorie).ToList();
            Console.WriteLine($"Temps 12 D : {Chrono.ElapsedMilliseconds}");
            produitCherCat.ForEach(p =>
            Console.WriteLine($"Catégorie {p.categorieNom} Produit {p.produitNom} Prix {p.prixMax}"));
            Console.ReadLine();
        }

        /// <summary>
        /// Les produits les plus chers de la catégorie
        /// </summary>
        private static void Requete12E() {
            Chrono.Restart();
            var produitCherCat = dbcontexte.Categories
                .Select(cat => new {
                    IdCategorie = cat.CategoryId,
                    NomCategorie = cat.CategoryName,
                    PrixMax = cat.Products.Max(p => p.UnitPrice)
                }).Join(dbcontexte.Products, c => c.IdCategorie, p => p.CategoryId, (c, p)
                       => new {
                           categorie = c.IdCategorie,
                           categorieNom = c.NomCategorie,
                           produitNom = p.ProductName,
                           prixMax = c.PrixMax,
                           prix = p.UnitPrice
                       }).Where(p => p.prixMax == p.prix)
                       .OrderBy(cat => cat.categorie)
                       .ToList();

            Console.WriteLine($"Temps 12 E : {Chrono.ElapsedMilliseconds}");
            produitCherCat.ForEach(p =>
            Console.WriteLine($"Catégorie {p.categorieNom} Produit {p.produitNom} Prix {p.prixMax}"));
            Console.ReadLine();
        }

        /// <summary>
        /// Les produits les plus chers de la catégorie
        /// </summary>
        private static void Requete12F() {
            Chrono.Restart();
            var produitCherCat = dbcontexte.Products.
                Where(p => p.UnitPrice == p.Category.Products.Max(p2 => p2.UnitPrice))
                .Select(p => new {
                    IdCategorie = p.Category.CategoryId,
                    NomCategorie = p.Category.CategoryName,
                    NomProduit = p.ProductName,
                    PrixMax = p.UnitPrice
                }).OrderBy(r => r.IdCategorie)
                .ToList();

            Console.WriteLine($"Temps 12 F : {Chrono.ElapsedMilliseconds}");
            produitCherCat.ForEach(p =>
            Console.WriteLine($"Catégorie {p.NomCategorie} Produit {p.NomProduit} Prix {p.PrixMax}"));
            Console.ReadLine();
        }

        #endregion Calcul Agrégats complexes
    }
}