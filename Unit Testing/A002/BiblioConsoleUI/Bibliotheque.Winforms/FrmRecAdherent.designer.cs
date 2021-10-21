namespace Bibliotheque.Winforms
{
    partial class FrmRecAdherent
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.adherentDataGridView = new System.Windows.Forms.DataGridView();
            this.adherentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(253, 360);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 31);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(149, 360);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 31);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // adherentDataGridView
            // 
            this.adherentDataGridView.AllowUserToAddRows = false;
            this.adherentDataGridView.AllowUserToDeleteRows = false;
            this.adherentDataGridView.AutoGenerateColumns = false;
            this.adherentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.adherentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adherentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adherentIDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.adherentDataGridView.DataSource = this.adherentBindingSource;
            this.adherentDataGridView.Location = new System.Drawing.Point(149, 59);
            this.adherentDataGridView.Name = "adherentDataGridView";
            this.adherentDataGridView.ReadOnly = true;
            this.adherentDataGridView.RowTemplate.Height = 24;
            this.adherentDataGridView.Size = new System.Drawing.Size(502, 264);
            this.adherentDataGridView.TabIndex = 3;
            this.adherentDataGridView.DoubleClick += new System.EventHandler(this.adherentDataGridView_DoubleClick);
            // 
            // adherentIDDataGridViewTextBoxColumn
            // 
            this.adherentIDDataGridViewTextBoxColumn.DataPropertyName = "IdAdherent";
            this.adherentIDDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.adherentIDDataGridViewTextBoxColumn.Name = "adherentIDDataGridViewTextBoxColumn";
            this.adherentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.adherentIDDataGridViewTextBoxColumn.Width = 108;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "NomAdherent";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 66;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "PrenomAdherent";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 86;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            // 
            // FrmRecAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.adherentDataGridView);
            this.Name = "FrmRecAdherent";
            this.Text = "Recherche Adhérent";
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView adherentDataGridView;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn adherentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
    }
}