namespace A003
{
    partial class FrmMere
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomMere = new System.Windows.Forms.TextBox();
            this.btnAjouterMere = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMere = new System.Windows.Forms.TextBox();
            this.txtRowsAffected = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReturnValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la mère:";
            // 
            // txtNomMere
            // 
            this.txtNomMere.Location = new System.Drawing.Point(151, 26);
            this.txtNomMere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomMere.Name = "txtNomMere";
            this.txtNomMere.Size = new System.Drawing.Size(296, 22);
            this.txtNomMere.TabIndex = 1;
            // 
            // btnAjouterMere
            // 
            this.btnAjouterMere.Location = new System.Drawing.Point(33, 75);
            this.btnAjouterMere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterMere.Name = "btnAjouterMere";
            this.btnAjouterMere.Size = new System.Drawing.Size(152, 28);
            this.btnAjouterMere.TabIndex = 2;
            this.btnAjouterMere.Text = "Ajouter la mère";
            this.btnAjouterMere.UseVisualStyleBackColor = true;
            this.btnAjouterMere.Click += new System.EventHandler(this.btnAjouterMere_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valeur de la clé primaire générée:";
            // 
            // txtIdMere
            // 
            this.txtIdMere.Location = new System.Drawing.Point(467, 78);
            this.txtIdMere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdMere.Name = "txtIdMere";
            this.txtIdMere.ReadOnly = true;
            this.txtIdMere.Size = new System.Drawing.Size(132, 22);
            this.txtIdMere.TabIndex = 4;
            // 
            // txtRowsAffected
            // 
            this.txtRowsAffected.Location = new System.Drawing.Point(465, 169);
            this.txtRowsAffected.Margin = new System.Windows.Forms.Padding(4);
            this.txtRowsAffected.Name = "txtRowsAffected";
            this.txtRowsAffected.ReadOnly = true;
            this.txtRowsAffected.Size = new System.Drawing.Size(132, 22);
            this.txtRowsAffected.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre lignes affectées";
            // 
            // txtReturnValue
            // 
            this.txtReturnValue.Location = new System.Drawing.Point(467, 126);
            this.txtReturnValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnValue.Name = "txtReturnValue";
            this.txtReturnValue.ReadOnly = true;
            this.txtReturnValue.Size = new System.Drawing.Size(132, 22);
            this.txtReturnValue.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valeur retour Return Value";
            // 
            // FrmMere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 373);
            this.Controls.Add(this.txtRowsAffected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReturnValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdMere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouterMere);
            this.Controls.Add(this.txtNomMere);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMere";
            this.Text = "Ajouter une mère";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomMere;
        private System.Windows.Forms.Button btnAjouterMere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMere;
        private System.Windows.Forms.TextBox txtRowsAffected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReturnValue;
        private System.Windows.Forms.Label label3;
    }
}