namespace A001
{
    partial class FrmCommande
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
            this.gpbNonQuery = new System.Windows.Forms.GroupBox();
            this.txtResultatNonQuery = new System.Windows.Forms.TextBox();
            this.txtRequeteNonQuery = new System.Windows.Forms.TextBox();
            this.btnNonQuery = new System.Windows.Forms.Button();
            this.gpbScalaire = new System.Windows.Forms.GroupBox();
            this.txtResultatTexte = new System.Windows.Forms.TextBox();
            this.txtResultatSansParametre = new System.Windows.Forms.TextBox();
            this.txtResultatAvecParametre = new System.Windows.Forms.TextBox();
            this.txtResultatRequeteLibre = new System.Windows.Forms.TextBox();
            this.btnExecuterTexte = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnAvecParametre = new System.Windows.Forms.Button();
            this.btnSansParametre = new System.Windows.Forms.Button();
            this.gpbNonQuery.SuspendLayout();
            this.gpbScalaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNonQuery
            // 
            this.gpbNonQuery.Controls.Add(this.txtResultatNonQuery);
            this.gpbNonQuery.Controls.Add(this.txtRequeteNonQuery);
            this.gpbNonQuery.Controls.Add(this.btnNonQuery);
            this.gpbNonQuery.Location = new System.Drawing.Point(71, 341);
            this.gpbNonQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbNonQuery.Name = "gpbNonQuery";
            this.gpbNonQuery.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbNonQuery.Size = new System.Drawing.Size(679, 233);
            this.gpbNonQuery.TabIndex = 4;
            this.gpbNonQuery.TabStop = false;
            this.gpbNonQuery.Text = "Requête sans jeu de résultats Execute Non Query";
            // 
            // txtResultatNonQuery
            // 
            this.txtResultatNonQuery.BackColor = System.Drawing.Color.Red;
            this.txtResultatNonQuery.ForeColor = System.Drawing.Color.White;
            this.txtResultatNonQuery.Location = new System.Drawing.Point(512, 33);
            this.txtResultatNonQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultatNonQuery.Name = "txtResultatNonQuery";
            this.txtResultatNonQuery.ReadOnly = true;
            this.txtResultatNonQuery.Size = new System.Drawing.Size(132, 22);
            this.txtResultatNonQuery.TabIndex = 8;
            // 
            // txtRequeteNonQuery
            // 
            this.txtRequeteNonQuery.Location = new System.Drawing.Point(8, 71);
            this.txtRequeteNonQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRequeteNonQuery.Multiline = true;
            this.txtRequeteNonQuery.Name = "txtRequeteNonQuery";
            this.txtRequeteNonQuery.Size = new System.Drawing.Size(473, 91);
            this.txtRequeteNonQuery.TabIndex = 5;
            // 
            // btnNonQuery
            // 
            this.btnNonQuery.Location = new System.Drawing.Point(8, 33);
            this.btnNonQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNonQuery.Name = "btnNonQuery";
            this.btnNonQuery.Size = new System.Drawing.Size(309, 31);
            this.btnNonQuery.TabIndex = 4;
            this.btnNonQuery.Text = "Résultat requête suivante";
            this.btnNonQuery.UseVisualStyleBackColor = true;
            this.btnNonQuery.Click += new System.EventHandler(this.btnNonQuery_Click);
            // 
            // gpbScalaire
            // 
            this.gpbScalaire.Controls.Add(this.txtResultatTexte);
            this.gpbScalaire.Controls.Add(this.txtResultatSansParametre);
            this.gpbScalaire.Controls.Add(this.txtResultatAvecParametre);
            this.gpbScalaire.Controls.Add(this.txtResultatRequeteLibre);
            this.gpbScalaire.Controls.Add(this.btnExecuterTexte);
            this.gpbScalaire.Controls.Add(this.txtCustomerID);
            this.gpbScalaire.Controls.Add(this.btnAvecParametre);
            this.gpbScalaire.Controls.Add(this.btnSansParametre);
            this.gpbScalaire.Location = new System.Drawing.Point(71, 38);
            this.gpbScalaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbScalaire.Name = "gpbScalaire";
            this.gpbScalaire.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbScalaire.Size = new System.Drawing.Size(679, 295);
            this.gpbScalaire.TabIndex = 3;
            this.gpbScalaire.TabStop = false;
            this.gpbScalaire.Text = "Requête avec réponse scalaire Execute Scalar";
            // 
            // txtResultatTexte
            // 
            this.txtResultatTexte.BackColor = System.Drawing.Color.Red;
            this.txtResultatTexte.ForeColor = System.Drawing.Color.White;
            this.txtResultatTexte.Location = new System.Drawing.Point(512, 151);
            this.txtResultatTexte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultatTexte.Name = "txtResultatTexte";
            this.txtResultatTexte.ReadOnly = true;
            this.txtResultatTexte.Size = new System.Drawing.Size(132, 22);
            this.txtResultatTexte.TabIndex = 9;
            // 
            // txtResultatSansParametre
            // 
            this.txtResultatSansParametre.BackColor = System.Drawing.Color.Red;
            this.txtResultatSansParametre.ForeColor = System.Drawing.Color.White;
            this.txtResultatSansParametre.Location = new System.Drawing.Point(512, 43);
            this.txtResultatSansParametre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultatSansParametre.Name = "txtResultatSansParametre";
            this.txtResultatSansParametre.ReadOnly = true;
            this.txtResultatSansParametre.Size = new System.Drawing.Size(132, 22);
            this.txtResultatSansParametre.TabIndex = 8;
            // 
            // txtResultatAvecParametre
            // 
            this.txtResultatAvecParametre.BackColor = System.Drawing.Color.Red;
            this.txtResultatAvecParametre.ForeColor = System.Drawing.Color.White;
            this.txtResultatAvecParametre.Location = new System.Drawing.Point(512, 94);
            this.txtResultatAvecParametre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultatAvecParametre.Name = "txtResultatAvecParametre";
            this.txtResultatAvecParametre.ReadOnly = true;
            this.txtResultatAvecParametre.Size = new System.Drawing.Size(132, 22);
            this.txtResultatAvecParametre.TabIndex = 6;
            // 
            // txtResultatRequeteLibre
            // 
            this.txtResultatRequeteLibre.Location = new System.Drawing.Point(8, 186);
            this.txtResultatRequeteLibre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultatRequeteLibre.Multiline = true;
            this.txtResultatRequeteLibre.Name = "txtResultatRequeteLibre";
            this.txtResultatRequeteLibre.Size = new System.Drawing.Size(473, 91);
            this.txtResultatRequeteLibre.TabIndex = 5;
            // 
            // btnExecuterTexte
            // 
            this.btnExecuterTexte.Location = new System.Drawing.Point(8, 148);
            this.btnExecuterTexte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExecuterTexte.Name = "btnExecuterTexte";
            this.btnExecuterTexte.Size = new System.Drawing.Size(309, 31);
            this.btnExecuterTexte.TabIndex = 4;
            this.btnExecuterTexte.Text = "Résultat requête suivante";
            this.btnExecuterTexte.UseVisualStyleBackColor = true;
            this.btnExecuterTexte.Click += new System.EventHandler(this.btnExecuterTexte_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(349, 94);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.Text = "ALFKI";
            // 
            // btnAvecParametre
            // 
            this.btnAvecParametre.Location = new System.Drawing.Point(8, 91);
            this.btnAvecParametre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvecParametre.Name = "btnAvecParametre";
            this.btnAvecParametre.Size = new System.Drawing.Size(309, 31);
            this.btnAvecParametre.TabIndex = 2;
            this.btnAvecParametre.Text = "Avec paramètre : Nombre de commandes de ";
            this.btnAvecParametre.UseVisualStyleBackColor = true;
            this.btnAvecParametre.Click += new System.EventHandler(this.btnAvecParametre_Click);
            // 
            // btnSansParametre
            // 
            this.btnSansParametre.Location = new System.Drawing.Point(8, 39);
            this.btnSansParametre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSansParametre.Name = "btnSansParametre";
            this.btnSansParametre.Size = new System.Drawing.Size(309, 31);
            this.btnSansParametre.TabIndex = 1;
            this.btnSansParametre.Text = "Sans paramètre : Nombre de clients";
            this.btnSansParametre.UseVisualStyleBackColor = true;
            this.btnSansParametre.Click += new System.EventHandler(this.btnSansParametre_Click);
            // 
            // FrmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 610);
            this.Controls.Add(this.gpbNonQuery);
            this.Controls.Add(this.gpbScalaire);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCommande";
            this.Text = "Découverte de l\'objet Commande";
            this.gpbNonQuery.ResumeLayout(false);
            this.gpbNonQuery.PerformLayout();
            this.gpbScalaire.ResumeLayout(false);
            this.gpbScalaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNonQuery;
        private System.Windows.Forms.TextBox txtResultatNonQuery;
        private System.Windows.Forms.TextBox txtRequeteNonQuery;
        private System.Windows.Forms.Button btnNonQuery;
        private System.Windows.Forms.GroupBox gpbScalaire;
        private System.Windows.Forms.TextBox txtResultatTexte;
        private System.Windows.Forms.TextBox txtResultatSansParametre;
        private System.Windows.Forms.TextBox txtResultatAvecParametre;
        private System.Windows.Forms.TextBox txtResultatRequeteLibre;
        private System.Windows.Forms.Button btnExecuterTexte;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnAvecParametre;
        private System.Windows.Forms.Button btnSansParametre;

    }
}