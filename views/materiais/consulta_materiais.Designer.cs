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
            this.codigo_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localArmazenamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaAtualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1_MATERIAIS = new projeto2023.EstampariadbDataSet1_MATERIAIS();
            this.materiaisTableAdapter = new projeto2023.EstampariadbDataSet1_MATERIAISTableAdapters.MateriaisTableAdapter();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ativar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.cod_Material = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_voltar = new System.Windows.Forms.Label();
            this.mnth_ultimaAtualizacao = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.mnth_dataEntrada = new System.Windows.Forms.MonthCalendar();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.lbl_dataEntrada = new System.Windows.Forms.Label();
            this.txb_nomeMaterial = new System.Windows.Forms.TextBox();
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
            this.cbox_materiais = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpesqForn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.codigo_Material,
            this.codigo_Fornecedor,
            this.nome_Material,
            this.descricao,
            this.unidadeMedida,
            this.precoUnitario,
            this.dataEntrada,
            this.numeroLote,
            this.localArmazenamento,
            this.quantidade_Material,
            this.UltimaAtualizacao,
            this.status_material});
            this.dtv_materiais.DataSource = this.materiaisBindingSource;
            this.dtv_materiais.Location = new System.Drawing.Point(96, 130);
            this.dtv_materiais.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_materiais.Name = "dtv_materiais";
            this.dtv_materiais.ReadOnly = true;
            this.dtv_materiais.RowHeadersWidth = 51;
            this.dtv_materiais.Size = new System.Drawing.Size(1824, 378);
            this.dtv_materiais.TabIndex = 0;
            this.dtv_materiais.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_materiais_CellContentDoubleClick);
            // 
            // codigo_Material
            // 
            this.codigo_Material.DataPropertyName = "codigo_Material";
            this.codigo_Material.HeaderText = "codigo_Material";
            this.codigo_Material.MinimumWidth = 6;
            this.codigo_Material.Name = "codigo_Material";
            this.codigo_Material.ReadOnly = true;
            this.codigo_Material.Width = 125;
            // 
            // codigo_Fornecedor
            // 
            this.codigo_Fornecedor.DataPropertyName = "codigo_Fornecedor";
            this.codigo_Fornecedor.HeaderText = "codigo_Fornecedor";
            this.codigo_Fornecedor.MinimumWidth = 6;
            this.codigo_Fornecedor.Name = "codigo_Fornecedor";
            this.codigo_Fornecedor.ReadOnly = true;
            this.codigo_Fornecedor.Width = 125;
            // 
            // nome_Material
            // 
            this.nome_Material.DataPropertyName = "nome_Material";
            this.nome_Material.HeaderText = "nome_Material";
            this.nome_Material.MinimumWidth = 6;
            this.nome_Material.Name = "nome_Material";
            this.nome_Material.ReadOnly = true;
            this.nome_Material.Width = 125;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "descricao";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 125;
            // 
            // unidadeMedida
            // 
            this.unidadeMedida.DataPropertyName = "unidadeMedida";
            this.unidadeMedida.HeaderText = "unidadeMedida";
            this.unidadeMedida.MinimumWidth = 6;
            this.unidadeMedida.Name = "unidadeMedida";
            this.unidadeMedida.ReadOnly = true;
            this.unidadeMedida.Width = 125;
            // 
            // precoUnitario
            // 
            this.precoUnitario.DataPropertyName = "precoUnitario";
            this.precoUnitario.HeaderText = "precoUnitario";
            this.precoUnitario.MinimumWidth = 6;
            this.precoUnitario.Name = "precoUnitario";
            this.precoUnitario.ReadOnly = true;
            this.precoUnitario.Width = 125;
            // 
            // dataEntrada
            // 
            this.dataEntrada.DataPropertyName = "dataEntrada";
            this.dataEntrada.HeaderText = "dataEntrada";
            this.dataEntrada.MinimumWidth = 6;
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.ReadOnly = true;
            this.dataEntrada.Width = 125;
            // 
            // numeroLote
            // 
            this.numeroLote.DataPropertyName = "numeroLote";
            this.numeroLote.HeaderText = "numeroLote";
            this.numeroLote.MinimumWidth = 6;
            this.numeroLote.Name = "numeroLote";
            this.numeroLote.ReadOnly = true;
            this.numeroLote.Width = 125;
            // 
            // localArmazenamento
            // 
            this.localArmazenamento.DataPropertyName = "localArmazenamento";
            this.localArmazenamento.HeaderText = "localArmazenamento";
            this.localArmazenamento.MinimumWidth = 6;
            this.localArmazenamento.Name = "localArmazenamento";
            this.localArmazenamento.ReadOnly = true;
            this.localArmazenamento.Width = 125;
            // 
            // quantidade_Material
            // 
            this.quantidade_Material.DataPropertyName = "quantidade_Material";
            this.quantidade_Material.HeaderText = "quantidade_Material";
            this.quantidade_Material.MinimumWidth = 6;
            this.quantidade_Material.Name = "quantidade_Material";
            this.quantidade_Material.ReadOnly = true;
            this.quantidade_Material.Width = 125;
            // 
            // UltimaAtualizacao
            // 
            this.UltimaAtualizacao.DataPropertyName = "UltimaAtualizacao";
            this.UltimaAtualizacao.HeaderText = "UltimaAtualizacao";
            this.UltimaAtualizacao.MinimumWidth = 6;
            this.UltimaAtualizacao.Name = "UltimaAtualizacao";
            this.UltimaAtualizacao.ReadOnly = true;
            this.UltimaAtualizacao.Width = 125;
            // 
            // status_material
            // 
            this.status_material.DataPropertyName = "status_material";
            this.status_material.HeaderText = "status_material";
            this.status_material.MinimumWidth = 6;
            this.status_material.Name = "status_material";
            this.status_material.ReadOnly = true;
            this.status_material.Width = 125;
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
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_ativar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button_excluir);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Controls.Add(this.cod_Material);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_voltar);
            this.panel1.Controls.Add(this.mnth_ultimaAtualizacao);
            this.panel1.Controls.Add(this.label5);
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
            this.panel1.Controls.Add(this.cbox_materiais);
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
            // btn_ativar
            // 
            this.btn_ativar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_ativar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_ativar.Location = new System.Drawing.Point(1713, 724);
            this.btn_ativar.Name = "btn_ativar";
            this.btn_ativar.Size = new System.Drawing.Size(121, 73);
            this.btn_ativar.TabIndex = 168;
            this.btn_ativar.Text = "ATIVAR";
            this.btn_ativar.UseVisualStyleBackColor = false;
            this.btn_ativar.Visible = false;
            this.btn_ativar.Click += new System.EventHandler(this.btn_ativar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.Red;
            this.button_excluir.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button_excluir.Location = new System.Drawing.Point(1713, 796);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(121, 73);
            this.button_excluir.TabIndex = 167;
            this.button_excluir.Text = "EXCLUIR";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Visible = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_salvar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.Location = new System.Drawing.Point(1713, 660);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(121, 73);
            this.btn_salvar.TabIndex = 166;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Visible = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_limpar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_limpar.Location = new System.Drawing.Point(1197, 891);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(121, 42);
            this.btn_limpar.TabIndex = 165;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
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
            // label_voltar
            // 
            this.label_voltar.AutoSize = true;
            this.label_voltar.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voltar.Location = new System.Drawing.Point(68, 923);
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
            // txb_nomeMaterial
            // 
            this.txb_nomeMaterial.Location = new System.Drawing.Point(1011, 683);
            this.txb_nomeMaterial.Name = "txb_nomeMaterial";
            this.txb_nomeMaterial.Size = new System.Drawing.Size(307, 22);
            this.txb_nomeMaterial.TabIndex = 152;
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
            // cbox_materiais
            // 
            this.cbox_materiais.AutoSize = true;
            this.cbox_materiais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_materiais.Location = new System.Drawing.Point(1890, 106);
            this.cbox_materiais.Name = "cbox_materiais";
            this.cbox_materiais.Size = new System.Drawing.Size(18, 17);
            this.cbox_materiais.TabIndex = 135;
            this.cbox_materiais.UseVisualStyleBackColor = true;
            this.cbox_materiais.CheckedChanged += new System.EventHandler(this.cbox_materiais_CheckedChanged);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1713, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 73);
            this.button1.TabIndex = 166;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(1713, 796);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 73);
            this.button2.TabIndex = 167;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(1713, 724);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 73);
            this.button3.TabIndex = 168;
            this.button3.Text = "ATIVAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.btn_ativar_Click);
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
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbox_materiais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpesqForn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_voltar;
        private System.Windows.Forms.MonthCalendar mnth_ultimaAtualizacao;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn localArmazenamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimaAtualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_material;
        private System.Windows.Forms.Button btn_ativar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}