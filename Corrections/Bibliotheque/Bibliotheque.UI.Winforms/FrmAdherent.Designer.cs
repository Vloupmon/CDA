
namespace Bibliotheque.UI.Winforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adherentIDLabel = new System.Windows.Forms.Label();
            this.AdherentEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.AdherentEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.gbRecherche.SuspendLayout();
            this.gbBoutonOpe.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Par son identfiant :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(24, 98);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(183, 25);
            this.nomLabel.TabIndex = 7;
            this.nomLabel.Text = "Par le début du nom :";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(24, 145);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(78, 25);
            this.prenomLabel.TabIndex = 8;
            this.prenomLabel.Text = "Prenom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom :";
            // 
            // adherentIDLabel
            // 
            this.adherentIDLabel.AutoSize = true;
            this.adherentIDLabel.Location = new System.Drawing.Point(24, 58);
            this.adherentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adherentIDLabel.Name = "adherentIDLabel";
            this.adherentIDLabel.Size = new System.Drawing.Size(101, 25);
            this.adherentIDLabel.TabIndex = 6;
            this.adherentIDLabel.Text = "Identifiant :";
            // 
            // AdherentEP
            // 
            this.AdherentEP.ContainerControl = this;
            this.AdherentEP.DataSource = this.adherentBindingSource;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            // 
            // gbRecherche
            // 
            this.gbRecherche.Controls.Add(this.label1);
            this.gbRecherche.Controls.Add(this.nomLabel);
            this.gbRecherche.Controls.Add(this.txtDebNom);
            this.gbRecherche.Controls.Add(this.btnRechercher);
            this.gbRecherche.Controls.Add(this.txtAdherentID);
            this.gbRecherche.Location = new System.Drawing.Point(209, 12);
            this.gbRecherche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRecherche.Size = new System.Drawing.Size(578, 228);
            this.gbRecherche.TabIndex = 3;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Identifier l\'adhérent";
            // 
            // txtDebNom
            // 
            this.txtDebNom.Location = new System.Drawing.Point(216, 94);
            this.txtDebNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDebNom.Name = "txtDebNom";
            this.txtDebNom.Size = new System.Drawing.Size(228, 31);
            this.txtDebNom.TabIndex = 1;
            this.txtDebNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebNom_KeyDown);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(28, 158);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(131, 44);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtAdherentID
            // 
            this.txtAdherentID.Location = new System.Drawing.Point(216, 33);
            this.txtAdherentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdherentID.Name = "txtAdherentID";
            this.txtAdherentID.Size = new System.Drawing.Size(165, 31);
            this.txtAdherentID.TabIndex = 0;
            this.txtAdherentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdherentID_KeyDown);
            // 
            // gbBoutonOpe
            // 
            this.gbBoutonOpe.Controls.Add(this.btnAnnuler);
            this.gbBoutonOpe.Controls.Add(this.btnValider);
            this.gbBoutonOpe.Controls.Add(this.btnNouveau);
            this.gbBoutonOpe.Controls.Add(this.btnEditer);
            this.gbBoutonOpe.Location = new System.Drawing.Point(209, 591);
            this.gbBoutonOpe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBoutonOpe.Name = "gbBoutonOpe";
            this.gbBoutonOpe.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBoutonOpe.Size = new System.Drawing.Size(584, 100);
            this.gbBoutonOpe.TabIndex = 5;
            this.gbBoutonOpe.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(380, 33);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(94, 41);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(268, 34);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(94, 41);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(140, 34);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(120, 41);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(28, 34);
            this.btnEditer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(94, 41);
            this.btnEditer.TabIndex = 0;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.nomTextBox);
            this.gbDetails.Controls.Add(this.prenomTextBox);
            this.gbDetails.Controls.Add(this.prenomLabel);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.adherentIDLabel);
            this.gbDetails.Controls.Add(this.adherentIDTextBox);
            this.gbDetails.Location = new System.Drawing.Point(209, 291);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDetails.Size = new System.Drawing.Size(578, 233);
            this.gbDetails.TabIndex = 4;
            this.gbDetails.TabStop = false;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(140, 97);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(304, 31);
            this.nomTextBox.TabIndex = 4;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(140, 141);
            this.prenomTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(304, 31);
            this.prenomTextBox.TabIndex = 5;
            // 
            // adherentIDTextBox
            // 
            this.adherentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "AdherentID", true));
            this.adherentIDTextBox.Location = new System.Drawing.Point(140, 53);
            this.adherentIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adherentIDTextBox.Name = "adherentIDTextBox";
            this.adherentIDTextBox.Size = new System.Drawing.Size(124, 31);
            this.adherentIDTextBox.TabIndex = 3;
            // 
            // FrmAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 703);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.gbBoutonOpe);
            this.Controls.Add(this.gbDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdherent";
            this.Text = "Gérer les adhérents";
            ((System.ComponentModel.ISupportInitialize)(this.AdherentEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.gbBoutonOpe.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adherentIDLabel;
    }
}


