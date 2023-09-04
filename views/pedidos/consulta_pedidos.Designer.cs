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
            this.dtv_pedidos.Name = "dtv_pedidos";
            this.dtv_pedidos.ReadOnly = true;
            this.dtv_pedidos.Size = new System.Drawing.Size(1368, 525);
            this.dtv_pedidos.TabIndex = 8;
            // 
            // codigoPedidoDataGridViewTextBoxColumn
            // 
            this.codigoPedidoDataGridViewTextBoxColumn.DataPropertyName = "codigo_Pedido";
            this.codigoPedidoDataGridViewTextBoxColumn.HeaderText = "codigo_Pedido";
            this.codigoPedidoDataGridViewTextBoxColumn.Name = "codigoPedidoDataGridViewTextBoxColumn";
            this.codigoPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoColaboradorDataGridViewTextBoxColumn
            // 
            this.codigoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "codigo_Colaborador";
            this.codigoColaboradorDataGridViewTextBoxColumn.HeaderText = "codigo_Colaborador";
            this.codigoColaboradorDataGridViewTextBoxColumn.Name = "codigoColaboradorDataGridViewTextBoxColumn";
            this.codigoColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "codigo_Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corCamisetaPedidoDataGridViewTextBoxColumn
            // 
            this.corCamisetaPedidoDataGridViewTextBoxColumn.DataPropertyName = "corCamiseta_Pedido";
            this.corCamisetaPedidoDataGridViewTextBoxColumn.HeaderText = "corCamiseta_Pedido";
            this.corCamisetaPedidoDataGridViewTextBoxColumn.Name = "corCamisetaPedidoDataGridViewTextBoxColumn";
            this.corCamisetaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tecidoCamisetaPedidoDataGridViewTextBoxColumn
            // 
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.DataPropertyName = "tecidoCamiseta_Pedido";
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.HeaderText = "tecidoCamiseta_Pedido";
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.Name = "tecidoCamisetaPedidoDataGridViewTextBoxColumn";
            this.tecidoCamisetaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatoCamisetaPedidoDataGridViewTextBoxColumn
            // 
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.DataPropertyName = "formatoCamiseta_Pedido";
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.HeaderText = "formatoCamiseta_Pedido";
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.Name = "formatoCamisetaPedidoDataGridViewTextBoxColumn";
            this.formatoCamisetaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoGolaPedidoDataGridViewTextBoxColumn
            // 
            this.tipoGolaPedidoDataGridViewTextBoxColumn.DataPropertyName = "tipoGola_Pedido";
            this.tipoGolaPedidoDataGridViewTextBoxColumn.HeaderText = "tipoGola_Pedido";
            this.tipoGolaPedidoDataGridViewTextBoxColumn.Name = "tipoGolaPedidoDataGridViewTextBoxColumn";
            this.tipoGolaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tecnicasPedidoDataGridViewTextBoxColumn
            // 
            this.tecnicasPedidoDataGridViewTextBoxColumn.DataPropertyName = "tecnicas_Pedido";
            this.tecnicasPedidoDataGridViewTextBoxColumn.HeaderText = "tecnicas_Pedido";
            this.tecnicasPedidoDataGridViewTextBoxColumn.Name = "tecnicasPedidoDataGridViewTextBoxColumn";
            this.tecnicasPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamPquantPedidoDataGridViewTextBoxColumn
            // 
            this.tamPquantPedidoDataGridViewTextBoxColumn.DataPropertyName = "tamP_quant_Pedido";
            this.tamPquantPedidoDataGridViewTextBoxColumn.HeaderText = "tamP_quant_Pedido";
            this.tamPquantPedidoDataGridViewTextBoxColumn.Name = "tamPquantPedidoDataGridViewTextBoxColumn";
            this.tamPquantPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamMquantPedidoDataGridViewTextBoxColumn
            // 
            this.tamMquantPedidoDataGridViewTextBoxColumn.DataPropertyName = "tamM_quant_Pedido";
            this.tamMquantPedidoDataGridViewTextBoxColumn.HeaderText = "tamM_quant_Pedido";
            this.tamMquantPedidoDataGridViewTextBoxColumn.Name = "tamMquantPedidoDataGridViewTextBoxColumn";
            this.tamMquantPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamGquantPedidoDataGridViewTextBoxColumn
            // 
            this.tamGquantPedidoDataGridViewTextBoxColumn.DataPropertyName = "tamG_quant_Pedido";
            this.tamGquantPedidoDataGridViewTextBoxColumn.HeaderText = "tamG_quant_Pedido";
            this.tamGquantPedidoDataGridViewTextBoxColumn.Name = "tamGquantPedidoDataGridViewTextBoxColumn";
            this.tamGquantPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diponibilizadoClienteDataGridViewTextBoxColumn
            // 
            this.diponibilizadoClienteDataGridViewTextBoxColumn.DataPropertyName = "diponibilizadoCliente";
            this.diponibilizadoClienteDataGridViewTextBoxColumn.HeaderText = "diponibilizadoCliente";
            this.diponibilizadoClienteDataGridViewTextBoxColumn.Name = "diponibilizadoClienteDataGridViewTextBoxColumn";
            this.diponibilizadoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantdisponibilizadoClienteDataGridViewTextBoxColumn
            // 
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.DataPropertyName = "quantdisponibilizadoCliente";
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.HeaderText = "quantdisponibilizadoCliente";
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.Name = "quantdisponibilizadoClienteDataGridViewTextBoxColumn";
            this.quantdisponibilizadoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCamisetasPedidoDataGridViewTextBoxColumn
            // 
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.DataPropertyName = "totalCamisetas_Pedido";
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.HeaderText = "totalCamisetas_Pedido";
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.Name = "totalCamisetasPedidoDataGridViewTextBoxColumn";
            this.totalCamisetasPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datainicialDataGridViewTextBoxColumn
            // 
            this.datainicialDataGridViewTextBoxColumn.DataPropertyName = "data_inicial";
            this.datainicialDataGridViewTextBoxColumn.HeaderText = "data_inicial";
            this.datainicialDataGridViewTextBoxColumn.Name = "datainicialDataGridViewTextBoxColumn";
            this.datainicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            this.dataentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitPedidoDataGridViewTextBoxColumn
            // 
            this.valorUnitPedidoDataGridViewTextBoxColumn.DataPropertyName = "valorUnit_Pedido";
            this.valorUnitPedidoDataGridViewTextBoxColumn.HeaderText = "valorUnit_Pedido";
            this.valorUnitPedidoDataGridViewTextBoxColumn.Name = "valorUnitPedidoDataGridViewTextBoxColumn";
            this.valorUnitPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalPedidoDataGridViewTextBoxColumn
            // 
            this.valorTotalPedidoDataGridViewTextBoxColumn.DataPropertyName = "valorTotal_Pedido";
            this.valorTotalPedidoDataGridViewTextBoxColumn.HeaderText = "valorTotal_Pedido";
            this.valorTotalPedidoDataGridViewTextBoxColumn.Name = "valorTotalPedidoDataGridViewTextBoxColumn";
            this.valorTotalPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorEntradaPedidoDataGridViewTextBoxColumn
            // 
            this.valorEntradaPedidoDataGridViewTextBoxColumn.DataPropertyName = "valorEntrada_Pedido";
            this.valorEntradaPedidoDataGridViewTextBoxColumn.HeaderText = "valorEntrada_Pedido";
            this.valorEntradaPedidoDataGridViewTextBoxColumn.Name = "valorEntradaPedidoDataGridViewTextBoxColumn";
            this.valorEntradaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorAbertoPedidoDataGridViewTextBoxColumn
            // 
            this.valorAbertoPedidoDataGridViewTextBoxColumn.DataPropertyName = "valorAberto_Pedido";
            this.valorAbertoPedidoDataGridViewTextBoxColumn.HeaderText = "valorAberto_Pedido";
            this.valorAbertoPedidoDataGridViewTextBoxColumn.Name = "valorAbertoPedidoDataGridViewTextBoxColumn";
            this.valorAbertoPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagamentoEntradaPedidoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.DataPropertyName = "formaPagamentoEntrada_Pedido";
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.HeaderText = "formaPagamentoEntrada_Pedido";
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.Name = "formaPagamentoEntradaPedidoDataGridViewTextBoxColumn";
            this.formaPagamentoEntradaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagamentoFinalPedidoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.DataPropertyName = "formaPagamentoFinal_Pedido";
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.HeaderText = "formaPagamentoFinal_Pedido";
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.Name = "formaPagamentoFinalPedidoDataGridViewTextBoxColumn";
            this.formaPagamentoFinalPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusPedidoDataGridViewTextBoxColumn
            // 
            this.statusPedidoDataGridViewTextBoxColumn.DataPropertyName = "status_Pedido";
            this.statusPedidoDataGridViewTextBoxColumn.HeaderText = "status_Pedido";
            this.statusPedidoDataGridViewTextBoxColumn.Name = "statusPedidoDataGridViewTextBoxColumn";
            this.statusPedidoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 525);
            this.panel1.TabIndex = 11;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(1171, 437);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(185, 63);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(973, 437);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(185, 63);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1368, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consulta_pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_pedidos";
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