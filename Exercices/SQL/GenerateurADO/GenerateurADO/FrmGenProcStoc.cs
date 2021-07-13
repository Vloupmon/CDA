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
    public partial class FrmGenProcStoc : Form
    {
        Histo historique = new Histo();
        Table tableCourante = null;

        public FrmGenProcStoc()
        {
            InitializeComponent();
        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {

            GenerateurProcStoc.ServerName = txtServeur.Text;
            GenerateurProcStoc.Catalog = TxtCatalogue.Text;
            GenerateurProcStoc.PathModeles = Properties.Settings.Default.PathModeles;

                if (GenerateurProcStoc.Initialize())
            {
                bdsTables.DataSource = GenerateurProcStoc.Tables.OrderBy(t => t.Name);
            }
        }

        private void GenererScripts(Table table)
        {
            GenerateurProcStoc.InitializeTable(table);
            bdsKey.DataSource = table.Key;
            bdsColonnes.DataSource = table.Columns;
            tcProcedures.TabPages[3].Focus();
            rtxtInsertion.Text = GenerateurProcStoc.GenererInsertion(table, txtAuteur.Text, ckbSuppression.Checked, ckbSuppression.Checked);
            rtxtModification.Text = GenerateurProcStoc.GenererModification(table, txtAuteur.Text, ckbSuppression.Checked, ckbSuppression.Checked);
            rtxtSuppression.Text = GenerateurProcStoc.GenererSuppression(table, txtAuteur.Text, ckbSuppression.Checked, ckbSuppression.Checked);
        }


        private void tableDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            tableCourante = bdsTables.Current as Table;
            if (tableCourante != null)
            {
                GenererScripts(tableCourante);
            }

        }

        private void GenererScriptServeur(object sender, EventArgs e)
        {
            int pageSel = tcProcedures.SelectedIndex;

            switch (pageSel)
            {
                case 0:
                    GenerateurProcStoc.ExecuterScript(rtxtInsertion.Text, tableCourante, "Insertion", historique);
                    break;
                case 1:
                    GenerateurProcStoc.ExecuterScript(rtxtModification.Text, tableCourante, "Modification", historique);
                    break;
                case 2:
                    GenerateurProcStoc.ExecuterScript(rtxtSuppression.Text, tableCourante, "Suppression", historique);
                    break;
                default:
                    break;
            }
            AfficherHisto();
        }
        private void GenererScritsServeurTable(Table table)
        {
            GenerateurProcStoc.ExecuterScript(rtxtInsertion.Text, table, "Insertion", historique);
            AfficherHisto();
            GenerateurProcStoc.ExecuterScript(rtxtModification.Text, table, "Modification", historique);
            AfficherHisto();
            GenerateurProcStoc.ExecuterScript(rtxtSuppression.Text, table, "Suppression", historique);
            AfficherHisto();
        }



        private void btnGenererServeurScripts_Click(object sender, EventArgs e)
        {
            GenererScritsServeurTable(tableCourante);
        }

        private void btnGenererAllProcStock_Click(object sender, EventArgs e)
        {
            foreach (Table table in GenerateurProcStoc.Tables.OrderBy(t=>t.Name))
            {
                GenerateurProcStoc.InitializeTable(table);
                GenerateurProcStoc.ExecuterScript(GenerateurProcStoc.GenererInsertion(table, txtAuteur.Text, ckbSuppression.Checked,ckConcurrence.Checked),
                    table, "Insertion", historique);
                AfficherHisto();
                GenerateurProcStoc.ExecuterScript(GenerateurProcStoc.GenererModification(table, txtAuteur.Text, ckbSuppression.Checked, ckConcurrence.Checked),
                    table, "Modification", historique);
                AfficherHisto();
                GenerateurProcStoc.ExecuterScript(GenerateurProcStoc.GenererSuppression(table, txtAuteur.Text, ckbSuppression.Checked, ckConcurrence.Checked),
                    table, "Suppression", historique);
                AfficherHisto();
            }


        }
        private void AfficherHisto()
        {
            Histo.Entree entree = historique.Entrees.Last();
            ListViewItem item = new ListViewItem(entree.TableName);
            item.SubItems.Add(entree.Operation);
            item.SubItems.Add(entree.Resultat == true ? "OK" : "Erreur");
            item.SubItems.Add(entree.Resultat == true ? "Succès" : entree.ErreurText);
            lvHisto.Items.Add(item);
            lvHisto.EnsureVisible(lvHisto.Items.Count - 1); // afficher le dernier
        }

        private void btnEffacerHistorique_Click(object sender, EventArgs e)
        {
            lvHisto.Items.Clear();
        }
    }
}
