namespace projeto2023.views.fornecedores
{
    partial class consulta_fornecedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtv_fornecedores = new System.Windows.Forms.DataGridView();
            this.codigoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefantasiaFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoEstadualFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoMunicipalFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representanteFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciocontratoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1_FORNECEDORES = new projeto2023.EstampariadbDataSet1_FORNECEDORES();
            this.fornecedoresTableAdapter = new projeto2023.EstampariadbDataSet1_FORNECEDORESTableAdapters.FornecedoresTableAdapter();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_fornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_FORNECEDORES)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtv_fornecedores);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 426);
            this.panel1.TabIndex = 10;
            // 
            // dtv_fornecedores
            // 
            this.dtv_fornecedores.AutoGenerateColumns = false;
            this.dtv_fornecedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.dtv_fornecedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtv_fornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtv_fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_fornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoFornecedorDataGridViewTextBoxColumn,
            this.nomefantasiaFornecedorDataGridViewTextBoxColumn,
            this.razaosocialFornecedorDataGridViewTextBoxColumn,
            this.cnpjFornecedorDataGridViewTextBoxColumn,
            this.inscricaoEstadualFornecedorDataGridViewTextBoxColumn,
            this.inscricaoMunicipalFornecedorDataGridViewTextBoxColumn,
            this.cepFornecedorDataGridViewTextBoxColumn,
            this.enderecoFornecedorDataGridViewTextBoxColumn,
            this.numeroFornecedorDataGridViewTextBoxColumn,
            this.cidadeFornecedorDataGridViewTextBoxColumn,
            this.estadoFornecedorDataGridViewTextBoxColumn,
            this.representanteFornecedorDataGridViewTextBoxColumn,
            this.emailFornecedorDataGridViewTextBoxColumn,
            this.telefoneFornecedorDataGridViewTextBoxColumn,
            this.iniciocontratoFornecedorDataGridViewTextBoxColumn,
            this.statusFornecedorDataGridViewTextBoxColumn});
            this.dtv_fornecedores.DataSource = this.fornecedoresBindingSource;
            this.dtv_fornecedores.GridColor = System.Drawing.Color.DarkGray;
            this.dtv_fornecedores.Location = new System.Drawing.Point(0, 4);
            this.dtv_fornecedores.Name = "dtv_fornecedores";
            this.dtv_fornecedores.ReadOnly = true;
            this.dtv_fornecedores.Size = new System.Drawing.Size(1338, 401);
            this.dtv_fornecedores.TabIndex = 8;
            // 
            // codigoFornecedorDataGridViewTextBoxColumn
            // 
            this.codigoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_Fornecedor";
            this.codigoFornecedorDataGridViewTextBoxColumn.HeaderText = "codigo_Fornecedor";
            this.codigoFornecedorDataGridViewTextBoxColumn.Name = "codigoFornecedorDataGridViewTextBoxColumn";
            this.codigoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefantasiaFornecedorDataGridViewTextBoxColumn
            // 
            this.nomefantasiaFornecedorDataGridViewTextBoxColumn.DataPropertyName = "nomefantasia_Fornecedor";
            this.nomefantasiaFornecedorDataGridViewTextBoxColumn.HeaderText = "nomefantasia_Fornecedor";
            this.nomefantasiaFornecedorDataGridViewTextBoxColumn.Name = "nomefantasiaFornecedorDataGridViewTextBoxColumn";
            this.nomefantasiaFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaosocialFornecedorDataGridViewTextBoxColumn
            // 
            this.razaosocialFornecedorDataGridViewTextBoxColumn.DataPropertyName = "razaosocial_Fornecedor";
            this.razaosocialFornecedorDataGridViewTextBoxColumn.HeaderText = "razaosocial_Fornecedor";
            this.razaosocialFornecedorDataGridViewTextBoxColumn.Name = "razaosocialFornecedorDataGridViewTextBoxColumn";
            this.razaosocialFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpjFornecedorDataGridViewTextBoxColumn
            // 
            this.cnpjFornecedorDataGridViewTextBoxColumn.DataPropertyName = "cnpj_Fornecedor";
            this.cnpjFornecedorDataGridViewTextBoxColumn.HeaderText = "cnpj_Fornecedor";
            this.cnpjFornecedorDataGridViewTextBoxColumn.Name = "cnpjFornecedorDataGridViewTextBoxColumn";
            this.cnpjFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscricaoEstadualFornecedorDataGridViewTextBoxColumn
            // 
            this.inscricaoEstadualFornecedorDataGridViewTextBoxColumn.DataPropertyName = "inscricaoEstadual_Fornecedor";
            this.inscricaoEstadualFornecedorDataGridViewTextBoxColumn.HeaderText = "inscricaoEstadual_Fornecedor";
            this.inscricaoEstadualFornecedorDataGridViewTextBoxColumn.Name = "inscricaoEstadualFornecedorDataGridViewTextBoxColumn";
            this.inscricaoEstadualFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscricaoMunicipalFornecedorDataGridViewTextBoxColumn
            // 
            this.inscricaoMunicipalFornecedorDataGridViewTextBoxColumn.DataPropertyName = "inscricaoMunicipal_Fornecedor";
            this.inscricaoMunicipalFornecedorDataGridViewTextBoxColumn.HeaderText = "inscricaoMunicipal_Fornecedor";
            this.inscricaoMunicipalFornecedorDataGridViewTextBoxColumn.Name = "inscricaoMunicipalFornecedorDataGridViewTextBoxColumn";
            this.inscricaoMunicipalFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepFornecedorDataGridViewTextBoxColumn
            // 
            this.cepFornecedorDataGridViewTextBoxColumn.DataPropertyName = "cep_Fornecedor";
            this.cepFornecedorDataGridViewTextBoxColumn.HeaderText = "cep_Fornecedor";
            this.cepFornecedorDataGridViewTextBoxColumn.Name = "cepFornecedorDataGridViewTextBoxColumn";
            this.cepFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoFornecedorDataGridViewTextBoxColumn
            // 
            this.enderecoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "endereco_Fornecedor";
            this.enderecoFornecedorDataGridViewTextBoxColumn.HeaderText = "endereco_Fornecedor";
            this.enderecoFornecedorDataGridViewTextBoxColumn.Name = "enderecoFornecedorDataGridViewTextBoxColumn";
            this.enderecoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroFornecedorDataGridViewTextBoxColumn
            // 
            this.numeroFornecedorDataGridViewTextBoxColumn.DataPropertyName = "numero_Fornecedor";
            this.numeroFornecedorDataGridViewTextBoxColumn.HeaderText = "numero_Fornecedor";
            this.numeroFornecedorDataGridViewTextBoxColumn.Name = "numeroFornecedorDataGridViewTextBoxColumn";
            this.numeroFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeFornecedorDataGridViewTextBoxColumn
            // 
            this.cidadeFornecedorDataGridViewTextBoxColumn.DataPropertyName = "cidade_Fornecedor";
            this.cidadeFornecedorDataGridViewTextBoxColumn.HeaderText = "cidade_Fornecedor";
            this.cidadeFornecedorDataGridViewTextBoxColumn.Name = "cidadeFornecedorDataGridViewTextBoxColumn";
            this.cidadeFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoFornecedorDataGridViewTextBoxColumn
            // 
            this.estadoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "estado_Fornecedor";
            this.estadoFornecedorDataGridViewTextBoxColumn.HeaderText = "estado_Fornecedor";
            this.estadoFornecedorDataGridViewTextBoxColumn.Name = "estadoFornecedorDataGridViewTextBoxColumn";
            this.estadoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // representanteFornecedorDataGridViewTextBoxColumn
            // 
            this.representanteFornecedorDataGridViewTextBoxColumn.DataPropertyName = "representante_Fornecedor";
            this.representanteFornecedorDataGridViewTextBoxColumn.HeaderText = "representante_Fornecedor";
            this.representanteFornecedorDataGridViewTextBoxColumn.Name = "representanteFornecedorDataGridViewTextBoxColumn";
            this.representanteFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailFornecedorDataGridViewTextBoxColumn
            // 
            this.emailFornecedorDataGridViewTextBoxColumn.DataPropertyName = "email_Fornecedor";
            this.emailFornecedorDataGridViewTextBoxColumn.HeaderText = "email_Fornecedor";
            this.emailFornecedorDataGridViewTextBoxColumn.Name = "emailFornecedorDataGridViewTextBoxColumn";
            this.emailFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneFornecedorDataGridViewTextBoxColumn
            // 
            this.telefoneFornecedorDataGridViewTextBoxColumn.DataPropertyName = "telefone_Fornecedor";
            this.telefoneFornecedorDataGridViewTextBoxColumn.HeaderText = "telefone_Fornecedor";
            this.telefoneFornecedorDataGridViewTextBoxColumn.Name = "telefoneFornecedorDataGridViewTextBoxColumn";
            this.telefoneFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iniciocontratoFornecedorDataGridViewTextBoxColumn
            // 
            this.iniciocontratoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "iniciocontrato_Fornecedor";
            this.iniciocontratoFornecedorDataGridViewTextBoxColumn.HeaderText = "iniciocontrato_Fornecedor";
            this.iniciocontratoFornecedorDataGridViewTextBoxColumn.Name = "iniciocontratoFornecedorDataGridViewTextBoxColumn";
            this.iniciocontratoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusFornecedorDataGridViewTextBoxColumn
            // 
            this.statusFornecedorDataGridViewTextBoxColumn.DataPropertyName = "status_Fornecedor";
            this.statusFornecedorDataGridViewTextBoxColumn.HeaderText = "status_Fornecedor";
            this.statusFornecedorDataGridViewTextBoxColumn.Name = "statusFornecedorDataGridViewTextBoxColumn";
            this.statusFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.estampariadbDataSet1_FORNECEDORES;
            // 
            // estampariadbDataSet1_FORNECEDORES
            // 
            this.estampariadbDataSet1_FORNECEDORES.DataSetName = "EstampariadbDataSet1_FORNECEDORES";
            this.estampariadbDataSet1_FORNECEDORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(1049, 490);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 11;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(1223, 490);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 12;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // consulta_fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1368, 525);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.panel1);
            this.Name = "consulta_fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_fornecedores";
            this.Load += new System.EventHandler(this.consulta_fornecedores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_fornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_FORNECEDORES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtv_fornecedores;
        private EstampariadbDataSet1_FORNECEDORES estampariadbDataSet1_FORNECEDORES;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private EstampariadbDataSet1_FORNECEDORESTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefantasiaFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoEstadualFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoMunicipalFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representanteFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciocontratoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_fechar;
    }
}