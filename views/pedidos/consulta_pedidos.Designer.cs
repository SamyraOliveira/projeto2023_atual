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
            this.dtv_pedidos = new System.Windows.Forms.DataGridView();
            this.codigoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corCamisetaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoGolaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnicasPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet = new projeto2023.EstampariadbDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.pedidosTableAdapter = new projeto2023.EstampariadbDataSetTableAdapters.PedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtv_pedidos
            // 
            this.dtv_pedidos.AllowUserToAddRows = false;
            this.dtv_pedidos.AllowUserToDeleteRows = false;
            this.dtv_pedidos.AutoGenerateColumns = false;
            this.dtv_pedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.dtv_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtv_pedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            this.valorAbertoPedidoDataGridViewTextBoxColumn,
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn,
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn,
            this.statusPedidoDataGridViewTextBoxColumn});
            this.dtv_pedidos.DataSource = this.pedidosBindingSource;
            this.dtv_pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtv_pedidos.GridColor = System.Drawing.Color.DarkGray;
            this.dtv_pedidos.Location = new System.Drawing.Point(0, 0);
            this.dtv_pedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtv_pedidos.Name = "dtv_pedidos";
            this.dtv_pedidos.ReadOnly = true;
            this.dtv_pedidos.RowHeadersWidth = 51;
            this.dtv_pedidos.Size = new System.Drawing.Size(1824, 646);
            this.dtv_pedidos.TabIndex = 8;
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
            // formaPagamentoEntradaPedidoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.DataPropertyName = "formaPagamentoEntrada_Pedido";
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.HeaderText = "formaPagamentoEntrada_Pedido";
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.Name = "formaPagamentoEntradaPedidoDataGridViewTextBoxColumn";
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // formaPagamentoFinalPedidoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.DataPropertyName = "formaPagamentoFinal_Pedido";
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.HeaderText = "formaPagamentoFinal_Pedido";
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.Name = "formaPagamentoFinalPedidoDataGridViewTextBoxColumn";
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPedidoDataGridViewTextBoxColumn
            // 
            this.statusPedidoDataGridViewTextBoxColumn.DataPropertyName = "status_Pedido";
            this.statusPedidoDataGridViewTextBoxColumn.HeaderText = "status_Pedido";
            this.statusPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusPedidoDataGridViewTextBoxColumn.Name = "statusPedidoDataGridViewTextBoxColumn";
            this.statusPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.estampariadbDataSet;
            // 
            // estampariadbDataSet
            // 
            this.estampariadbDataSet.DataSetName = "EstampariadbDataSet";
            this.estampariadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.dtv_pedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1824, 646);
            this.panel1.TabIndex = 11;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(1561, 538);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(247, 78);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(1297, 538);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(247, 78);
            this.btn_imprimir.TabIndex = 9;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // consulta_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1824, 646);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consulta_pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Pedidos";
            this.Load += new System.EventHandler(this.consulta_pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_pedidos;
        private System.Windows.Forms.Panel panel1;
        private EstampariadbDataSet estampariadbDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private EstampariadbDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corCamisetaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecidoCamisetaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatoCamisetaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoGolaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnicasPedidoDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoEntradaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoFinalPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPedidoDataGridViewTextBoxColumn;
    }
}