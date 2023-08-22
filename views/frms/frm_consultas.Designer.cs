namespace projeto2023.views.frms
{
    partial class frm_consultas
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
            this.pctb_consultas = new System.Windows.Forms.PictureBox();
            this.pnl_consultas = new System.Windows.Forms.Panel();
            this.ltv_clientes = new System.Windows.Forms.ListView();
            this.ltv_materiais = new System.Windows.Forms.ListView();
            this.ltv_fornecedores = new System.Windows.Forms.ListView();
            this.ltv_pedidos = new System.Windows.Forms.ListView();
            this.codigo_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigo_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigo_Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corCamiseta_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tecidoCamiseta_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formatoCamiseta_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipoGola_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tecnicas_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estampa_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamP_quant_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamM_quant_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamG_quant_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disponibilizadoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantdisponibilizadoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalCamisetas_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_inicial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_entrega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorUnit_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorTotal_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorEntrada_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorAberto_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formaPagamentoEntrada_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formaPagamentoFinal_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltv_colaboradores = new System.Windows.Forms.ListView();
            this.menu_consultas = new System.Windows.Forms.MenuStrip();
            this.colaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.materiais = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidos = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_consultas)).BeginInit();
            this.pnl_consultas.SuspendLayout();
            this.menu_consultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctb_consultas
            // 
            this.pctb_consultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_consultas.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_consultas.Location = new System.Drawing.Point(1029, 239);
            this.pctb_consultas.Name = "pctb_consultas";
            this.pctb_consultas.Size = new System.Drawing.Size(292, 309);
            this.pctb_consultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_consultas.TabIndex = 5;
            this.pctb_consultas.TabStop = false;
            // 
            // pnl_consultas
            // 
            this.pnl_consultas.Controls.Add(this.ltv_clientes);
            this.pnl_consultas.Controls.Add(this.ltv_materiais);
            this.pnl_consultas.Controls.Add(this.ltv_fornecedores);
            this.pnl_consultas.Controls.Add(this.ltv_pedidos);
            this.pnl_consultas.Controls.Add(this.ltv_colaboradores);
            this.pnl_consultas.Location = new System.Drawing.Point(12, 71);
            this.pnl_consultas.Name = "pnl_consultas";
            this.pnl_consultas.Size = new System.Drawing.Size(1011, 609);
            this.pnl_consultas.TabIndex = 4;
            // 
            // ltv_clientes
            // 
            this.ltv_clientes.HideSelection = false;
            this.ltv_clientes.Location = new System.Drawing.Point(374, 434);
            this.ltv_clientes.Name = "ltv_clientes";
            this.ltv_clientes.Size = new System.Drawing.Size(286, 172);
            this.ltv_clientes.TabIndex = 4;
            this.ltv_clientes.UseCompatibleStateImageBehavior = false;
            this.ltv_clientes.Visible = false;
            // 
            // ltv_materiais
            // 
            this.ltv_materiais.HideSelection = false;
            this.ltv_materiais.Location = new System.Drawing.Point(666, 434);
            this.ltv_materiais.Name = "ltv_materiais";
            this.ltv_materiais.Size = new System.Drawing.Size(286, 172);
            this.ltv_materiais.TabIndex = 3;
            this.ltv_materiais.UseCompatibleStateImageBehavior = false;
            this.ltv_materiais.Visible = false;
            // 
            // ltv_fornecedores
            // 
            this.ltv_fornecedores.HideSelection = false;
            this.ltv_fornecedores.Location = new System.Drawing.Point(18, 393);
            this.ltv_fornecedores.Name = "ltv_fornecedores";
            this.ltv_fornecedores.Size = new System.Drawing.Size(286, 172);
            this.ltv_fornecedores.TabIndex = 2;
            this.ltv_fornecedores.UseCompatibleStateImageBehavior = false;
            this.ltv_fornecedores.Visible = false;
            // 
            // ltv_pedidos
            // 
            this.ltv_pedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ltv_pedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo_Pedido,
            this.codigo_Colaborador,
            this.codigo_Cliente,
            this.corCamiseta_Pedido,
            this.tecidoCamiseta_Pedido,
            this.formatoCamiseta_Pedido,
            this.tipoGola_Pedido,
            this.tecnicas_Pedido,
            this.estampa_Pedido,
            this.tamP_quant_Pedido,
            this.tamM_quant_Pedido,
            this.tamG_quant_Pedido,
            this.disponibilizadoCliente,
            this.quantdisponibilizadoCliente,
            this.totalCamisetas_Pedido,
            this.data_inicial,
            this.data_entrega,
            this.valorUnit_Pedido,
            this.valorTotal_Pedido,
            this.valorEntrada_Pedido,
            this.valorAberto_Pedido,
            this.formaPagamentoEntrada_Pedido,
            this.formaPagamentoFinal_Pedido,
            this.status_Pedido});
            this.ltv_pedidos.HideSelection = false;
            this.ltv_pedidos.Location = new System.Drawing.Point(3, 14);
            this.ltv_pedidos.Name = "ltv_pedidos";
            this.ltv_pedidos.Size = new System.Drawing.Size(1005, 172);
            this.ltv_pedidos.TabIndex = 1;
            this.ltv_pedidos.UseCompatibleStateImageBehavior = false;
            this.ltv_pedidos.View = System.Windows.Forms.View.Details;
            this.ltv_pedidos.Visible = false;
            this.ltv_pedidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ltv_pedidos_MouseClick);
            // 
            // codigo_Pedido
            // 
            this.codigo_Pedido.DisplayIndex = 23;
            this.codigo_Pedido.Text = "Codigo Pedido";
            // 
            // codigo_Colaborador
            // 
            this.codigo_Colaborador.DisplayIndex = 0;
            this.codigo_Colaborador.Text = "ID Colaborador";
            // 
            // codigo_Cliente
            // 
            this.codigo_Cliente.DisplayIndex = 1;
            this.codigo_Cliente.Text = "ID Cliente";
            // 
            // corCamiseta_Pedido
            // 
            this.corCamiseta_Pedido.DisplayIndex = 2;
            this.corCamiseta_Pedido.Text = "Cor Camiseta";
            // 
            // tecidoCamiseta_Pedido
            // 
            this.tecidoCamiseta_Pedido.DisplayIndex = 3;
            this.tecidoCamiseta_Pedido.Text = "Tecido";
            // 
            // formatoCamiseta_Pedido
            // 
            this.formatoCamiseta_Pedido.DisplayIndex = 4;
            this.formatoCamiseta_Pedido.Text = "Formato";
            // 
            // tipoGola_Pedido
            // 
            this.tipoGola_Pedido.DisplayIndex = 5;
            this.tipoGola_Pedido.Text = "Gola";
            // 
            // tecnicas_Pedido
            // 
            this.tecnicas_Pedido.DisplayIndex = 6;
            this.tecnicas_Pedido.Text = "Tecnica";
            // 
            // estampa_Pedido
            // 
            this.estampa_Pedido.DisplayIndex = 7;
            this.estampa_Pedido.Text = "Estampa";
            // 
            // tamP_quant_Pedido
            // 
            this.tamP_quant_Pedido.DisplayIndex = 8;
            this.tamP_quant_Pedido.Text = "Tamanho P";
            // 
            // tamM_quant_Pedido
            // 
            this.tamM_quant_Pedido.DisplayIndex = 9;
            this.tamM_quant_Pedido.Text = "Tamanho M";
            // 
            // tamG_quant_Pedido
            // 
            this.tamG_quant_Pedido.DisplayIndex = 10;
            this.tamG_quant_Pedido.Text = "Tamanho G";
            // 
            // disponibilizadoCliente
            // 
            this.disponibilizadoCliente.DisplayIndex = 11;
            this.disponibilizadoCliente.Text = "Disponibilizado Cliente";
            // 
            // quantdisponibilizadoCliente
            // 
            this.quantdisponibilizadoCliente.DisplayIndex = 12;
            this.quantdisponibilizadoCliente.Text = "Quantidade Disponibilizado";
            // 
            // totalCamisetas_Pedido
            // 
            this.totalCamisetas_Pedido.DisplayIndex = 13;
            this.totalCamisetas_Pedido.Text = "Total Camisetas";
            // 
            // data_inicial
            // 
            this.data_inicial.DisplayIndex = 14;
            this.data_inicial.Text = "Data Inicial";
            // 
            // data_entrega
            // 
            this.data_entrega.DisplayIndex = 15;
            this.data_entrega.Text = "Data Entrega";
            // 
            // valorUnit_Pedido
            // 
            this.valorUnit_Pedido.DisplayIndex = 16;
            this.valorUnit_Pedido.Text = "Valor Unitário";
            // 
            // valorTotal_Pedido
            // 
            this.valorTotal_Pedido.DisplayIndex = 17;
            this.valorTotal_Pedido.Text = "Valor Total";
            // 
            // valorEntrada_Pedido
            // 
            this.valorEntrada_Pedido.DisplayIndex = 18;
            this.valorEntrada_Pedido.Text = "Valor Entrada";
            // 
            // valorAberto_Pedido
            // 
            this.valorAberto_Pedido.DisplayIndex = 19;
            this.valorAberto_Pedido.Text = "Valor Aberto";
            // 
            // formaPagamentoEntrada_Pedido
            // 
            this.formaPagamentoEntrada_Pedido.DisplayIndex = 20;
            this.formaPagamentoEntrada_Pedido.Text = "Forma Pag. Entrada";
            // 
            // formaPagamentoFinal_Pedido
            // 
            this.formaPagamentoFinal_Pedido.DisplayIndex = 21;
            this.formaPagamentoFinal_Pedido.Text = "Forma Pag. Final";
            // 
            // status_Pedido
            // 
            this.status_Pedido.DisplayIndex = 22;
            this.status_Pedido.Text = "Status";
            // 
            // ltv_colaboradores
            // 
            this.ltv_colaboradores.HideSelection = false;
            this.ltv_colaboradores.Location = new System.Drawing.Point(3, 192);
            this.ltv_colaboradores.Name = "ltv_colaboradores";
            this.ltv_colaboradores.Size = new System.Drawing.Size(1005, 172);
            this.ltv_colaboradores.TabIndex = 0;
            this.ltv_colaboradores.UseCompatibleStateImageBehavior = false;
            this.ltv_colaboradores.Visible = false;
            // 
            // menu_consultas
            // 
            this.menu_consultas.BackColor = System.Drawing.SystemColors.Control;
            this.menu_consultas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradores,
            this.fornecedores,
            this.materiais,
            this.clientes,
            this.pedidos});
            this.menu_consultas.Location = new System.Drawing.Point(0, 0);
            this.menu_consultas.Name = "menu_consultas";
            this.menu_consultas.Size = new System.Drawing.Size(1333, 24);
            this.menu_consultas.TabIndex = 3;
            this.menu_consultas.Text = "menuStrip1";
            // 
            // colaboradores
            // 
            this.colaboradores.Name = "colaboradores";
            this.colaboradores.Size = new System.Drawing.Size(96, 20);
            this.colaboradores.Text = "Colaboradores";
            this.colaboradores.Click += new System.EventHandler(this.colaboradores_Click);
            // 
            // fornecedores
            // 
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(90, 20);
            this.fornecedores.Text = "Fornecedores";
            this.fornecedores.Click += new System.EventHandler(this.fornecedores_Click);
            // 
            // materiais
            // 
            this.materiais.Name = "materiais";
            this.materiais.Size = new System.Drawing.Size(67, 20);
            this.materiais.Text = "Materiais";
            this.materiais.Click += new System.EventHandler(this.materiais_Click);
            // 
            // clientes
            // 
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(61, 20);
            this.clientes.Text = "Clientes";
            this.clientes.Click += new System.EventHandler(this.clientes_Click);
            // 
            // pedidos
            // 
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(61, 20);
            this.pedidos.Text = "Pedidos";
            this.pedidos.Click += new System.EventHandler(this.pedidos_Click);
            // 
            // frm_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.pctb_consultas);
            this.Controls.Add(this.pnl_consultas);
            this.Controls.Add(this.menu_consultas);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctb_consultas)).EndInit();
            this.pnl_consultas.ResumeLayout(false);
            this.menu_consultas.ResumeLayout(false);
            this.menu_consultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctb_consultas;
        private System.Windows.Forms.Panel pnl_consultas;
        private System.Windows.Forms.MenuStrip menu_consultas;
        private System.Windows.Forms.ToolStripMenuItem colaboradores;
        private System.Windows.Forms.ToolStripMenuItem fornecedores;
        private System.Windows.Forms.ToolStripMenuItem materiais;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem pedidos;
        private System.Windows.Forms.ListView ltv_clientes;
        private System.Windows.Forms.ListView ltv_materiais;
        private System.Windows.Forms.ListView ltv_fornecedores;
        private System.Windows.Forms.ListView ltv_pedidos;
        private System.Windows.Forms.ListView ltv_colaboradores;
        private System.Windows.Forms.ColumnHeader codigo_Colaborador;
        private System.Windows.Forms.ColumnHeader codigo_Cliente;
        private System.Windows.Forms.ColumnHeader corCamiseta_Pedido;
        private System.Windows.Forms.ColumnHeader tecidoCamiseta_Pedido;
        private System.Windows.Forms.ColumnHeader formatoCamiseta_Pedido;
        private System.Windows.Forms.ColumnHeader tipoGola_Pedido;
        private System.Windows.Forms.ColumnHeader tecnicas_Pedido;
        private System.Windows.Forms.ColumnHeader estampa_Pedido;
        private System.Windows.Forms.ColumnHeader tamP_quant_Pedido;
        private System.Windows.Forms.ColumnHeader tamM_quant_Pedido;
        private System.Windows.Forms.ColumnHeader tamG_quant_Pedido;
        private System.Windows.Forms.ColumnHeader disponibilizadoCliente;
        private System.Windows.Forms.ColumnHeader quantdisponibilizadoCliente;
        private System.Windows.Forms.ColumnHeader totalCamisetas_Pedido;
        private System.Windows.Forms.ColumnHeader data_inicial;
        private System.Windows.Forms.ColumnHeader data_entrega;
        private System.Windows.Forms.ColumnHeader valorUnit_Pedido;
        private System.Windows.Forms.ColumnHeader valorTotal_Pedido;
        private System.Windows.Forms.ColumnHeader valorEntrada_Pedido;
        private System.Windows.Forms.ColumnHeader valorAberto_Pedido;
        private System.Windows.Forms.ColumnHeader formaPagamentoEntrada_Pedido;
        private System.Windows.Forms.ColumnHeader formaPagamentoFinal_Pedido;
        private System.Windows.Forms.ColumnHeader status_Pedido;
        private System.Windows.Forms.ColumnHeader codigo_Pedido;
    }
}