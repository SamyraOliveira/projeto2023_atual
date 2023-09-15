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
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.pedidosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1 = new projeto2023.EstampariadbDataSet();
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter1 = new projeto2023.EstampariadbDataSetTableAdapters.PedidosTableAdapter();
            this.pedidosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtQuantidadeP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantidadeM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantidadeG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvPedidosProdução)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dvPedidosProdução
            // 
            this.dvPedidosProdução.AllowUserToAddRows = false;
            this.dvPedidosProdução.AllowUserToDeleteRows = false;
            this.dvPedidosProdução.AllowUserToResizeColumns = false;
            this.dvPedidosProdução.AllowUserToResizeRows = false;
            this.dvPedidosProdução.AutoGenerateColumns = false;
            this.dvPedidosProdução.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPedidosProdução.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.cor,
            this.quantidade_p,
            this.quantidade_m,
            this.quantidade_g,
            this.total_pedido,
            this.entrega,
            this.status});
            this.dvPedidosProdução.DataSource = this.pedidosBindingSource3;
            this.dvPedidosProdução.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dvPedidosProdução.GridColor = System.Drawing.SystemColors.Info;
            this.dvPedidosProdução.Location = new System.Drawing.Point(19, 60);
            this.dvPedidosProdução.MultiSelect = false;
            this.dvPedidosProdução.Name = "dvPedidosProdução";
            this.dvPedidosProdução.RowHeadersWidth = 51;
            this.dvPedidosProdução.RowTemplate.Height = 24;
            this.dvPedidosProdução.Size = new System.Drawing.Size(722, 709);
            this.dvPedidosProdução.TabIndex = 1;
            this.dvPedidosProdução.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
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
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1072, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lançar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(774, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cod.Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(774, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cor Camisa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Camisas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data Entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1184, 716);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 38);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status:";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(988, 219);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(223, 31);
            this.txtCor.TabIndex = 9;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(983, 140);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(134, 31);
            this.txtCod.TabIndex = 10;
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPedido.Location = new System.Drawing.Point(1037, 290);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.Size = new System.Drawing.Size(154, 31);
            this.txtTotalPedido.TabIndex = 11;
            // 
            // txtEntrega
            // 
            this.txtEntrega.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrega.Location = new System.Drawing.Point(1016, 352);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(227, 31);
            this.txtEntrega.TabIndex = 12;
            // 
            // pedidosBindingSource2
            // 
            this.pedidosBindingSource2.DataMember = "Pedidos";
            this.pedidosBindingSource2.DataSource = this.estampariadbDataSet1BindingSource;
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
            // pedidosBindingSource1
            // 
            this.pedidosBindingSource1.DataMember = "Pedidos";
            this.pedidosBindingSource1.DataSource = this.estampariadbDataSet1;
            // 
            // pedidosTableAdapter1
            // 
            this.pedidosTableAdapter1.ClearBeforeFill = true;
            // 
            // pedidosBindingSource3
            // 
            this.pedidosBindingSource3.DataMember = "Pedidos";
            this.pedidosBindingSource3.DataSource = this.estampariadbDataSet1BindingSource;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(1311, 722);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(172, 31);
            this.txtStatus.TabIndex = 13;
            // 
            // txtQuantidadeP
            // 
            this.txtQuantidadeP.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeP.Location = new System.Drawing.Point(999, 476);
            this.txtQuantidadeP.Name = "txtQuantidadeP";
            this.txtQuantidadeP.Size = new System.Drawing.Size(172, 31);
            this.txtQuantidadeP.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(750, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 48);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantidade P:";
            // 
            // txtQuantidadeM
            // 
            this.txtQuantidadeM.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeM.Location = new System.Drawing.Point(1007, 546);
            this.txtQuantidadeM.Name = "txtQuantidadeM";
            this.txtQuantidadeM.Size = new System.Drawing.Size(172, 31);
            this.txtQuantidadeM.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(750, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 48);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quantidade M:";
            // 
            // txtQuantidadeG
            // 
            this.txtQuantidadeG.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeG.Location = new System.Drawing.Point(1001, 614);
            this.txtQuantidadeG.Name = "txtQuantidadeG";
            this.txtQuantidadeG.Size = new System.Drawing.Size(172, 31);
            this.txtQuantidadeG.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(750, 608);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 48);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantidade G:";
            // 
            // cod
            // 
            this.cod.DataPropertyName = "codigo_Pedido";
            this.cod.HeaderText = "cod";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 45;
            // 
            // cor
            // 
            this.cor.DataPropertyName = "corCamiseta_Pedido";
            this.cor.HeaderText = "COR";
            this.cor.MinimumWidth = 6;
            this.cor.Name = "cor";
            this.cor.Width = 80;
            // 
            // quantidade_p
            // 
            this.quantidade_p.DataPropertyName = "tamP_quant_Pedido";
            this.quantidade_p.HeaderText = "Quantidade P";
            this.quantidade_p.MinimumWidth = 6;
            this.quantidade_p.Name = "quantidade_p";
            this.quantidade_p.Width = 95;
            // 
            // quantidade_m
            // 
            this.quantidade_m.DataPropertyName = "tamM_quant_Pedido";
            this.quantidade_m.HeaderText = "Quantidade M";
            this.quantidade_m.MinimumWidth = 6;
            this.quantidade_m.Name = "quantidade_m";
            this.quantidade_m.Width = 95;
            // 
            // quantidade_g
            // 
            this.quantidade_g.DataPropertyName = "tamG_quant_Pedido";
            this.quantidade_g.HeaderText = "Quantidade G";
            this.quantidade_g.MinimumWidth = 6;
            this.quantidade_g.Name = "quantidade_g";
            this.quantidade_g.Width = 95;
            // 
            // total_pedido
            // 
            this.total_pedido.DataPropertyName = "totalCamisetas_Pedido";
            this.total_pedido.HeaderText = "Total Pedido";
            this.total_pedido.MinimumWidth = 6;
            this.total_pedido.Name = "total_pedido";
            // 
            // entrega
            // 
            this.entrega.DataPropertyName = "data_entrega";
            this.entrega.HeaderText = "Entrega";
            this.entrega.MinimumWidth = 6;
            this.entrega.Name = "entrega";
            this.entrega.Width = 90;
            // 
            // status
            // 
            this.status.DataPropertyName = "status_Pedido";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 90;
            // 
            // crud_producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1518, 789);
            this.Controls.Add(this.txtQuantidadeG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQuantidadeM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuantidadeP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEntrega);
            this.Controls.Add(this.txtTotalPedido);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource3)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtTotalPedido;
        private System.Windows.Forms.TextBox txtEntrega;
        private EstampariadbDataSet estampariadbDataSet1;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
        private EstampariadbDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter1;
        private System.Windows.Forms.BindingSource pedidosBindingSource2;
        private System.Windows.Forms.BindingSource estampariadbDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dvPedidosProdução;
        private System.Windows.Forms.BindingSource pedidosBindingSource3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtQuantidadeP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantidadeM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidadeG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_g;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}