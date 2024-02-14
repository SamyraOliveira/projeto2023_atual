namespace projeto2023.views.producao
{
    partial class crud_producao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crud_producao));
            this.dvPedidosProdução = new System.Windows.Forms.DataGridView();
            this.codigo_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_Colaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estampa_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1 = new projeto2023.EstampariadbDataSet();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pedidosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txb_idpedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_responsavel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_qp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_qm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_qg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_cor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_tecido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_formato = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_gola = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_tecnica = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_estrega = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.pcb_estampa = new System.Windows.Forms.PictureBox();
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter1 = new projeto2023.EstampariadbDataSetTableAdapters.PedidosTableAdapter();
            this.txb_caminho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvPedidosProdução)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_estampa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvPedidosProdução
            // 
            this.dvPedidosProdução.AllowUserToAddRows = false;
            this.dvPedidosProdução.AllowUserToDeleteRows = false;
            this.dvPedidosProdução.AllowUserToResizeColumns = false;
            this.dvPedidosProdução.AllowUserToResizeRows = false;
            this.dvPedidosProdução.AutoGenerateColumns = false;
            this.dvPedidosProdução.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.dvPedidosProdução.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvPedidosProdução.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvPedidosProdução.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPedidosProdução.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_Pedido,
            this.cor,
            this.quantidade_p,
            this.quantidade_m,
            this.quantidade_g,
            this.total_pedido,
            this.data_entrega,
            this.status_Pedido,
            this.codigo_Colaborador,
            this.codigo_Cliente,
            this.tecido,
            this.formato,
            this.gola,
            this.tecnicas,
            this.estampa_Pedido});
            this.dvPedidosProdução.DataSource = this.pedidosBindingSource3;
            this.dvPedidosProdução.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dvPedidosProdução.GridColor = System.Drawing.Color.Khaki;
            this.dvPedidosProdução.Location = new System.Drawing.Point(19, 60);
            this.dvPedidosProdução.Name = "dvPedidosProdução";
            this.dvPedidosProdução.ReadOnly = true;
            this.dvPedidosProdução.RowHeadersWidth = 51;
            this.dvPedidosProdução.RowTemplate.Height = 24;
            this.dvPedidosProdução.Size = new System.Drawing.Size(722, 637);
            this.dvPedidosProdução.TabIndex = 1;
            this.dvPedidosProdução.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvPedidosProdução_CellContentDoubleClick);
            // 
            // codigo_Pedido
            // 
            this.codigo_Pedido.DataPropertyName = "codigo_Pedido";
            this.codigo_Pedido.HeaderText = "cod";
            this.codigo_Pedido.MinimumWidth = 6;
            this.codigo_Pedido.Name = "codigo_Pedido";
            this.codigo_Pedido.ReadOnly = true;
            this.codigo_Pedido.Width = 45;
            // 
            // cor
            // 
            this.cor.DataPropertyName = "corCamiseta_Pedido";
            this.cor.HeaderText = "COR";
            this.cor.MinimumWidth = 6;
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
            this.cor.Width = 80;
            // 
            // quantidade_p
            // 
            this.quantidade_p.DataPropertyName = "tamP_quant_Pedido";
            this.quantidade_p.HeaderText = "Quantidade P";
            this.quantidade_p.MinimumWidth = 6;
            this.quantidade_p.Name = "quantidade_p";
            this.quantidade_p.ReadOnly = true;
            this.quantidade_p.Width = 95;
            // 
            // quantidade_m
            // 
            this.quantidade_m.DataPropertyName = "tamM_quant_Pedido";
            this.quantidade_m.HeaderText = "Quantidade M";
            this.quantidade_m.MinimumWidth = 6;
            this.quantidade_m.Name = "quantidade_m";
            this.quantidade_m.ReadOnly = true;
            this.quantidade_m.Width = 95;
            // 
            // quantidade_g
            // 
            this.quantidade_g.DataPropertyName = "tamG_quant_Pedido";
            this.quantidade_g.HeaderText = "Quantidade G";
            this.quantidade_g.MinimumWidth = 6;
            this.quantidade_g.Name = "quantidade_g";
            this.quantidade_g.ReadOnly = true;
            this.quantidade_g.Width = 95;
            // 
            // total_pedido
            // 
            this.total_pedido.DataPropertyName = "totalCamisetas_Pedido";
            this.total_pedido.HeaderText = "Total Pedido";
            this.total_pedido.MinimumWidth = 6;
            this.total_pedido.Name = "total_pedido";
            this.total_pedido.ReadOnly = true;
            this.total_pedido.Width = 87;
            // 
            // data_entrega
            // 
            this.data_entrega.DataPropertyName = "data_entrega";
            this.data_entrega.HeaderText = "Entrega";
            this.data_entrega.MinimumWidth = 6;
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.ReadOnly = true;
            this.data_entrega.Width = 85;
            // 
            // status_Pedido
            // 
            this.status_Pedido.DataPropertyName = "status_Pedido";
            this.status_Pedido.HeaderText = "Status";
            this.status_Pedido.MinimumWidth = 6;
            this.status_Pedido.Name = "status_Pedido";
            this.status_Pedido.ReadOnly = true;
            this.status_Pedido.Width = 85;
            // 
            // codigo_Colaborador
            // 
            this.codigo_Colaborador.DataPropertyName = "codigo_Colaborador";
            this.codigo_Colaborador.HeaderText = "codigo_Colaborador";
            this.codigo_Colaborador.MinimumWidth = 6;
            this.codigo_Colaborador.Name = "codigo_Colaborador";
            this.codigo_Colaborador.ReadOnly = true;
            this.codigo_Colaborador.Width = 125;
            // 
            // codigo_Cliente
            // 
            this.codigo_Cliente.DataPropertyName = "codigo_Cliente";
            this.codigo_Cliente.HeaderText = "codigo_Cliente";
            this.codigo_Cliente.MinimumWidth = 6;
            this.codigo_Cliente.Name = "codigo_Cliente";
            this.codigo_Cliente.ReadOnly = true;
            this.codigo_Cliente.Width = 125;
            // 
            // tecido
            // 
            this.tecido.DataPropertyName = "tecidoCamiseta_Pedido";
            this.tecido.HeaderText = "tecidoCamiseta_Pedido";
            this.tecido.MinimumWidth = 6;
            this.tecido.Name = "tecido";
            this.tecido.ReadOnly = true;
            this.tecido.Width = 125;
            // 
            // formato
            // 
            this.formato.DataPropertyName = "formatoCamiseta_Pedido";
            this.formato.HeaderText = "formatoCamiseta_Pedido";
            this.formato.MinimumWidth = 6;
            this.formato.Name = "formato";
            this.formato.ReadOnly = true;
            this.formato.Width = 125;
            // 
            // gola
            // 
            this.gola.DataPropertyName = "tipoGola_Pedido";
            this.gola.HeaderText = "tipoGola_Pedido";
            this.gola.MinimumWidth = 6;
            this.gola.Name = "gola";
            this.gola.ReadOnly = true;
            this.gola.Width = 125;
            // 
            // tecnicas
            // 
            this.tecnicas.DataPropertyName = "tecnicas_Pedido";
            this.tecnicas.HeaderText = "tecnicas_Pedido";
            this.tecnicas.MinimumWidth = 6;
            this.tecnicas.Name = "tecnicas";
            this.tecnicas.ReadOnly = true;
            this.tecnicas.Width = 125;
            // 
            // estampa_Pedido
            // 
            this.estampa_Pedido.DataPropertyName = "estampa_Pedido";
            this.estampa_Pedido.HeaderText = "estampa_Pedido";
            this.estampa_Pedido.MinimumWidth = 6;
            this.estampa_Pedido.Name = "estampa_Pedido";
            this.estampa_Pedido.ReadOnly = true;
            this.estampa_Pedido.Width = 125;
            // 
            // pedidosBindingSource3
            // 
            this.pedidosBindingSource3.DataMember = "Pedidos";
            this.pedidosBindingSource3.DataSource = this.estampariadbDataSet1BindingSource;
            // 
            // estampariadbDataSet1BindingSource
            // 
            this.estampariadbDataSet1BindingSource.DataSource = this.estampariadbDataSet1;
            this.estampariadbDataSet1BindingSource.Position = 0;
            // 
            // estampariadbDataSet1
            // 
            this.estampariadbDataSet1.DataSetName = "EstampariadbDataSet";
            this.estampariadbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos Pendentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(978, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Linhas de Produção";
            // 
            // pedidosBindingSource2
            // 
            this.pedidosBindingSource2.DataMember = "Pedidos";
            this.pedidosBindingSource2.DataSource = this.estampariadbDataSet1BindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 740);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "VOLTAR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txb_idpedido
            // 
            this.txb_idpedido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_idpedido.Location = new System.Drawing.Point(906, 182);
            this.txb_idpedido.Name = "txb_idpedido";
            this.txb_idpedido.ReadOnly = true;
            this.txb_idpedido.Size = new System.Drawing.Size(109, 26);
            this.txb_idpedido.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label5.Location = new System.Drawing.Point(775, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 137;
            this.label5.Text = "ID Pedido:";
            // 
            // txb_responsavel
            // 
            this.txb_responsavel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_responsavel.Location = new System.Drawing.Point(1243, 184);
            this.txb_responsavel.Name = "txb_responsavel";
            this.txb_responsavel.ReadOnly = true;
            this.txb_responsavel.Size = new System.Drawing.Size(220, 26);
            this.txb_responsavel.TabIndex = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label6.Location = new System.Drawing.Point(1077, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 26);
            this.label6.TabIndex = 139;
            this.label6.Text = "Responsavel:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txb_qp
            // 
            this.txb_qp.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_qp.Location = new System.Drawing.Point(1332, 291);
            this.txb_qp.Name = "txb_qp";
            this.txb_qp.ReadOnly = true;
            this.txb_qp.Size = new System.Drawing.Size(109, 26);
            this.txb_qp.TabIndex = 144;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label8.Location = new System.Drawing.Point(1154, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 26);
            this.label8.TabIndex = 143;
            this.label8.Text = "Quantidade P:";
            // 
            // txb_qm
            // 
            this.txb_qm.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_qm.Location = new System.Drawing.Point(1334, 330);
            this.txb_qm.Name = "txb_qm";
            this.txb_qm.ReadOnly = true;
            this.txb_qm.Size = new System.Drawing.Size(109, 26);
            this.txb_qm.TabIndex = 146;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label9.Location = new System.Drawing.Point(1154, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 26);
            this.label9.TabIndex = 145;
            this.label9.Text = "Quantidade M:";
            // 
            // txb_qg
            // 
            this.txb_qg.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_qg.Location = new System.Drawing.Point(1332, 372);
            this.txb_qg.Name = "txb_qg";
            this.txb_qg.ReadOnly = true;
            this.txb_qg.Size = new System.Drawing.Size(109, 26);
            this.txb_qg.TabIndex = 148;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label10.Location = new System.Drawing.Point(1154, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 26);
            this.label10.TabIndex = 147;
            this.label10.Text = "Quantidade G:";
            // 
            // txb_cor
            // 
            this.txb_cor.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cor.Location = new System.Drawing.Point(823, 299);
            this.txb_cor.Name = "txb_cor";
            this.txb_cor.ReadOnly = true;
            this.txb_cor.Size = new System.Drawing.Size(160, 26);
            this.txb_cor.TabIndex = 150;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label11.Location = new System.Drawing.Point(765, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 26);
            this.label11.TabIndex = 149;
            this.label11.Text = "Cor:";
            // 
            // txb_tecido
            // 
            this.txb_tecido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tecido.Location = new System.Drawing.Point(863, 348);
            this.txb_tecido.Name = "txb_tecido";
            this.txb_tecido.ReadOnly = true;
            this.txb_tecido.Size = new System.Drawing.Size(160, 26);
            this.txb_tecido.TabIndex = 152;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label12.Location = new System.Drawing.Point(765, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 26);
            this.label12.TabIndex = 151;
            this.label12.Text = "Tecido:";
            // 
            // txb_formato
            // 
            this.txb_formato.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_formato.Location = new System.Drawing.Point(878, 397);
            this.txb_formato.Name = "txb_formato";
            this.txb_formato.ReadOnly = true;
            this.txb_formato.Size = new System.Drawing.Size(160, 26);
            this.txb_formato.TabIndex = 154;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label13.Location = new System.Drawing.Point(765, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 26);
            this.label13.TabIndex = 153;
            this.label13.Text = "Formato:";
            // 
            // txb_gola
            // 
            this.txb_gola.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_gola.Location = new System.Drawing.Point(898, 443);
            this.txb_gola.Name = "txb_gola";
            this.txb_gola.ReadOnly = true;
            this.txb_gola.Size = new System.Drawing.Size(160, 26);
            this.txb_gola.TabIndex = 156;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label14.Location = new System.Drawing.Point(765, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 26);
            this.label14.TabIndex = 155;
            this.label14.Text = "Tipo Gola:";
            // 
            // txb_tecnica
            // 
            this.txb_tecnica.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tecnica.Location = new System.Drawing.Point(874, 488);
            this.txb_tecnica.Name = "txb_tecnica";
            this.txb_tecnica.ReadOnly = true;
            this.txb_tecnica.Size = new System.Drawing.Size(160, 26);
            this.txb_tecnica.TabIndex = 158;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label15.Location = new System.Drawing.Point(765, 485);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 26);
            this.label15.TabIndex = 157;
            this.label15.Text = "Tecnica:";
            // 
            // txb_estrega
            // 
            this.txb_estrega.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_estrega.Location = new System.Drawing.Point(1294, 444);
            this.txb_estrega.Name = "txb_estrega";
            this.txb_estrega.ReadOnly = true;
            this.txb_estrega.Size = new System.Drawing.Size(160, 26);
            this.txb_estrega.TabIndex = 160;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label16.Location = new System.Drawing.Point(1182, 442);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 26);
            this.label16.TabIndex = 159;
            this.label16.Text = "Entrega:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label18.Location = new System.Drawing.Point(1134, 507);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 26);
            this.label18.TabIndex = 163;
            this.label18.Text = "Estampa:";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.btn_iniciar.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(932, 719);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(218, 73);
            this.btn_iniciar.TabIndex = 165;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Visible = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.btn_limpar.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(1213, 718);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(218, 73);
            this.btn_limpar.TabIndex = 166;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Visible = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // pcb_estampa
            // 
            this.pcb_estampa.Location = new System.Drawing.Point(1283, 559);
            this.pcb_estampa.Name = "pcb_estampa";
            this.pcb_estampa.Size = new System.Drawing.Size(196, 135);
            this.pcb_estampa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_estampa.TabIndex = 167;
            this.pcb_estampa.TabStop = false;
            // 
            // pedidosBindingSource1
            // 
            this.pedidosBindingSource1.DataMember = "Pedidos";
            this.pedidosBindingSource1.DataSource = this.estampariadbDataSet1;
            // 
            // pedidosTableAdapter1
            // 
            this.pedidosTableAdapter1.ClearBeforeFill = true;
            // 
            // txb_caminho
            // 
            this.txb_caminho.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_caminho.Location = new System.Drawing.Point(1282, 511);
            this.txb_caminho.Name = "txb_caminho";
            this.txb_caminho.ReadOnly = true;
            this.txb_caminho.Size = new System.Drawing.Size(160, 26);
            this.txb_caminho.TabIndex = 168;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 728);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 22);
            this.label4.TabIndex = 169;
            this.label4.Text = "Verificar Produções >";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // crud_producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1771, 845);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_caminho);
            this.Controls.Add(this.pcb_estampa);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txb_estrega);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txb_tecnica);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txb_gola);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txb_formato);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_tecido);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txb_cor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txb_qg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_qm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_qp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_responsavel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_idpedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvPedidosProdução);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "crud_producao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linha de Produção";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.crud_producao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvPedidosProdução)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_estampa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private EstampariadbDataSet estampariadbDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private EstampariadbDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corCamisetaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCamisetasPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private EstampariadbDataSet estampariadbDataSet1;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
        private EstampariadbDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter1;
        private System.Windows.Forms.BindingSource pedidosBindingSource2;
        private System.Windows.Forms.BindingSource estampariadbDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dvPedidosProdução;
        private System.Windows.Forms.BindingSource pedidosBindingSource3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_idpedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_responsavel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_qp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_qm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_qg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_cor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_tecido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_formato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_gola;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb_tecnica;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_estrega;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.PictureBox pcb_estampa;
        private System.Windows.Forms.TextBox txb_caminho;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_Colaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecido;
        private System.Windows.Forms.DataGridViewTextBoxColumn formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn gola;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estampa_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_g;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Pedido;
        private System.Windows.Forms.Label label4;
    }
}