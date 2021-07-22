namespace Bibliotheque.WinUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.choixDuSGBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choixDuSGBDToolStripMenuItem,
            this.adhérentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // choixDuSGBDToolStripMenuItem
            // 
            this.choixDuSGBDToolStripMenuItem.Name = "choixDuSGBDToolStripMenuItem";
            this.choixDuSGBDToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.choixDuSGBDToolStripMenuItem.Text = "Choix du SGBD";
            this.choixDuSGBDToolStripMenuItem.Click += new System.EventHandler(this.choixDuSGBDToolStripMenuItem_Click);
            // 
            // adhérentsToolStripMenuItem
            // 
            this.adhérentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem});
            this.adhérentsToolStripMenuItem.Name = "adhérentsToolStripMenuItem";
            this.adhérentsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.adhérentsToolStripMenuItem.Text = "Adhérents";
            this.adhérentsToolStripMenuItem.Click += new System.EventHandler(this.adhérentsToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Gestion des prêts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem choixDuSGBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
    }
}

