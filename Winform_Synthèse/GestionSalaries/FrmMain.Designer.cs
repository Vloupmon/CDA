
namespace GestionSalaraies {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGestionUtilisateurs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionSalaries = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestionUtilisateurs,
            this.menuGestionSalaries});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGestionUtilisateurs
            // 
            this.menuGestionUtilisateurs.Name = "menuGestionUtilisateurs";
            this.menuGestionUtilisateurs.Size = new System.Drawing.Size(145, 20);
            this.menuGestionUtilisateurs.Text = "Gestions des utilisateurs";
            this.menuGestionUtilisateurs.Click += new System.EventHandler(this.menuGestionUtilisateurs_Click);
            // 
            // menuGestionSalaries
            // 
            this.menuGestionSalaries.Name = "menuGestionSalaries";
            this.menuGestionSalaries.Size = new System.Drawing.Size(121, 20);
            this.menuGestionSalaries.Text = "Gestion des salariés";
            this.menuGestionSalaries.Click += new System.EventHandler(this.menuGestionSalaries_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.formShown); //Login window
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGestionUtilisateurs;
        private System.Windows.Forms.ToolStripMenuItem menuGestionSalaries;
    }
}