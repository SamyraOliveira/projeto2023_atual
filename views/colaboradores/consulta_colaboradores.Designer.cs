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
            this.estampariadbDataSet1_COLABORADORES = new projeto2023.EstampariadbDataSet1_COLABORADORES();
            this.estampariadbDataSet1COLABORADORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradoresTableAdapter = new projeto2023.EstampariadbDataSet1_COLABORADORESTableAdapters.ColaboradoresTableAdapter();
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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_colaboradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_COLABORADORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1COLABORADORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).BeginInit();
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
            // estampariadbDataSet1_COLABORADORES
            // 
            this.estampariadbDataSet1_COLABORADORES.DataSetName = "EstampariadbDataSet1_COLABORADORES";
            this.estampariadbDataSet1_COLABORADORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estampariadbDataSet1COLABORADORESBindingSource
            // 
            this.estampariadbDataSet1COLABORADORESBindingSource.DataSource = this.estampariadbDataSet1_COLABORADORES;
            this.estampariadbDataSet1COLABORADORESBindingSource.Position = 0;
            // 
            // colaboradoresBindingSource
            // 
            this.colaboradoresBindingSource.DataMember = "Colaboradores";
            this.colaboradoresBindingSource.DataSource = this.estampariadbDataSet1COLABORADORESBindingSource;
            // 
            // colaboradoresTableAdapter
            // 
            this.colaboradoresTableAdapter.ClearBeforeFill = true;
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
            // 
            // cargoColaboradorDataGridViewTextBoxColumn
            // 
            this.cargoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "cargo_Colaborador";
            this.cargoColaboradorDataGridViewTextBoxColumn.HeaderText = "cargo_Colaborador";
            this.cargoColaboradorDataGridViewTextBoxColumn.Name = "cargoColaboradorDataGridViewTextBoxColumn";
            // 
            // telefoneColaboradorDataGridViewTextBoxColumn
            // 
            this.telefoneColaboradorDataGridViewTextBoxColumn.DataPropertyName = "telefone_Colaborador";
            this.telefoneColaboradorDataGridViewTextBoxColumn.HeaderText = "telefone_Colaborador";
            this.telefoneColaboradorDataGridViewTextBoxColumn.Name = "telefoneColaboradorDataGridViewTextBoxColumn";
            // 
            // emailColaboradorDataGridViewTextBoxColumn
            // 
            this.emailColaboradorDataGridViewTextBoxColumn.DataPropertyName = "email_Colaborador";
            this.emailColaboradorDataGridViewTextBoxColumn.HeaderText = "email_Colaborador";
            this.emailColaboradorDataGridViewTextBoxColumn.Name = "emailColaboradorDataGridViewTextBoxColumn";
            // 
            // estadoColaboradorDataGridViewTextBoxColumn
            // 
            this.estadoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "estado_Colaborador";
            this.estadoColaboradorDataGridViewTextBoxColumn.HeaderText = "estado_Colaborador";
            this.estadoColaboradorDataGridViewTextBoxColumn.Name = "estadoColaboradorDataGridViewTextBoxColumn";
            // 
            // cidadeColaboradorDataGridViewTextBoxColumn
            // 
            this.cidadeColaboradorDataGridViewTextBoxColumn.DataPropertyName = "cidade_Colaborador";
            this.cidadeColaboradorDataGridViewTextBoxColumn.HeaderText = "cidade_Colaborador";
            this.cidadeColaboradorDataGridViewTextBoxColumn.Name = "cidadeColaboradorDataGridViewTextBoxColumn";
            // 
            // enderecoColaboradorDataGridViewTextBoxColumn
            // 
            this.enderecoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "endereco_Colaborador";
            this.enderecoColaboradorDataGridViewTextBoxColumn.HeaderText = "endereco_Colaborador";
            this.enderecoColaboradorDataGridViewTextBoxColumn.Name = "enderecoColaboradorDataGridViewTextBoxColumn";
            // 
            // bairroColaboradorDataGridViewTextBoxColumn
            // 
            this.bairroColaboradorDataGridViewTextBoxColumn.DataPropertyName = "bairro_Colaborador";
            this.bairroColaboradorDataGridViewTextBoxColumn.HeaderText = "bairro_Colaborador";
            this.bairroColaboradorDataGridViewTextBoxColumn.Name = "bairroColaboradorDataGridViewTextBoxColumn";
            // 
            // cEPColaboradorDataGridViewTextBoxColumn
            // 
            this.cEPColaboradorDataGridViewTextBoxColumn.DataPropertyName = "CEP_Colaborador";
            this.cEPColaboradorDataGridViewTextBoxColumn.HeaderText = "CEP_Colaborador";
            this.cEPColaboradorDataGridViewTextBoxColumn.Name = "cEPColaboradorDataGridViewTextBoxColumn";
            // 
            // nomeColaboradorDataGridViewTextBoxColumn
            // 
            this.nomeColaboradorDataGridViewTextBoxColumn.DataPropertyName = "nome_Colaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.HeaderText = "nome_Colaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.Name = "nomeColaboradorDataGridViewTextBoxColumn";
            // 
            // dataNascColaboradorDataGridViewTextBoxColumn
            // 
            this.dataNascColaboradorDataGridViewTextBoxColumn.DataPropertyName = "dataNasc_Colaborador";
            this.dataNascColaboradorDataGridViewTextBoxColumn.HeaderText = "dataNasc_Colaborador";
            this.dataNascColaboradorDataGridViewTextBoxColumn.Name = "dataNascColaboradorDataGridViewTextBoxColumn";
            // 
            // userColaboradorDataGridViewTextBoxColumn
            // 
            this.userColaboradorDataGridViewTextBoxColumn.DataPropertyName = "user_Colaborador";
            this.userColaboradorDataGridViewTextBoxColumn.HeaderText = "user_Colaborador";
            this.userColaboradorDataGridViewTextBoxColumn.Name = "userColaboradorDataGridViewTextBoxColumn";
            // 
            // passwordColaboradorDataGridViewTextBoxColumn
            // 
            this.passwordColaboradorDataGridViewTextBoxColumn.DataPropertyName = "password_Colaborador";
            this.passwordColaboradorDataGridViewTextBoxColumn.HeaderText = "password_Colaborador";
            this.passwordColaboradorDataGridViewTextBoxColumn.Name = "passwordColaboradorDataGridViewTextBoxColumn";
            // 
            // statusColaboradorDataGridViewTextBoxColumn
            // 
            this.statusColaboradorDataGridViewTextBoxColumn.DataPropertyName = "status_Colaborador";
            this.statusColaboradorDataGridViewTextBoxColumn.HeaderText = "status_Colaborador";
            this.statusColaboradorDataGridViewTextBoxColumn.Name = "statusColaboradorDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtv_colaboradores);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 426);
            this.panel1.TabIndex = 9;
            // 
            // consulta_colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1368, 525);
            this.Controls.Add(this.panel1);
            this.Name = "consulta_colaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_colaboradores";
            this.Load += new System.EventHandler(this.consulta_colaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_colaboradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_COLABORADORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1COLABORADORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).EndInit();
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
    }
}