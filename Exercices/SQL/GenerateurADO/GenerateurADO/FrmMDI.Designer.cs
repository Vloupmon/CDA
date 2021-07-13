namespace GenerateurADO
{
    partial class FrmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generateurProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateurCommandesSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateurProceduresToolStripMenuItem,
            this.generateurCommandesSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generateurProceduresToolStripMenuItem
            // 
            this.generateurProceduresToolStripMenuItem.Name = "generateurProceduresToolStripMenuItem";
            this.generateurProceduresToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.generateurProceduresToolStripMenuItem.Text = "Generateur Procedures";
            this.generateurProceduresToolStripMenuItem.Click += new System.EventHandler(this.generateurProceduresToolStripMenuItem_Click);
            // 
            // generateurCommandesSQLToolStripMenuItem
            // 
            this.generateurCommandesSQLToolStripMenuItem.Name = "generateurCommandesSQLToolStripMenuItem";
            this.generateurCommandesSQLToolStripMenuItem.Size = new System.Drawing.Size(172, 20);
            this.generateurCommandesSQLToolStripMenuItem.Text = "Generateur Commandes SQL";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDI";
            this.Text = "Generateur ADO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generateurProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateurCommandesSQLToolStripMenuItem;
    }
}

