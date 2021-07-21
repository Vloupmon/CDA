namespace A001
{
    partial class FrmLectureDonnees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLectureDonnees));
            this.txtRequete = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lstDernieresCommandes = new System.Windows.Forms.ListBox();
            this.btnCommandeParametree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRequete
            // 
            this.txtRequete.Location = new System.Drawing.Point(86, 107);
            this.txtRequete.Multiline = true;
            this.txtRequete.Name = "txtRequete";
            this.txtRequete.Size = new System.Drawing.Size(431, 72);
            this.txtRequete.TabIndex = 7;
            this.txtRequete.Text = resources.GetString("txtRequete.Text");
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(341, 54);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 5;
            // 
            // lstDernieresCommandes
            // 
            this.lstDernieresCommandes.FormattingEnabled = true;
            this.lstDernieresCommandes.Location = new System.Drawing.Point(86, 185);
            this.lstDernieresCommandes.Name = "lstDernieresCommandes";
            this.lstDernieresCommandes.Size = new System.Drawing.Size(431, 147);
            this.lstDernieresCommandes.TabIndex = 6;
            // 
            // btnCommandeParametree
            // 
            this.btnCommandeParametree.Location = new System.Drawing.Point(86, 47);
            this.btnCommandeParametree.Name = "btnCommandeParametree";
            this.btnCommandeParametree.Size = new System.Drawing.Size(196, 33);
            this.btnCommandeParametree.TabIndex = 4;
            this.btnCommandeParametree.Text = "Commande Paramétrée avec IdClient";
            this.btnCommandeParametree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommandeParametree.UseVisualStyleBackColor = true;
            this.btnCommandeParametree.Click += new System.EventHandler(this.btnCommandeParametree_Click);
            // 
            // FrmLectureDonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 379);
            this.Controls.Add(this.txtRequete);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lstDernieresCommandes);
            this.Controls.Add(this.btnCommandeParametree);
            this.Name = "FrmLectureDonnees";
            this.Text = "Découverte de l\'objet DataReader pour extraire des valeurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequete;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ListBox lstDernieresCommandes;
        private System.Windows.Forms.Button btnCommandeParametree;

    }
}