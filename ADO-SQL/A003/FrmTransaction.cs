using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Transactions;

namespace A003
{
    public partial class FrmTransaction : Form
    {
        public FrmTransaction()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Gestion des ajouts avec transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (rdbLocale.Checked) GererTransactionLocale();  
            else GererTransactionScope();
            
        }

        private void GererTransactionScope()
        {
            // Transaction Scope 
            // Toute connexion ouverte dans la portée représentée par le bloc using 
            // et concerant une ressource de type TransactionScope
            // est automatiquement ajoutée à la transaction en cours.
            // Toutes les instructions exécutées avec les connexions ouvertes dans cette portée 
            // seront pilotées par cette transaction (dans cette portée bien entendu).
           
        }

        private void GererTransactionLocale()
        {
            // Transaction locale 
            // Pour des transactions simples portant sur une seule connexion
            // Choix de la connexion et des commandes gérées au sein de cette transaction 
            // Toutes les instructions exécutées avec les connexions ouvertes dans cette portée 
            // seront pilotées par cette transaction (dans cette portée bien entendu).
        }       

    }
}


