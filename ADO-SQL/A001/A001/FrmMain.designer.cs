namespace A001
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
            this.adoConnecteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectureDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSMain
            // 
            this.mnuSMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adoConnecteToolStripMenuItem});
            this.mnuSMain.Location = new System.Drawing.Point(0, 0);
            this.mnuSMain.Name = "mnuSMain";
            this.mnuSMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuSMain.Size = new System.Drawing.Size(829, 28);
            this.mnuSMain.TabIndex = 1;
            this.mnuSMain.Text = "menuStrip1";
            // 
            // adoConnecteToolStripMenuItem
            // 
            this.adoConnecteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.lectureDonnéesToolStripMenuItem});
            this.adoConnecteToolStripMenuItem.Name = "adoConnecteToolStripMenuItem";
            this.adoConnecteToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.adoConnecteToolStripMenuItem.Text = "Ado Connecte Comptoir";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.commandeToolStripMenuItem.Text = "Commande";
            this.commandeToolStripMenuItem.Click += new System.EventHandler(this.commandeToolStripMenuItem_Click);
            // 
            // lectureDonnéesToolStripMenuItem
            // 
            this.lectureDonnéesToolStripMenuItem.Name = "lectureDonnéesToolStripMenuItem";
            this.lectureDonnéesToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.lectureDonnéesToolStripMenuItem.Text = "LectureDonnées";
            this.lectureDonnéesToolStripMenuItem.Click += new System.EventHandler(this.lectureDonnéesToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem adoConnecteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectureDonnéesToolStripMenuItem;
    }
}

