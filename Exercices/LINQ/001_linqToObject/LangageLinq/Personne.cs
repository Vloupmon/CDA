using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LangageLinq
{
    public enum Sexe : int
    {
        Masculin = 0,
        Féminin = 1
    } 
	 
    public partial class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Civilite { get; set; }
        public Sexe Genre { get; set; }
        public string AdresseMail { get; set; }
        public DateTime? DateNaissance { get; set; }

        public double Age { get => (DateNaissance.HasValue) ? (DateTime.Now - DateNaissance.Value).Days / 365.0 : 0; }

    }
}
