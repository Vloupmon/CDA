using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHashSet
{
    public partial class FrmTestHashSet : Form
    {
        HashSet<int> liste1;
        HashSet<int> liste2;
        HashSet<int> listeBackup;
        public FrmTestHashSet()
        {
            InitializeComponent();
            Initialiser();
            gbMethodes.Select();
        }

        private void Initialiser()
        {
            liste1 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
            liste2 = new HashSet<int> { 4, 5, 6, 7, 8, 9,10 };
            listeBackup = new HashSet<int>();
            AfficherListe(txtListe1, liste1);
            AfficherListe(txtListe2, liste2);
                        
            for (int i = 0; i < liste1.Count; i++)
            {
                listeBackup.Add(liste1.ElementAt(i));
            }
        }

        private void AfficherListe(Control controle, HashSet<int> liste)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < liste.Count; i++)
            {
                sb.Append($"{liste.ElementAt(i)} ");
            }
            controle.Text = sb.ToString();
        }

        private void rd_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            if (rd.Checked)
            {
                switch(rd.Name)
                    {
                    case "rdUnionWith":
                        RestoreListe(liste1);
                        liste1.UnionWith(liste2);
                        txtDescMethode.Text = "Union \r\nListe représente l'union des deux listes sans doublon";
                        AfficherListe(txtListeResultat, liste1);
                        break;
                    case "rdIntersectWith":
                        RestoreListe(liste1);
                        liste1.IntersectWith(liste2);
                        txtDescMethode.Text = "Intersection \r\nListe représente l'intersection des deux listes ";
                        AfficherListe(txtListeResultat, liste1);
                        break;
                    case "rdExceptWith":
                        RestoreListe(liste1);
                        liste1.ExceptWith(liste2);
                        txtDescMethode.Text = "Différence \r\nListe représente la différence entre  les deux listes \r\n";
                        txtDescMethode.Text += "La liste cible comporte uniquement ses éléments absents de l'autre liste";
                        AfficherListe(txtListeResultat, liste1);
                        break;
                    case "rdSymmetricExceptWith":
                        RestoreListe(liste1);
                        liste1.SymmetricExceptWith(liste2);
                        txtDescMethode.Text = "Différence symétrique \r\nListe sans les éléments présents dans les deux listes";
                        AfficherListe(txtListeResultat, liste1);
                        break;

                }
            }
        }

        private void RestoreListe(HashSet<int> liste)
        {
            liste.Clear();
            for (int i = 0; i < listeBackup.Count; i++)
            {
                liste.Add(listeBackup.ElementAt(i));
            }
        }
    }
}
