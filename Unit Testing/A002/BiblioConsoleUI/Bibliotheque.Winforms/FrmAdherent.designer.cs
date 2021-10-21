namespace Bibliotheque.Winforms
{
    partial class FrmAdherent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label adherentIDLabel;
            this.AdherentEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.txtDebNom = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtAdherentID = new System.Windows.Forms.TextBox();
            this.gbBoutonOpe = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.adherentIDTextBox = new System.Windows.Forms.TextBox();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            adherentIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdherentEP)).BeginInit();
            this.gbRecherche.SuspendLayout();
            this.gbBoutonOpe.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 17);
            label1.TabIndex = 7;
            label1.Text = "Par son identfiant :";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(19, 63);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(144, 17);
            nomLabel.TabIndex = 7;
            nomLabel.Text = "Par le début du nom :";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(19, 93);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(61, 17);
            prenomLabel.TabIndex = 8;
            prenomLabel.Text = "Prenom:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 17);
            label2.TabIndex = 6;
            label2.Text = "Nom :";
            // 
            // adherentIDLabel
            // 
            adherentIDLabel.AutoSize = true;
            adherentIDLabel.Location = new System.Drawing.Point(19, 37);
            adherentIDLabel.Name = "adherentIDLabel";
            adherentIDLabel.Size = new System.Drawing.Size(77, 17);
            adherentIDLabel.TabIndex = 6;
            adherentIDLabel.Text = "Identifiant :";
            // 
            // AdherentEP
            // 
            this.AdherentEP.ContainerControl = this;
            this.AdherentEP.DataSource = this.adherentBindingSource;
            // 
            // gbRecherche
            // 
            this.gbRecherche.Controls.Add(label1);
            this.gbRecherche.Controls.Add(nomLabel);
            this.gbRecherche.Controls.Add(this.txtDebNom);
            this.gbRecherche.Controls.Add(this.btnRechercher);
            this.gbRecherche.Controls.Add(this.txtAdherentID);
            this.gbRecherche.Location = new System.Drawing.Point(167, 8);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Size = new System.Drawing.Size(462, 146);
            this.gbRecherche.TabIndex = 3;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Identifier l\'adhérent";
            // 
            // txtDebNom
            // 
            this.txtDebNom.Location = new System.Drawing.Point(173, 60);
            this.txtDebNom.Name = "txtDebNom";
            this.txtDebNom.Size = new System.Drawing.Size(183, 22);
            this.txtDebNom.TabIndex = 1;
            this.txtDebNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebNom_KeyDown);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(22, 101);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(105, 28);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtAdherentID
            // 
            this.txtAdherentID.Location = new System.Drawing.Point(173, 21);
            this.txtAdherentID.Name = "txtAdherentID";
            this.txtAdherentID.Size = new System.Drawing.Size(133, 22);
            this.txtAdherentID.TabIndex = 0;
            this.txtAdherentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdherentID_KeyDown);
            // 
            // gbBoutonOpe
            // 
            this.gbBoutonOpe.Controls.Add(this.btnAnnuler);
            this.gbBoutonOpe.Controls.Add(this.btnValider);
            this.gbBoutonOpe.Controls.Add(this.btnNouveau);
            this.gbBoutonOpe.Controls.Add(this.btnEditer);
            this.gbBoutonOpe.Location = new System.Drawing.Point(167, 378);
            this.gbBoutonOpe.Name = "gbBoutonOpe";
            this.gbBoutonOpe.Size = new System.Drawing.Size(467, 64);
            this.gbBoutonOpe.TabIndex = 5;
            this.gbBoutonOpe.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(304, 21);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 26);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(214, 22);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 26);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(112, 22);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(96, 26);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(22, 22);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(75, 26);
            this.btnEditer.TabIndex = 0;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.nomTextBox);
            this.gbDetails.Controls.Add(this.prenomTextBox);
            this.gbDetails.Controls.Add(prenomLabel);
            this.gbDetails.Controls.Add(label2);
            this.gbDetails.Controls.Add(adherentIDLabel);
            this.gbDetails.Controls.Add(this.adherentIDTextBox);
            this.gbDetails.Location = new System.Drawing.Point(167, 186);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(462, 149);
            this.gbDetails.TabIndex = 4;
            this.gbDetails.TabStop = false;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "NomAdherent", true));
            this.nomTextBox.Location = new System.Drawing.Point(112, 62);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(244, 22);
            this.nomTextBox.TabIndex = 4;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "PrenomAdherent", true));
            this.prenomTextBox.Location = new System.Drawing.Point(112, 90);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(244, 22);
            this.prenomTextBox.TabIndex = 5;
            // 
            // adherentIDTextBox
            // 
            this.adherentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "IdAdherent", true));
            this.adherentIDTextBox.Location = new System.Drawing.Point(112, 34);
            this.adherentIDTextBox.Name = "adherentIDTextBox";
            this.adherentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.adherentIDTextBox.TabIndex = 3;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            // 
            // FrmAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.gbBoutonOpe);
            this.Controls.Add(this.gbDetails);
            this.Name = "FrmAdherent";
            this.Text = "Gestion des adhérents";
            ((System.ComponentModel.ISupportInitialize)(this.AdherentEP)).EndInit();
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.gbBoutonOpe.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.ErrorProvider AdherentEP;
        private System.Windows.Forms.GroupBox gbRecherche;
        private System.Windows.Forms.TextBox txtDebNom;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtAdherentID;
        private System.Windows.Forms.GroupBox gbBoutonOpe;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox adherentIDTextBox;
    }
}

