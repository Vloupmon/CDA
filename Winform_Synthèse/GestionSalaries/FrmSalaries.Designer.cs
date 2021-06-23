namespace GestionSalaraies {
    partial class FrmSalaries {
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
            this.components = new System.ComponentModel.Container();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.cbSalaries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetailSalarie = new System.Windows.Forms.GroupBox();
            this.cbCommercial = new System.Windows.Forms.CheckBox();
            this.gbCommercial = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.txtTauxCs = new System.Windows.Forms.TextBox();
            this.txtSalaireNet = new System.Windows.Forms.TextBox();
            this.txtSalaireBrut = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epSalarie = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbDetailSalarie.SuspendLayout();
            this.gbCommercial.SuspendLayout();
            this.pnlBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSalarie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(315, 24);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(74, 20);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // cbSalaries
            // 
            this.cbSalaries.FormattingEnabled = true;
            this.cbSalaries.Location = new System.Drawing.Point(173, 24);
            this.cbSalaries.Margin = new System.Windows.Forms.Padding(2);
            this.cbSalaries.Name = "cbSalaries";
            this.cbSalaries.Size = new System.Drawing.Size(132, 21);
            this.cbSalaries.TabIndex = 0;
            this.cbSalaries.SelectedIndexChanged += new System.EventHandler(this.cbSalaries_SelectedIndexChanged);
            this.cbSalaries.Click += new System.EventHandler(this.cbSalaries_Click);
            this.cbSalaries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSalaries_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisir un salarie :";
            // 
            // gbDetailSalarie
            // 
            this.gbDetailSalarie.Controls.Add(this.cbCommercial);
            this.gbDetailSalarie.Controls.Add(this.gbCommercial);
            this.gbDetailSalarie.Controls.Add(this.txtTauxCs);
            this.gbDetailSalarie.Controls.Add(this.txtSalaireNet);
            this.gbDetailSalarie.Controls.Add(this.txtSalaireBrut);
            this.gbDetailSalarie.Controls.Add(this.txtNom);
            this.gbDetailSalarie.Controls.Add(this.txtDate);
            this.gbDetailSalarie.Controls.Add(this.label8);
            this.gbDetailSalarie.Controls.Add(this.label7);
            this.gbDetailSalarie.Controls.Add(this.label6);
            this.gbDetailSalarie.Controls.Add(this.label5);
            this.gbDetailSalarie.Controls.Add(this.label3);
            this.gbDetailSalarie.Controls.Add(this.pnlBoutons);
            this.gbDetailSalarie.Controls.Add(this.txtPrenom);
            this.gbDetailSalarie.Controls.Add(this.label4);
            this.gbDetailSalarie.Controls.Add(this.txtMatricule);
            this.gbDetailSalarie.Controls.Add(this.label2);
            this.gbDetailSalarie.Location = new System.Drawing.Point(30, 68);
            this.gbDetailSalarie.Margin = new System.Windows.Forms.Padding(2);
            this.gbDetailSalarie.Name = "gbDetailSalarie";
            this.gbDetailSalarie.Padding = new System.Windows.Forms.Padding(2);
            this.gbDetailSalarie.Size = new System.Drawing.Size(359, 464);
            this.gbDetailSalarie.TabIndex = 0;
            this.gbDetailSalarie.TabStop = false;
            this.gbDetailSalarie.Text = "Détails Salarie";
            // 
            // cbCommercial
            // 
            this.cbCommercial.AutoSize = true;
            this.cbCommercial.Location = new System.Drawing.Point(142, 286);
            this.cbCommercial.Name = "cbCommercial";
            this.cbCommercial.Size = new System.Drawing.Size(80, 17);
            this.cbCommercial.TabIndex = 9;
            this.cbCommercial.Text = "Commercial";
            this.cbCommercial.UseVisualStyleBackColor = true;
            this.cbCommercial.CheckedChanged += new System.EventHandler(this.cbCommercial_CheckedChanged);
            // 
            // gbCommercial
            // 
            this.gbCommercial.Controls.Add(this.label10);
            this.gbCommercial.Controls.Add(this.label9);
            this.gbCommercial.Controls.Add(this.txtCommission);
            this.gbCommercial.Controls.Add(this.txtCA);
            this.gbCommercial.Enabled = false;
            this.gbCommercial.Location = new System.Drawing.Point(20, 309);
            this.gbCommercial.Name = "gbCommercial";
            this.gbCommercial.Size = new System.Drawing.Size(324, 86);
            this.gbCommercial.TabIndex = 10;
            this.gbCommercial.TabStop = false;
            this.gbCommercial.Text = "Commercial attributs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Commission";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Chiffre d\'Affaire";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(122, 60);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(132, 20);
            this.txtCommission.TabIndex = 11;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(122, 19);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(132, 20);
            this.txtCA.TabIndex = 10;
            // 
            // txtTauxCs
            // 
            this.txtTauxCs.Location = new System.Drawing.Point(142, 239);
            this.txtTauxCs.Name = "txtTauxCs";
            this.txtTauxCs.Size = new System.Drawing.Size(132, 20);
            this.txtTauxCs.TabIndex = 8;
            // 
            // txtSalaireNet
            // 
            this.txtSalaireNet.Location = new System.Drawing.Point(142, 206);
            this.txtSalaireNet.Name = "txtSalaireNet";
            this.txtSalaireNet.Size = new System.Drawing.Size(132, 20);
            this.txtSalaireNet.TabIndex = 7;
            // 
            // txtSalaireBrut
            // 
            this.txtSalaireBrut.Location = new System.Drawing.Point(143, 173);
            this.txtSalaireBrut.Name = "txtSalaireBrut";
            this.txtSalaireBrut.Size = new System.Drawing.Size(131, 20);
            this.txtSalaireBrut.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(142, 140);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(132, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(142, 74);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(133, 20);
            this.txtDate.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date de Naissance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Taux CS :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salaire Net :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salaire Brut :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom :";
            // 
            // pnlBoutons
            // 
            this.pnlBoutons.Controls.Add(this.btnValider);
            this.pnlBoutons.Controls.Add(this.btnAnnuler);
            this.pnlBoutons.Controls.Add(this.btnModifier);
            this.pnlBoutons.Location = new System.Drawing.Point(20, 400);
            this.pnlBoutons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBoutons.Name = "pnlBoutons";
            this.pnlBoutons.Size = new System.Drawing.Size(325, 60);
            this.pnlBoutons.TabIndex = 14;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(244, 17);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(56, 23);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(134, 17);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(24, 17);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(56, 23);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(142, 107);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(132, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom :";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(143, 41);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(132, 20);
            this.txtMatricule.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matricule :";
            // 
            // epSalarie
            // 
            this.epSalarie.ContainerControl = this;
            // 
            // FrmSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 556);
            this.Controls.Add(this.gbDetailSalarie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSalaries);
            this.Controls.Add(this.btnNouveau);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSalaries";
            this.Text = "Gestion des salaries";
            this.Load += new System.EventHandler(this.FrmSalaries_Load);
            this.gbDetailSalarie.ResumeLayout(false);
            this.gbDetailSalarie.PerformLayout();
            this.gbCommercial.ResumeLayout(false);
            this.gbCommercial.PerformLayout();
            this.pnlBoutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epSalarie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.ComboBox cbSalaries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetailSalarie;
        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epSalarie;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtTauxCs;
        private System.Windows.Forms.TextBox txtSalaireNet;
        private System.Windows.Forms.TextBox txtSalaireBrut;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.CheckBox cbCommercial;
        private System.Windows.Forms.GroupBox gbCommercial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtCA;
    }
}