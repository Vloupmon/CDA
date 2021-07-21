namespace A003
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuSMain = new System.Windows.Forms.MenuStrip();
            this.adoConnecteADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMereFilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSMain
            // 
            this.mnuSMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adoConnecteADOToolStripMenuItem});
            this.mnuSMain.Location = new System.Drawing.Point(0, 0);
            this.mnuSMain.Name = "mnuSMain";
            this.mnuSMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuSMain.Size = new System.Drawing.Size(829, 28);
            this.mnuSMain.TabIndex = 1;
            this.mnuSMain.Text = "menuStrip1";
            // 
            // adoConnecteADOToolStripMenuItem
            // 
            this.adoConnecteADOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMereToolStripMenuItem,
            this.ajouterMereFilleToolStripMenuItem,
            this.ajouterTransactionToolStripMenuItem});
            this.adoConnecteADOToolStripMenuItem.Name = "adoConnecteADOToolStripMenuItem";
            this.adoConnecteADOToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.adoConnecteADOToolStripMenuItem.Text = "Ado Connecte ADO";
            // 
            // ajouterMereToolStripMenuItem
            // 
            this.ajouterMereToolStripMenuItem.Name = "ajouterMereToolStripMenuItem";
            this.ajouterMereToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.ajouterMereToolStripMenuItem.Text = "Ajouter Mere";
            this.ajouterMereToolStripMenuItem.Click += new System.EventHandler(this.ajouterMereToolStripMenuItem_Click);
            // 
            // ajouterMereFilleToolStripMenuItem
            // 
            this.ajouterMereFilleToolStripMenuItem.Name = "ajouterMereFilleToolStripMenuItem";
            this.ajouterMereFilleToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.ajouterMereFilleToolStripMenuItem.Text = "Ajouter Mere-Fille";
            this.ajouterMereFilleToolStripMenuItem.Click += new System.EventHandler(this.ajouterMereFilleToolStripMenuItem_Click);
            // 
            // ajouterTransactionToolStripMenuItem
            // 
            this.ajouterTransactionToolStripMenuItem.Name = "ajouterTransactionToolStripMenuItem";
            this.ajouterTransactionToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.ajouterTransactionToolStripMenuItem.Text = "Ajouter Transaction";
            this.ajouterTransactionToolStripMenuItem.Click += new System.EventHandler(this.ajouterTransactionToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 610);
            this.Controls.Add(this.mnuSMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuSMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADO Mode connecté";
            this.mnuSMain.ResumeLayout(false);
            this.mnuSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSMain;
        private System.Windows.Forms.ToolStripMenuItem adoConnecteADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMereFilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterTransactionToolStripMenuItem;
    }
}

