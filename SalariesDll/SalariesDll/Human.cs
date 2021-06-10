namespace SalariesDll {

    using System;
    using System.Text.RegularExpressions;

    [Serializable()]
    public class Human {
        private static int _compteur = 0;
        private DateTime _dateNaissance;
        private string _nom;
        private string _prenom;

        public Human() {
            _compteur++;
        }

        public Human(string nom, string prenom)
            : this() {
            Nom = nom;
            Prenom = prenom;
        }

        public Human(DateTime date, string nom, string prenom) : this(nom, prenom) {
            DateNaissance = date;
        }

        public Human(Salarie salarie)
            : this(salarie.DateNaissance, salarie.Nom, salarie.Prenom) {
        }

        ~Human() {
            _compteur--;
        }

        public static int Compteur {
            get => _compteur;
        }

        public DateTime DateNaissance {
            get => _dateNaissance;
            set {
                if (InRange(value)) {
                    _dateNaissance = value;
                } else {
                    throw new FormatException(string.Format("La date de naissance {0} n'est pas valide.", value));
                }
            }
        }

        public string Nom {
            get => _nom;
            set {
                if (Regex.IsMatch(value, @"^[a-zA-Z]{3,30}")) {
                    _nom = value;
                } else {
                    throw new FormatException(string.Format("Le nom {0} n'est pas valide.", value));
                }
            }
        }

        public string Prenom {
            get => _prenom;
            set {
                if (Regex.IsMatch(value, @"^[a-zA-Z]{3,30}")) {
                    _prenom = value;
                } else {
                    throw new FormatException(string.Format("Le prenom {0} n'est pas valide.", value));
                }
            }
        }

        public override bool Equals(object obj) {
            return (obj is Salarie salarieObj &&
                DateNaissance == salarieObj.DateNaissance) &&
                Nom == salarieObj.Nom &&
                Prenom == salarieObj.Prenom;
        }

        public override int GetHashCode() {
            HashCode hash = new();
            hash.Add(DateNaissance);
            hash.Add(Nom);
            hash.Add(Prenom);
            return (hash.ToHashCode());
        }

        public override string ToString() {
            return String.Join(";", DateNaissance.ToString(), Nom, Prenom);
        }

        private static bool InRange(DateTime time) {
            DateTime min = new(1900, 1, 1);
            DateTime max = DateTime.Now.AddYears(-15);

            return (time >= min & time <= max);
        }
    }
}