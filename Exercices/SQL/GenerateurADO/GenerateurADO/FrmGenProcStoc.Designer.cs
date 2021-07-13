namespace GenerateurADO
{
    partial class FrmGenProcStoc
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.ckConcurrence = new System.Windows.Forms.CheckBox();
            this.ckbSuppression = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCatalogue = new System.Windows.Forms.TextBox();
            this.txtServeur = new System.Windows.Forms.TextBox();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.tcProcedures = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExecuterInsertion = new System.Windows.Forms.Button();
            this.rtxtInsertion = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExecuterModification = new System.Windows.Forms.Button();
            this.rtxtModification = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExecuterSuppression = new System.Windows.Forms.Button();
            this.rtxtSuppression = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordinalPosKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsKey = new System.Windows.Forms.BindingSource(this.components);
            this.dgvColonnes = new System.Windows.Forms.DataGridView();
            this.ordinalPosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isIdentityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptNullDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bdsColonnes = new System.Windows.Forms.BindingSource(this.components);
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.bdsTables = new System.Windows.Forms.BindingSource(this.components);
            this.lvHisto = new System.Windows.Forms.ListView();
            this.Table = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Operation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Resultat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageErreur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenererServeurScripts = new System.Windows.Forms.Button();
            this.btnGenererAllProcStock = new System.Windows.Forms.Button();
            this.btnEffacerHistorique = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbParametres.SuspendLayout();
            this.tcProcedures.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsColonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTables)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametres
            // 
            this.gbParametres.Controls.Add(this.label3);
            this.gbParametres.Controls.Add(this.txtAuteur);
            this.gbParametres.Controls.Add(this.ckConcurrence);
            this.gbParametres.Controls.Add(this.ckbSuppression);
            this.gbParametres.Controls.Add(this.label2);
            this.gbParametres.Controls.Add(this.label1);
            this.gbParametres.Controls.Add(this.TxtCatalogue);
            this.gbParametres.Controls.Add(this.txtServeur);
            this.gbParametres.Location = new System.Drawing.Point(37, 13);
            this.gbParametres.Margin = new System.Windows.Forms.Padding(4);
            this.gbParametres.Name = "gbParametres";
            this.gbParametres.Padding = new System.Windows.Forms.Padding(4);
            this.gbParametres.Size = new System.Drawing.Size(399, 239);
            this.gbParametres.TabIndex = 0;
            this.gbParametres.TabStop = false;
            this.gbParametres.Text = "Paramètres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Auteur :";
            // 
            // txtAuteur
            // 
            this.txtAuteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GenerateurADO.Properties.Settings.Default, "Auteur", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAuteur.Location = new System.Drawing.Point(97, 187);
            this.txtAuteur.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(252, 22);
            this.txtAuteur.TabIndex = 3;
            this.txtAuteur.Text = global::GenerateurADO.Properties.Settings.Default.Auteur;
            // 
            // ckConcurrence
            // 
            this.ckConcurrence.AutoSize = true;
            this.ckConcurrence.Checked = true;
            this.ckConcurrence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckConcurrence.Location = new System.Drawing.Point(27, 151);
            this.ckConcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.ckConcurrence.Name = "ckConcurrence";
            this.ckConcurrence.Size = new System.Drawing.Size(231, 21);
            this.ckConcurrence.TabIndex = 2;
            this.ckConcurrence.Text = "MAJ Concurrentielle TimeStamp";
            this.ckConcurrence.UseVisualStyleBackColor = true;
            // 
            // ckbSuppression
            // 
            this.ckbSuppression.AutoSize = true;
            this.ckbSuppression.Checked = true;
            this.ckbSuppression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSuppression.Location = new System.Drawing.Point(27, 123);
            this.ckbSuppression.Margin = new System.Windows.Forms.Padding(4);
            this.ckbSuppression.Name = "ckbSuppression";
            this.ckbSuppression.Size = new System.Drawing.Size(178, 21);
            this.ckbSuppression.TabIndex = 2;
            this.ckbSuppression.Text = "Suppression des objets";
            this.ckbSuppression.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catalogue :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serveur :";
            // 
            // TxtCatalogue
            // 
            this.TxtCatalogue.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GenerateurADO.Properties.Settings.Default, "Catalogue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtCatalogue.Location = new System.Drawing.Point(97, 65);
            this.TxtCatalogue.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCatalogue.Name = "TxtCatalogue";
            this.TxtCatalogue.Size = new System.Drawing.Size(252, 22);
            this.TxtCatalogue.TabIndex = 0;
            this.TxtCatalogue.Text = global::GenerateurADO.Properties.Settings.Default.Catalogue;
            // 
            // txtServeur
            // 
            this.txtServeur.Location = new System.Drawing.Point(97, 27);
            this.txtServeur.Margin = new System.Windows.Forms.Padding(4);
            this.txtServeur.Name = "txtServeur";
            this.txtServeur.Size = new System.Drawing.Size(252, 22);
            this.txtServeur.TabIndex = 0;
            this.txtServeur.Text = "(local)";
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(37, 274);
            this.btnInitialiser.Margin = new System.Windows.Forms.Padding(4);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(243, 28);
            this.btnInitialiser.TabIndex = 2;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // tcProcedures
            // 
            this.tcProcedures.Controls.Add(this.tabPage1);
            this.tcProcedures.Controls.Add(this.tabPage2);
            this.tcProcedures.Controls.Add(this.tabPage3);
            this.tcProcedures.Controls.Add(this.tabPage4);
            this.tcProcedures.Location = new System.Drawing.Point(527, 24);
            this.tcProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.tcProcedures.Name = "tcProcedures";
            this.tcProcedures.SelectedIndex = 0;
            this.tcProcedures.Size = new System.Drawing.Size(857, 517);
            this.tcProcedures.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExecuterInsertion);
            this.tabPage1.Controls.Add(this.rtxtInsertion);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(849, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExecuterInsertion
            // 
            this.btnExecuterInsertion.Location = new System.Drawing.Point(23, 416);
            this.btnExecuterInsertion.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecuterInsertion.Name = "btnExecuterInsertion";
            this.btnExecuterInsertion.Size = new System.Drawing.Size(257, 28);
            this.btnExecuterInsertion.TabIndex = 1;
            this.btnExecuterInsertion.Text = "Executer Serveur";
            this.btnExecuterInsertion.UseVisualStyleBackColor = true;
            this.btnExecuterInsertion.Click += new System.EventHandler(this.GenererScriptServeur);
            // 
            // rtxtInsertion
            // 
            this.rtxtInsertion.Location = new System.Drawing.Point(23, 21);
            this.rtxtInsertion.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtInsertion.Name = "rtxtInsertion";
            this.rtxtInsertion.Size = new System.Drawing.Size(784, 323);
            this.rtxtInsertion.TabIndex = 0;
            this.rtxtInsertion.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExecuterModification);
            this.tabPage2.Controls.Add(this.rtxtModification);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(849, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modification";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExecuterModification
            // 
            this.btnExecuterModification.Location = new System.Drawing.Point(29, 372);
            this.btnExecuterModification.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecuterModification.Name = "btnExecuterModification";
            this.btnExecuterModification.Size = new System.Drawing.Size(257, 28);
            this.btnExecuterModification.TabIndex = 3;
            this.btnExecuterModification.Text = "Executer Serveur";
            this.btnExecuterModification.UseVisualStyleBackColor = true;
            this.btnExecuterModification.Click += new System.EventHandler(this.GenererScriptServeur);
            // 
            // rtxtModification
            // 
            this.rtxtModification.Location = new System.Drawing.Point(29, 21);
            this.rtxtModification.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtModification.Name = "rtxtModification";
            this.rtxtModification.Size = new System.Drawing.Size(784, 323);
            this.rtxtModification.TabIndex = 2;
            this.rtxtModification.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnExecuterSuppression);
            this.tabPage3.Controls.Add(this.rtxtSuppression);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(849, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suppression";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExecuterSuppression
            // 
            this.btnExecuterSuppression.Location = new System.Drawing.Point(29, 416);
            this.btnExecuterSuppression.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecuterSuppression.Name = "btnExecuterSuppression";
            this.btnExecuterSuppression.Size = new System.Drawing.Size(257, 28);
            this.btnExecuterSuppression.TabIndex = 3;
            this.btnExecuterSuppression.Text = "Executer Serveur";
            this.btnExecuterSuppression.UseVisualStyleBackColor = true;
            this.btnExecuterSuppression.Click += new System.EventHandler(this.GenererScriptServeur);
            // 
            // rtxtSuppression
            // 
            this.rtxtSuppression.Location = new System.Drawing.Point(29, 21);
            this.rtxtSuppression.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtSuppression.Name = "rtxtSuppression";
            this.rtxtSuppression.Size = new System.Drawing.Size(784, 323);
            this.rtxtSuppression.TabIndex = 2;
            this.rtxtSuppression.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.dgvColonnes);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(849, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Infos Table";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordinalPosKeyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bdsKey;
            this.dataGridView1.Location = new System.Drawing.Point(33, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(491, 185);
            this.dataGridView1.TabIndex = 1;
            // 
            // ordinalPosKeyDataGridViewTextBoxColumn
            // 
            this.ordinalPosKeyDataGridViewTextBoxColumn.DataPropertyName = "OrdinalPosKey";
            this.ordinalPosKeyDataGridViewTextBoxColumn.HeaderText = "OrdinalPosKey";
            this.ordinalPosKeyDataGridViewTextBoxColumn.Name = "ordinalPosKeyDataGridViewTextBoxColumn";
            this.ordinalPosKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bdsKey
            // 
            this.bdsKey.DataSource = typeof(GerenateurProcStoc.KeyColumn);
            // 
            // dgvColonnes
            // 
            this.dgvColonnes.AllowUserToAddRows = false;
            this.dgvColonnes.AllowUserToDeleteRows = false;
            this.dgvColonnes.AutoGenerateColumns = false;
            this.dgvColonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColonnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordinalPosDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.isIdentityDataGridViewCheckBoxColumn,
            this.acceptNullDataGridViewCheckBoxColumn});
            this.dgvColonnes.DataSource = this.bdsColonnes;
            this.dgvColonnes.Location = new System.Drawing.Point(33, 27);
            this.dgvColonnes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvColonnes.Name = "dgvColonnes";
            this.dgvColonnes.ReadOnly = true;
            this.dgvColonnes.Size = new System.Drawing.Size(857, 185);
            this.dgvColonnes.TabIndex = 0;
            // 
            // ordinalPosDataGridViewTextBoxColumn
            // 
            this.ordinalPosDataGridViewTextBoxColumn.DataPropertyName = "OrdinalPos";
            this.ordinalPosDataGridViewTextBoxColumn.HeaderText = "OrdinalPos";
            this.ordinalPosDataGridViewTextBoxColumn.Name = "ordinalPosDataGridViewTextBoxColumn";
            this.ordinalPosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isIdentityDataGridViewCheckBoxColumn
            // 
            this.isIdentityDataGridViewCheckBoxColumn.DataPropertyName = "IsIdentity";
            this.isIdentityDataGridViewCheckBoxColumn.HeaderText = "IsIdentity";
            this.isIdentityDataGridViewCheckBoxColumn.Name = "isIdentityDataGridViewCheckBoxColumn";
            this.isIdentityDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // acceptNullDataGridViewCheckBoxColumn
            // 
            this.acceptNullDataGridViewCheckBoxColumn.DataPropertyName = "AcceptNull";
            this.acceptNullDataGridViewCheckBoxColumn.HeaderText = "AcceptNull";
            this.acceptNullDataGridViewCheckBoxColumn.Name = "acceptNullDataGridViewCheckBoxColumn";
            this.acceptNullDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bdsColonnes
            // 
            this.bdsColonnes.AllowNew = false;
            this.bdsColonnes.DataSource = typeof(GerenateurProcStoc.Column);
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
            this.tableDataGridView.Location = new System.Drawing.Point(37, 327);
            this.tableDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.Size = new System.Drawing.Size(351, 453);
            this.tableDataGridView.TabIndex = 3;
            this.tableDataGridView.SelectionChanged += new System.EventHandler(this.tableDataGridView_SelectionChanged);
            // 
            // bdsTables
            // 
            this.bdsTables.DataSource = typeof(GerenateurProcStoc.Table);
            // 
            // lvHisto
            // 
            this.lvHisto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Table,
            this.Operation,
            this.Resultat,
            this.MessageErreur});
            this.lvHisto.Location = new System.Drawing.Point(531, 691);
            this.lvHisto.Margin = new System.Windows.Forms.Padding(4);
            this.lvHisto.Name = "lvHisto";
            this.lvHisto.Size = new System.Drawing.Size(853, 170);
            this.lvHisto.TabIndex = 4;
            this.lvHisto.UseCompatibleStateImageBehavior = false;
            this.lvHisto.View = System.Windows.Forms.View.Details;
            // 
            // Table
            // 
            this.Table.Text = "Table";
            this.Table.Width = 120;
            // 
            // Operation
            // 
            this.Operation.Text = "Type Proc";
            this.Operation.Width = 100;
            // 
            // Resultat
            // 
            this.Resultat.Text = "Resultat";
            // 
            // MessageErreur
            // 
            this.MessageErreur.Text = "Message si erreur";
            this.MessageErreur.Width = 350;
            // 
            // btnGenererServeurScripts
            // 
            this.btnGenererServeurScripts.Location = new System.Drawing.Point(554, 549);
            this.btnGenererServeurScripts.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenererServeurScripts.Name = "btnGenererServeurScripts";
            this.btnGenererServeurScripts.Size = new System.Drawing.Size(620, 28);
            this.btnGenererServeurScripts.TabIndex = 5;
            this.btnGenererServeurScripts.Text = "Executer Serveur Insertion, Modification , Suppression pour cette table";
            this.btnGenererServeurScripts.UseVisualStyleBackColor = true;
            this.btnGenererServeurScripts.Click += new System.EventHandler(this.btnGenererServeurScripts_Click);
            // 
            // btnGenererAllProcStock
            // 
            this.btnGenererAllProcStock.Location = new System.Drawing.Point(554, 598);
            this.btnGenererAllProcStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenererAllProcStock.Name = "btnGenererAllProcStock";
            this.btnGenererAllProcStock.Size = new System.Drawing.Size(620, 28);
            this.btnGenererAllProcStock.TabIndex = 5;
            this.btnGenererAllProcStock.Text = "Générer les procédures stockées de chaque table";
            this.btnGenererAllProcStock.UseVisualStyleBackColor = true;
            this.btnGenererAllProcStock.Click += new System.EventHandler(this.btnGenererAllProcStock_Click);
            // 
            // btnEffacerHistorique
            // 
            this.btnEffacerHistorique.Location = new System.Drawing.Point(554, 641);
            this.btnEffacerHistorique.Margin = new System.Windows.Forms.Padding(4);
            this.btnEffacerHistorique.Name = "btnEffacerHistorique";
            this.btnEffacerHistorique.Size = new System.Drawing.Size(211, 28);
            this.btnEffacerHistorique.TabIndex = 6;
            this.btnEffacerHistorique.Text = "Effacer Historique";
            this.btnEffacerHistorique.UseVisualStyleBackColor = true;
            this.btnEffacerHistorique.Click += new System.EventHandler(this.btnEffacerHistorique_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Schema";
            this.dataGridViewTextBoxColumn2.HeaderText = "Schema";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FrmGenProcStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 865);
            this.Controls.Add(this.btnEffacerHistorique);
            this.Controls.Add(this.btnGenererAllProcStock);
            this.Controls.Add(this.btnGenererServeurScripts);
            this.Controls.Add(this.lvHisto);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.tcProcedures);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.gbParametres);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGenProcStoc";
            this.Text = "Générateur de procédures stockées";
            this.gbParametres.ResumeLayout(false);
            this.gbParametres.PerformLayout();
            this.tcProcedures.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsColonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametres;
        private System.Windows.Forms.CheckBox ckConcurrence;
        private System.Windows.Forms.CheckBox ckbSuppression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCatalogue;
        private System.Windows.Forms.TextBox txtServeur;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.TabControl tcProcedures;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExecuterInsertion;
        private System.Windows.Forms.RichTextBox rtxtInsertion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExecuterModification;
        private System.Windows.Forms.RichTextBox rtxtModification;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExecuterSuppression;
        private System.Windows.Forms.RichTextBox rtxtSuppression;
        private System.Windows.Forms.BindingSource bdsTables;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordinalPosKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bdsKey;
        private System.Windows.Forms.DataGridView dgvColonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordinalPosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isIdentityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptNullDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource bdsColonnes;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.ListView lvHisto;
        private System.Windows.Forms.Button btnGenererServeurScripts;
        private System.Windows.Forms.Button btnGenererAllProcStock;
        private System.Windows.Forms.ColumnHeader Table;
        private System.Windows.Forms.ColumnHeader Operation;
        private System.Windows.Forms.ColumnHeader Resultat;
        private System.Windows.Forms.ColumnHeader MessageErreur;
        private System.Windows.Forms.Button btnEffacerHistorique;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}