using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A001
{
    public partial class FrmCommande : Form
    {
        SqlConnection sqlConnection = null;
        public FrmCommande()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Requête exécutée avec la méthode ExecuteNonQuery 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNonQuery_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Requête simple exécutée avec la méthode ExecuteScalar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSansParametre_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Requête libre exécutée avec la méthode ExecuteScalar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecuterTexte_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Requête avec paramètre exécutée avec la méthode ExecuteScalar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAvecParametre_Click(object sender, EventArgs e)
        {

        }

      
       
    }
}
