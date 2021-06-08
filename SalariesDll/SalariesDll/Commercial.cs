using System;

namespace SalariesDll {

    [Serializable()]
    public class Commercial : Salarie {
        private int _chiffreAffaire;
        private int _commission;

        public Commercial()
            : base() {
        }

        public Commercial(string nom, string prenom) : base(nom, prenom) {
        }

        public Commercial(Salarie sal) : base(sal) {
        }

        public Commercial(Salarie sal, int chiffreaffaire, int commission) : this(sal) {
            _chiffreAffaire = chiffreaffaire;
            _commission = commission;
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

        public new int CalculerSalaireNet() {
            return (int)(SalaireBrut - (SalaireBrut * TauxCs)
                + ((float)Commission / 100) * ChiffreAffaire);
        }

        public override string ToString() {
            return String.Join(";", DateNaissance.ToString(), Matricule, Nom, Prenom,
                SalaireBrut.ToString(), CalculerSalaireNet().ToString(),
                TauxCs.ToString(), ChiffreAffaire.ToString(), Commission.ToString());
        }
    }
}