namespace GestionSalaraies
{
    partial class DialConnexion
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
            this.gbxParamIdentif = new System.Windows.Forms.GroupBox();
            this.lblMDP = new System.Windows.Forms.Label();
            this.lblNomUtil = new System.Windows.Forms.Label();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.epUtilisateur = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxParamIdentif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxParamIdentif
            // 
            this.gbxParamIdentif.Controls.Add(this.lblMDP);
            this.gbxParamIdentif.Controls.Add(this.lblNomUtil);
            this.gbxParamIdentif.Controls.Add(this.txtMDP);
            this.gbxParamIdentif.Controls.Add(this.txtIdentifiant);
            this.gbxParamIdentif.Location = new System.Drawing.Point(13, 13);
            this.gbxParamIdentif.Name = "gbxParamIdentif";
            this.gbxParamIdentif.Size = new System.Drawing.Size(298, 126);
            this.gbxParamIdentif.TabIndex = 0;
            this.gbxParamIdentif.TabStop = false;
            this.gbxParamIdentif.Text = "Paramètres d\'identification";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(39, 77);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(71, 13);
            this.lblMDP.TabIndex = 3;
            this.lblMDP.Text = "Mot de passe";
            // 
            // lblNomUtil
            // 
            this.lblNomUtil.AutoSize = true;
            this.lblNomUtil.Location = new System.Drawing.Point(39, 35);
            this.lblNomUtil.Name = "lblNomUtil";
            this.lblNomUtil.Size = new System.Drawing.Size(56, 13);
            this.lblNomUtil.TabIndex = 2;
            this.lblNomUtil.Text = "Identifiant ";
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(124, 74);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(136, 20);
            this.txtMDP.TabIndex = 1;
            this.txtMDP.Tag = "MDP";
            this.txtMDP.Validating += new System.ComponentModel.CancelEventHandler(this.txtMDP_Validating);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(124, 32);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(136, 20);
            this.txtIdentifiant.TabIndex = 0;
            this.txtIdentifiant.Tag = "";
            this.txtIdentifiant.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdentifiant_Validating);
            // 
            // btnConnexion
            // 
            this.btnConnexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConnexion.Location = new System.Drawing.Point(13, 178);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(109, 23);
            this.btnConnexion.TabIndex = 1;
            this.btnConnexion.Text = "&Connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.CausesValidation = false;
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(200, 177);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(111, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // epUtilisateur
            // 
            this.epUtilisateur.ContainerControl = this;
            // 
            // DialConnexion
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(323, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.gbxParamIdentif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identifiez-vous";
            this.gbxParamIdentif.ResumeLayout(false);
            this.gbxParamIdentif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox gbxParamIdentif;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Label lblNomUtil;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ErrorProvider epUtilisateur;
    }
}