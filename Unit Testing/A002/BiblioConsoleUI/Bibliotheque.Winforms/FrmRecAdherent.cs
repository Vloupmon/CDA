
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bibliotheque.BLL;
using Bibliotheque.BOL;
using Bibliotheque.Repository;

namespace Bibliotheque.Winforms
{
    public partial class FrmRecAdherent : Form
    {
        BindingSource adherentBSG;
        public FrmRecAdherent()
        {
            InitializeComponent();
        }
        public FrmRecAdherent(string debNom, BindingSource adherentBS) : this()
        {
            adherentBSG = adherentBS;
            AdherentManager adhMan = new AdherentManager(Configuration._serviceProvider.GetService<IAdherentRepository>());
            HashSet<Adherent> adherents = adhMan.Lister().Where(a=>a.NomAdherent
            .StartsWith(debNom,StringComparison.CurrentCultureIgnoreCase)).ToHashSet();

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
                adherentBSG.Add(adherentBindingSource.Current);
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