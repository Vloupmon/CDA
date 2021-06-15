namespace Bibliotheque.UI.Winforms
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
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adherentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(316, 562);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(94, 48);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(186, 562);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 48);
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
            this.adherentDataGridView.Location = new System.Drawing.Point(186, 92);
            this.adherentDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adherentDataGridView.Name = "adherentDataGridView";
            this.adherentDataGridView.ReadOnly = true;
            this.adherentDataGridView.RowHeadersWidth = 62;
            this.adherentDataGridView.RowTemplate.Height = 24;
            this.adherentDataGridView.Size = new System.Drawing.Size(628, 412);
            this.adherentDataGridView.TabIndex = 3;
            this.adherentDataGridView.DoubleClick += new System.EventHandler(this.adherentDataGridView_DoubleClick);
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            // 
            // adherentIDDataGridViewTextBoxColumn
            // 
            this.adherentIDDataGridViewTextBoxColumn.DataPropertyName = "AdherentID";
            this.adherentIDDataGridViewTextBoxColumn.HeaderText = "ID Adhérent";
            this.adherentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adherentIDDataGridViewTextBoxColumn.Name = "adherentIDDataGridViewTextBoxColumn";
            this.adherentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.adherentIDDataGridViewTextBoxColumn.Width = 144;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 88;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 110;
            // 
            // FrmRecAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 703);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.adherentDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRecAdherent";
            this.Text = "Rechercher Adhérent";
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