namespace projeto2023.views.clientes
{
    partial class crud_clientes
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
            this.pnl_crud_clientes = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.mntc_dataNasc = new System.Windows.Forms.MonthCalendar();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.mskd_cep = new System.Windows.Forms.MaskedTextBox();
            this.mskd_cpf_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.mskd_telefone = new System.Windows.Forms.MaskedTextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_crud_clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_crud_clientes
            // 
            this.pnl_crud_clientes.Controls.Add(this.btn_cancelar);
            this.pnl_crud_clientes.Controls.Add(this.btn_limpar);
            this.pnl_crud_clientes.Controls.Add(this.btn_excluir);
            this.pnl_crud_clientes.Controls.Add(this.btn_salvar);
            this.pnl_crud_clientes.Controls.Add(this.mntc_dataNasc);
            this.pnl_crud_clientes.Controls.Add(this.cmb_estado);
            this.pnl_crud_clientes.Controls.Add(this.mskd_cep);
            this.pnl_crud_clientes.Controls.Add(this.mskd_cpf_cnpj);
            this.pnl_crud_clientes.Controls.Add(this.mskd_telefone);
            this.pnl_crud_clientes.Controls.Add(this.txb_cidade);
            this.pnl_crud_clientes.Controls.Add(this.txb_email);
            this.pnl_crud_clientes.Controls.Add(this.txb_nome);
            this.pnl_crud_clientes.Controls.Add(this.txb_endereco);
            this.pnl_crud_clientes.Controls.Add(this.label9);
            this.pnl_crud_clientes.Controls.Add(this.label8);
            this.pnl_crud_clientes.Controls.Add(this.label7);
            this.pnl_crud_clientes.Controls.Add(this.label6);
            this.pnl_crud_clientes.Controls.Add(this.label5);
            this.pnl_crud_clientes.Controls.Add(this.label4);
            this.pnl_crud_clientes.Controls.Add(this.label3);
            this.pnl_crud_clientes.Controls.Add(this.label2);
            this.pnl_crud_clientes.Controls.Add(this.label1);
            this.pnl_crud_clientes.Location = new System.Drawing.Point(32, 39);
            this.pnl_crud_clientes.Name = "pnl_crud_clientes";
            this.pnl_crud_clientes.Size = new System.Drawing.Size(1095, 537);
            this.pnl_crud_clientes.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(887, 356);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(136, 73);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(887, 260);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(136, 73);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(715, 356);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(136, 73);
            this.btn_excluir.TabIndex = 11;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(715, 260);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(136, 73);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // mntc_dataNasc
            // 
            this.mntc_dataNasc.Location = new System.Drawing.Point(754, 51);
            this.mntc_dataNasc.Name = "mntc_dataNasc";
            this.mntc_dataNasc.TabIndex = 8;
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(315, 126);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(121, 25);
            this.cmb_estado.TabIndex = 4;
            // 
            // mskd_cep
            // 
            this.mskd_cep.Location = new System.Drawing.Point(315, 188);
            this.mskd_cep.Mask = "_____-___";
            this.mskd_cep.Name = "mskd_cep";
            this.mskd_cep.Size = new System.Drawing.Size(83, 25);
            this.mskd_cep.TabIndex = 7;
            // 
            // mskd_cpf_cnpj
            // 
            this.mskd_cpf_cnpj.Location = new System.Drawing.Point(315, 71);
            this.mskd_cpf_cnpj.Mask = "___,___,___/__";
            this.mskd_cpf_cnpj.Name = "mskd_cpf_cnpj";
            this.mskd_cpf_cnpj.Size = new System.Drawing.Size(116, 25);
            this.mskd_cpf_cnpj.TabIndex = 1;
            // 
            // mskd_telefone
            // 
            this.mskd_telefone.Location = new System.Drawing.Point(489, 78);
            this.mskd_telefone.Mask = "(__) _____-____";
            this.mskd_telefone.Name = "mskd_telefone";
            this.mskd_telefone.Size = new System.Drawing.Size(122, 25);
            this.mskd_telefone.TabIndex = 1;
            // 
            // txb_cidade
            // 
            this.txb_cidade.Location = new System.Drawing.Point(489, 126);
            this.txb_cidade.Name = "txb_cidade";
            this.txb_cidade.Size = new System.Drawing.Size(122, 25);
            this.txb_cidade.TabIndex = 5;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(11, 126);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(273, 25);
            this.txb_email.TabIndex = 3;
            // 
            // txb_nome
            // 
            this.txb_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.txb_nome.Location = new System.Drawing.Point(11, 71);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(273, 25);
            this.txb_nome.TabIndex = 0;
            // 
            // txb_endereco
            // 
            this.txb_endereco.Location = new System.Drawing.Point(11, 188);
            this.txb_endereco.Name = "txb_endereco";
            this.txb_endereco.Size = new System.Drawing.Size(273, 25);
            this.txb_endereco.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(831, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Data Nasc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // crud_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1200, 588);
            this.Controls.Add(this.pnl_crud_clientes);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "crud_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO CLIENTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_crud_clientes.ResumeLayout(false);
            this.pnl_crud_clientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_crud_clientes;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.MonthCalendar mntc_dataNasc;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.MaskedTextBox mskd_cep;
        private System.Windows.Forms.MaskedTextBox mskd_cpf_cnpj;
        private System.Windows.Forms.MaskedTextBox mskd_telefone;
        private System.Windows.Forms.TextBox txb_cidade;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_endereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}