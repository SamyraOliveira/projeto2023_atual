using System.Data;

namespace projeto2023.views.pedidos
{
    partial class crud_pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crud_pedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_orcamento = new System.Windows.Forms.Button();
            this.btnregistrar_pedido = new System.Windows.Forms.Button();
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
            this.pnl_formapagamento = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_formapagamentoFinal = new System.Windows.Forms.ComboBox();
            this.lbl_formapagamentoFinal = new System.Windows.Forms.Label();
            this.cmb_formapagamentoEntrada = new System.Windows.Forms.ComboBox();
            this.lbl_formapagamentoEntrada = new System.Windows.Forms.Label();
            this.pnl_detalhespedido = new System.Windows.Forms.Panel();
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
            this.pnl_dadoscolabcli = new System.Windows.Forms.Panel();
            this.cmb_idCliente = new System.Windows.Forms.ComboBox();
            this.cmb_idColaborador = new System.Windows.Forms.ComboBox();
            this.lbl_nomeCliente = new System.Windows.Forms.Label();
            this.txb_nomeColaborador = new System.Windows.Forms.TextBox();
            this.txb_nomeCliente = new System.Windows.Forms.TextBox();
            this.lbl_idColaborador = new System.Windows.Forms.Label();
            this.OFD_estamparia = new System.Windows.Forms.OpenFileDialog();
            this.ltv_showPedidos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_valores.SuspendLayout();
            this.pnl_formapagamento.SuspendLayout();
            this.pnl_detalhespedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_estampa)).BeginInit();
            this.grpb_quantidades.SuspendLayout();
            this.pnl_dadoscolabcli.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Controls.Add(this.btn_orcamento);
            this.panel1.Controls.Add(this.btnregistrar_pedido);
            this.panel1.Controls.Add(this.pnl_valores);
            this.panel1.Controls.Add(this.pnl_formapagamento);
            this.panel1.Controls.Add(this.pnl_detalhespedido);
            this.panel1.Controls.Add(this.pnl_dadoscolabcli);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 816);
            this.panel1.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(800, 372);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(126, 58);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(660, 372);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(126, 58);
            this.btn_excluir.TabIndex = 24;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(800, 302);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(126, 58);
            this.btn_limpar.TabIndex = 23;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_orcamento
            // 
            this.btn_orcamento.Location = new System.Drawing.Point(660, 434);
            this.btn_orcamento.Name = "btn_orcamento";
            this.btn_orcamento.Size = new System.Drawing.Size(266, 58);
            this.btn_orcamento.TabIndex = 22;
            this.btn_orcamento.Text = "Orçamento";
            this.btn_orcamento.UseVisualStyleBackColor = true;
            // 
            // btnregistrar_pedido
            // 
            this.btnregistrar_pedido.Location = new System.Drawing.Point(660, 301);
            this.btnregistrar_pedido.Name = "btnregistrar_pedido";
            this.btnregistrar_pedido.Size = new System.Drawing.Size(126, 58);
            this.btnregistrar_pedido.TabIndex = 17;
            this.btnregistrar_pedido.Text = "Registrar";
            this.btnregistrar_pedido.UseVisualStyleBackColor = true;
            this.btnregistrar_pedido.Click += new System.EventHandler(this.btnregistrar_pedido_Click);
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
            this.pnl_valores.Location = new System.Drawing.Point(634, 71);
            this.pnl_valores.Name = "pnl_valores";
            this.pnl_valores.Size = new System.Drawing.Size(128, 212);
            this.pnl_valores.TabIndex = 21;
            // 
            // txb_valorAberto
            // 
            this.txb_valorAberto.Location = new System.Drawing.Point(11, 184);
            this.txb_valorAberto.Name = "txb_valorAberto";
            this.txb_valorAberto.Size = new System.Drawing.Size(70, 24);
            this.txb_valorAberto.TabIndex = 16;
            // 
            // lbl_valorAberto
            // 
            this.lbl_valorAberto.AutoSize = true;
            this.lbl_valorAberto.Location = new System.Drawing.Point(8, 165);
            this.lbl_valorAberto.Name = "lbl_valorAberto";
            this.lbl_valorAberto.Size = new System.Drawing.Size(113, 16);
            this.lbl_valorAberto.TabIndex = 15;
            this.lbl_valorAberto.Text = "Valor em Aberto";
            // 
            // txb_valorEntrada
            // 
            this.txb_valorEntrada.Location = new System.Drawing.Point(12, 139);
            this.txb_valorEntrada.Name = "txb_valorEntrada";
            this.txb_valorEntrada.Size = new System.Drawing.Size(70, 24);
            this.txb_valorEntrada.TabIndex = 14;
            // 
            // txb_valorTotal
            // 
            this.txb_valorTotal.Location = new System.Drawing.Point(12, 97);
            this.txb_valorTotal.Name = "txb_valorTotal";
            this.txb_valorTotal.Size = new System.Drawing.Size(70, 24);
            this.txb_valorTotal.TabIndex = 13;
            // 
            // txb_valorUnit
            // 
            this.txb_valorUnit.Location = new System.Drawing.Point(12, 55);
            this.txb_valorUnit.Name = "txb_valorUnit";
            this.txb_valorUnit.Size = new System.Drawing.Size(70, 24);
            this.txb_valorUnit.TabIndex = 6;
            // 
            // lbl_valorEntrada
            // 
            this.lbl_valorEntrada.AutoSize = true;
            this.lbl_valorEntrada.Location = new System.Drawing.Point(9, 120);
            this.lbl_valorEntrada.Name = "lbl_valorEntrada";
            this.lbl_valorEntrada.Size = new System.Drawing.Size(95, 16);
            this.lbl_valorEntrada.TabIndex = 12;
            this.lbl_valorEntrada.Text = "Valor Entrada";
            // 
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.AutoSize = true;
            this.lbl_valorTotal.Location = new System.Drawing.Point(9, 78);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(79, 16);
            this.lbl_valorTotal.TabIndex = 11;
            this.lbl_valorTotal.Text = "Valor Total";
            // 
            // lbl_valorUnit
            // 
            this.lbl_valorUnit.AutoSize = true;
            this.lbl_valorUnit.Location = new System.Drawing.Point(9, 37);
            this.lbl_valorUnit.Name = "lbl_valorUnit";
            this.lbl_valorUnit.Size = new System.Drawing.Size(95, 16);
            this.lbl_valorUnit.TabIndex = 10;
            this.lbl_valorUnit.Text = "Valor Unitário";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Pedido";
            // 
            // pnl_formapagamento
            // 
            this.pnl_formapagamento.Controls.Add(this.lbl_status);
            this.pnl_formapagamento.Controls.Add(this.cmb_status);
            this.pnl_formapagamento.Controls.Add(this.cmb_formapagamentoFinal);
            this.pnl_formapagamento.Controls.Add(this.lbl_formapagamentoFinal);
            this.pnl_formapagamento.Controls.Add(this.cmb_formapagamentoEntrada);
            this.pnl_formapagamento.Controls.Add(this.lbl_formapagamentoEntrada);
            this.pnl_formapagamento.Location = new System.Drawing.Point(768, 71);
            this.pnl_formapagamento.Name = "pnl_formapagamento";
            this.pnl_formapagamento.Size = new System.Drawing.Size(167, 204);
            this.pnl_formapagamento.TabIndex = 20;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(65, 132);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(48, 16);
            this.lbl_status.TabIndex = 21;
            this.lbl_status.Text = "Status";
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(19, 159);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 24);
            this.cmb_status.TabIndex = 20;
            // 
            // cmb_formapagamentoFinal
            // 
            this.cmb_formapagamentoFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formapagamentoFinal.FormattingEnabled = true;
            this.cmb_formapagamentoFinal.Location = new System.Drawing.Point(18, 106);
            this.cmb_formapagamentoFinal.Name = "cmb_formapagamentoFinal";
            this.cmb_formapagamentoFinal.Size = new System.Drawing.Size(121, 24);
            this.cmb_formapagamentoFinal.TabIndex = 19;
            // 
            // lbl_formapagamentoFinal
            // 
            this.lbl_formapagamentoFinal.AutoSize = true;
            this.lbl_formapagamentoFinal.Location = new System.Drawing.Point(16, 73);
            this.lbl_formapagamentoFinal.Name = "lbl_formapagamentoFinal";
            this.lbl_formapagamentoFinal.Size = new System.Drawing.Size(153, 32);
            this.lbl_formapagamentoFinal.TabIndex = 18;
            this.lbl_formapagamentoFinal.Text = "Formas de Pagamento\r\n               Final";
            // 
            // cmb_formapagamentoEntrada
            // 
            this.cmb_formapagamentoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formapagamentoEntrada.FormattingEnabled = true;
            this.cmb_formapagamentoEntrada.Location = new System.Drawing.Point(18, 42);
            this.cmb_formapagamentoEntrada.Name = "cmb_formapagamentoEntrada";
            this.cmb_formapagamentoEntrada.Size = new System.Drawing.Size(121, 24);
            this.cmb_formapagamentoEntrada.TabIndex = 17;
            // 
            // lbl_formapagamentoEntrada
            // 
            this.lbl_formapagamentoEntrada.AutoSize = true;
            this.lbl_formapagamentoEntrada.Location = new System.Drawing.Point(16, 15);
            this.lbl_formapagamentoEntrada.Name = "lbl_formapagamentoEntrada";
            this.lbl_formapagamentoEntrada.Size = new System.Drawing.Size(153, 32);
            this.lbl_formapagamentoEntrada.TabIndex = 0;
            this.lbl_formapagamentoEntrada.Text = "Formas de Pagamento\r\n             Entrada";
            // 
            // pnl_detalhespedido
            // 
            this.pnl_detalhespedido.Controls.Add(this.lbl_dataentrega);
            this.pnl_detalhespedido.Controls.Add(this.lbl_datainicial);
            this.pnl_detalhespedido.Controls.Add(this.mnth_dataentrega);
            this.pnl_detalhespedido.Controls.Add(this.mnth_datainicial);
            this.pnl_detalhespedido.Controls.Add(this.label11);
            this.pnl_detalhespedido.Controls.Add(this.pctb_estampa);
            this.pnl_detalhespedido.Controls.Add(this.cmb_tecnica);
            this.pnl_detalhespedido.Controls.Add(this.grpb_quantidades);
            this.pnl_detalhespedido.Controls.Add(this.cmb_formato);
            this.pnl_detalhespedido.Controls.Add(this.label7);
            this.pnl_detalhespedido.Controls.Add(this.label10);
            this.pnl_detalhespedido.Controls.Add(this.cmb_tecido);
            this.pnl_detalhespedido.Controls.Add(this.cmb_cores);
            this.pnl_detalhespedido.Controls.Add(this.label8);
            this.pnl_detalhespedido.Controls.Add(this.label9);
            this.pnl_detalhespedido.Controls.Add(this.cmb_gola);
            this.pnl_detalhespedido.Controls.Add(this.label6);
            this.pnl_detalhespedido.Location = new System.Drawing.Point(8, 67);
            this.pnl_detalhespedido.Name = "pnl_detalhespedido";
            this.pnl_detalhespedido.Size = new System.Drawing.Size(620, 576);
            this.pnl_detalhespedido.TabIndex = 5;
            // 
            // lbl_dataentrega
            // 
            this.lbl_dataentrega.AutoSize = true;
            this.lbl_dataentrega.Location = new System.Drawing.Point(450, 308);
            this.lbl_dataentrega.Name = "lbl_dataentrega";
            this.lbl_dataentrega.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_dataentrega.Size = new System.Drawing.Size(92, 16);
            this.lbl_dataentrega.TabIndex = 23;
            this.lbl_dataentrega.Text = "Data Entrega";
            // 
            // lbl_datainicial
            // 
            this.lbl_datainicial.AutoSize = true;
            this.lbl_datainicial.Location = new System.Drawing.Point(449, 19);
            this.lbl_datainicial.Name = "lbl_datainicial";
            this.lbl_datainicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_datainicial.Size = new System.Drawing.Size(78, 16);
            this.lbl_datainicial.TabIndex = 22;
            this.lbl_datainicial.Text = "Data Inicial";
            // 
            // mnth_dataentrega
            // 
            this.mnth_dataentrega.Location = new System.Drawing.Point(356, 331);
            this.mnth_dataentrega.Name = "mnth_dataentrega";
            this.mnth_dataentrega.TabIndex = 21;
            // 
            // mnth_datainicial
            // 
            this.mnth_datainicial.Location = new System.Drawing.Point(356, 54);
            this.mnth_datainicial.Name = "mnth_datainicial";
            this.mnth_datainicial.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Detalhes do Pedido";
            // 
            // pctb_estampa
            // 
            this.pctb_estampa.Location = new System.Drawing.Point(162, 106);
            this.pctb_estampa.Name = "pctb_estampa";
            this.pctb_estampa.Size = new System.Drawing.Size(152, 152);
            this.pctb_estampa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_estampa.TabIndex = 18;
            this.pctb_estampa.TabStop = false;
            this.pctb_estampa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctb_estampa_MouseClick);
            // 
            // cmb_tecnica
            // 
            this.cmb_tecnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tecnica.FormattingEnabled = true;
            this.cmb_tecnica.Location = new System.Drawing.Point(162, 74);
            this.cmb_tecnica.Name = "cmb_tecnica";
            this.cmb_tecnica.Size = new System.Drawing.Size(121, 24);
            this.cmb_tecnica.TabIndex = 15;
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
            this.grpb_quantidades.Location = new System.Drawing.Point(26, 262);
            this.grpb_quantidades.Name = "grpb_quantidades";
            this.grpb_quantidades.Size = new System.Drawing.Size(257, 221);
            this.grpb_quantidades.TabIndex = 7;
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
            this.lbl_tamP.Size = new System.Drawing.Size(14, 16);
            this.lbl_tamP.TabIndex = 16;
            this.lbl_tamP.Text = "P";
            // 
            // lbl_totalCamisetas
            // 
            this.lbl_totalCamisetas.AutoSize = true;
            this.lbl_totalCamisetas.Location = new System.Drawing.Point(97, 188);
            this.lbl_totalCamisetas.Name = "lbl_totalCamisetas";
            this.lbl_totalCamisetas.Size = new System.Drawing.Size(45, 16);
            this.lbl_totalCamisetas.TabIndex = 15;
            this.lbl_totalCamisetas.Text = "Total:";
            // 
            // txb_totalCamisetas
            // 
            this.txb_totalCamisetas.Location = new System.Drawing.Point(150, 185);
            this.txb_totalCamisetas.Name = "txb_totalCamisetas";
            this.txb_totalCamisetas.Size = new System.Drawing.Size(76, 24);
            this.txb_totalCamisetas.TabIndex = 14;
            // 
            // txb_disponibilizadocliente
            // 
            this.txb_disponibilizadocliente.Location = new System.Drawing.Point(212, 143);
            this.txb_disponibilizadocliente.Name = "txb_disponibilizadocliente";
            this.txb_disponibilizadocliente.Size = new System.Drawing.Size(30, 24);
            this.txb_disponibilizadocliente.TabIndex = 13;
            this.txb_disponibilizadocliente.TextChanged += new System.EventHandler(this.txb_disponibilizadocliente_TextChanged);
            // 
            // check_disponibilizadocliente
            // 
            this.check_disponibilizadocliente.AutoSize = true;
            this.check_disponibilizadocliente.Location = new System.Drawing.Point(25, 145);
            this.check_disponibilizadocliente.Name = "check_disponibilizadocliente";
            this.check_disponibilizadocliente.Size = new System.Drawing.Size(214, 20);
            this.check_disponibilizadocliente.TabIndex = 12;
            this.check_disponibilizadocliente.Text = "disponibilizado pelo cliente?";
            this.check_disponibilizadocliente.UseVisualStyleBackColor = true;
            // 
            // txb_tamG
            // 
            this.txb_tamG.Location = new System.Drawing.Point(53, 119);
            this.txb_tamG.Name = "txb_tamG";
            this.txb_tamG.Size = new System.Drawing.Size(30, 24);
            this.txb_tamG.TabIndex = 11;
            this.txb_tamG.TextChanged += new System.EventHandler(this.txb_tamG_TextChanged);
            // 
            // txb_tamM
            // 
            this.txb_tamM.Location = new System.Drawing.Point(53, 83);
            this.txb_tamM.Name = "txb_tamM";
            this.txb_tamM.Size = new System.Drawing.Size(30, 24);
            this.txb_tamM.TabIndex = 10;
            this.txb_tamM.TextChanged += new System.EventHandler(this.txb_tamM_TextChanged);
            // 
            // txb_tamP
            // 
            this.txb_tamP.Location = new System.Drawing.Point(53, 52);
            this.txb_tamP.Name = "txb_tamP";
            this.txb_tamP.Size = new System.Drawing.Size(30, 24);
            this.txb_tamP.TabIndex = 8;
            this.txb_tamP.TextChanged += new System.EventHandler(this.txb_tamP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // cmb_formato
            // 
            this.cmb_formato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formato.FormattingEnabled = true;
            this.cmb_formato.Location = new System.Drawing.Point(26, 186);
            this.cmb_formato.Name = "cmb_formato";
            this.cmb_formato.Size = new System.Drawing.Size(121, 24);
            this.cmb_formato.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tecido Camisetas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Formato Camiseta";
            // 
            // cmb_tecido
            // 
            this.cmb_tecido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tecido.FormattingEnabled = true;
            this.cmb_tecido.Location = new System.Drawing.Point(26, 128);
            this.cmb_tecido.Name = "cmb_tecido";
            this.cmb_tecido.Size = new System.Drawing.Size(121, 24);
            this.cmb_tecido.TabIndex = 11;
            // 
            // cmb_cores
            // 
            this.cmb_cores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cores.FormattingEnabled = true;
            this.cmb_cores.Location = new System.Drawing.Point(26, 74);
            this.cmb_cores.Name = "cmb_cores";
            this.cmb_cores.Size = new System.Drawing.Size(121, 24);
            this.cmb_cores.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cores Camisetas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Técnicas";
            // 
            // cmb_gola
            // 
            this.cmb_gola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gola.FormattingEnabled = true;
            this.cmb_gola.Location = new System.Drawing.Point(26, 236);
            this.cmb_gola.Name = "cmb_gola";
            this.cmb_gola.Size = new System.Drawing.Size(121, 24);
            this.cmb_gola.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Gola";
            // 
            // pnl_dadoscolabcli
            // 
            this.pnl_dadoscolabcli.Controls.Add(this.cmb_idCliente);
            this.pnl_dadoscolabcli.Controls.Add(this.cmb_idColaborador);
            this.pnl_dadoscolabcli.Controls.Add(this.lbl_nomeCliente);
            this.pnl_dadoscolabcli.Controls.Add(this.txb_nomeColaborador);
            this.pnl_dadoscolabcli.Controls.Add(this.txb_nomeCliente);
            this.pnl_dadoscolabcli.Controls.Add(this.lbl_idColaborador);
            this.pnl_dadoscolabcli.Location = new System.Drawing.Point(11, 9);
            this.pnl_dadoscolabcli.Name = "pnl_dadoscolabcli";
            this.pnl_dadoscolabcli.Size = new System.Drawing.Size(924, 52);
            this.pnl_dadoscolabcli.TabIndex = 4;
            // 
            // cmb_idCliente
            // 
            this.cmb_idCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idCliente.FormattingEnabled = true;
            this.cmb_idCliente.Location = new System.Drawing.Point(415, 28);
            this.cmb_idCliente.Name = "cmb_idCliente";
            this.cmb_idCliente.Size = new System.Drawing.Size(281, 24);
            this.cmb_idCliente.TabIndex = 7;
            this.cmb_idCliente.SelectedIndexChanged += new System.EventHandler(this.cmb_idCliente_SelectedIndexChanged);
            // 
            // cmb_idColaborador
            // 
            this.cmb_idColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idColaborador.FormattingEnabled = true;
            this.cmb_idColaborador.Location = new System.Drawing.Point(11, 26);
            this.cmb_idColaborador.MaxDropDownItems = 5;
            this.cmb_idColaborador.Name = "cmb_idColaborador";
            this.cmb_idColaborador.Size = new System.Drawing.Size(283, 24);
            this.cmb_idColaborador.TabIndex = 6;
            this.cmb_idColaborador.SelectedIndexChanged += new System.EventHandler(this.cmb_idColaborador_SelectedIndexChanged);
            // 
            // lbl_nomeCliente
            // 
            this.lbl_nomeCliente.AutoSize = true;
            this.lbl_nomeCliente.Location = new System.Drawing.Point(412, 11);
            this.lbl_nomeCliente.Name = "lbl_nomeCliente";
            this.lbl_nomeCliente.Size = new System.Drawing.Size(52, 16);
            this.lbl_nomeCliente.TabIndex = 3;
            this.lbl_nomeCliente.Text = "Cliente";
            // 
            // txb_nomeColaborador
            // 
            this.txb_nomeColaborador.Location = new System.Drawing.Point(101, 28);
            this.txb_nomeColaborador.Name = "txb_nomeColaborador";
            this.txb_nomeColaborador.ReadOnly = true;
            this.txb_nomeColaborador.Size = new System.Drawing.Size(289, 24);
            this.txb_nomeColaborador.TabIndex = 3;
            this.txb_nomeColaborador.Visible = false;
            // 
            // txb_nomeCliente
            // 
            this.txb_nomeCliente.Location = new System.Drawing.Point(503, 28);
            this.txb_nomeCliente.Name = "txb_nomeCliente";
            this.txb_nomeCliente.ReadOnly = true;
            this.txb_nomeCliente.Size = new System.Drawing.Size(289, 24);
            this.txb_nomeCliente.TabIndex = 5;
            this.txb_nomeCliente.Visible = false;
            // 
            // lbl_idColaborador
            // 
            this.lbl_idColaborador.AutoSize = true;
            this.lbl_idColaborador.Location = new System.Drawing.Point(9, 11);
            this.lbl_idColaborador.Name = "lbl_idColaborador";
            this.lbl_idColaborador.Size = new System.Drawing.Size(91, 16);
            this.lbl_idColaborador.TabIndex = 0;
            this.lbl_idColaborador.Text = "Colaborador";
            // 
            // OFD_estamparia
            // 
            this.OFD_estamparia.FileName = "OFD_estamparia";
            // 
            // ltv_showPedidos
            // 
            this.ltv_showPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23});
            this.ltv_showPedidos.HideSelection = false;
            this.ltv_showPedidos.Location = new System.Drawing.Point(993, 161);
            this.ltv_showPedidos.Name = "ltv_showPedidos";
            this.ltv_showPedidos.Size = new System.Drawing.Size(617, 488);
            this.ltv_showPedidos.TabIndex = 1;
            this.ltv_showPedidos.UseCompatibleStateImageBehavior = false;
            this.ltv_showPedidos.View = System.Windows.Forms.View.Details;
            this.ltv_showPedidos.Visible = false;
            this.ltv_showPedidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ltv_showPedidos_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1104, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 68);
            this.label1.TabIndex = 35;
            this.label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "VOLTAR";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // crud_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1646, 840);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltv_showPedidos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "crud_pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.crud_pedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_valores.ResumeLayout(false);
            this.pnl_valores.PerformLayout();
            this.pnl_formapagamento.ResumeLayout(false);
            this.pnl_formapagamento.PerformLayout();
            this.pnl_detalhespedido.ResumeLayout(false);
            this.pnl_detalhespedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_estampa)).EndInit();
            this.grpb_quantidades.ResumeLayout(false);
            this.grpb_quantidades.PerformLayout();
            this.pnl_dadoscolabcli.ResumeLayout(false);
            this.pnl_dadoscolabcli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_detalhespedido;
        private System.Windows.Forms.ComboBox cmb_tecnica;
        private System.Windows.Forms.ComboBox cmb_formato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_tecido;
        private System.Windows.Forms.ComboBox cmb_cores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_gola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpb_quantidades;
        private System.Windows.Forms.TextBox txb_disponibilizadocliente;
        private System.Windows.Forms.CheckBox check_disponibilizadocliente;
        private System.Windows.Forms.TextBox txb_tamG;
        private System.Windows.Forms.TextBox txb_tamM;
        private System.Windows.Forms.TextBox txb_tamP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_nomeCliente;
        private System.Windows.Forms.Panel pnl_dadoscolabcli;
        private System.Windows.Forms.TextBox txb_nomeColaborador;
        private System.Windows.Forms.Label lbl_idColaborador;
        private System.Windows.Forms.Label lbl_nomeCliente;
        private System.Windows.Forms.PictureBox pctb_estampa;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_orcamento;
        private System.Windows.Forms.Button btnregistrar_pedido;
        private System.Windows.Forms.Panel pnl_valores;
        private System.Windows.Forms.TextBox txb_valorEntrada;
        private System.Windows.Forms.TextBox txb_valorTotal;
        private System.Windows.Forms.TextBox txb_valorUnit;
        private System.Windows.Forms.Label lbl_valorEntrada;
        private System.Windows.Forms.Label lbl_valorTotal;
        private System.Windows.Forms.Label lbl_valorUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_dataentrega;
        private System.Windows.Forms.Label lbl_datainicial;
        private System.Windows.Forms.MonthCalendar mnth_dataentrega;
        private System.Windows.Forms.MonthCalendar mnth_datainicial;
        private System.Windows.Forms.Label lbl_totalCamisetas;
        private System.Windows.Forms.TextBox txb_totalCamisetas;
        private System.Windows.Forms.Label lbl_tamG;
        private System.Windows.Forms.Label lbl_tamM;
        private System.Windows.Forms.Label lbl_tamP;
        private System.Windows.Forms.TextBox txb_valorAberto;
        private System.Windows.Forms.Label lbl_valorAberto;
        private System.Windows.Forms.Panel pnl_formapagamento;
        private System.Windows.Forms.ComboBox cmb_formapagamentoFinal;
        private System.Windows.Forms.Label lbl_formapagamentoFinal;
        private System.Windows.Forms.ComboBox cmb_formapagamentoEntrada;
        private System.Windows.Forms.Label lbl_formapagamentoEntrada;
        private System.Windows.Forms.ComboBox cmb_idCliente;
        private System.Windows.Forms.ComboBox cmb_idColaborador;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.OpenFileDialog OFD_estamparia;
        private System.Windows.Forms.ListView ltv_showPedidos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}