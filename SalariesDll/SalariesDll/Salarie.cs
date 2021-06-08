namespace SalariesDll {

    using System;
    using System.Text.RegularExpressions;

    [Serializable()]
    public class Salarie {

        public delegate void ChangeSalaryEvenHandler(object sender, EventArgs e);

        private static int _compteur = 0;
        private DateTime _dateNaissance;
        private string _matricule;
        private string _nom;
        private string _prenom;
        private uint _salaireBrut;
        private float _tauxCs;

        public event ChangeSalaryEvenHandler ChangeSalary;

        public Salarie() {
            _compteur++;
        }

        public Salarie(string nom, string prenom)
            : this() {
            Nom = nom;
            Prenom = prenom;
        }

        public Salarie(DateTime date, string matricule, string nom, string prenom, uint salaire, float taux)
            : this(nom, prenom) {
            DateNaissance = date;
            Matricule = matricule;
            SalaireBrut = salaire;
            TauxCs = taux;
        }

        public Salarie(Salarie salarie)
            : this(salarie.DateNaissance, salarie.Matricule, salarie.Nom, salarie.Prenom,
                  salarie.SalaireBrut, salarie.TauxCs) {
        }

        ~Salarie() {
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
                }
                else {
                    throw new FormatException(string.Format("La date de naissance {0} n'est pas valide.", value));
                }
            }
        }

        public string Matricule {
            get => _matricule;
            set {
                if (Regex.IsMatch(value, @"[0-9]{2}[a-zA-Z]{3}[0-9]{2}")) {
                    _matricule = value;
                }
                else {
                    throw new FormatException(string.Format("Le matricule {0} n'est pas valide.", value));
                }
            }
        }

        public string Nom {
            get => _nom;
            set {
                if (Regex.IsMatch(value, @"^[a-zA-Z]{3,30}")) {
                    _nom = value;
                }
                else {
                    throw new FormatException(string.Format("Le nom {0} n'est pas valide.", value));
                }
            }
        }

        public string Prenom {
            get => _prenom;
            set {
                if (Regex.IsMatch(value, @"^[a-zA-Z]{3,30}")) {
                    _prenom = value;
                }
                else {
                    throw new FormatException(string.Format("Le prenom {0} n'est pas valide.", value));
                }
            }
        }

        public uint SalaireBrut {
            get => _salaireBrut;
            set {
                if (_salaireBrut != 0 && _salaireBrut != value) {
                    OnSalaryChange(new EventArgs());
                }
                _salaireBrut = value;
            }
        }

        public int CalculerSalaireNet() {
            return (int)(SalaireBrut - (SalaireBrut * TauxCs));
        }

        public float TauxCs {
            get => _tauxCs;
            set {
                if (value >= 0 && value <= 0.6) {
                    _tauxCs = value;
                }
                else {
                    throw new FormatException(string.Format("Le taux de cotisations sociales {0} n'est pas valide.", value.ToString()));
                }
            }
        }

        public override bool Equals(object obj) {
            return (obj is Salarie salarieObj &&
                   Matricule == salarieObj.Matricule &&
                   Nom == salarieObj.Nom &&
                   Prenom == salarieObj.Prenom &&
                   SalaireBrut == salarieObj.SalaireBrut &&
                   TauxCs == salarieObj.TauxCs &&
                   DateNaissance == salarieObj.DateNaissance);
        }

        public override int GetHashCode() {
            HashCode hash = new();
            hash.Add(DateNaissance);
            hash.Add(Matricule);
            hash.Add(Nom);
            hash.Add(Prenom);
            hash.Add(SalaireBrut);
            hash.Add(TauxCs);
            return (hash.ToHashCode());
        }

        public override string ToString() {
            return String.Join(";", DateNaissance.ToString(), Matricule, Nom, Prenom,
                SalaireBrut.ToString(), CalculerSalaireNet().ToString(),
                TauxCs.ToString());
        }

        private static bool InRange(DateTime time) {
            DateTime min = new(1900, 1, 1);
            DateTime max = DateTime.Now.AddYears(-15);

            return (time >= min & time <= max);
        }

        public virtual void OnSalaryChange(EventArgs e) {
            ChangeSalary?.Invoke(this, e);
        }
    }
}