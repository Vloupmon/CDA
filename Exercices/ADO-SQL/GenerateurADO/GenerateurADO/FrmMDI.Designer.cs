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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateurProceduresToolStripMenuItem,
            this.generateurCommandesSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generateurProceduresToolStripMenuItem
            // 
            this.generateurProceduresToolStripMenuItem.Name = "generateurProceduresToolStripMenuItem";
            this.generateurProceduresToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.generateurProceduresToolStripMenuItem.Text = "Generateur Procedures";
            this.generateurProceduresToolStripMenuItem.Click += new System.EventHandler(this.GenerateurProceduresToolStripMenuItem_Click);
            // 
            // generateurCommandesSQLToolStripMenuItem
            // 
            this.generateurCommandesSQLToolStripMenuItem.Name = "generateurCommandesSQLToolStripMenuItem";
            this.generateurCommandesSQLToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.generateurCommandesSQLToolStripMenuItem.Text = "Generateur Commandes SQL";
            this.generateurCommandesSQLToolStripMenuItem.Click += new System.EventHandler(this.GenerateurCommandesSQLToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 615);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

