namespace projeto2023.views.materiais
{
    partial class consulta_materiais
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
            this.dtv_materiais = new System.Windows.Forms.DataGridView();
            this.codigoMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localArmazenamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaAtualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1_MATERIAIS = new projeto2023.EstampariadbDataSet1_MATERIAIS();
            this.materiaisTableAdapter = new projeto2023.EstampariadbDataSet1_MATERIAISTableAdapters.MateriaisTableAdapter();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_materiais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_MATERIAIS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtv_materiais
            // 
            this.dtv_materiais.AllowUserToAddRows = false;
            this.dtv_materiais.AllowUserToDeleteRows = false;
            this.dtv_materiais.AutoGenerateColumns = false;
            this.dtv_materiais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_materiais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoMaterialDataGridViewTextBoxColumn,
            this.codigoFornecedorDataGridViewTextBoxColumn,
            this.nomeMaterialDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.unidadeMedidaDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn,
            this.numeroLoteDataGridViewTextBoxColumn,
            this.localArmazenamentoDataGridViewTextBoxColumn,
            this.quantidadeMaterialDataGridViewTextBoxColumn,
            this.ultimaAtualizacaoDataGridViewTextBoxColumn,
            this.statusmaterialDataGridViewTextBoxColumn});
            this.dtv_materiais.DataSource = this.materiaisBindingSource;
            this.dtv_materiais.Location = new System.Drawing.Point(0, 0);
            this.dtv_materiais.Name = "dtv_materiais";
            this.dtv_materiais.ReadOnly = true;
            this.dtv_materiais.Size = new System.Drawing.Size(1324, 129);
            this.dtv_materiais.TabIndex = 0;
            // 
            // codigoMaterialDataGridViewTextBoxColumn
            // 
            this.codigoMaterialDataGridViewTextBoxColumn.DataPropertyName = "codigo_Material";
            this.codigoMaterialDataGridViewTextBoxColumn.HeaderText = "codigo_Material";
            this.codigoMaterialDataGridViewTextBoxColumn.Name = "codigoMaterialDataGridViewTextBoxColumn";
            this.codigoMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoFornecedorDataGridViewTextBoxColumn
            // 
            this.codigoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_Fornecedor";
            this.codigoFornecedorDataGridViewTextBoxColumn.HeaderText = "codigo_Fornecedor";
            this.codigoFornecedorDataGridViewTextBoxColumn.Name = "codigoFornecedorDataGridViewTextBoxColumn";
            this.codigoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeMaterialDataGridViewTextBoxColumn
            // 
            this.nomeMaterialDataGridViewTextBoxColumn.DataPropertyName = "nome_Material";
            this.nomeMaterialDataGridViewTextBoxColumn.HeaderText = "nome_Material";
            this.nomeMaterialDataGridViewTextBoxColumn.Name = "nomeMaterialDataGridViewTextBoxColumn";
            this.nomeMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadeMedidaDataGridViewTextBoxColumn
            // 
            this.unidadeMedidaDataGridViewTextBoxColumn.DataPropertyName = "unidadeMedida";
            this.unidadeMedidaDataGridViewTextBoxColumn.HeaderText = "unidadeMedida";
            this.unidadeMedidaDataGridViewTextBoxColumn.Name = "unidadeMedidaDataGridViewTextBoxColumn";
            this.unidadeMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "precoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            this.precoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "dataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "dataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroLoteDataGridViewTextBoxColumn
            // 
            this.numeroLoteDataGridViewTextBoxColumn.DataPropertyName = "numeroLote";
            this.numeroLoteDataGridViewTextBoxColumn.HeaderText = "numeroLote";
            this.numeroLoteDataGridViewTextBoxColumn.Name = "numeroLoteDataGridViewTextBoxColumn";
            this.numeroLoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localArmazenamentoDataGridViewTextBoxColumn
            // 
            this.localArmazenamentoDataGridViewTextBoxColumn.DataPropertyName = "localArmazenamento";
            this.localArmazenamentoDataGridViewTextBoxColumn.HeaderText = "localArmazenamento";
            this.localArmazenamentoDataGridViewTextBoxColumn.Name = "localArmazenamentoDataGridViewTextBoxColumn";
            this.localArmazenamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeMaterialDataGridViewTextBoxColumn
            // 
            this.quantidadeMaterialDataGridViewTextBoxColumn.DataPropertyName = "quantidade_Material";
            this.quantidadeMaterialDataGridViewTextBoxColumn.HeaderText = "quantidade_Material";
            this.quantidadeMaterialDataGridViewTextBoxColumn.Name = "quantidadeMaterialDataGridViewTextBoxColumn";
            this.quantidadeMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultimaAtualizacaoDataGridViewTextBoxColumn
            // 
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.DataPropertyName = "UltimaAtualizacao";
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.HeaderText = "UltimaAtualizacao";
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.Name = "ultimaAtualizacaoDataGridViewTextBoxColumn";
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusmaterialDataGridViewTextBoxColumn
            // 
            this.statusmaterialDataGridViewTextBoxColumn.DataPropertyName = "status_material";
            this.statusmaterialDataGridViewTextBoxColumn.HeaderText = "status_material";
            this.statusmaterialDataGridViewTextBoxColumn.Name = "statusmaterialDataGridViewTextBoxColumn";
            this.statusmaterialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaisBindingSource
            // 
            this.materiaisBindingSource.DataMember = "Materiais";
            this.materiaisBindingSource.DataSource = this.estampariadbDataSet1_MATERIAIS;
            // 
            // estampariadbDataSet1_MATERIAIS
            // 
            this.estampariadbDataSet1_MATERIAIS.DataSetName = "EstampariadbDataSet1_MATERIAIS";
            this.estampariadbDataSet1_MATERIAIS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaisTableAdapter
            // 
            this.materiaisTableAdapter.ClearBeforeFill = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(1155, 411);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(185, 63);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(951, 411);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(185, 63);
            this.btn_imprimir.TabIndex = 3;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtv_materiais);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 486);
            this.panel1.TabIndex = 4;
            // 
            // consulta_materiais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1352, 486);
            this.Controls.Add(this.panel1);
            this.Name = "consulta_materiais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_materiais";
            this.Load += new System.EventHandler(this.consulta_materiais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_materiais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_MATERIAIS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_materiais;
        private EstampariadbDataSet1_MATERIAIS estampariadbDataSet1_MATERIAIS;
        private System.Windows.Forms.BindingSource materiaisBindingSource;
        private EstampariadbDataSet1_MATERIAISTableAdapters.MateriaisTableAdapter materiaisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localArmazenamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimaAtualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Panel panel1;
    }
}