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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta_materiais));
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
            this.dtv_materiais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtv_materiais.Name = "dtv_materiais";
            this.dtv_materiais.ReadOnly = true;
            this.dtv_materiais.RowHeadersWidth = 51;
            this.dtv_materiais.Size = new System.Drawing.Size(1765, 159);
            this.dtv_materiais.TabIndex = 0;
            // 
            // codigoMaterialDataGridViewTextBoxColumn
            // 
            this.codigoMaterialDataGridViewTextBoxColumn.DataPropertyName = "codigo_Material";
            this.codigoMaterialDataGridViewTextBoxColumn.HeaderText = "codigo_Material";
            this.codigoMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoMaterialDataGridViewTextBoxColumn.Name = "codigoMaterialDataGridViewTextBoxColumn";
            this.codigoMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoFornecedorDataGridViewTextBoxColumn
            // 
            this.codigoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_Fornecedor";
            this.codigoFornecedorDataGridViewTextBoxColumn.HeaderText = "codigo_Fornecedor";
            this.codigoFornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoFornecedorDataGridViewTextBoxColumn.Name = "codigoFornecedorDataGridViewTextBoxColumn";
            this.codigoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoFornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeMaterialDataGridViewTextBoxColumn
            // 
            this.nomeMaterialDataGridViewTextBoxColumn.DataPropertyName = "nome_Material";
            this.nomeMaterialDataGridViewTextBoxColumn.HeaderText = "nome_Material";
            this.nomeMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeMaterialDataGridViewTextBoxColumn.Name = "nomeMaterialDataGridViewTextBoxColumn";
            this.nomeMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // unidadeMedidaDataGridViewTextBoxColumn
            // 
            this.unidadeMedidaDataGridViewTextBoxColumn.DataPropertyName = "unidadeMedida";
            this.unidadeMedidaDataGridViewTextBoxColumn.HeaderText = "unidadeMedida";
            this.unidadeMedidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadeMedidaDataGridViewTextBoxColumn.Name = "unidadeMedidaDataGridViewTextBoxColumn";
            this.unidadeMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeMedidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "precoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            this.precoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "dataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "dataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEntradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroLoteDataGridViewTextBoxColumn
            // 
            this.numeroLoteDataGridViewTextBoxColumn.DataPropertyName = "numeroLote";
            this.numeroLoteDataGridViewTextBoxColumn.HeaderText = "numeroLote";
            this.numeroLoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroLoteDataGridViewTextBoxColumn.Name = "numeroLoteDataGridViewTextBoxColumn";
            this.numeroLoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroLoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // localArmazenamentoDataGridViewTextBoxColumn
            // 
            this.localArmazenamentoDataGridViewTextBoxColumn.DataPropertyName = "localArmazenamento";
            this.localArmazenamentoDataGridViewTextBoxColumn.HeaderText = "localArmazenamento";
            this.localArmazenamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.localArmazenamentoDataGridViewTextBoxColumn.Name = "localArmazenamentoDataGridViewTextBoxColumn";
            this.localArmazenamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.localArmazenamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeMaterialDataGridViewTextBoxColumn
            // 
            this.quantidadeMaterialDataGridViewTextBoxColumn.DataPropertyName = "quantidade_Material";
            this.quantidadeMaterialDataGridViewTextBoxColumn.HeaderText = "quantidade_Material";
            this.quantidadeMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeMaterialDataGridViewTextBoxColumn.Name = "quantidadeMaterialDataGridViewTextBoxColumn";
            this.quantidadeMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // ultimaAtualizacaoDataGridViewTextBoxColumn
            // 
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.DataPropertyName = "UltimaAtualizacao";
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.HeaderText = "UltimaAtualizacao";
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.Name = "ultimaAtualizacaoDataGridViewTextBoxColumn";
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultimaAtualizacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusmaterialDataGridViewTextBoxColumn
            // 
            this.statusmaterialDataGridViewTextBoxColumn.DataPropertyName = "status_material";
            this.statusmaterialDataGridViewTextBoxColumn.HeaderText = "status_material";
            this.statusmaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusmaterialDataGridViewTextBoxColumn.Name = "statusmaterialDataGridViewTextBoxColumn";
            this.statusmaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusmaterialDataGridViewTextBoxColumn.Width = 125;
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
            this.btn_fechar.Location = new System.Drawing.Point(1540, 506);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(247, 78);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(1268, 506);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(247, 78);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1803, 598);
            this.panel1.TabIndex = 4;
            // 
            // consulta_materiais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1803, 598);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consulta_materiais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Materiais";
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