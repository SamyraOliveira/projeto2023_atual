namespace projeto2023.views.clientes
{
    partial class consulta_clientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtv_clientes = new System.Windows.Forms.DataGridView();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFCNPJClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1_CLIENTES = new projeto2023.EstampariadbDataSet1_CLIENTES();
            this.clientesTableAdapter = new projeto2023.EstampariadbDataSet1_CLIENTESTableAdapters.ClientesTableAdapter();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtv_clientes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 426);
            this.panel1.TabIndex = 10;
            // 
            // dtv_clientes
            // 
            this.dtv_clientes.AutoGenerateColumns = false;
            this.dtv_clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.dtv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoClienteDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.cPFCNPJClienteDataGridViewTextBoxColumn,
            this.telefoneClienteDataGridViewTextBoxColumn,
            this.emailClienteDataGridViewTextBoxColumn,
            this.dataNascClienteDataGridViewTextBoxColumn,
            this.estadoClienteDataGridViewTextBoxColumn,
            this.cidadeClienteDataGridViewTextBoxColumn,
            this.enderecoClienteDataGridViewTextBoxColumn,
            this.cEPClienteDataGridViewTextBoxColumn,
            this.statusClienteDataGridViewTextBoxColumn});
            this.dtv_clientes.DataSource = this.clientesBindingSource;
            this.dtv_clientes.GridColor = System.Drawing.Color.DarkGray;
            this.dtv_clientes.Location = new System.Drawing.Point(6, 3);
            this.dtv_clientes.Name = "dtv_clientes";
            this.dtv_clientes.ReadOnly = true;
            this.dtv_clientes.Size = new System.Drawing.Size(1145, 401);
            this.dtv_clientes.TabIndex = 8;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "codigo_Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFCNPJClienteDataGridViewTextBoxColumn
            // 
            this.cPFCNPJClienteDataGridViewTextBoxColumn.DataPropertyName = "CPFCNPJ_Cliente";
            this.cPFCNPJClienteDataGridViewTextBoxColumn.HeaderText = "CPFCNPJ_Cliente";
            this.cPFCNPJClienteDataGridViewTextBoxColumn.Name = "cPFCNPJClienteDataGridViewTextBoxColumn";
            this.cPFCNPJClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneClienteDataGridViewTextBoxColumn
            // 
            this.telefoneClienteDataGridViewTextBoxColumn.DataPropertyName = "telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.HeaderText = "telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.Name = "telefoneClienteDataGridViewTextBoxColumn";
            this.telefoneClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailClienteDataGridViewTextBoxColumn
            // 
            this.emailClienteDataGridViewTextBoxColumn.DataPropertyName = "email_Cliente";
            this.emailClienteDataGridViewTextBoxColumn.HeaderText = "email_Cliente";
            this.emailClienteDataGridViewTextBoxColumn.Name = "emailClienteDataGridViewTextBoxColumn";
            this.emailClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascClienteDataGridViewTextBoxColumn
            // 
            this.dataNascClienteDataGridViewTextBoxColumn.DataPropertyName = "dataNasc_Cliente";
            this.dataNascClienteDataGridViewTextBoxColumn.HeaderText = "dataNasc_Cliente";
            this.dataNascClienteDataGridViewTextBoxColumn.Name = "dataNascClienteDataGridViewTextBoxColumn";
            this.dataNascClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoClienteDataGridViewTextBoxColumn
            // 
            this.estadoClienteDataGridViewTextBoxColumn.DataPropertyName = "estado_Cliente";
            this.estadoClienteDataGridViewTextBoxColumn.HeaderText = "estado_Cliente";
            this.estadoClienteDataGridViewTextBoxColumn.Name = "estadoClienteDataGridViewTextBoxColumn";
            this.estadoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeClienteDataGridViewTextBoxColumn
            // 
            this.cidadeClienteDataGridViewTextBoxColumn.DataPropertyName = "cidade_Cliente";
            this.cidadeClienteDataGridViewTextBoxColumn.HeaderText = "cidade_Cliente";
            this.cidadeClienteDataGridViewTextBoxColumn.Name = "cidadeClienteDataGridViewTextBoxColumn";
            this.cidadeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoClienteDataGridViewTextBoxColumn
            // 
            this.enderecoClienteDataGridViewTextBoxColumn.DataPropertyName = "endereco_Cliente";
            this.enderecoClienteDataGridViewTextBoxColumn.HeaderText = "endereco_Cliente";
            this.enderecoClienteDataGridViewTextBoxColumn.Name = "enderecoClienteDataGridViewTextBoxColumn";
            this.enderecoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPClienteDataGridViewTextBoxColumn
            // 
            this.cEPClienteDataGridViewTextBoxColumn.DataPropertyName = "CEP_Cliente";
            this.cEPClienteDataGridViewTextBoxColumn.HeaderText = "CEP_Cliente";
            this.cEPClienteDataGridViewTextBoxColumn.Name = "cEPClienteDataGridViewTextBoxColumn";
            this.cEPClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusClienteDataGridViewTextBoxColumn
            // 
            this.statusClienteDataGridViewTextBoxColumn.DataPropertyName = "status_Cliente";
            this.statusClienteDataGridViewTextBoxColumn.HeaderText = "status_Cliente";
            this.statusClienteDataGridViewTextBoxColumn.Name = "statusClienteDataGridViewTextBoxColumn";
            this.statusClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.estampariadbDataSet1_CLIENTES;
            // 
            // estampariadbDataSet1_CLIENTES
            // 
            this.estampariadbDataSet1_CLIENTES.DataSetName = "EstampariadbDataSet1_CLIENTES";
            this.estampariadbDataSet1_CLIENTES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(1043, 473);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 11;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(1205, 473);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 12;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // consulta_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1368, 525);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.panel1);
            this.Name = "consulta_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_clientes";
            this.Load += new System.EventHandler(this.consulta_clientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_CLIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtv_clientes;
        private EstampariadbDataSet1_CLIENTES estampariadbDataSet1_CLIENTES;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private EstampariadbDataSet1_CLIENTESTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCNPJClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_fechar;
    }
}