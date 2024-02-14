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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta_clientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cod_cliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_ativar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txb_cep = new System.Windows.Forms.TextBox();
            this.txb_telefone = new System.Windows.Forms.TextBox();
            this.txb_cpf = new System.Windows.Forms.TextBox();
            this.mntc_dataNasc = new System.Windows.Forms.MonthCalendar();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txb_cidade = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_endereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbox_clientes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dtv_clientes = new System.Windows.Forms.DataGridView();
            this.codigo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet1_CLIENTES = new projeto2023.EstampariadbDataSet1_CLIENTES();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkbox_status = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new projeto2023.EstampariadbDataSet1_CLIENTESTableAdapters.ClientesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cod_cliente);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btn_ativar);
            this.panel1.Controls.Add(this.button_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txb_cep);
            this.panel1.Controls.Add(this.txb_telefone);
            this.panel1.Controls.Add(this.txb_cpf);
            this.panel1.Controls.Add(this.mntc_dataNasc);
            this.panel1.Controls.Add(this.cmb_estado);
            this.panel1.Controls.Add(this.txb_cidade);
            this.panel1.Controls.Add(this.txb_email);
            this.panel1.Controls.Add(this.txb_nome);
            this.panel1.Controls.Add(this.txb_endereco);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbox_clientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.dtv_clientes);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.checkbox_status);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 843);
            this.panel1.TabIndex = 10;
            // 
            // cod_cliente
            // 
            this.cod_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_cliente.Location = new System.Drawing.Point(146, 466);
            this.cod_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            this.cod_cliente.Size = new System.Drawing.Size(62, 24);
            this.cod_cliente.TabIndex = 133;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label16.Location = new System.Drawing.Point(29, 469);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 18);
            this.label16.TabIndex = 132;
            this.label16.Text = "ID CLIENTE:";
            // 
            // btn_ativar
            // 
            this.btn_ativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.btn_ativar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_ativar.Location = new System.Drawing.Point(1065, 577);
            this.btn_ativar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ativar.Name = "btn_ativar";
            this.btn_ativar.Size = new System.Drawing.Size(91, 59);
            this.btn_ativar.TabIndex = 131;
            this.btn_ativar.Text = "ATIVAR";
            this.btn_ativar.UseVisualStyleBackColor = false;
            this.btn_ativar.Visible = false;
            this.btn_ativar.Click += new System.EventHandler(this.btn_ativar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
            this.button_excluir.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button_excluir.Location = new System.Drawing.Point(1065, 635);
            this.button_excluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(91, 59);
            this.button_excluir.TabIndex = 130;
            this.button_excluir.Text = "EXCLUIR";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Visible = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.btn_salvar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.Location = new System.Drawing.Point(1065, 525);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(91, 59);
            this.btn_salvar.TabIndex = 129;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Visible = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(620, 648);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 128;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txb_cep
            // 
            this.txb_cep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_cep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.txb_cep.Location = new System.Drawing.Point(459, 657);
            this.txb_cep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_cep.Name = "txb_cep";
            this.txb_cep.Size = new System.Drawing.Size(92, 20);
            this.txb_cep.TabIndex = 125;
            // 
            // txb_telefone
            // 
            this.txb_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.txb_telefone.Location = new System.Drawing.Point(625, 526);
            this.txb_telefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_telefone.Name = "txb_telefone";
            this.txb_telefone.Size = new System.Drawing.Size(92, 20);
            this.txb_telefone.TabIndex = 124;
            // 
            // txb_cpf
            // 
            this.txb_cpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.txb_cpf.Location = new System.Drawing.Point(459, 527);
            this.txb_cpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_cpf.Name = "txb_cpf";
            this.txb_cpf.Size = new System.Drawing.Size(92, 20);
            this.txb_cpf.TabIndex = 123;
            // 
            // mntc_dataNasc
            // 
            this.mntc_dataNasc.Location = new System.Drawing.Point(781, 527);
            this.mntc_dataNasc.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mntc_dataNasc.Name = "mntc_dataNasc";
            this.mntc_dataNasc.TabIndex = 121;
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cmb_estado.Location = new System.Drawing.Point(454, 592);
            this.cmb_estado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(92, 21);
            this.cmb_estado.TabIndex = 114;
            // 
            // txb_cidade
            // 
            this.txb_cidade.Location = new System.Drawing.Point(620, 599);
            this.txb_cidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_cidade.Name = "txb_cidade";
            this.txb_cidade.Size = new System.Drawing.Size(92, 20);
            this.txb_cidade.TabIndex = 116;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(165, 592);
            this.txb_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(206, 20);
            this.txb_email.TabIndex = 112;
            // 
            // txb_nome
            // 
            this.txb_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.txb_nome.Location = new System.Drawing.Point(170, 527);
            this.txb_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(206, 20);
            this.txb_nome.TabIndex = 108;
            // 
            // txb_endereco
            // 
            this.txb_endereco.Location = new System.Drawing.Point(165, 657);
            this.txb_endereco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_endereco.Name = "txb_endereco";
            this.txb_endereco.Size = new System.Drawing.Size(206, 20);
            this.txb_endereco.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label9.Location = new System.Drawing.Point(833, 500);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 122;
            this.label9.Text = "Data Nasc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label8.Location = new System.Drawing.Point(618, 583);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 120;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label7.Location = new System.Drawing.Point(618, 507);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 119;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label6.Location = new System.Drawing.Point(452, 641);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 117;
            this.label6.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label5.Location = new System.Drawing.Point(452, 575);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 115;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label4.Location = new System.Drawing.Point(452, 511);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label3.Location = new System.Drawing.Point(163, 641);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label10.Location = new System.Drawing.Point(163, 575);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 110;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label11.Location = new System.Drawing.Point(163, 511);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 109;
            this.label11.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label2.Location = new System.Drawing.Point(13, 746);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 107;
            this.label2.Text = "VOLTAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1236, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox_clientes
            // 
            this.cbox_clientes.AutoSize = true;
            this.cbox_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_clientes.Location = new System.Drawing.Point(1401, 58);
            this.cbox_clientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_clientes.Name = "cbox_clientes";
            this.cbox_clientes.Size = new System.Drawing.Size(15, 14);
            this.cbox_clientes.TabIndex = 106;
            this.cbox_clientes.UseVisualStyleBackColor = true;
            this.cbox_clientes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(1309, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 105;
            this.label1.Text = "Inativos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(210, 48);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(162, 24);
            this.txtPesquisa.TabIndex = 104;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dtv_clientes
            // 
            this.dtv_clientes.AllowUserToAddRows = false;
            this.dtv_clientes.AllowUserToDeleteRows = false;
            this.dtv_clientes.AllowUserToResizeColumns = false;
            this.dtv_clientes.AutoGenerateColumns = false;
            this.dtv_clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.dtv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_Cliente,
            this.nome_Cliente,
            this.CPFCNPJ_Cliente,
            this.telefone_Cliente,
            this.email_Cliente,
            this.dataNasc_Cliente,
            this.estado_Cliente,
            this.cidade_Cliente,
            this.endereco_Cliente,
            this.CEP_Cliente,
            this.status_Cliente});
            this.dtv_clientes.DataSource = this.clientesBindingSource;
            this.dtv_clientes.GridColor = System.Drawing.Color.DarkGray;
            this.dtv_clientes.Location = new System.Drawing.Point(3, 74);
            this.dtv_clientes.MultiSelect = false;
            this.dtv_clientes.Name = "dtv_clientes";
            this.dtv_clientes.RowHeadersWidth = 51;
            this.dtv_clientes.ShowRowErrors = false;
            this.dtv_clientes.Size = new System.Drawing.Size(1433, 362);
            this.dtv_clientes.TabIndex = 8;
            this.dtv_clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_clientes_CellContentDoubleClick);
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
            // nome_Cliente
            // 
            this.nome_Cliente.DataPropertyName = "nome_Cliente";
            this.nome_Cliente.HeaderText = "nome_Cliente";
            this.nome_Cliente.MinimumWidth = 6;
            this.nome_Cliente.Name = "nome_Cliente";
            this.nome_Cliente.Width = 125;
            // 
            // CPFCNPJ_Cliente
            // 
            this.CPFCNPJ_Cliente.DataPropertyName = "CPFCNPJ_Cliente";
            this.CPFCNPJ_Cliente.HeaderText = "CPFCNPJ_Cliente";
            this.CPFCNPJ_Cliente.MinimumWidth = 6;
            this.CPFCNPJ_Cliente.Name = "CPFCNPJ_Cliente";
            this.CPFCNPJ_Cliente.Width = 125;
            // 
            // telefone_Cliente
            // 
            this.telefone_Cliente.DataPropertyName = "telefone_Cliente";
            this.telefone_Cliente.HeaderText = "telefone_Cliente";
            this.telefone_Cliente.MinimumWidth = 6;
            this.telefone_Cliente.Name = "telefone_Cliente";
            this.telefone_Cliente.Width = 125;
            // 
            // email_Cliente
            // 
            this.email_Cliente.DataPropertyName = "email_Cliente";
            this.email_Cliente.HeaderText = "email_Cliente";
            this.email_Cliente.MinimumWidth = 6;
            this.email_Cliente.Name = "email_Cliente";
            this.email_Cliente.Width = 125;
            // 
            // dataNasc_Cliente
            // 
            this.dataNasc_Cliente.DataPropertyName = "dataNasc_Cliente";
            this.dataNasc_Cliente.HeaderText = "dataNasc_Cliente";
            this.dataNasc_Cliente.MinimumWidth = 6;
            this.dataNasc_Cliente.Name = "dataNasc_Cliente";
            this.dataNasc_Cliente.Width = 125;
            // 
            // estado_Cliente
            // 
            this.estado_Cliente.DataPropertyName = "estado_Cliente";
            this.estado_Cliente.HeaderText = "estado_Cliente";
            this.estado_Cliente.MinimumWidth = 6;
            this.estado_Cliente.Name = "estado_Cliente";
            this.estado_Cliente.Width = 125;
            // 
            // cidade_Cliente
            // 
            this.cidade_Cliente.DataPropertyName = "cidade_Cliente";
            this.cidade_Cliente.HeaderText = "cidade_Cliente";
            this.cidade_Cliente.MinimumWidth = 6;
            this.cidade_Cliente.Name = "cidade_Cliente";
            this.cidade_Cliente.Width = 125;
            // 
            // endereco_Cliente
            // 
            this.endereco_Cliente.DataPropertyName = "endereco_Cliente";
            this.endereco_Cliente.HeaderText = "endereco_Cliente";
            this.endereco_Cliente.MinimumWidth = 6;
            this.endereco_Cliente.Name = "endereco_Cliente";
            this.endereco_Cliente.Width = 125;
            // 
            // CEP_Cliente
            // 
            this.CEP_Cliente.DataPropertyName = "CEP_Cliente";
            this.CEP_Cliente.HeaderText = "CEP_Cliente";
            this.CEP_Cliente.MinimumWidth = 6;
            this.CEP_Cliente.Name = "CEP_Cliente";
            this.CEP_Cliente.Width = 125;
            // 
            // status_Cliente
            // 
            this.status_Cliente.DataPropertyName = "status_Cliente";
            this.status_Cliente.HeaderText = "status_Cliente";
            this.status_Cliente.MinimumWidth = 6;
            this.status_Cliente.Name = "status_Cliente";
            this.status_Cliente.Width = 125;
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label18.Location = new System.Drawing.Point(18, 42);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(195, 26);
            this.label18.TabIndex = 103;
            this.label18.Text = "Pesquisar Nome:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label13.Location = new System.Drawing.Point(545, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(453, 55);
            this.label13.TabIndex = 100;
            this.label13.Text = "Consulta Clientes";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // checkbox_status
            // 
            this.checkbox_status.AutoSize = true;
            this.checkbox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_status.Location = new System.Drawing.Point(1528, 69);
            this.checkbox_status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkbox_status.Name = "checkbox_status";
            this.checkbox_status.Size = new System.Drawing.Size(15, 14);
            this.checkbox_status.TabIndex = 102;
            this.checkbox_status.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.label17.Location = new System.Drawing.Point(1436, 59);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 26);
            this.label17.TabIndex = 101;
            this.label17.Text = "Inativos";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // consulta_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consulta_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.consulta_clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkbox_status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbox_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_cep;
        private System.Windows.Forms.TextBox txb_telefone;
        private System.Windows.Forms.TextBox txb_cpf;
        private System.Windows.Forms.MonthCalendar mntc_dataNasc;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.TextBox txb_cidade;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_endereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ativar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Cliente;
        private System.Windows.Forms.TextBox cod_cliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
    }
}