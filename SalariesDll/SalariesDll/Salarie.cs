using System;

namespace SalariesDll
{
    using System;
    using System.Text.RegularExpressions;

    public class Salarie
    {
        private string _matricule;
        private string _nom;
        private string _prenom;
        private int _salaireBrut;
        private float _tauxCs;
        private DateTime _dateNaissance;
        private static int _compteur = 0;

        public Salarie()
        {
            _compteur++;
        }
        ~Salarie()
        {
            _compteur--;
        }
        public Salarie(string nom, string prenom)
            : this()
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }
        public Salarie(string matricule, string nom, string prenom, int salaire, float taux, DateTime date)
            : this(nom, prenom)
        {
            this.Matricule = matricule;
            this.SalaireBrut = salaire;
            this.TauxCs = taux;
            this.DateNaissance = date;
        }
        public Salarie(Salarie salarie)
            : this(salarie.Matricule, salarie.Nom, salarie.Prenom, salarie.SalaireBrut, salarie.TauxCs, salarie.DateNaissance)
        {
        }
        public int SalaireNet()
        {
                return (int)(SalaireBrut - SalaireBrut * TauxCs);
        }
        private bool InRange(DateTime time)
        {
            DateTime min = new DateTime(1900, 1, 1);
            DateTime max = DateTime.Now.AddYears(-15);

            return (time >= min & time <= max);
        }

        public string Matricule
        {
            get => _matricule;
            set
            {
                if (Regex.IsMatch(value, @"[0-9]{2}[a-zA-Z]{3}[0-9]{2}"))
                {
                    _matricule = value;
                }
                else
                {
                    throw new Exception(string.Format("Le matricule {0} n'est pas valide.", value));
                }
            }
        }
        public string Nom
        {
            get => _nom;
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]{3,30}"))
                {
                    this._nom = value;
                }
                else
                {
                    throw new Exception(string.Format("Le nom {0} n'est pas valide.", value));
                }
            }
        }
        public string Prenom
        {
            get => _prenom;
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]{3,30}"))
                {
                    this._prenom = value;
                }
                else
                {
                    throw new Exception(string.Format("Le prenom {0} n'est pas valide.", value));
                }
            }
        }
        public int SalaireBrut
        {
            get => _salaireBrut;
            set => _salaireBrut = value;
        }
        public float TauxCs
        {
            get => _tauxCs;
            set
            {
                if (value >= 0 && value <= 0.6)
                {
                    _tauxCs = value;
                }
                else
                {
                    throw new Exception(string.Format("Le taux de cotisations sociales {0} n'est pas valide.", value.ToString()));
                } 
            }
        }
        public DateTime DateNaissance
        {
            get => _dateNaissance;
            set
            {
                if (InRange(value))
                {
                    _dateNaissance = value;
                }
                else
                {
                    throw new Exception(string.Format("La date de naissance {0} n'est pas valide.", value));
                }
            }
        }

        public static int Compteur
        {
            get => _compteur;
        }
    }
}
