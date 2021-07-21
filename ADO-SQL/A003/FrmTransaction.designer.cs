namespace A003
{
    partial class FrmTransaction
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomFille2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdFille2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDistribuee = new System.Windows.Forms.RadioButton();
            this.rdbLocale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdMere
            // 
            this.txtIdMere.Location = new System.Drawing.Point(483, 226);
            this.txtIdMere.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMere.Name = "txtIdMere";
            this.txtIdMere.ReadOnly = true;
            this.txtIdMere.Size = new System.Drawing.Size(132, 22);
            this.txtIdMere.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valeur de la clé primaire générée:";
            // 
            // btnAjouterMereFille
            // 
            this.btnAjouterMereFille.Location = new System.Drawing.Point(43, 224);
            this.btnAjouterMereFille.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterMereFille.Name = "btnAjouterMereFille";
            this.btnAjouterMereFille.Size = new System.Drawing.Size(152, 28);
            this.btnAjouterMereFille.TabIndex = 10;
            this.btnAjouterMereFille.Text = "Ajouter mère et filles";
            this.btnAjouterMereFille.UseVisualStyleBackColor = true;
            this.btnAjouterMereFille.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // txtNomMere
            // 
            this.txtNomMere.Location = new System.Drawing.Point(177, 19);
            this.txtNomMere.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomMere.Name = "txtNomMere";
            this.txtNomMere.Size = new System.Drawing.Size(296, 22);
            this.txtNomMere.TabIndex = 1;
            this.txtNomMere.Text = "Baronne de la tronche en biais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la mère:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom de la fille 1 :";
            // 
            // txtNomFille
            // 
            this.txtNomFille.Location = new System.Drawing.Point(180, 88);
            this.txtNomFille.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomFille.Name = "txtNomFille";
            this.txtNomFille.Size = new System.Drawing.Size(296, 22);
            this.txtNomFille.TabIndex = 5;
            this.txtNomFille.Text = "Berthe au grand pied";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Identifiant fille 1 :";
            // 
            // txtIdFille
            // 
            this.txtIdFille.Location = new System.Drawing.Point(177, 56);
            this.txtIdFille.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdFille.Name = "txtIdFille";
            this.txtIdFille.Size = new System.Drawing.Size(88, 22);
            this.txtIdFille.TabIndex = 3;
            this.txtIdFille.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Identifiant fille 2 :";
            // 
            // txtNomFille2
            // 
            this.txtNomFille2.Location = new System.Drawing.Point(183, 163);
            this.txtNomFille2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomFille2.Name = "txtNomFille2";
            this.txtNomFille2.Size = new System.Drawing.Size(296, 22);
            this.txtNomFille2.TabIndex = 9;
            this.txtNomFille2.Text = "Gisèle de Bertrade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nom de la fille 2 :";
            // 
            // txtIdFille2
            // 
            this.txtIdFille2.Location = new System.Drawing.Point(180, 131);
            this.txtIdFille2.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdFille2.Name = "txtIdFille2";
            this.txtIdFille2.Size = new System.Drawing.Size(88, 22);
            this.txtIdFille2.TabIndex = 7;
            this.txtIdFille2.Text = "11";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDistribuee);
            this.groupBox1.Controls.Add(this.rdbLocale);
            this.groupBox1.Location = new System.Drawing.Point(43, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 63);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // rdbDistribuee
            // 
            this.rdbDistribuee.AutoSize = true;
            this.rdbDistribuee.Location = new System.Drawing.Point(94, 35);
            this.rdbDistribuee.Name = "rdbDistribuee";
            this.rdbDistribuee.Size = new System.Drawing.Size(93, 21);
            this.rdbDistribuee.TabIndex = 0;
            this.rdbDistribuee.TabStop = true;
            this.rdbDistribuee.Text = "Distribuée";
            this.rdbDistribuee.UseVisualStyleBackColor = true;
            // 
            // rdbLocale
            // 
            this.rdbLocale.AutoSize = true;
            this.rdbLocale.Checked = true;
            this.rdbLocale.Location = new System.Drawing.Point(6, 35);
            this.rdbLocale.Name = "rdbLocale";
            this.rdbLocale.Size = new System.Drawing.Size(71, 21);
            this.rdbLocale.TabIndex = 0;
            this.rdbLocale.TabStop = true;
            this.rdbLocale.Text = "Locale";
            this.rdbLocale.UseVisualStyleBackColor = true;
            // 
            // FrmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomFille2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdFille2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomFille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdMere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouterMereFille);
            this.Controls.Add(this.txtIdFille);
            this.Controls.Add(this.txtNomMere);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTransaction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomFille2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdFille2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDistribuee;
        private System.Windows.Forms.RadioButton rdbLocale;
    }
}