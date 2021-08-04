using LinqToEntityCore_1.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LinqToEntityCore_1
{
    
     public static class Exemple
    {
        static ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities();

       public static void ComptageClients()
        {
            int ca = 2500;
           
            var CA = dbContext.Orders.Where(o=>o.Customer.Country=="France").
                Select(o => new
            {
                o.OrderId,
                o.CustomerId,
                o.Customer.CompanyName,
                CA = o.OrderDetails.Sum(y => ((float)y.UnitPrice * (1.0f - y.Discount)) * y.Quantity)
            }).ToList();
            var CA2 = CA.GroupBy(co=>new { co.CustomerId, co.CompanyName }).Select(t=>
                new
                                     {
                                         t.Key.CustomerId,
                                         t.Key.CompanyName,
                                         CaTotal = t.Sum(o=>o.CA)
                                     }).Where(c=>c.CaTotal>ca).ToList();
            
            
        }
        public static void ListeClients()
        {
            List<Customers> clients = (from c in dbContext.Customers.Include(c=>c.Orders)
                                       where c.Orders.Select(o => o.OrderDate.Value.Year == 2010).Count() > 0
                                       select c).ToList();
            foreach (var item in clients)
            {
                Console.WriteLine(item.CompanyName);
            }
        }
        public static void PrixMax()
        {
            var produitsplusChers = (from c in dbContext.Categories
                                     join p in dbContext.Products 
                                     on c.CategoryId equals p.CategoryId
                                     group p by new
                                     { p.CategoryId, c.CategoryName } into cat

                                     select new
                                     {
                                        cat.Key.CategoryId,
                                        cat.Key.CategoryName,
                                        nombreProduits = cat.Count(),
                                        prixMax = cat.Max(p => p.UnitPrice)                                      
                                     });
            
            foreach (var item in produitsplusChers)
            {
                Console.WriteLine("Catégorie {0} {1} Prix Max : {2} nombre produits {3}",
                    item.CategoryId, item.CategoryName, item.prixMax, item.nombreProduits);
             
            }



        }
        public static void ProduitsParCategorie()
        {

            //var gCat_Prod = from c in dbContext.Categories
            //                join p in dbContext.Products on c.CategoryId equals p.CategoryId.Value
            //                into prodParCat
            //                select new { cat = c, produits = prodParCat }
            //                ;
            //var res = gCat_Prod.ToList();

            var gCat_ProdCore3 = (from p in dbContext.Products.Where(p=>p.CategoryId!=null)
                         group p by new { p.Category.CategoryId, p.Category.CategoryName } 
                         into prodParCat
                         select new 
                         {
                             CategoryId = prodParCat.Key.CategoryId,
                             CategoryName = prodParCat.Key.CategoryName,
                             NbProduits = prodParCat.Count(),
                             PrixMax = prodParCat.Max(p=>p.UnitPrice)
                         });

            foreach (var categorie in gCat_ProdCore3)
            {
                Console.WriteLine($"Catégorie {categorie.CategoryId} {categorie.CategoryName} " +
                    $"Nbre produits : {categorie.NbProduits} Prix Max : {categorie.PrixMax}");
                //foreach (var produit in categorie.Produits)
                //{
                //    Console.WriteLine("Produit {0} {1}", produit.ProductId, produit.ProductName);
                //}
            }

            Console.ReadLine();



        }
    }
}
