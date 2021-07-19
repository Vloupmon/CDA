namespace GenerateurADO
{
    partial class FrmGenererCommande
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
            this.gbParametres = new System.Windows.Forms.GroupBox();
            this.btnSaveParametres = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCatalogue = new System.Windows.Forms.TextBox();
            this.txtServeur = new System.Windows.Forms.TextBox();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsTables = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProcStocs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storedProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnClipBoard = new System.Windows.Forms.Button();
            this.bdsKey = new System.Windows.Forms.BindingSource(this.components);
            this.bdsColonnes = new System.Windows.Forms.BindingSource(this.components);
            this.gbParametres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcStocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedProcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsColonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametres
            // 
            this.gbParametres.Controls.Add(this.btnSaveParametres);
            this.gbParametres.Controls.Add(this.label2);
            this.gbParametres.Controls.Add(this.label1);
            this.gbParametres.Controls.Add(this.TxtCatalogue);
            this.gbParametres.Controls.Add(this.txtServeur);
            this.gbParametres.Location = new System.Drawing.Point(42, 15);
            this.gbParametres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbParametres.Name = "gbParametres";
            this.gbParametres.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbParametres.Size = new System.Drawing.Size(566, 252);
            this.gbParametres.TabIndex = 0;
            this.gbParametres.TabStop = false;
            this.gbParametres.Text = "Paramètres";
            // 
            // btnSaveParametres
            // 
            this.btnSaveParametres.Location = new System.Drawing.Point(28, 146);
            this.btnSaveParametres.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveParametres.Name = "btnSaveParametres";
            this.btnSaveParametres.Size = new System.Drawing.Size(264, 72);
            this.btnSaveParametres.TabIndex = 5;
            this.btnSaveParametres.Text = "Sauvegarde Parametres";
            this.btnSaveParametres.UseVisualStyleBackColor = true;
            this.btnSaveParametres.Click += new System.EventHandler(this.BtnSaveParametres_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catalogue :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serveur :";
            // 
            // TxtCatalogue
            // 
            this.TxtCatalogue.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GenerateurADO.Properties.Settings.Default, "Catalogue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtCatalogue.Location = new System.Drawing.Point(110, 83);
            this.TxtCatalogue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCatalogue.Name = "TxtCatalogue";
            this.TxtCatalogue.Size = new System.Drawing.Size(283, 26);
            this.TxtCatalogue.TabIndex = 0;
            this.TxtCatalogue.Text = global::GenerateurADO.Properties.Settings.Default.Catalogue;
            // 
            // txtServeur
            // 
            this.txtServeur.Location = new System.Drawing.Point(110, 34);
            this.txtServeur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServeur.Name = "txtServeur";
            this.txtServeur.Size = new System.Drawing.Size(283, 26);
            this.txtServeur.TabIndex = 0;
            this.txtServeur.Text = "(local)";
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(42, 298);
            this.btnInitialiser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(273, 35);
            this.btnInitialiser.TabIndex = 2;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.BtnInitialiser_Click);
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.tableDataGridView.DataSource = this.bdsTables;
            this.tableDataGridView.Location = new System.Drawing.Point(42, 355);
            this.tableDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.RowHeadersWidth = 62;
            this.tableDataGridView.Size = new System.Drawing.Size(592, 454);
            this.tableDataGridView.TabIndex = 3;
            this.tableDataGridView.Click += new System.EventHandler(this.TableDataGridView_DoubleClick);
            this.tableDataGridView.DoubleClick += new System.EventHandler(this.TableDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Schema";
            this.dataGridViewTextBoxColumn2.HeaderText = "Schema";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 350;
            // 
            // bdsTables
            // 
            this.bdsTables.DataSource = typeof(GerenateurProcStoc.Table);
            // 
            // dgvProcStocs
            // 
            this.dgvProcStocs.AllowUserToAddRows = false;
            this.dgvProcStocs.AllowUserToDeleteRows = false;
            this.dgvProcStocs.AutoGenerateColumns = false;
            this.dgvProcStocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcStocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvProcStocs.DataSource = this.storedProcBindingSource;
            this.dgvProcStocs.Location = new System.Drawing.Point(692, 38);
            this.dgvProcStocs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvProcStocs.Name = "dgvProcStocs";
            this.dgvProcStocs.ReadOnly = true;
            this.dgvProcStocs.RowHeadersWidth = 62;
            this.dgvProcStocs.RowTemplate.Height = 24;
            this.dgvProcStocs.Size = new System.Drawing.Size(614, 231);
            this.dgvProcStocs.TabIndex = 3;
            this.dgvProcStocs.DoubleClick += new System.EventHandler(this.BtnInitialiser_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Schema";
            this.dataGridViewTextBoxColumn4.HeaderText = "Schema";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // storedProcBindingSource
            // 
            this.storedProcBindingSource.DataSource = typeof(GerenateurProcStoc.StoredProc);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(692, 355);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommand.Size = new System.Drawing.Size(854, 454);
            this.txtCommand.TabIndex = 4;
            // 
            // btnClipBoard
            // 
            this.btnClipBoard.Location = new System.Drawing.Point(692, 298);
            this.btnClipBoard.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClipBoard.Name = "btnClipBoard";
            this.btnClipBoard.Size = new System.Drawing.Size(202, 42);
            this.btnClipBoard.TabIndex = 5;
            this.btnClipBoard.Text = "Copier Presse Papier";
            this.btnClipBoard.UseVisualStyleBackColor = true;
            this.btnClipBoard.Click += new System.EventHandler(this.BtnClipBoard_Click);
            // 
            // bdsKey
            // 
            this.bdsKey.DataSource = typeof(GerenateurProcStoc.KeyColumn);
            // 
            // bdsColonnes
            // 
            this.bdsColonnes.AllowNew = false;
            this.bdsColonnes.DataSource = typeof(GerenateurProcStoc.Column);
            // 
            // FrmGenererCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 944);
            this.Controls.Add(this.btnClipBoard);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.dgvProcStocs);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.gbParametres);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGenererCommande";
            this.Text = "Générateur de commandes ";
            this.gbParametres.ResumeLayout(false);
            this.gbParametres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcStocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedProcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsColonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCatalogue;
        private System.Windows.Forms.TextBox txtServeur;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.BindingSource bdsTables;
        private System.Windows.Forms.BindingSource bdsKey;
        private System.Windows.Forms.BindingSource bdsColonnes;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.Button btnSaveParametres;
        private System.Windows.Forms.BindingSource storedProcBindingSource;
        private System.Windows.Forms.DataGridView dgvProcStocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnClipBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}