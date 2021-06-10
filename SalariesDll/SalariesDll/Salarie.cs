namespace SalariesDll {

    using System;
    using System.Text.RegularExpressions;

    [Serializable()]
    public class Salarie : Human {
        private string _matricule;
        private uint _salaireBrut;
        private float _tauxCs;

        public delegate void ChangeSalaryEvenHandler(object sender, SalaryEventArgs e);

        public event ChangeSalaryEvenHandler ChangeSalary;

        public Salarie()
            : base() {
        }

        public Salarie(string nom, string prenom)
            : base(nom, prenom) {
        }

        public Salarie(DateTime date, string matricule, string nom, string prenom, uint salaire, float taux)
            : base(date, nom, prenom) {
            Matricule = matricule;
            SalaireBrut = salaire;
            TauxCs = taux;
        }

        public Salarie(Salarie salarie)
            : this(salarie.DateNaissance, salarie.Matricule, salarie.Nom, salarie.Prenom,
                  salarie.SalaireBrut, salarie.TauxCs) {
        }

        public string Matricule {
            get => _matricule;
            set {
                if (Regex.IsMatch(value, @"[0-9]{2}[a-zA-Z]{3}[0-9]{2}")) {
                    _matricule = value;
                } else {
                    throw new FormatException(string.Format("Le matricule {0} n'est pas valide.", value));
                }
            }
        }

        public uint SalaireBrut {
            get => _salaireBrut;
            set {
                if (_salaireBrut != 0 && _salaireBrut != value) {
                    SalaryEventArgs args = new();
                    args.FormerSalary = _salaireBrut;
                    args.CurrentSalary = value;
                    OnSalaryChange(args);
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
                } else {
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

        protected virtual void OnSalaryChange(SalaryEventArgs e) {
            ChangeSalary?.Invoke(this, e);
        }
    }
}