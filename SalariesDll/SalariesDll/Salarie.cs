namespace SalariesDll {

    using System;
    using System.Text.RegularExpressions;

    public class Commercial : Salarie {
        private int _chiffreAffaire;
        private int _commission;

        public Commercial()
            : base() {
        }

        public Commercial(Commercial com) : base(com.DateNaissance, com.Matricule, com.Nom,
            com.Prenom, com.SalaireBrut, com.TauxCs) {
            _chiffreAffaire = com.ChiffreAffaire;
            _commission = com.Commission;
        }

        public int ChiffreAffaire {
            get => _chiffreAffaire;
            set => _chiffreAffaire = value;
        }

        public int Commission {
            get => _commission;
            set => _commission = value;
        }
    }

    public class Salarie {
        private static int _compteur = 0;
        private DateTime _dateNaissance;
        private string _matricule;
        private string _nom;
        private string _prenom;
        private int _salaireBrut;
        private float _tauxCs;

        public Salarie() {
            _compteur++;
        }

        public Salarie(string nom, string prenom)
            : this() {
            Nom = nom;
            Prenom = prenom;
        }

        public Salarie(DateTime date, string matricule, string nom, string prenom, int salaire, float taux)
            : this(nom, prenom) {
            Matricule = matricule;
            SalaireBrut = salaire;
            TauxCs = taux;
            DateNaissance = date;
        }

        public Salarie(Salarie salarie)
            : this(salarie.Matricule, salarie.Nom, salarie.Prenom,
                  salarie.SalaireBrut, salarie.TauxCs, salarie.DateNaissance) {
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
                    throw new Exception(string.Format("La date de naissance {0} n'est pas valide.", value));
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
                    throw new Exception(string.Format("Le matricule {0} n'est pas valide.", value));
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
                    throw new Exception(string.Format("Le nom {0} n'est pas valide.", value));
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
                    throw new Exception(string.Format("Le prenom {0} n'est pas valide.", value));
                }
            }
        }

        public int SalaireBrut {
            get => _salaireBrut;
            set => _salaireBrut = value;
        }

        public int SalaireNet {
            get => (int)(_salaireBrut - _salaireBrut * _tauxCs);
            set {
            }
        }

        public float TauxCs {
            get => _tauxCs;
            set {
                if (value >= 0 && value <= 0.6) {
                    _tauxCs = value;
                }
                else {
                    throw new Exception(string.Format("Le taux de cotisations sociales {0} n'est pas valide.", value.ToString()));
                }
            }
        }

        public override bool Equals(object obj) {
            return (obj is Salarie salarieObj &&
                   _matricule == salarieObj._matricule &&
                   _nom == salarieObj._nom &&
                   _prenom == salarieObj._prenom &&
                   _salaireBrut == salarieObj._salaireBrut &&
                   _tauxCs == salarieObj._tauxCs &&
                   _dateNaissance == salarieObj._dateNaissance);
        }

        public override int GetHashCode() {
            HashCode hash = new HashCode();
            hash.Add(_matricule);
            hash.Add(_nom);
            hash.Add(_prenom);
            hash.Add(_salaireBrut);
            hash.Add(_tauxCs);
            return (hash.ToHashCode());
        }

        public override string ToString() {
            return String.Join(";", _matricule, _nom, _prenom,
                _salaireBrut.ToString(), SalaireNet.ToString(),
                _tauxCs.ToString(), _dateNaissance.ToString());
        }

        private bool InRange(DateTime time) {
            DateTime min = new DateTime(1900, 1, 1);
            DateTime max = DateTime.Now.AddYears(-15);

            return (time >= min & time <= max);
        }
    }
}