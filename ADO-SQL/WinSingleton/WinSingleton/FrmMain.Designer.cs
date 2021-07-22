namespace WinSingleton
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
            this.fenetreXInstancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fenetreXInstancesToolStripMenuItem,
            this.singletonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fenetreXInstancesToolStripMenuItem
            // 
            this.fenetreXInstancesToolStripMenuItem.Name = "fenetreXInstancesToolStripMenuItem";
            this.fenetreXInstancesToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.fenetreXInstancesToolStripMenuItem.Text = "Fenetre X Instances";
            this.fenetreXInstancesToolStripMenuItem.Click += new System.EventHandler(this.fenetreXInstancesToolStripMenuItem_Click);
            // 
            // singletonToolStripMenuItem
            // 
            this.singletonToolStripMenuItem.Name = "singletonToolStripMenuItem";
            this.singletonToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.singletonToolStripMenuItem.Text = "Singleton";
            this.singletonToolStripMenuItem.Click += new System.EventHandler(this.singletonToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Gestion des fenêtres";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fenetreXInstancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singletonToolStripMenuItem;
    }
}

