namespace A003
{
    partial class FrmMereFille
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
            this.txtIdMere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouterMereFille = new System.Windows.Forms.Button();
            this.txtNomMere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomFille = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdFille = new System.Windows.Forms.TextBox();
            this.txtRowsAffected = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReturnValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdMere
            // 
            this.txtIdMere.Location = new System.Drawing.Point(362, 155);
            this.txtIdMere.Name = "txtIdMere";
            this.txtIdMere.ReadOnly = true;
            this.txtIdMere.Size = new System.Drawing.Size(100, 20);
            this.txtIdMere.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valeur de la clé primaire générée:";
            // 
            // btnAjouterMereFille
            // 
            this.btnAjouterMereFille.Location = new System.Drawing.Point(32, 153);
            this.btnAjouterMereFille.Name = "btnAjouterMereFille";
            this.btnAjouterMereFille.Size = new System.Drawing.Size(114, 23);
            this.btnAjouterMereFille.TabIndex = 6;
            this.btnAjouterMereFille.Text = "Ajouter mère et fille";
            this.btnAjouterMereFille.UseVisualStyleBackColor = true;
            this.btnAjouterMereFille.Click += new System.EventHandler(this.btnAjouterMereFille_Click);
            // 
            // txtNomMere
            // 
            this.txtNomMere.Location = new System.Drawing.Point(133, 54);
            this.txtNomMere.Name = "txtNomMere";
            this.txtNomMere.Size = new System.Drawing.Size(223, 20);
            this.txtNomMere.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de la mère:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom de la fille:";
            // 
            // txtNomFille
            // 
            this.txtNomFille.Location = new System.Drawing.Point(133, 110);
            this.txtNomFille.Name = "txtNomFille";
            this.txtNomFille.Size = new System.Drawing.Size(223, 20);
            this.txtNomFille.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Identifiant de la fille:";
            // 
            // txtIdFille
            // 
            this.txtIdFille.Location = new System.Drawing.Point(133, 84);
            this.txtIdFille.Name = "txtIdFille";
            this.txtIdFille.Size = new System.Drawing.Size(84, 20);
            this.txtIdFille.TabIndex = 3;
            // 
            // txtRowsAffected
            // 
            this.txtRowsAffected.Location = new System.Drawing.Point(362, 224);
            this.txtRowsAffected.Name = "txtRowsAffected";
            this.txtRowsAffected.ReadOnly = true;
            this.txtRowsAffected.Size = new System.Drawing.Size(100, 20);
            this.txtRowsAffected.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre lignes affectées";
            // 
            // txtReturnValue
            // 
            this.txtReturnValue.Location = new System.Drawing.Point(362, 189);
            this.txtReturnValue.Name = "txtReturnValue";
            this.txtReturnValue.ReadOnly = true;
            this.txtReturnValue.Size = new System.Drawing.Size(100, 20);
            this.txtReturnValue.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valeur retour Return Value";
            // 
            // FrmMereFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 351);
            this.Controls.Add(this.txtRowsAffected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReturnValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomFille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdMere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouterMereFille);
            this.Controls.Add(this.txtIdFille);
            this.Controls.Add(this.txtNomMere);
            this.Controls.Add(this.label1);
            this.Name = "FrmMereFille";
            this.Text = "Ajouter Couple Mere Fille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdMere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouterMereFille;
        private System.Windows.Forms.TextBox txtNomMere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomFille;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdFille;
        private System.Windows.Forms.TextBox txtRowsAffected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReturnValue;
        private System.Windows.Forms.Label label6;
    }
}