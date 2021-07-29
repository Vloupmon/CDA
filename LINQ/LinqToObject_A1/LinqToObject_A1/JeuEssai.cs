using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToObject_A1
{
    public static class JeuEssai
    {
        public static int[] CreeListeEntiers() => new int[] { 0, 9, 8, 1, 2, 3, 4, 6, 5, 7, 115, -1, 7, 265 };

        public static List<Stagiaire> CreeListeStagiaire() =>

             new List<Stagiaire>
            {
                new Stagiaire { Matricule = "14087532", Nom = "Mirebeau", Prenom = "Jean-Hugues", DateNaissance = new DateTime(1981, 12, 27) },
                new Stagiaire { Matricule = "15023439", Nom = "Conti", Prenom = "Stéphane", DateNaissance = new DateTime(1981, 5, 3) },
                new Stagiaire { Matricule = "14157659", Nom = "Barbier", Prenom = "Alan", DateNaissance = new DateTime(1985, 10, 26) },
                new Stagiaire { Matricule = "15012748", Nom = "Bazin", Prenom = "Jean-Hugo", DateNaissance = new DateTime(1981, 11, 6) },
                new Stagiaire { Matricule = "15061484", Nom = "Bigaul", Prenom = "Julien", DateNaissance = new DateTime(1978, 10, 15) },
                new Stagiaire { Matricule = "15006348", Nom = "Durand", Prenom = "Guillaume", DateNaissance = new DateTime(1990, 09, 17) },
                new Stagiaire { Matricule = "13097233", Nom = "Fleury", Prenom = "Cédric", DateNaissance = new DateTime(1991, 11, 5) },
                new Stagiaire { Matricule = "14146166", Nom = "Amirouche", Prenom = "Mohamed", DateNaissance = new DateTime(1981, 12, 24) },
                new Stagiaire { Matricule = "14159484", Nom = "Pare", Prenom = "Pahpa Eric", DateNaissance = new DateTime(1969, 05, 14) },
                new Stagiaire { Matricule = "14075415", Nom = "Vabre", Prenom = "Amandine", DateNaissance = new DateTime(1985, 5, 8) },
                new Stagiaire { Matricule = "14108864", Nom = "Germanique", Prenom = "Antoine", DateNaissance = new DateTime(1987, 12, 15) }
            };


       

    }
    public class Stagiaire
    {
        public string Matricule { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime? DateNaissance { get; set; }
        public double Age { get => (DateNaissance.HasValue) ? (DateTime.Now - DateNaissance.Value).Days / 365.0 : 0; }
    }
}
