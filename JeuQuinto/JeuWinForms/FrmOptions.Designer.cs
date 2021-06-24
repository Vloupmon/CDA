namespace JeuWinForms
{

    partial class FrmOptions
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDPointsErreur = new System.Windows.Forms.NumericUpDown();
            this.cbCultures = new System.Windows.Forms.ComboBox();
            this.nUDErreurs = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nUDPointsParSeconde = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nUDManches = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPointsErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDErreurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPointsParSeconde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDManches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(16, 326);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 38);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(144, 326);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(105, 38);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre d\'erreurs autorisées:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Culture courante :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de points par erreur :";
            // 
            // nUDPointsErreur
            // 
            this.nUDPointsErreur.Location = new System.Drawing.Point(266, 208);
            this.nUDPointsErreur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nUDPointsErreur.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDPointsErreur.Name = "nUDPointsErreur";
            this.nUDPointsErreur.Size = new System.Drawing.Size(99, 26);
            this.nUDPointsErreur.TabIndex = 3;
            this.nUDPointsErreur.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cbCultures
            // 
            this.cbCultures.Location = new System.Drawing.Point(156, 54);
            this.cbCultures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCultures.Name = "cbCultures";
            this.cbCultures.Size = new System.Drawing.Size(208, 28);
            this.cbCultures.TabIndex = 0;
            // 
            // nUDErreurs
            // 
            this.nUDErreurs.Location = new System.Drawing.Point(266, 261);
            this.nUDErreurs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nUDErreurs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDErreurs.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDErreurs.Name = "nUDErreurs";
            this.nUDErreurs.Size = new System.Drawing.Size(99, 26);
            this.nUDErreurs.TabIndex = 4;
            this.nUDErreurs.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre de points par seconde :";
            // 
            // nUDPointsParSeconde
            // 
            this.nUDPointsParSeconde.Location = new System.Drawing.Point(266, 161);
            this.nUDPointsParSeconde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nUDPointsParSeconde.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDPointsParSeconde.Name = "nUDPointsParSeconde";
            this.nUDPointsParSeconde.Size = new System.Drawing.Size(99, 26);
            this.nUDPointsParSeconde.TabIndex = 2;
            this.nUDPointsParSeconde.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre de manches par partie :";
            // 
            // nUDManches
            // 
            this.nUDManches.Location = new System.Drawing.Point(266, 107);
            this.nUDManches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nUDManches.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nUDManches.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDManches.Name = "nUDManches";
            this.nUDManches.Size = new System.Drawing.Size(99, 26);
            this.nUDManches.TabIndex = 1;
            this.nUDManches.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FrmOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(587, 445);
            this.ControlBox = false;
            this.Controls.Add(this.cbCultures);
            this.Controls.Add(this.nUDErreurs);
            this.Controls.Add(this.nUDManches);
            this.Controls.Add(this.nUDPointsParSeconde);
            this.Controls.Add(this.nUDPointsErreur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOptions";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOptions_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nUDPointsErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDErreurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPointsParSeconde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDManches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDPointsErreur;
        private System.Windows.Forms.ComboBox cbCultures;
        private System.Windows.Forms.NumericUpDown nUDErreurs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUDPointsParSeconde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUDManches;
    }
}