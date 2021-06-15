using Bibliotheque.BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheque.UI.Winforms
{
    public partial class FrmRecAdherent : Form
    {
        private string _adherentID;
        HashSet<Adherent> Adherents;
        public string AdherentID { get => _adherentID; set => _adherentID = value; }

        public FrmRecAdherent()
        {
            Adherents = Global.Sauvegarde.Load<Adherent>(Global.Repertoire).ToHashSet<Adherent>();
            InitializeComponent();
        }
        public FrmRecAdherent(string debNom) : this()
        {
            HashSet<Adherent> adherents = Adherents.Where(a=>a.Nom.StartsWith(debNom,StringComparison.CurrentCultureIgnoreCase)).ToHashSet();
            if (adherents.Count > 0)
            {
                adherentBindingSource.DataSource = adherents;
            }

        }

        private void adherentDataGridView_DoubleClick(object sender, EventArgs e)
        {
            SelectionnerAdherent();
        }

        private void SelectionnerAdherent()
        {
            if (adherentBindingSource.Current != null)
            {
                _adherentID = (adherentBindingSource.Current as Adherent).AdherentID;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectionnerAdherent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}