namespace projeto2023.views.pedidos
{
    partial class consulta_pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta_pedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cbx_inativos_Pedidos = new System.Windows.Forms.CheckBox();
            this.lbl_inativos = new System.Windows.Forms.Label();
            this.txt_pesquisarNome = new System.Windows.Forms.TextBox();
            this.lbl_pesquisarNome = new System.Windows.Forms.Label();
            this.lbl_Consulta_Materiais = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.dtv_pedidos = new System.Windows.Forms.DataGridView();
            this.estampariadbDataSet = new projeto2023.EstampariadbDataSet();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new projeto2023.EstampariadbDataSetTableAdapters.PedidosTableAdapter();
            this.codigoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corCamisetaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoGolaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnicasPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estampaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamPquantPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamMquantPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamGquantPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diponibilizadoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCamisetasPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorEntradaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorAbertoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_formapagamento = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_formapagamentoFinal = new System.Windows.Forms.ComboBox();
            this.lbl_formapagamentoFinal = new System.Windows.Forms.Label();
            this.cmb_formapagamentoEntrada = new System.Windows.Forms.ComboBox();
            this.lbl_formapagamentoEntrada = new System.Windows.Forms.Label();
            this.pnl_dadoscolabcli = new System.Windows.Forms.Panel();
            this.cmb_idCliente = new System.Windows.Forms.ComboBox();
            this.cmb_idColaborador = new System.Windows.Forms.ComboBox();
            this.lbl_nomeCliente = new System.Windows.Forms.Label();
            this.txb_nomeColaborador = new System.Windows.Forms.TextBox();
            this.txb_nomeCliente = new System.Windows.Forms.TextBox();
            this.lbl_idColaborador = new System.Windows.Forms.Label();
            this.pnl_valores = new System.Windows.Forms.Panel();
            this.txb_valorAberto = new System.Windows.Forms.TextBox();
            this.lbl_valorAberto = new System.Windows.Forms.Label();
            this.txb_valorEntrada = new System.Windows.Forms.TextBox();
            this.txb_valorTotal = new System.Windows.Forms.TextBox();
            this.txb_valorUnit = new System.Windows.Forms.TextBox();
            this.lbl_valorEntrada = new System.Windows.Forms.Label();
            this.lbl_valorTotal = new System.Windows.Forms.Label();
            this.lbl_valorUnit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_caminhoImagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_dataentrega = new System.Windows.Forms.Label();
            this.lbl_datainicial = new System.Windows.Forms.Label();
            this.mnth_dataentrega = new System.Windows.Forms.MonthCalendar();
            this.mnth_datainicial = new System.Windows.Forms.MonthCalendar();
            this.label11 = new System.Windows.Forms.Label();
            this.pctb_estampa = new System.Windows.Forms.PictureBox();
            this.cmb_tecnica = new System.Windows.Forms.ComboBox();
            this.grpb_quantidades = new System.Windows.Forms.GroupBox();
            this.lbl_tamG = new System.Windows.Forms.Label();
            this.lbl_tamM = new System.Windows.Forms.Label();
            this.lbl_tamP = new System.Windows.Forms.Label();
            this.lbl_totalCamisetas = new System.Windows.Forms.Label();
            this.txb_totalCamisetas = new System.Windows.Forms.TextBox();
            this.txb_disponibilizadocliente = new System.Windows.Forms.TextBox();
            this.check_disponibilizadocliente = new System.Windows.Forms.CheckBox();
            this.txb_tamG = new System.Windows.Forms.TextBox();
            this.txb_tamM = new System.Windows.Forms.TextBox();
            this.txb_tamP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_formato = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_tecido = new System.Windows.Forms.ComboBox();
            this.cmb_cores = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_gola = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_orcamento = new System.Windows.Forms.Button();
            this.label_voltar = new System.Windows.Forms.Label();
            this.estampariadbDataSet1 = new projeto2023.EstampariadbDataSet1();
            this.colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradoresTableAdapter = new projeto2023.EstampariadbDataSet1TableAdapters.ColaboradoresTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            this.pnl_formapagamento.SuspendLayout();
            this.pnl_dadoscolabcli.SuspendLayout();
            this.pnl_valores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_estampa)).BeginInit();
            this.grpb_quantidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_voltar);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pnl_formapagamento);
            this.panel1.Controls.Add(this.pnl_dadoscolabcli);
            this.panel1.Controls.Add(this.pnl_valores);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txb_caminhoImagem);
            this.panel1.Controls.Add(this.btn_orcamento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_dataentrega);
            this.panel1.Controls.Add(this.lbl_datainicial);
            this.panel1.Controls.Add(this.mnth_dataentrega);
            this.panel1.Controls.Add(this.mnth_datainicial);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pctb_estampa);
            this.panel1.Controls.Add(this.cmb_tecnica);
            this.panel1.Controls.Add(this.grpb_quantidades);
            this.panel1.Controls.Add(this.cmb_formato);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmb_tecido);
            this.panel1.Controls.Add(this.cmb_cores);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmb_gola);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbx_inativos_Pedidos);
            this.panel1.Controls.Add(this.lbl_inativos);
            this.panel1.Controls.Add(this.txt_pesquisarNome);
            this.panel1.Controls.Add(this.lbl_pesquisarNome);
            this.panel1.Controls.Add(this.lbl_Consulta_Materiais);
            this.panel1.Controls.Add(this.dtv_pedidos);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1918, 1006);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label15.Location = new System.Drawing.Point(935, 535);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 45);
            this.label15.TabIndex = 171;
            this.label15.Text = "Alterar";
            // 
            // cbx_inativos_Pedidos
            // 
            this.cbx_inativos_Pedidos.AutoSize = true;
            this.cbx_inativos_Pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_inativos_Pedidos.Location = new System.Drawing.Point(1894, 119);
            this.cbx_inativos_Pedidos.Name = "cbx_inativos_Pedidos";
            this.cbx_inativos_Pedidos.Size = new System.Drawing.Size(18, 17);
            this.cbx_inativos_Pedidos.TabIndex = 169;
            this.cbx_inativos_Pedidos.UseVisualStyleBackColor = true;
            this.cbx_inativos_Pedidos.CheckedChanged += new System.EventHandler(this.cbx_inativos_Pedidos_CheckedChanged);
            // 
            // lbl_inativos
            // 
            this.lbl_inativos.AutoSize = true;
            this.lbl_inativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inativos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_inativos.Location = new System.Drawing.Point(1768, 107);
            this.lbl_inativos.Name = "lbl_inativos";
            this.lbl_inativos.Size = new System.Drawing.Size(120, 32);
            this.lbl_inativos.TabIndex = 168;
            this.lbl_inativos.Text = "Inativos";
            // 
            // txt_pesquisarNome
            // 
            this.txt_pesquisarNome.Location = new System.Drawing.Point(312, 107);
            this.txt_pesquisarNome.Name = "txt_pesquisarNome";
            this.txt_pesquisarNome.Size = new System.Drawing.Size(187, 22);
            this.txt_pesquisarNome.TabIndex = 170;
            // 
            // lbl_pesquisarNome
            // 
            this.lbl_pesquisarNome.AutoSize = true;
            this.lbl_pesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisarNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_pesquisarNome.Location = new System.Drawing.Point(43, 98);
            this.lbl_pesquisarNome.Name = "lbl_pesquisarNome";
            this.lbl_pesquisarNome.Size = new System.Drawing.Size(246, 32);
            this.lbl_pesquisarNome.TabIndex = 167;
            this.lbl_pesquisarNome.Text = "Pesquisar Nome:";
            // 
            // lbl_Consulta_Materiais
            // 
            this.lbl_Consulta_Materiais.AutoSize = true;
            this.lbl_Consulta_Materiais.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Consulta_Materiais.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consulta_Materiais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.lbl_Consulta_Materiais.Location = new System.Drawing.Point(824, 44);
            this.lbl_Consulta_Materiais.Name = "lbl_Consulta_Materiais";
            this.lbl_Consulta_Materiais.Size = new System.Drawing.Size(566, 68);
            this.lbl_Consulta_Materiais.TabIndex = 166;
            this.lbl_Consulta_Materiais.Text = "Consulta Pedidos";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(1667, 529);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(247, 52);
            this.btn_imprimir.TabIndex = 165;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // dtv_pedidos
            // 
            this.dtv_pedidos.AllowUserToAddRows = false;
            this.dtv_pedidos.AllowUserToDeleteRows = false;
            this.dtv_pedidos.AutoGenerateColumns = false;
            this.dtv_pedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPedidoDataGridViewTextBoxColumn,
            this.codigoColaboradorDataGridViewTextBoxColumn,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.corCamisetaPedidoDataGridViewTextBoxColumn,
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn,
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn,
            this.tipoGolaPedidoDataGridViewTextBoxColumn,
            this.tecnicasPedidoDataGridViewTextBoxColumn,
            this.estampaPedidoDataGridViewTextBoxColumn,
            this.tamPquantPedidoDataGridViewTextBoxColumn,
            this.tamMquantPedidoDataGridViewTextBoxColumn,
            this.tamGquantPedidoDataGridViewTextBoxColumn,
            this.diponibilizadoClienteDataGridViewTextBoxColumn,
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn,
            this.totalCamisetasPedidoDataGridViewTextBoxColumn,
            this.datainicialDataGridViewTextBoxColumn,
            this.dataentregaDataGridViewTextBoxColumn,
            this.valorUnitPedidoDataGridViewTextBoxColumn,
            this.valorTotalPedidoDataGridViewTextBoxColumn,
            this.valorEntradaPedidoDataGridViewTextBoxColumn,
            this.valorAbertoPedidoDataGridViewTextBoxColumn});
            this.dtv_pedidos.DataSource = this.pedidosBindingSource;
            this.dtv_pedidos.Location = new System.Drawing.Point(129, 151);
            this.dtv_pedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_pedidos.Name = "dtv_pedidos";
            this.dtv_pedidos.ReadOnly = true;
            this.dtv_pedidos.RowHeadersWidth = 51;
            this.dtv_pedidos.Size = new System.Drawing.Size(1856, 378);
            this.dtv_pedidos.TabIndex = 164;
            // 
            // estampariadbDataSet
            // 
            this.estampariadbDataSet.DataSetName = "EstampariadbDataSet";
            this.estampariadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.estampariadbDataSet;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // codigoPedidoDataGridViewTextBoxColumn
            // 
            this.codigoPedidoDataGridViewTextBoxColumn.DataPropertyName = "codigo_Pedido";
            this.codigoPedidoDataGridViewTextBoxColumn.HeaderText = "codigo_Pedido";
            this.codigoPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoPedidoDataGridViewTextBoxColumn.Name = "codigoPedidoDataGridViewTextBoxColumn";
            this.codigoPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoColaboradorDataGridViewTextBoxColumn
            // 
            this.codigoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "codigo_Colaborador";
            this.codigoColaboradorDataGridViewTextBoxColumn.HeaderText = "codigo_Colaborador";
            this.codigoColaboradorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoColaboradorDataGridViewTextBoxColumn.Name = "codigoColaboradorDataGridViewTextBoxColumn";
            this.codigoColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoColaboradorDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "codigo_Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // corCamisetaPedidoDataGridViewTextBoxColumn
            // 
            this.corCamisetaPedidoDataGridViewTextBoxColumn.DataPropertyName = "corCamiseta_Pedido";
            this.corCamisetaPedidoDataGridViewTextBoxColumn.HeaderText = "corCamiseta_Pedido";
            this.corCamisetaPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.corCamisetaPedidoDataGridViewTextBoxColumn.Name = "corCamisetaPedidoDataGridViewTextBoxColumn";
            this.corCamisetaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.corCamisetaPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tecidoCamisetaPedidoDataGridViewTextBoxColumn
            // 
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.DataPropertyName = "tecidoCamiseta_Pedido";
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.HeaderText = "tecidoCamiseta_Pedido";
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.Name = "tecidoCamisetaPedidoDataGridViewTextBoxColumn";
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // formatoCamisetaPedidoDataGridViewTextBoxColumn
            // 
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.DataPropertyName = "formatoCamiseta_Pedido";
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.HeaderText = "formatoCamiseta_Pedido";
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.Name = "formatoCamisetaPedidoDataGridViewTextBoxColumn";
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoGolaPedidoDataGridViewTextBoxColumn
            // 
            this.tipoGolaPedidoDataGridViewTextBoxColumn.DataPropertyName = "tipoGola_Pedido";
            this.tipoGolaPedidoDataGridViewTextBoxColumn.HeaderText = "tipoGola_Pedido";
            this.tipoGolaPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoGolaPedidoDataGridViewTextBoxColumn.Name = "tipoGolaPedidoDataGridViewTextBoxColumn";
            this.tipoGolaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoGolaPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tecnicasPedidoDataGridViewTextBoxColumn
            // 
            this.tecnicasPedidoDataGridViewTextBoxColumn.DataPropertyName = "tecnicas_Pedido";
            this.tecnicasPedidoDataGridViewTextBoxColumn.HeaderText = "tecnicas_Pedido";
            this.tecnicasPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tecnicasPedidoDataGridViewTextBoxColumn.Name = "tecnicasPedidoDataGridViewTextBoxColumn";
            this.tecnicasPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tecnicasPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estampaPedidoDataGridViewTextBoxColumn
            // 
            this.estampaPedidoDataGridViewTextBoxColumn.DataPropertyName = "estampa_Pedido";
            this.estampaPedidoDataGridViewTextBoxColumn.HeaderText = "estampa_Pedido";
            this.estampaPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estampaPedidoDataGridViewTextBoxColumn.Name = "estampaPedidoDataGridViewTextBoxColumn";
            this.estampaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estampaPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tamPquantPedidoDataGridViewTextBoxColumn
            // 
            this.tamPquantPedidoDataGridViewTextBoxColumn.DataPropertyName = "tamP_quant_Pedido";
            this.tamPquantPedidoDataGridViewTextBoxColumn.HeaderText = "tamP_quant_Pedido";
            this.tamPquantPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tamPquantPedidoDataGridViewTextBoxColumn.Name = "tamPquantPedidoDataGridViewTextBoxColumn";
            this.tamPquantPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamPquantPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tamMquantPedidoDataGridViewTextBoxColumn
            // 
            this.tamMquantPedidoDataGridViewTextBoxColumn.DataPropertyName = "tamM_quant_Pedido";
            this.tamMquantPedidoDataGridViewTextBoxColumn.HeaderText = "tamM_quant_Pedido";
            this.tamMquantPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tamMquantPedidoDataGridViewTextBoxColumn.Name = "tamMquantPedidoDataGridViewTextBoxColumn";
            this.tamMquantPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamMquantPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tamGquantPedidoDataGridViewTextBoxColumn
            // 
            this.tamGquantPedidoDataGridViewTextBoxColumn.DataPropertyName = "tamG_quant_Pedido";
            this.tamGquantPedidoDataGridViewTextBoxColumn.HeaderText = "tamG_quant_Pedido";
            this.tamGquantPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tamGquantPedidoDataGridViewTextBoxColumn.Name = "tamGquantPedidoDataGridViewTextBoxColumn";
            this.tamGquantPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamGquantPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // diponibilizadoClienteDataGridViewTextBoxColumn
            // 
            this.diponibilizadoClienteDataGridViewTextBoxColumn.DataPropertyName = "diponibilizadoCliente";
            this.diponibilizadoClienteDataGridViewTextBoxColumn.HeaderText = "diponibilizadoCliente";
            this.diponibilizadoClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diponibilizadoClienteDataGridViewTextBoxColumn.Name = "diponibilizadoClienteDataGridViewTextBoxColumn";
            this.diponibilizadoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.diponibilizadoClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantdisponibilizadoClienteDataGridViewTextBoxColumn
            // 
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.DataPropertyName = "quantdisponibilizadoCliente";
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.HeaderText = "quantdisponibilizadoCliente";
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.Name = "quantdisponibilizadoClienteDataGridViewTextBoxColumn";
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCamisetasPedidoDataGridViewTextBoxColumn
            // 
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.DataPropertyName = "totalCamisetas_Pedido";
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.HeaderText = "totalCamisetas_Pedido";
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.Name = "totalCamisetasPedidoDataGridViewTextBoxColumn";
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // datainicialDataGridViewTextBoxColumn
            // 
            this.datainicialDataGridViewTextBoxColumn.DataPropertyName = "data_inicial";
            this.datainicialDataGridViewTextBoxColumn.HeaderText = "data_inicial";
            this.datainicialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datainicialDataGridViewTextBoxColumn.Name = "datainicialDataGridViewTextBoxColumn";
            this.datainicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.datainicialDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            this.dataentregaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataentregaDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorUnitPedidoDataGridViewTextBoxColumn
            // 
            this.valorUnitPedidoDataGridViewTextBoxColumn.DataPropertyName = "valorUnit_Pedido";
            this.valorUnitPedidoDataGridViewTextBoxColumn.HeaderText = "valorUnit_Pedido";
            this.valorUnitPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorUnitPedidoDataGridViewTextBoxColumn.Name = "valorUnitPedidoDataGridViewTextBoxColumn";
            this.valorUnitPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUnitPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalPedidoDataGridViewTextBoxColumn
            // 
            this.valorTotalPedidoDataGridViewTextBoxColumn.DataPropertyName = "valorTotal_Pedido";
            this.valorTotalPedidoDataGridViewTextBoxColumn.HeaderText = "valorTotal_Pedido";
            this.valorTotalPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorTotalPedidoDataGridViewTextBoxColumn.Name = "valorTotalPedidoDataGridViewTextBoxColumn";
            this.valorTotalPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorEntradaPedidoDataGridViewTextBoxColumn
            // 
            this.valorEntradaPedidoDataGridViewTextBoxColumn.DataPropertyName = "valorEntrada_Pedido";
            this.valorEntradaPedidoDataGridViewTextBoxColumn.HeaderText = "valorEntrada_Pedido";
            this.valorEntradaPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorEntradaPedidoDataGridViewTextBoxColumn.Name = "valorEntradaPedidoDataGridViewTextBoxColumn";
            this.valorEntradaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorEntradaPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorAbertoPedidoDataGridViewTextBoxColumn
            // 
            this.valorAbertoPedidoDataGridViewTextBoxColumn.DataPropertyName = "valorAberto_Pedido";
            this.valorAbertoPedidoDataGridViewTextBoxColumn.HeaderText = "valorAberto_Pedido";
            this.valorAbertoPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorAbertoPedidoDataGridViewTextBoxColumn.Name = "valorAbertoPedidoDataGridViewTextBoxColumn";
            this.valorAbertoPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorAbertoPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // pnl_formapagamento
            // 
            this.pnl_formapagamento.Controls.Add(this.lbl_status);
            this.pnl_formapagamento.Controls.Add(this.cmb_status);
            this.pnl_formapagamento.Controls.Add(this.cmb_formapagamentoFinal);
            this.pnl_formapagamento.Controls.Add(this.lbl_formapagamentoFinal);
            this.pnl_formapagamento.Controls.Add(this.cmb_formapagamentoEntrada);
            this.pnl_formapagamento.Controls.Add(this.lbl_formapagamentoEntrada);
            this.pnl_formapagamento.Location = new System.Drawing.Point(1348, 669);
            this.pnl_formapagamento.Name = "pnl_formapagamento";
            this.pnl_formapagamento.Size = new System.Drawing.Size(214, 239);
            this.pnl_formapagamento.TabIndex = 187;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(59, 173);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(44, 16);
            this.lbl_status.TabIndex = 21;
            this.lbl_status.Text = "Status";
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Em aberto",
            "Orçamento",
            "Em andamento",
            "Concluído",
            "Entregue",
            "Cancelado"});
            this.cmb_status.Location = new System.Drawing.Point(19, 198);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 24);
            this.cmb_status.TabIndex = 20;
            // 
            // cmb_formapagamentoFinal
            // 
            this.cmb_formapagamentoFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formapagamentoFinal.FormattingEnabled = true;
            this.cmb_formapagamentoFinal.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Pix",
            "Transferência Bancária",
            "Boleto Bancário"});
            this.cmb_formapagamentoFinal.Location = new System.Drawing.Point(18, 133);
            this.cmb_formapagamentoFinal.Name = "cmb_formapagamentoFinal";
            this.cmb_formapagamentoFinal.Size = new System.Drawing.Size(121, 24);
            this.cmb_formapagamentoFinal.TabIndex = 19;
            // 
            // lbl_formapagamentoFinal
            // 
            this.lbl_formapagamentoFinal.AutoSize = true;
            this.lbl_formapagamentoFinal.Location = new System.Drawing.Point(16, 94);
            this.lbl_formapagamentoFinal.Name = "lbl_formapagamentoFinal";
            this.lbl_formapagamentoFinal.Size = new System.Drawing.Size(145, 32);
            this.lbl_formapagamentoFinal.TabIndex = 18;
            this.lbl_formapagamentoFinal.Text = "Formas de Pagamento\r\n               Final";
            // 
            // cmb_formapagamentoEntrada
            // 
            this.cmb_formapagamentoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formapagamentoEntrada.FormattingEnabled = true;
            this.cmb_formapagamentoEntrada.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Pix",
            "Transferência Bancária",
            "Boleto Bancário"});
            this.cmb_formapagamentoEntrada.Location = new System.Drawing.Point(17, 61);
            this.cmb_formapagamentoEntrada.Name = "cmb_formapagamentoEntrada";
            this.cmb_formapagamentoEntrada.Size = new System.Drawing.Size(121, 24);
            this.cmb_formapagamentoEntrada.TabIndex = 17;
            // 
            // lbl_formapagamentoEntrada
            // 
            this.lbl_formapagamentoEntrada.AutoSize = true;
            this.lbl_formapagamentoEntrada.Location = new System.Drawing.Point(16, 15);
            this.lbl_formapagamentoEntrada.Name = "lbl_formapagamentoEntrada";
            this.lbl_formapagamentoEntrada.Size = new System.Drawing.Size(145, 32);
            this.lbl_formapagamentoEntrada.TabIndex = 0;
            this.lbl_formapagamentoEntrada.Text = "Formas de Pagamento\r\n             Entrada";
            // 
            // pnl_dadoscolabcli
            // 
            this.pnl_dadoscolabcli.Controls.Add(this.cmb_idCliente);
            this.pnl_dadoscolabcli.Controls.Add(this.cmb_idColaborador);
            this.pnl_dadoscolabcli.Controls.Add(this.lbl_nomeCliente);
            this.pnl_dadoscolabcli.Controls.Add(this.txb_nomeColaborador);
            this.pnl_dadoscolabcli.Controls.Add(this.txb_nomeCliente);
            this.pnl_dadoscolabcli.Controls.Add(this.lbl_idColaborador);
            this.pnl_dadoscolabcli.Location = new System.Drawing.Point(28, 583);
            this.pnl_dadoscolabcli.Name = "pnl_dadoscolabcli";
            this.pnl_dadoscolabcli.Size = new System.Drawing.Size(924, 52);
            this.pnl_dadoscolabcli.TabIndex = 172;
            // 
            // cmb_idCliente
            // 
            this.cmb_idCliente.DataSource = this.colaboradoresBindingSource;
            this.cmb_idCliente.DisplayMember = "nome_Colaborador";
            this.cmb_idCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idCliente.FormattingEnabled = true;
            this.cmb_idCliente.Location = new System.Drawing.Point(415, 28);
            this.cmb_idCliente.Name = "cmb_idCliente";
            this.cmb_idCliente.Size = new System.Drawing.Size(281, 24);
            this.cmb_idCliente.TabIndex = 7;
            // 
            // cmb_idColaborador
            // 
            this.cmb_idColaborador.DataSource = this.colaboradoresBindingSource;
            this.cmb_idColaborador.DisplayMember = "nome_Colaborador";
            this.cmb_idColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idColaborador.FormattingEnabled = true;
            this.cmb_idColaborador.Location = new System.Drawing.Point(11, 26);
            this.cmb_idColaborador.MaxDropDownItems = 5;
            this.cmb_idColaborador.Name = "cmb_idColaborador";
            this.cmb_idColaborador.Size = new System.Drawing.Size(283, 24);
            this.cmb_idColaborador.TabIndex = 6;
            // 
            // lbl_nomeCliente
            // 
            this.lbl_nomeCliente.AutoSize = true;
            this.lbl_nomeCliente.Location = new System.Drawing.Point(412, 11);
            this.lbl_nomeCliente.Name = "lbl_nomeCliente";
            this.lbl_nomeCliente.Size = new System.Drawing.Size(48, 16);
            this.lbl_nomeCliente.TabIndex = 3;
            this.lbl_nomeCliente.Text = "Cliente";
            // 
            // txb_nomeColaborador
            // 
            this.txb_nomeColaborador.Location = new System.Drawing.Point(101, 28);
            this.txb_nomeColaborador.Name = "txb_nomeColaborador";
            this.txb_nomeColaborador.ReadOnly = true;
            this.txb_nomeColaborador.Size = new System.Drawing.Size(289, 22);
            this.txb_nomeColaborador.TabIndex = 3;
            this.txb_nomeColaborador.Visible = false;
            // 
            // txb_nomeCliente
            // 
            this.txb_nomeCliente.Location = new System.Drawing.Point(503, 28);
            this.txb_nomeCliente.Name = "txb_nomeCliente";
            this.txb_nomeCliente.ReadOnly = true;
            this.txb_nomeCliente.Size = new System.Drawing.Size(289, 22);
            this.txb_nomeCliente.TabIndex = 5;
            this.txb_nomeCliente.Visible = false;
            // 
            // lbl_idColaborador
            // 
            this.lbl_idColaborador.AutoSize = true;
            this.lbl_idColaborador.Location = new System.Drawing.Point(9, 11);
            this.lbl_idColaborador.Name = "lbl_idColaborador";
            this.lbl_idColaborador.Size = new System.Drawing.Size(83, 16);
            this.lbl_idColaborador.TabIndex = 0;
            this.lbl_idColaborador.Text = "Colaborador";
            // 
            // pnl_valores
            // 
            this.pnl_valores.Controls.Add(this.txb_valorAberto);
            this.pnl_valores.Controls.Add(this.lbl_valorAberto);
            this.pnl_valores.Controls.Add(this.txb_valorEntrada);
            this.pnl_valores.Controls.Add(this.txb_valorTotal);
            this.pnl_valores.Controls.Add(this.txb_valorUnit);
            this.pnl_valores.Controls.Add(this.lbl_valorEntrada);
            this.pnl_valores.Controls.Add(this.lbl_valorTotal);
            this.pnl_valores.Controls.Add(this.lbl_valorUnit);
            this.pnl_valores.Controls.Add(this.label13);
            this.pnl_valores.Location = new System.Drawing.Point(1568, 669);
            this.pnl_valores.Name = "pnl_valores";
            this.pnl_valores.Size = new System.Drawing.Size(128, 241);
            this.pnl_valores.TabIndex = 189;
            // 
            // txb_valorAberto
            // 
            this.txb_valorAberto.Location = new System.Drawing.Point(11, 208);
            this.txb_valorAberto.Name = "txb_valorAberto";
            this.txb_valorAberto.Size = new System.Drawing.Size(70, 22);
            this.txb_valorAberto.TabIndex = 16;
            // 
            // lbl_valorAberto
            // 
            this.lbl_valorAberto.AutoSize = true;
            this.lbl_valorAberto.Location = new System.Drawing.Point(8, 184);
            this.lbl_valorAberto.Name = "lbl_valorAberto";
            this.lbl_valorAberto.Size = new System.Drawing.Size(104, 16);
            this.lbl_valorAberto.TabIndex = 15;
            this.lbl_valorAberto.Text = "Valor em Aberto";
            // 
            // txb_valorEntrada
            // 
            this.txb_valorEntrada.Location = new System.Drawing.Point(12, 153);
            this.txb_valorEntrada.Name = "txb_valorEntrada";
            this.txb_valorEntrada.Size = new System.Drawing.Size(70, 22);
            this.txb_valorEntrada.TabIndex = 14;
            // 
            // txb_valorTotal
            // 
            this.txb_valorTotal.Location = new System.Drawing.Point(12, 105);
            this.txb_valorTotal.Name = "txb_valorTotal";
            this.txb_valorTotal.Size = new System.Drawing.Size(70, 22);
            this.txb_valorTotal.TabIndex = 13;
            // 
            // txb_valorUnit
            // 
            this.txb_valorUnit.Location = new System.Drawing.Point(12, 55);
            this.txb_valorUnit.Name = "txb_valorUnit";
            this.txb_valorUnit.Size = new System.Drawing.Size(70, 22);
            this.txb_valorUnit.TabIndex = 6;
            // 
            // lbl_valorEntrada
            // 
            this.lbl_valorEntrada.AutoSize = true;
            this.lbl_valorEntrada.Location = new System.Drawing.Point(9, 132);
            this.lbl_valorEntrada.Name = "lbl_valorEntrada";
            this.lbl_valorEntrada.Size = new System.Drawing.Size(89, 16);
            this.lbl_valorEntrada.TabIndex = 12;
            this.lbl_valorEntrada.Text = "Valor Entrada";
            // 
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.AutoSize = true;
            this.lbl_valorTotal.Location = new System.Drawing.Point(9, 84);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(73, 16);
            this.lbl_valorTotal.TabIndex = 11;
            this.lbl_valorTotal.Text = "Valor Total";
            // 
            // lbl_valorUnit
            // 
            this.lbl_valorUnit.AutoSize = true;
            this.lbl_valorUnit.Location = new System.Drawing.Point(9, 37);
            this.lbl_valorUnit.Name = "lbl_valorUnit";
            this.lbl_valorUnit.Size = new System.Drawing.Size(88, 16);
            this.lbl_valorUnit.TabIndex = 10;
            this.lbl_valorUnit.Text = "Valor Unitário";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Pedido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 771);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 24);
            this.button1.TabIndex = 199;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txb_caminhoImagem
            // 
            this.txb_caminhoImagem.Location = new System.Drawing.Point(170, 771);
            this.txb_caminhoImagem.Name = "txb_caminhoImagem";
            this.txb_caminhoImagem.Size = new System.Drawing.Size(121, 22);
            this.txb_caminhoImagem.TabIndex = 197;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 751);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 195;
            this.label3.Text = "Estampa";
            // 
            // lbl_dataentrega
            // 
            this.lbl_dataentrega.AutoSize = true;
            this.lbl_dataentrega.Location = new System.Drawing.Point(1132, 669);
            this.lbl_dataentrega.Name = "lbl_dataentrega";
            this.lbl_dataentrega.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_dataentrega.Size = new System.Drawing.Size(86, 16);
            this.lbl_dataentrega.TabIndex = 193;
            this.lbl_dataentrega.Text = "Data Entrega";
            // 
            // lbl_datainicial
            // 
            this.lbl_datainicial.AutoSize = true;
            this.lbl_datainicial.Location = new System.Drawing.Point(777, 669);
            this.lbl_datainicial.Name = "lbl_datainicial";
            this.lbl_datainicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_datainicial.Size = new System.Drawing.Size(73, 16);
            this.lbl_datainicial.TabIndex = 191;
            this.lbl_datainicial.Text = "Data Inicial";
            // 
            // mnth_dataentrega
            // 
            this.mnth_dataentrega.Location = new System.Drawing.Point(1036, 695);
            this.mnth_dataentrega.Name = "mnth_dataentrega";
            this.mnth_dataentrega.TabIndex = 190;
            // 
            // mnth_datainicial
            // 
            this.mnth_datainicial.Location = new System.Drawing.Point(683, 695);
            this.mnth_datainicial.Name = "mnth_datainicial";
            this.mnth_datainicial.TabIndex = 188;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 669);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 16);
            this.label11.TabIndex = 186;
            this.label11.Text = "Detalhes do Pedido";
            // 
            // pctb_estampa
            // 
            this.pctb_estampa.Location = new System.Drawing.Point(170, 801);
            this.pctb_estampa.Name = "pctb_estampa";
            this.pctb_estampa.Size = new System.Drawing.Size(152, 107);
            this.pctb_estampa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_estampa.TabIndex = 185;
            this.pctb_estampa.TabStop = false;
            // 
            // cmb_tecnica
            // 
            this.cmb_tecnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tecnica.FormattingEnabled = true;
            this.cmb_tecnica.Items.AddRange(new object[] {
            "Sublimação",
            "Transfer",
            "Bordado"});
            this.cmb_tecnica.Location = new System.Drawing.Point(170, 724);
            this.cmb_tecnica.Name = "cmb_tecnica";
            this.cmb_tecnica.Size = new System.Drawing.Size(121, 24);
            this.cmb_tecnica.TabIndex = 181;
            // 
            // grpb_quantidades
            // 
            this.grpb_quantidades.Controls.Add(this.lbl_tamG);
            this.grpb_quantidades.Controls.Add(this.lbl_tamM);
            this.grpb_quantidades.Controls.Add(this.lbl_tamP);
            this.grpb_quantidades.Controls.Add(this.lbl_totalCamisetas);
            this.grpb_quantidades.Controls.Add(this.txb_totalCamisetas);
            this.grpb_quantidades.Controls.Add(this.txb_disponibilizadocliente);
            this.grpb_quantidades.Controls.Add(this.check_disponibilizadocliente);
            this.grpb_quantidades.Controls.Add(this.txb_tamG);
            this.grpb_quantidades.Controls.Add(this.txb_tamM);
            this.grpb_quantidades.Controls.Add(this.txb_tamP);
            this.grpb_quantidades.Controls.Add(this.label5);
            this.grpb_quantidades.Location = new System.Drawing.Point(387, 696);
            this.grpb_quantidades.Name = "grpb_quantidades";
            this.grpb_quantidades.Size = new System.Drawing.Size(257, 221);
            this.grpb_quantidades.TabIndex = 173;
            this.grpb_quantidades.TabStop = false;
            // 
            // lbl_tamG
            // 
            this.lbl_tamG.AutoSize = true;
            this.lbl_tamG.Location = new System.Drawing.Point(21, 127);
            this.lbl_tamG.Name = "lbl_tamG";
            this.lbl_tamG.Size = new System.Drawing.Size(17, 16);
            this.lbl_tamG.TabIndex = 18;
            this.lbl_tamG.Text = "G";
            // 
            // lbl_tamM
            // 
            this.lbl_tamM.AutoSize = true;
            this.lbl_tamM.Location = new System.Drawing.Point(20, 89);
            this.lbl_tamM.Name = "lbl_tamM";
            this.lbl_tamM.Size = new System.Drawing.Size(18, 16);
            this.lbl_tamM.TabIndex = 17;
            this.lbl_tamM.Text = "M";
            // 
            // lbl_tamP
            // 
            this.lbl_tamP.AutoSize = true;
            this.lbl_tamP.Location = new System.Drawing.Point(23, 55);
            this.lbl_tamP.Name = "lbl_tamP";
            this.lbl_tamP.Size = new System.Drawing.Size(16, 16);
            this.lbl_tamP.TabIndex = 16;
            this.lbl_tamP.Text = "P";
            // 
            // lbl_totalCamisetas
            // 
            this.lbl_totalCamisetas.AutoSize = true;
            this.lbl_totalCamisetas.Location = new System.Drawing.Point(97, 188);
            this.lbl_totalCamisetas.Name = "lbl_totalCamisetas";
            this.lbl_totalCamisetas.Size = new System.Drawing.Size(41, 16);
            this.lbl_totalCamisetas.TabIndex = 15;
            this.lbl_totalCamisetas.Text = "Total:";
            // 
            // txb_totalCamisetas
            // 
            this.txb_totalCamisetas.Location = new System.Drawing.Point(150, 185);
            this.txb_totalCamisetas.Name = "txb_totalCamisetas";
            this.txb_totalCamisetas.Size = new System.Drawing.Size(76, 22);
            this.txb_totalCamisetas.TabIndex = 14;
            // 
            // txb_disponibilizadocliente
            // 
            this.txb_disponibilizadocliente.Location = new System.Drawing.Point(212, 143);
            this.txb_disponibilizadocliente.Name = "txb_disponibilizadocliente";
            this.txb_disponibilizadocliente.Size = new System.Drawing.Size(30, 22);
            this.txb_disponibilizadocliente.TabIndex = 13;
            // 
            // check_disponibilizadocliente
            // 
            this.check_disponibilizadocliente.AutoSize = true;
            this.check_disponibilizadocliente.Location = new System.Drawing.Point(25, 145);
            this.check_disponibilizadocliente.Name = "check_disponibilizadocliente";
            this.check_disponibilizadocliente.Size = new System.Drawing.Size(199, 20);
            this.check_disponibilizadocliente.TabIndex = 12;
            this.check_disponibilizadocliente.Text = "disponibilizado pelo cliente?";
            this.check_disponibilizadocliente.UseVisualStyleBackColor = true;
            // 
            // txb_tamG
            // 
            this.txb_tamG.Location = new System.Drawing.Point(53, 119);
            this.txb_tamG.Name = "txb_tamG";
            this.txb_tamG.Size = new System.Drawing.Size(30, 22);
            this.txb_tamG.TabIndex = 11;
            // 
            // txb_tamM
            // 
            this.txb_tamM.Location = new System.Drawing.Point(53, 83);
            this.txb_tamM.Name = "txb_tamM";
            this.txb_tamM.Size = new System.Drawing.Size(30, 22);
            this.txb_tamM.TabIndex = 10;
            // 
            // txb_tamP
            // 
            this.txb_tamP.Location = new System.Drawing.Point(53, 52);
            this.txb_tamP.Name = "txb_tamP";
            this.txb_tamP.Size = new System.Drawing.Size(30, 22);
            this.txb_tamP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // cmb_formato
            // 
            this.cmb_formato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formato.FormattingEnabled = true;
            this.cmb_formato.Items.AddRange(new object[] {
            "Regular",
            "Slim Fit",
            "Oversized",
            "Crop Top",
            "Regata",
            "Manga Longa",
            "Manga 3/4"});
            this.cmb_formato.Location = new System.Drawing.Point(34, 836);
            this.cmb_formato.Name = "cmb_formato";
            this.cmb_formato.Size = new System.Drawing.Size(121, 24);
            this.cmb_formato.TabIndex = 183;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 758);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 176;
            this.label7.Text = "Tecido Camisetas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 816);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 16);
            this.label10.TabIndex = 182;
            this.label10.Text = "Formato Camiseta";
            // 
            // cmb_tecido
            // 
            this.cmb_tecido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tecido.FormattingEnabled = true;
            this.cmb_tecido.Items.AddRange(new object[] {
            "Algodão",
            "Poliéster",
            "Algodão-Poliéster"});
            this.cmb_tecido.Location = new System.Drawing.Point(34, 778);
            this.cmb_tecido.Name = "cmb_tecido";
            this.cmb_tecido.Size = new System.Drawing.Size(121, 24);
            this.cmb_tecido.TabIndex = 177;
            // 
            // cmb_cores
            // 
            this.cmb_cores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cores.FormattingEnabled = true;
            this.cmb_cores.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Cinza",
            "Azul",
            "Vermelho",
            "Rosa",
            "Roxo",
            "Laranja"});
            this.cmb_cores.Location = new System.Drawing.Point(34, 724);
            this.cmb_cores.Name = "cmb_cores";
            this.cmb_cores.Size = new System.Drawing.Size(121, 24);
            this.cmb_cores.TabIndex = 179;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 704);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 178;
            this.label8.Text = "Cores Camisetas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 704);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 180;
            this.label9.Text = "Técnicas";
            // 
            // cmb_gola
            // 
            this.cmb_gola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gola.FormattingEnabled = true;
            this.cmb_gola.Items.AddRange(new object[] {
            "Gola Redonda",
            "Gola V",
            "Gola Polo",
            "Gola Henley",
            "Gola Careca",
            "Gola Canoa"});
            this.cmb_gola.Location = new System.Drawing.Point(34, 886);
            this.cmb_gola.Name = "cmb_gola";
            this.cmb_gola.Size = new System.Drawing.Size(121, 24);
            this.cmb_gola.TabIndex = 175;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 866);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 174;
            this.label6.Text = "Tipo Gola";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.button3.Location = new System.Drawing.Point(1748, 879);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 73);
            this.button3.TabIndex = 202;
            this.button3.Text = "ATIVAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.button2.Location = new System.Drawing.Point(1748, 793);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 73);
            this.button2.TabIndex = 201;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.button4.Location = new System.Drawing.Point(1748, 707);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 73);
            this.button4.TabIndex = 200;
            this.button4.Text = "SALVAR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_limpar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.btn_limpar.Location = new System.Drawing.Point(1575, 928);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(121, 42);
            this.btn_limpar.TabIndex = 203;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_orcamento
            // 
            this.btn_orcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_orcamento.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_orcamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.btn_orcamento.Location = new System.Drawing.Point(1748, 633);
            this.btn_orcamento.Name = "btn_orcamento";
            this.btn_orcamento.Size = new System.Drawing.Size(164, 58);
            this.btn_orcamento.TabIndex = 192;
            this.btn_orcamento.Text = "Orçamento";
            this.btn_orcamento.UseVisualStyleBackColor = false;
            // 
            // label_voltar
            // 
            this.label_voltar.AutoSize = true;
            this.label_voltar.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label_voltar.Location = new System.Drawing.Point(23, 943);
            this.label_voltar.Name = "label_voltar";
            this.label_voltar.Size = new System.Drawing.Size(116, 27);
            this.label_voltar.TabIndex = 204;
            this.label_voltar.Text = "VOLTAR";
            // 
            // estampariadbDataSet1
            // 
            this.estampariadbDataSet1.DataSetName = "EstampariadbDataSet1";
            this.estampariadbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradoresBindingSource
            // 
            this.colaboradoresBindingSource.DataMember = "Colaboradores";
            this.colaboradoresBindingSource.DataSource = this.estampariadbDataSet1;
            // 
            // colaboradoresTableAdapter
            // 
            this.colaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // consulta_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1924, 1008);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consulta_pedidos";
            this.Text = "consulta_pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.consulta_pedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            this.pnl_formapagamento.ResumeLayout(false);
            this.pnl_formapagamento.PerformLayout();
            this.pnl_dadoscolabcli.ResumeLayout(false);
            this.pnl_dadoscolabcli.PerformLayout();
            this.pnl_valores.ResumeLayout(false);
            this.pnl_valores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_estampa)).EndInit();
            this.grpb_quantidades.ResumeLayout(false);
            this.grpb_quantidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cbx_inativos_Pedidos;
        private System.Windows.Forms.Label lbl_inativos;
        private System.Windows.Forms.TextBox txt_pesquisarNome;
        private System.Windows.Forms.Label lbl_pesquisarNome;
        private System.Windows.Forms.Label lbl_Consulta_Materiais;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridView dtv_pedidos;
        private EstampariadbDataSet estampariadbDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private EstampariadbDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corCamisetaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecidoCamisetaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatoCamisetaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoGolaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnicasPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estampaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamPquantPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamMquantPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamGquantPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diponibilizadoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantdisponibilizadoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCamisetasPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorEntradaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorAbertoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnl_formapagamento;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ComboBox cmb_formapagamentoFinal;
        private System.Windows.Forms.Label lbl_formapagamentoFinal;
        private System.Windows.Forms.ComboBox cmb_formapagamentoEntrada;
        private System.Windows.Forms.Label lbl_formapagamentoEntrada;
        private System.Windows.Forms.Panel pnl_dadoscolabcli;
        private System.Windows.Forms.ComboBox cmb_idCliente;
        private System.Windows.Forms.ComboBox cmb_idColaborador;
        private System.Windows.Forms.Label lbl_nomeCliente;
        private System.Windows.Forms.TextBox txb_nomeColaborador;
        private System.Windows.Forms.TextBox txb_nomeCliente;
        private System.Windows.Forms.Label lbl_idColaborador;
        private System.Windows.Forms.Panel pnl_valores;
        private System.Windows.Forms.TextBox txb_valorAberto;
        private System.Windows.Forms.Label lbl_valorAberto;
        private System.Windows.Forms.TextBox txb_valorEntrada;
        private System.Windows.Forms.TextBox txb_valorTotal;
        private System.Windows.Forms.TextBox txb_valorUnit;
        private System.Windows.Forms.Label lbl_valorEntrada;
        private System.Windows.Forms.Label lbl_valorTotal;
        private System.Windows.Forms.Label lbl_valorUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_caminhoImagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_dataentrega;
        private System.Windows.Forms.Label lbl_datainicial;
        private System.Windows.Forms.MonthCalendar mnth_dataentrega;
        private System.Windows.Forms.MonthCalendar mnth_datainicial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pctb_estampa;
        private System.Windows.Forms.ComboBox cmb_tecnica;
        private System.Windows.Forms.GroupBox grpb_quantidades;
        private System.Windows.Forms.Label lbl_tamG;
        private System.Windows.Forms.Label lbl_tamM;
        private System.Windows.Forms.Label lbl_tamP;
        private System.Windows.Forms.Label lbl_totalCamisetas;
        private System.Windows.Forms.TextBox txb_totalCamisetas;
        private System.Windows.Forms.TextBox txb_disponibilizadocliente;
        private System.Windows.Forms.CheckBox check_disponibilizadocliente;
        private System.Windows.Forms.TextBox txb_tamG;
        private System.Windows.Forms.TextBox txb_tamM;
        private System.Windows.Forms.TextBox txb_tamP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_formato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_tecido;
        private System.Windows.Forms.ComboBox cmb_cores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_gola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_orcamento;
        private System.Windows.Forms.Label label_voltar;
        private EstampariadbDataSet1 estampariadbDataSet1;
        private System.Windows.Forms.BindingSource colaboradoresBindingSource;
        private EstampariadbDataSet1TableAdapters.ColaboradoresTableAdapter colaboradoresTableAdapter;
    }
}