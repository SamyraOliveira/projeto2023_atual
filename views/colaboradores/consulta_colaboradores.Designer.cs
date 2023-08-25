namespace projeto2023.views.colaboradores
{
    partial class consulta_colaboradores
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
            this.dtv_colaboradores = new System.Windows.Forms.DataGridView();
            this.codigoColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1COLABORADORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1_COLABORADORES = new projeto2023.EstampariadbDataSet1_COLABORADORES();
            this.colaboradoresTableAdapter = new projeto2023.EstampariadbDataSet1_COLABORADORESTableAdapters.ColaboradoresTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_colaboradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1COLABORADORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_COLABORADORES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtv_colaboradores
            // 
            this.dtv_colaboradores.AutoGenerateColumns = false;
            this.dtv_colaboradores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.dtv_colaboradores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtv_colaboradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtv_colaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_colaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoColaboradorDataGridViewTextBoxColumn,
            this.cPFColaboradorDataGridViewTextBoxColumn,
            this.cargoColaboradorDataGridViewTextBoxColumn,
            this.telefoneColaboradorDataGridViewTextBoxColumn,
            this.emailColaboradorDataGridViewTextBoxColumn,
            this.estadoColaboradorDataGridViewTextBoxColumn,
            this.cidadeColaboradorDataGridViewTextBoxColumn,
            this.enderecoColaboradorDataGridViewTextBoxColumn,
            this.bairroColaboradorDataGridViewTextBoxColumn,
            this.cEPColaboradorDataGridViewTextBoxColumn,
            this.nomeColaboradorDataGridViewTextBoxColumn,
            this.dataNascColaboradorDataGridViewTextBoxColumn,
            this.userColaboradorDataGridViewTextBoxColumn,
            this.passwordColaboradorDataGridViewTextBoxColumn,
            this.statusColaboradorDataGridViewTextBoxColumn});
            this.dtv_colaboradores.DataSource = this.colaboradoresBindingSource;
            this.dtv_colaboradores.GridColor = System.Drawing.Color.DarkGray;
            this.dtv_colaboradores.Location = new System.Drawing.Point(0, 4);
            this.dtv_colaboradores.Name = "dtv_colaboradores";
            this.dtv_colaboradores.ReadOnly = true;
            this.dtv_colaboradores.Size = new System.Drawing.Size(1338, 401);
            this.dtv_colaboradores.TabIndex = 8;
            // 
            // codigoColaboradorDataGridViewTextBoxColumn
            // 
            this.codigoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "codigo_Colaborador";
            this.codigoColaboradorDataGridViewTextBoxColumn.HeaderText = "codigo_Colaborador";
            this.codigoColaboradorDataGridViewTextBoxColumn.Name = "codigoColaboradorDataGridViewTextBoxColumn";
            this.codigoColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFColaboradorDataGridViewTextBoxColumn
            // 
            this.cPFColaboradorDataGridViewTextBoxColumn.DataPropertyName = "CPF_Colaborador";
            this.cPFColaboradorDataGridViewTextBoxColumn.HeaderText = "CPF_Colaborador";
            this.cPFColaboradorDataGridViewTextBoxColumn.Name = "cPFColaboradorDataGridViewTextBoxColumn";
            this.cPFColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoColaboradorDataGridViewTextBoxColumn
            // 
            this.cargoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "cargo_Colaborador";
            this.cargoColaboradorDataGridViewTextBoxColumn.HeaderText = "cargo_Colaborador";
            this.cargoColaboradorDataGridViewTextBoxColumn.Name = "cargoColaboradorDataGridViewTextBoxColumn";
            this.cargoColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneColaboradorDataGridViewTextBoxColumn
            // 
            this.telefoneColaboradorDataGridViewTextBoxColumn.DataPropertyName = "telefone_Colaborador";
            this.telefoneColaboradorDataGridViewTextBoxColumn.HeaderText = "telefone_Colaborador";
            this.telefoneColaboradorDataGridViewTextBoxColumn.Name = "telefoneColaboradorDataGridViewTextBoxColumn";
            this.telefoneColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailColaboradorDataGridViewTextBoxColumn
            // 
            this.emailColaboradorDataGridViewTextBoxColumn.DataPropertyName = "email_Colaborador";
            this.emailColaboradorDataGridViewTextBoxColumn.HeaderText = "email_Colaborador";
            this.emailColaboradorDataGridViewTextBoxColumn.Name = "emailColaboradorDataGridViewTextBoxColumn";
            this.emailColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoColaboradorDataGridViewTextBoxColumn
            // 
            this.estadoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "estado_Colaborador";
            this.estadoColaboradorDataGridViewTextBoxColumn.HeaderText = "estado_Colaborador";
            this.estadoColaboradorDataGridViewTextBoxColumn.Name = "estadoColaboradorDataGridViewTextBoxColumn";
            this.estadoColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeColaboradorDataGridViewTextBoxColumn
            // 
            this.cidadeColaboradorDataGridViewTextBoxColumn.DataPropertyName = "cidade_Colaborador";
            this.cidadeColaboradorDataGridViewTextBoxColumn.HeaderText = "cidade_Colaborador";
            this.cidadeColaboradorDataGridViewTextBoxColumn.Name = "cidadeColaboradorDataGridViewTextBoxColumn";
            this.cidadeColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoColaboradorDataGridViewTextBoxColumn
            // 
            this.enderecoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "endereco_Colaborador";
            this.enderecoColaboradorDataGridViewTextBoxColumn.HeaderText = "endereco_Colaborador";
            this.enderecoColaboradorDataGridViewTextBoxColumn.Name = "enderecoColaboradorDataGridViewTextBoxColumn";
            this.enderecoColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroColaboradorDataGridViewTextBoxColumn
            // 
            this.bairroColaboradorDataGridViewTextBoxColumn.DataPropertyName = "bairro_Colaborador";
            this.bairroColaboradorDataGridViewTextBoxColumn.HeaderText = "bairro_Colaborador";
            this.bairroColaboradorDataGridViewTextBoxColumn.Name = "bairroColaboradorDataGridViewTextBoxColumn";
            this.bairroColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPColaboradorDataGridViewTextBoxColumn
            // 
            this.cEPColaboradorDataGridViewTextBoxColumn.DataPropertyName = "CEP_Colaborador";
            this.cEPColaboradorDataGridViewTextBoxColumn.HeaderText = "CEP_Colaborador";
            this.cEPColaboradorDataGridViewTextBoxColumn.Name = "cEPColaboradorDataGridViewTextBoxColumn";
            this.cEPColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeColaboradorDataGridViewTextBoxColumn
            // 
            this.nomeColaboradorDataGridViewTextBoxColumn.DataPropertyName = "nome_Colaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.HeaderText = "nome_Colaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.Name = "nomeColaboradorDataGridViewTextBoxColumn";
            this.nomeColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascColaboradorDataGridViewTextBoxColumn
            // 
            this.dataNascColaboradorDataGridViewTextBoxColumn.DataPropertyName = "dataNasc_Colaborador";
            this.dataNascColaboradorDataGridViewTextBoxColumn.HeaderText = "dataNasc_Colaborador";
            this.dataNascColaboradorDataGridViewTextBoxColumn.Name = "dataNascColaboradorDataGridViewTextBoxColumn";
            this.dataNascColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userColaboradorDataGridViewTextBoxColumn
            // 
            this.userColaboradorDataGridViewTextBoxColumn.DataPropertyName = "user_Colaborador";
            this.userColaboradorDataGridViewTextBoxColumn.HeaderText = "user_Colaborador";
            this.userColaboradorDataGridViewTextBoxColumn.Name = "userColaboradorDataGridViewTextBoxColumn";
            this.userColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordColaboradorDataGridViewTextBoxColumn
            // 
            this.passwordColaboradorDataGridViewTextBoxColumn.DataPropertyName = "password_Colaborador";
            this.passwordColaboradorDataGridViewTextBoxColumn.HeaderText = "password_Colaborador";
            this.passwordColaboradorDataGridViewTextBoxColumn.Name = "passwordColaboradorDataGridViewTextBoxColumn";
            this.passwordColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusColaboradorDataGridViewTextBoxColumn
            // 
            this.statusColaboradorDataGridViewTextBoxColumn.DataPropertyName = "status_Colaborador";
            this.statusColaboradorDataGridViewTextBoxColumn.HeaderText = "status_Colaborador";
            this.statusColaboradorDataGridViewTextBoxColumn.Name = "statusColaboradorDataGridViewTextBoxColumn";
            this.statusColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colaboradoresBindingSource
            // 
            this.colaboradoresBindingSource.DataMember = "Colaboradores";
            this.colaboradoresBindingSource.DataSource = this.estampariadbDataSet1COLABORADORESBindingSource;
            // 
            // estampariadbDataSet1COLABORADORESBindingSource
            // 
            this.estampariadbDataSet1COLABORADORESBindingSource.DataSource = this.estampariadbDataSet1_COLABORADORES;
            this.estampariadbDataSet1COLABORADORESBindingSource.Position = 0;
            // 
            // estampariadbDataSet1_COLABORADORES
            // 
            this.estampariadbDataSet1_COLABORADORES.DataSetName = "EstampariadbDataSet1_COLABORADORES";
            this.estampariadbDataSet1_COLABORADORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradoresTableAdapter
            // 
            this.colaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtv_colaboradores);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 426);
            this.panel1.TabIndex = 9;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(943, 450);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(185, 63);
            this.btn_imprimir.TabIndex = 10;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(1165, 450);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(185, 63);
            this.btn_fechar.TabIndex = 11;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // consulta_colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1368, 525);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.panel1);
            this.Name = "consulta_colaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_colaboradores";
            this.Load += new System.EventHandler(this.consulta_colaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_colaboradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1COLABORADORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_COLABORADORES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_colaboradores;
        private System.Windows.Forms.BindingSource estampariadbDataSet1COLABORADORESBindingSource;
        private EstampariadbDataSet1_COLABORADORES estampariadbDataSet1_COLABORADORES;
        private System.Windows.Forms.BindingSource colaboradoresBindingSource;
        private EstampariadbDataSet1_COLABORADORESTableAdapters.ColaboradoresTableAdapter colaboradoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_fechar;
    }
}