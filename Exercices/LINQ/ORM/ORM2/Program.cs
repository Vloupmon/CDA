using System;
using System.Linq;
using System.Collections.Generic;
using ORM2.Models;

namespace ORM2 {

    internal class Program {

        private static void Main(string[] args) {
            AFPA2020Entities dbContext = new();

            Personne personne = dbContext.Personnes.Find(20);
            personne = dbContext.Personnes.First(x => x.NomPersonne == "MASSON");
            Console.WriteLine(personne.IdPersonne);
        }
    }
}