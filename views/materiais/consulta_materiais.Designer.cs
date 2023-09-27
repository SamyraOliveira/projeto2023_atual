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
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_voltar = new System.Windows.Forms.Label();
            this.mnth_ultimaAtualizacao = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.mnth_dataEntrada = new System.Windows.Forms.MonthCalendar();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.lbl_dataEntrada = new System.Windows.Forms.Label();
            this.txb_quantEntrada = new System.Windows.Forms.TextBox();
            this.cmb_unidadeMedida = new System.Windows.Forms.ComboBox();
            this.cmb_idFornecedor = new System.Windows.Forms.ComboBox();
            this.lbl_quantEntrada = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txb_numeroLote = new System.Windows.Forms.TextBox();
            this.lbl_unidadeMedida = new System.Windows.Forms.Label();
            this.lbl_precoUnit = new System.Windows.Forms.Label();
            this.lbl_nomeMaterial = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_idFornecedor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_precoUnit = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_localArmazenamento = new System.Windows.Forms.ComboBox();
            this.cbox_fornecedores = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpesqForn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_nomeMaterial = new System.Windows.Forms.TextBox();
            this.cod_Material = new System.Windows.Forms.TextBox();
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
            this.dtv_materiais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.dtv_materiais.Location = new System.Drawing.Point(96, 130);
            this.dtv_materiais.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_materiais.Name = "dtv_materiais";
            this.dtv_materiais.ReadOnly = true;
            this.dtv_materiais.RowHeadersWidth = 51;
            this.dtv_materiais.Size = new System.Drawing.Size(1824, 378);
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
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(1766, 515);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(247, 52);
            this.btn_imprimir.TabIndex = 3;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cod_Material);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_voltar);
            this.panel1.Controls.Add(this.mnth_ultimaAtualizacao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.mnth_dataEntrada);
            this.panel1.Controls.Add(this.txb_descricao);
            this.panel1.Controls.Add(this.lbl_dataEntrada);
            this.panel1.Controls.Add(this.txb_nomeMaterial);
            this.panel1.Controls.Add(this.txb_quantEntrada);
            this.panel1.Controls.Add(this.cmb_unidadeMedida);
            this.panel1.Controls.Add(this.cmb_idFornecedor);
            this.panel1.Controls.Add(this.lbl_quantEntrada);
            this.panel1.Controls.Add(this.lbl_descricao);
            this.panel1.Controls.Add(this.txb_numeroLote);
            this.panel1.Controls.Add(this.lbl_unidadeMedida);
            this.panel1.Controls.Add(this.lbl_precoUnit);
            this.panel1.Controls.Add(this.lbl_nomeMaterial);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_idFornecedor);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txb_precoUnit);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.cmb_localArmazenamento);
            this.panel1.Controls.Add(this.cbox_fornecedores);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtpesqForn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtv_materiais);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1055);
            this.panel1.TabIndex = 4;
            // 
            // label_voltar
            // 
            this.label_voltar.AutoSize = true;
            this.label_voltar.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voltar.Location = new System.Drawing.Point(21, 958);
            this.label_voltar.Name = "label_voltar";
            this.label_voltar.Size = new System.Drawing.Size(116, 27);
            this.label_voltar.TabIndex = 161;
            this.label_voltar.Text = "VOLTAR";
            this.label_voltar.Click += new System.EventHandler(this.label_voltar_Click);
            // 
            // mnth_ultimaAtualizacao
            // 
            this.mnth_ultimaAtualizacao.Location = new System.Drawing.Point(380, 812);
            this.mnth_ultimaAtualizacao.Name = "mnth_ultimaAtualizacao";
            this.mnth_ultimaAtualizacao.TabIndex = 160;
            this.mnth_ultimaAtualizacao.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label5.Location = new System.Drawing.Point(387, 787);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 21);
            this.label5.TabIndex = 159;
            this.label5.Text = "---ultima atualizacao";
            this.label5.Visible = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_limpar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_limpar.Location = new System.Drawing.Point(1687, 823);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(129, 58);
            this.btn_limpar.TabIndex = 158;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_salvar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.Location = new System.Drawing.Point(1687, 731);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(129, 58);
            this.btn_salvar.TabIndex = 157;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            // 
            // mnth_dataEntrada
            // 
            this.mnth_dataEntrada.Location = new System.Drawing.Point(380, 574);
            this.mnth_dataEntrada.Name = "mnth_dataEntrada";
            this.mnth_dataEntrada.TabIndex = 156;
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(1338, 674);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(275, 165);
            this.txb_descricao.TabIndex = 153;
            // 
            // lbl_dataEntrada
            // 
            this.lbl_dataEntrada.AutoSize = true;
            this.lbl_dataEntrada.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_dataEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_dataEntrada.Location = new System.Drawing.Point(387, 549);
            this.lbl_dataEntrada.Name = "lbl_dataEntrada";
            this.lbl_dataEntrada.Size = new System.Drawing.Size(162, 21);
            this.lbl_dataEntrada.TabIndex = 140;
            this.lbl_dataEntrada.Text = "Data de Entrada";
            // 
            // txb_quantEntrada
            // 
            this.txb_quantEntrada.Location = new System.Drawing.Point(964, 842);
            this.txb_quantEntrada.Name = "txb_quantEntrada";
            this.txb_quantEntrada.Size = new System.Drawing.Size(130, 22);
            this.txb_quantEntrada.TabIndex = 155;
            // 
            // cmb_unidadeMedida
            // 
            this.cmb_unidadeMedida.FormattingEnabled = true;
            this.cmb_unidadeMedida.Location = new System.Drawing.Point(703, 753);
            this.cmb_unidadeMedida.Name = "cmb_unidadeMedida";
            this.cmb_unidadeMedida.Size = new System.Drawing.Size(121, 24);
            this.cmb_unidadeMedida.TabIndex = 148;
            // 
            // cmb_idFornecedor
            // 
            this.cmb_idFornecedor.FormattingEnabled = true;
            this.cmb_idFornecedor.Location = new System.Drawing.Point(704, 683);
            this.cmb_idFornecedor.Name = "cmb_idFornecedor";
            this.cmb_idFornecedor.Size = new System.Drawing.Size(259, 24);
            this.cmb_idFornecedor.TabIndex = 147;
            // 
            // lbl_quantEntrada
            // 
            this.lbl_quantEntrada.AutoSize = true;
            this.lbl_quantEntrada.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_quantEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_quantEntrada.Location = new System.Drawing.Point(961, 819);
            this.lbl_quantEntrada.Name = "lbl_quantEntrada";
            this.lbl_quantEntrada.Size = new System.Drawing.Size(175, 21);
            this.lbl_quantEntrada.TabIndex = 141;
            this.lbl_quantEntrada.Text = "Quantidade inicial";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_descricao.Location = new System.Drawing.Point(1409, 650);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(101, 21);
            this.lbl_descricao.TabIndex = 142;
            this.lbl_descricao.Text = "Descrição";
            // 
            // txb_numeroLote
            // 
            this.txb_numeroLote.Location = new System.Drawing.Point(935, 753);
            this.txb_numeroLote.Name = "txb_numeroLote";
            this.txb_numeroLote.Size = new System.Drawing.Size(100, 22);
            this.txb_numeroLote.TabIndex = 154;
            // 
            // lbl_unidadeMedida
            // 
            this.lbl_unidadeMedida.AutoSize = true;
            this.lbl_unidadeMedida.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_unidadeMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_unidadeMedida.Location = new System.Drawing.Point(702, 730);
            this.lbl_unidadeMedida.Name = "lbl_unidadeMedida";
            this.lbl_unidadeMedida.Size = new System.Drawing.Size(190, 21);
            this.lbl_unidadeMedida.TabIndex = 139;
            this.lbl_unidadeMedida.Text = "Unidade de Medida";
            // 
            // lbl_precoUnit
            // 
            this.lbl_precoUnit.AutoSize = true;
            this.lbl_precoUnit.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_precoUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_precoUnit.Location = new System.Drawing.Point(1132, 732);
            this.lbl_precoUnit.Name = "lbl_precoUnit";
            this.lbl_precoUnit.Size = new System.Drawing.Size(142, 21);
            this.lbl_precoUnit.TabIndex = 143;
            this.lbl_precoUnit.Text = "Preço Unitario";
            // 
            // lbl_nomeMaterial
            // 
            this.lbl_nomeMaterial.AutoSize = true;
            this.lbl_nomeMaterial.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_nomeMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_nomeMaterial.Location = new System.Drawing.Point(1008, 660);
            this.lbl_nomeMaterial.Name = "lbl_nomeMaterial";
            this.lbl_nomeMaterial.Size = new System.Drawing.Size(148, 21);
            this.lbl_nomeMaterial.TabIndex = 138;
            this.lbl_nomeMaterial.Text = "Nome Material";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label9.Location = new System.Drawing.Point(701, 819);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 21);
            this.label9.TabIndex = 144;
            this.label9.Text = "Local de Armazenamento";
            // 
            // lbl_idFornecedor
            // 
            this.lbl_idFornecedor.AutoSize = true;
            this.lbl_idFornecedor.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_idFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_idFornecedor.Location = new System.Drawing.Point(701, 660);
            this.lbl_idFornecedor.Name = "lbl_idFornecedor";
            this.lbl_idFornecedor.Size = new System.Drawing.Size(115, 21);
            this.lbl_idFornecedor.TabIndex = 137;
            this.lbl_idFornecedor.Text = "Fornecedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label10.Location = new System.Drawing.Point(931, 730);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 145;
            this.label10.Text = "Numero Lote";
            // 
            // txb_precoUnit
            // 
            this.txb_precoUnit.Location = new System.Drawing.Point(1136, 755);
            this.txb_precoUnit.Name = "txb_precoUnit";
            this.txb_precoUnit.Size = new System.Drawing.Size(100, 22);
            this.txb_precoUnit.TabIndex = 151;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_status.Location = new System.Drawing.Point(1182, 822);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(69, 21);
            this.lbl_status.TabIndex = 146;
            this.lbl_status.Text = "Status";
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(1184, 845);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(134, 24);
            this.cmb_status.TabIndex = 150;
            // 
            // cmb_localArmazenamento
            // 
            this.cmb_localArmazenamento.FormattingEnabled = true;
            this.cmb_localArmazenamento.Location = new System.Drawing.Point(704, 842);
            this.cmb_localArmazenamento.Name = "cmb_localArmazenamento";
            this.cmb_localArmazenamento.Size = new System.Drawing.Size(166, 24);
            this.cmb_localArmazenamento.TabIndex = 149;
            // 
            // cbox_fornecedores
            // 
            this.cbox_fornecedores.AutoSize = true;
            this.cbox_fornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_fornecedores.Location = new System.Drawing.Point(1890, 106);
            this.cbox_fornecedores.Name = "cbox_fornecedores";
            this.cbox_fornecedores.Size = new System.Drawing.Size(18, 17);
            this.cbox_fornecedores.TabIndex = 135;
            this.cbox_fornecedores.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(1764, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 134;
            this.label1.Text = "Inativos";
            // 
            // txtpesqForn
            // 
            this.txtpesqForn.Location = new System.Drawing.Point(350, 94);
            this.txtpesqForn.Name = "txtpesqForn";
            this.txtpesqForn.Size = new System.Drawing.Size(187, 22);
            this.txtpesqForn.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label3.Location = new System.Drawing.Point(81, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 32);
            this.label3.TabIndex = 133;
            this.label3.Text = "Pesquisar Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label4.Location = new System.Drawing.Point(755, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(592, 68);
            this.label4.TabIndex = 132;
            this.label4.Text = "Consulta Materais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 162;
            this.label2.Text = "ID Material:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label15.Location = new System.Drawing.Point(973, 522);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 45);
            this.label15.TabIndex = 163;
            this.label15.Text = "Alterar";
            // 
            // txb_nomeMaterial
            // 
            this.txb_nomeMaterial.Location = new System.Drawing.Point(1011, 683);
            this.txb_nomeMaterial.Name = "txb_nomeMaterial";
            this.txb_nomeMaterial.Size = new System.Drawing.Size(307, 22);
            this.txb_nomeMaterial.TabIndex = 152;
            // 
            // cod_Material
            // 
            this.cod_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_Material.Location = new System.Drawing.Point(193, 558);
            this.cod_Material.Name = "cod_Material";
            this.cod_Material.ReadOnly = true;
            this.cod_Material.Size = new System.Drawing.Size(91, 28);
            this.cod_Material.TabIndex = 164;
            // 
            // consulta_materiais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "consulta_materiais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Materiais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.consulta_materiais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_materiais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_MATERIAIS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbox_fornecedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpesqForn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_voltar;
        private System.Windows.Forms.MonthCalendar mnth_ultimaAtualizacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.MonthCalendar mnth_dataEntrada;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.Label lbl_dataEntrada;
        private System.Windows.Forms.TextBox txb_quantEntrada;
        private System.Windows.Forms.ComboBox cmb_unidadeMedida;
        private System.Windows.Forms.ComboBox cmb_idFornecedor;
        private System.Windows.Forms.Label lbl_quantEntrada;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txb_numeroLote;
        private System.Windows.Forms.Label lbl_unidadeMedida;
        private System.Windows.Forms.Label lbl_precoUnit;
        private System.Windows.Forms.Label lbl_nomeMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_idFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_precoUnit;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ComboBox cmb_localArmazenamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cod_Material;
        private System.Windows.Forms.TextBox txb_nomeMaterial;
    }
}