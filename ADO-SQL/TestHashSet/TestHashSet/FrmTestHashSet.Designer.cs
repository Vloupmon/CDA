namespace TestHashSet
{
    partial class FrmTestHashSet
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
            this.txtListe1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListe2 = new System.Windows.Forms.TextBox();
            this.gbMethodes = new System.Windows.Forms.GroupBox();
            this.rdSymmetricExceptWith = new System.Windows.Forms.RadioButton();
            this.rdExceptWith = new System.Windows.Forms.RadioButton();
            this.rdIntersectWith = new System.Windows.Forms.RadioButton();
            this.rdUnionWith = new System.Windows.Forms.RadioButton();
            this.txtDescMethode = new System.Windows.Forms.TextBox();
            this.txtListeResultat = new System.Windows.Forms.TextBox();
            this.gbMethodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtListe1
            // 
            this.txtListe1.Location = new System.Drawing.Point(191, 59);
            this.txtListe1.Name = "txtListe1";
            this.txtListe1.ReadOnly = true;
            this.txtListe1.Size = new System.Drawing.Size(791, 22);
            this.txtListe1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HashSet 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "HashSet 2";
            // 
            // txtListe2
            // 
            this.txtListe2.Location = new System.Drawing.Point(191, 116);
            this.txtListe2.Name = "txtListe2";
            this.txtListe2.ReadOnly = true;
            this.txtListe2.Size = new System.Drawing.Size(791, 22);
            this.txtListe2.TabIndex = 2;
            // 
            // gbMethodes
            // 
            this.gbMethodes.Controls.Add(this.rdSymmetricExceptWith);
            this.gbMethodes.Controls.Add(this.rdExceptWith);
            this.gbMethodes.Controls.Add(this.rdIntersectWith);
            this.gbMethodes.Controls.Add(this.rdUnionWith);
            this.gbMethodes.Location = new System.Drawing.Point(79, 181);
            this.gbMethodes.Name = "gbMethodes";
            this.gbMethodes.Size = new System.Drawing.Size(302, 215);
            this.gbMethodes.TabIndex = 4;
            this.gbMethodes.TabStop = false;
            this.gbMethodes.Text = "Méthodes de fusion";
            // 
            // rdSymmetricExceptWith
            // 
            this.rdSymmetricExceptWith.AutoSize = true;
            this.rdSymmetricExceptWith.Location = new System.Drawing.Point(49, 171);
            this.rdSymmetricExceptWith.Name = "rdSymmetricExceptWith";
            this.rdSymmetricExceptWith.Size = new System.Drawing.Size(164, 21);
            this.rdSymmetricExceptWith.TabIndex = 3;
            this.rdSymmetricExceptWith.TabStop = true;
            this.rdSymmetricExceptWith.Text = "SymmetricExceptWith";
            this.rdSymmetricExceptWith.UseVisualStyleBackColor = true;
            this.rdSymmetricExceptWith.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rdExceptWith
            // 
            this.rdExceptWith.AutoSize = true;
            this.rdExceptWith.Location = new System.Drawing.Point(49, 126);
            this.rdExceptWith.Name = "rdExceptWith";
            this.rdExceptWith.Size = new System.Drawing.Size(99, 21);
            this.rdExceptWith.TabIndex = 2;
            this.rdExceptWith.TabStop = true;
            this.rdExceptWith.Text = "ExceptWith";
            this.rdExceptWith.UseVisualStyleBackColor = true;
            this.rdExceptWith.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rdIntersectWith
            // 
            this.rdIntersectWith.AutoSize = true;
            this.rdIntersectWith.Location = new System.Drawing.Point(49, 84);
            this.rdIntersectWith.Name = "rdIntersectWith";
            this.rdIntersectWith.Size = new System.Drawing.Size(111, 21);
            this.rdIntersectWith.TabIndex = 1;
            this.rdIntersectWith.TabStop = true;
            this.rdIntersectWith.Text = "IntersectWith";
            this.rdIntersectWith.UseVisualStyleBackColor = true;
            this.rdIntersectWith.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rdUnionWith
            // 
            this.rdUnionWith.AutoSize = true;
            this.rdUnionWith.Location = new System.Drawing.Point(49, 42);
            this.rdUnionWith.Name = "rdUnionWith";
            this.rdUnionWith.Size = new System.Drawing.Size(94, 21);
            this.rdUnionWith.TabIndex = 0;
            this.rdUnionWith.TabStop = true;
            this.rdUnionWith.Text = "UnionWith";
            this.rdUnionWith.UseVisualStyleBackColor = true;
            this.rdUnionWith.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // txtDescMethode
            // 
            this.txtDescMethode.Location = new System.Drawing.Point(445, 191);
            this.txtDescMethode.Multiline = true;
            this.txtDescMethode.Name = "txtDescMethode";
            this.txtDescMethode.ReadOnly = true;
            this.txtDescMethode.Size = new System.Drawing.Size(537, 114);
            this.txtDescMethode.TabIndex = 5;
            // 
            // txtListeResultat
            // 
            this.txtListeResultat.Location = new System.Drawing.Point(445, 336);
            this.txtListeResultat.Name = "txtListeResultat";
            this.txtListeResultat.ReadOnly = true;
            this.txtListeResultat.Size = new System.Drawing.Size(545, 22);
            this.txtListeResultat.TabIndex = 6;
            // 
            // FrmTestHashSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 619);
            this.Controls.Add(this.txtDescMethode);
            this.Controls.Add(this.gbMethodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtListeResultat);
            this.Controls.Add(this.txtListe2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListe1);
            this.Name = "FrmTestHashSet";
            this.Text = "Les mécanismes de fusion de HashSet";
            this.gbMethodes.ResumeLayout(false);
            this.gbMethodes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListe2;
        private System.Windows.Forms.GroupBox gbMethodes;
        private System.Windows.Forms.RadioButton rdSymmetricExceptWith;
        private System.Windows.Forms.RadioButton rdExceptWith;
        private System.Windows.Forms.RadioButton rdIntersectWith;
        private System.Windows.Forms.RadioButton rdUnionWith;
        private System.Windows.Forms.TextBox txtDescMethode;
        private System.Windows.Forms.TextBox txtListeResultat;
    }
}

