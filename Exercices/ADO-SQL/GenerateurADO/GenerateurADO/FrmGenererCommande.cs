using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenateurProcStoc;

namespace GenerateurADO
{
    public partial class FrmGenererCommande : Form
    {

        Table tableCourante = null;
        static FrmGenererCommande _frmGenererCommande = null;
        private FrmGenererCommande()
        {
            InitializeComponent();
            storedProcBindingSource.CurrentItemChanged += StoredProcBindingSource_CurrentItemChanged;
        }

        public static FrmGenererCommande CreateInstance()
        {
            if (_frmGenererCommande == null || _frmGenererCommande.IsDisposed)
            {
                _frmGenererCommande = new FrmGenererCommande();
            }
            if (_frmGenererCommande.WindowState==FormWindowState.Minimized)
            {
                _frmGenererCommande.WindowState = FormWindowState.Maximized;
            }
            _frmGenererCommande.Activate();
            return _frmGenererCommande;
        }

        private void StoredProcBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            txtCommand.Text = GenerateurProcStoc.GenererCommandeV2(storedProcBindingSource.Current as StoredProc);
        }

        private void BtnInitialiser_Click(object sender, EventArgs e)
        {
            GenerateurProcStoc.ServerName = txtServeur.Text;
            GenerateurProcStoc.Catalog = TxtCatalogue.Text;
            GenerateurProcStoc.PathModeles = Properties.Settings.Default.PathModeles;
            if (GenerateurProcStoc.Initialize())
            {
                bdsTables.DataSource = GenerateurProcStoc.Tables.OrderBy(t => t.Name);
            }
        }

        private void TableDataGridView_DoubleClick(object sender, EventArgs e)
        {
            tableCourante = bdsTables.Current as Table;
            if (tableCourante != null)
            {
                GenerateurProcStoc.InitializeProcStocDep(tableCourante);
                storedProcBindingSource.DataSource = GenerateurProcStoc.StoredProcs;
            }
        }

        private void BtnSaveParametres_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void BtnClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)txtCommand.Text);
        }

    
    }
}
