using System;
using System.Windows.Forms;

namespace WinForms_chaine {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(inputBox.Text) && pos.Value < inputBox.Text.Length) {
                if (char.IsLetter(inputBox.Text[Convert.ToInt32(pos.Value)])) {
                    resultBox.Text = "Lettre";
                } else if (char.IsDigit(inputBox.Text[Convert.ToInt32(pos.Value)])) {
                    resultBox.Text = "Chiffre";
                } else if (char.IsSymbol(inputBox.Text[Convert.ToInt32(pos.Value)])) {
                    resultBox.Text = "Symbole";
                } else if (char.IsPunctuation(inputBox.Text[Convert.ToInt32(pos.Value)])) {
                    resultBox.Text = "Ponctuation";
                } else if (char.IsWhiteSpace(inputBox.Text[Convert.ToInt32(pos.Value)])) {
                    resultBox.Text = "Espace";
                } else {
                    resultBox.Text = @"/!\ INVALIDE /!\";
                }
            } else {
                resultBox.Text = @"/!\ INVALIDE /!\";
            }
        }
    }
}