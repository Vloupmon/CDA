namespace A001
{
    partial class FrmConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnecter = new System.Windows.Forms.Button();
            this.txtEtatConnexion = new System.Windows.Forms.TextBox();
            this.btnProprietes = new System.Windows.Forms.Button();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(29, 70);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(82, 23);
            this.btnConnecter.TabIndex = 0;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // txtEtatConnexion
            // 
            this.txtEtatConnexion.Location = new System.Drawing.Point(148, 241);
            this.txtEtatConnexion.Name = "txtEtatConnexion";
            this.txtEtatConnexion.ReadOnly = true;
            this.txtEtatConnexion.Size = new System.Drawing.Size(171, 20);
            this.txtEtatConnexion.TabIndex = 1;
            // 
            // btnProprietes
            // 
            this.btnProprietes.Location = new System.Drawing.Point(29, 129);
            this.btnProprietes.Name = "btnProprietes";
            this.btnProprietes.Size = new System.Drawing.Size(82, 23);
            this.btnProprietes.TabIndex = 2;
            this.btnProprietes.Text = "Propriétés";
            this.btnProprietes.UseVisualStyleBackColor = true;
            this.btnProprietes.Click += new System.EventHandler(this.btnProprietes_Click);
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.Location = new System.Drawing.Point(29, 193);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(82, 23);
            this.btnDeconnecter.TabIndex = 3;
            this.btnDeconnecter.Text = "Déconnecter";
            this.btnDeconnecter.UseVisualStyleBackColor = true;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Etat de la connexion";
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeconnecter);
            this.Controls.Add(this.btnProprietes);
            this.Controls.Add(this.txtEtatConnexion);
            this.Controls.Add(this.btnConnecter);
            this.Name = "FrmConnexion";
            this.Text = "Découverte de l\'objet Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.TextBox txtEtatConnexion;
        private System.Windows.Forms.Button btnProprietes;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Label label1;
    }
}