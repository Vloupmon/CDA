using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuWinForms
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
            chargerProprietes();
            associerGestionnairesEvenements();

        }
        /// <summary>
        /// Sur changement de valeurs 
        /// Modifications des paramètres de l'application de niveau utilisateur
        /// </summary>
        private void associerGestionnairesEvenements()
        {
            nUDErreurs.ValueChanged += nUDErreurs_ValueChanged;
            nUDManches.ValueChanged += nUDManches_ValueChanged;
            nUDPointsErreur.ValueChanged += nUDPointsErreur_ValueChanged;
            nUDPointsParSeconde.ValueChanged += nUDPointsParSeconde_ValueChanged;
            cbCultures.SelectedValueChanged += cbCultures_SelectedValueChanged;
        }

        void cbCultures_SelectedValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CultureCourante = cbCultures.SelectedValue.ToString();
        }

        void nUDPointsParSeconde_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NombrePointsParSeconde = Convert.ToInt32(nUDPointsParSeconde.Value);
        }

        void nUDPointsErreur_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NombrePointsErreur = Convert.ToInt32(nUDPointsErreur.Value);
        }

        void nUDManches_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NombreManches = Convert.ToInt32(nUDManches.Value);
        }

        void nUDErreurs_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NombreErreurs = Convert.ToInt32(nUDErreurs.Value);
        }
        /// <summary>
        /// Chargement des paramètres de l' application
        /// à partir du fichier de configuration de l'application
        /// </summary>
        private void chargerProprietes()
        {
            nUDErreurs.Maximum = Properties.Settings.Default.NombreErreursMaxi;
            nUDErreurs.Minimum = Properties.Settings.Default.NombreErreursMini;
            nUDErreurs.Value = Properties.Settings.Default.NombreErreurs;
            nUDManches.Minimum = Properties.Settings.Default.NombreManchesMini;
            nUDManches.Maximum = Properties.Settings.Default.NombreManchesMaxi;
            nUDManches.Value = Properties.Settings.Default.NombreManches;
            nUDPointsErreur.Minimum = Properties.Settings.Default.NombrePointsErreurMini;
            nUDPointsErreur.Maximum = Properties.Settings.Default.NombrePointsErreurMaxi;
            nUDPointsErreur.Value = Properties.Settings.Default.NombrePointsErreur;
            nUDPointsParSeconde.Minimum = Properties.Settings.Default.NombrePointsSecondeMini;
            nUDPointsParSeconde.Maximum = Properties.Settings.Default.NombrePointsSecondeMaxi;
            nUDPointsParSeconde.Value = Properties.Settings.Default.NombrePointsParSeconde;
            cbCultures.DataSource = Properties.Settings.Default.Cultures;
            cbCultures.SelectedItem = Properties.Settings.Default.CultureCourante;
        }

        private void FrmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}