namespace A002
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
            this.components = new System.ComponentModel.Container();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAbandonner = new System.Windows.Forms.Button();
            this.gbConnexion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotPasse = new System.Windows.Forms.TextBox();
            this.txtIDUtilisateur = new System.Windows.Forms.TextBox();
            this.erpConnexion = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpConnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValider.Location = new System.Drawing.Point(16, 194);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(125, 28);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Se connecter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAbandonner
            // 
            this.btnAbandonner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbandonner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbandonner.Location = new System.Drawing.Point(258, 194);
            this.btnAbandonner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbandonner.Name = "btnAbandonner";
            this.btnAbandonner.Size = new System.Drawing.Size(121, 28);
            this.btnAbandonner.TabIndex = 5;
            this.btnAbandonner.Text = "Quitter";
            this.btnAbandonner.UseVisualStyleBackColor = true;
            // 
            // gbConnexion
            // 
            this.gbConnexion.Controls.Add(this.label2);
            this.gbConnexion.Controls.Add(this.label1);
            this.gbConnexion.Controls.Add(this.txtMotPasse);
            this.gbConnexion.Controls.Add(this.txtIDUtilisateur);
            this.gbConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbConnexion.Location = new System.Drawing.Point(16, 15);
            this.gbConnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConnexion.Name = "gbConnexion";
            this.gbConnexion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConnexion.Size = new System.Drawing.Size(363, 142);
            this.gbConnexion.TabIndex = 6;
            this.gbConnexion.TabStop = false;
            this.gbConnexion.Text = "Paramètres d\'authentification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de Passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Utilisateur";
            // 
            // txtMotPasse
            // 
            this.txtMotPasse.Location = new System.Drawing.Point(131, 73);
            this.txtMotPasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.Size = new System.Drawing.Size(192, 22);
            this.txtMotPasse.TabIndex = 5;
            this.txtMotPasse.UseSystemPasswordChar = true;
            // 
            // txtIDUtilisateur
            // 
            this.txtIDUtilisateur.Location = new System.Drawing.Point(131, 30);
            this.txtIDUtilisateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDUtilisateur.Name = "txtIDUtilisateur";
            this.txtIDUtilisateur.Size = new System.Drawing.Size(192, 22);
            this.txtIDUtilisateur.TabIndex = 4;
            // 
            // erpConnexion
            // 
            this.erpConnexion.ContainerControl = this;
            // 
            // FrmConnexion
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbandonner;
            this.ClientSize = new System.Drawing.Size(422, 265);
            this.ControlBox = false;
            this.Controls.Add(this.gbConnexion);
            this.Controls.Add(this.btnAbandonner);
            this.Controls.Add(this.btnValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Identifiez-vous ";
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            this.Shown += new System.EventHandler(this.FrmConnexion_Shown);
            this.gbConnexion.ResumeLayout(false);
            this.gbConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpConnexion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAbandonner;
        private System.Windows.Forms.GroupBox gbConnexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotPasse;
        private System.Windows.Forms.TextBox txtIDUtilisateur;
        private System.Windows.Forms.ErrorProvider erpConnexion;
    }
}