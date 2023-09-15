namespace projeto2023.views.materiais
{
    partial class crud_materiais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crud_materiais));
            this.lbl_idFornecedor = new System.Windows.Forms.Label();
            this.lbl_nomeMaterial = new System.Windows.Forms.Label();
            this.lbl_unidadeMedida = new System.Windows.Forms.Label();
            this.lbl_dataEntrada = new System.Windows.Forms.Label();
            this.lbl_quantEntrada = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_precoUnit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_idFornecedor = new System.Windows.Forms.ComboBox();
            this.cmb_unidadeMedida = new System.Windows.Forms.ComboBox();
            this.cmb_localArmazenamento = new System.Windows.Forms.ComboBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txb_precoUnit = new System.Windows.Forms.TextBox();
            this.txb_nomeMaterial = new System.Windows.Forms.TextBox();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.txb_numeroLote = new System.Windows.Forms.TextBox();
            this.txb_quantEntrada = new System.Windows.Forms.TextBox();
            this.mnth_dataEntrada = new System.Windows.Forms.MonthCalendar();
            this.pln_crud = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.mnth_ultimaAtualizacao = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.lbl_ultAtualizacao = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.pctb_cadastros = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pln_crud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idFornecedor
            // 
            this.lbl_idFornecedor.AutoSize = true;
            this.lbl_idFornecedor.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_idFornecedor.Location = new System.Drawing.Point(352, 183);
            this.lbl_idFornecedor.Name = "lbl_idFornecedor";
            this.lbl_idFornecedor.Size = new System.Drawing.Size(115, 21);
            this.lbl_idFornecedor.TabIndex = 0;
            this.lbl_idFornecedor.Text = "Fornecedor";
            // 
            // lbl_nomeMaterial
            // 
            this.lbl_nomeMaterial.AutoSize = true;
            this.lbl_nomeMaterial.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_nomeMaterial.Location = new System.Drawing.Point(659, 183);
            this.lbl_nomeMaterial.Name = "lbl_nomeMaterial";
            this.lbl_nomeMaterial.Size = new System.Drawing.Size(148, 21);
            this.lbl_nomeMaterial.TabIndex = 1;
            this.lbl_nomeMaterial.Text = "Nome Material";
            // 
            // lbl_unidadeMedida
            // 
            this.lbl_unidadeMedida.AutoSize = true;
            this.lbl_unidadeMedida.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_unidadeMedida.Location = new System.Drawing.Point(358, 253);
            this.lbl_unidadeMedida.Name = "lbl_unidadeMedida";
            this.lbl_unidadeMedida.Size = new System.Drawing.Size(190, 21);
            this.lbl_unidadeMedida.TabIndex = 2;
            this.lbl_unidadeMedida.Text = "Unidade de Medida";
            // 
            // lbl_dataEntrada
            // 
            this.lbl_dataEntrada.AutoSize = true;
            this.lbl_dataEntrada.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_dataEntrada.Location = new System.Drawing.Point(37, 194);
            this.lbl_dataEntrada.Name = "lbl_dataEntrada";
            this.lbl_dataEntrada.Size = new System.Drawing.Size(162, 21);
            this.lbl_dataEntrada.TabIndex = 3;
            this.lbl_dataEntrada.Text = "Data de Entrada";
            // 
            // lbl_quantEntrada
            // 
            this.lbl_quantEntrada.AutoSize = true;
            this.lbl_quantEntrada.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_quantEntrada.Location = new System.Drawing.Point(674, 481);
            this.lbl_quantEntrada.Name = "lbl_quantEntrada";
            this.lbl_quantEntrada.Size = new System.Drawing.Size(175, 21);
            this.lbl_quantEntrada.TabIndex = 4;
            this.lbl_quantEntrada.Text = "Quantidade inicial";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_descricao.Location = new System.Drawing.Point(846, 260);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(101, 21);
            this.lbl_descricao.TabIndex = 6;
            this.lbl_descricao.Text = "Descrição";
            // 
            // lbl_precoUnit
            // 
            this.lbl_precoUnit.AutoSize = true;
            this.lbl_precoUnit.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_precoUnit.Location = new System.Drawing.Point(357, 341);
            this.lbl_precoUnit.Name = "lbl_precoUnit";
            this.lbl_precoUnit.Size = new System.Drawing.Size(142, 21);
            this.lbl_precoUnit.TabIndex = 7;
            this.lbl_precoUnit.Text = "Preço Unitario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(358, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Local de Armazenamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(582, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Numero Lote";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_status.Location = new System.Drawing.Point(914, 481);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(69, 21);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status";
            // 
            // cmb_idFornecedor
            // 
            this.cmb_idFornecedor.FormattingEnabled = true;
            this.cmb_idFornecedor.Location = new System.Drawing.Point(355, 206);
            this.cmb_idFornecedor.Name = "cmb_idFornecedor";
            this.cmb_idFornecedor.Size = new System.Drawing.Size(259, 24);
            this.cmb_idFornecedor.TabIndex = 11;
            // 
            // cmb_unidadeMedida
            // 
            this.cmb_unidadeMedida.FormattingEnabled = true;
            this.cmb_unidadeMedida.Location = new System.Drawing.Point(361, 276);
            this.cmb_unidadeMedida.Name = "cmb_unidadeMedida";
            this.cmb_unidadeMedida.Size = new System.Drawing.Size(121, 24);
            this.cmb_unidadeMedida.TabIndex = 12;
            // 
            // cmb_localArmazenamento
            // 
            this.cmb_localArmazenamento.FormattingEnabled = true;
            this.cmb_localArmazenamento.Location = new System.Drawing.Point(361, 475);
            this.cmb_localArmazenamento.Name = "cmb_localArmazenamento";
            this.cmb_localArmazenamento.Size = new System.Drawing.Size(166, 24);
            this.cmb_localArmazenamento.TabIndex = 13;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(916, 504);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(134, 24);
            this.cmb_status.TabIndex = 14;
            // 
            // txb_precoUnit
            // 
            this.txb_precoUnit.Location = new System.Drawing.Point(361, 364);
            this.txb_precoUnit.Name = "txb_precoUnit";
            this.txb_precoUnit.Size = new System.Drawing.Size(100, 24);
            this.txb_precoUnit.TabIndex = 15;
            // 
            // txb_nomeMaterial
            // 
            this.txb_nomeMaterial.Location = new System.Drawing.Point(662, 206);
            this.txb_nomeMaterial.Name = "txb_nomeMaterial";
            this.txb_nomeMaterial.Size = new System.Drawing.Size(307, 24);
            this.txb_nomeMaterial.TabIndex = 16;
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(775, 284);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(275, 165);
            this.txb_descricao.TabIndex = 17;
            // 
            // txb_numeroLote
            // 
            this.txb_numeroLote.Location = new System.Drawing.Point(586, 276);
            this.txb_numeroLote.Name = "txb_numeroLote";
            this.txb_numeroLote.Size = new System.Drawing.Size(100, 24);
            this.txb_numeroLote.TabIndex = 18;
            // 
            // txb_quantEntrada
            // 
            this.txb_quantEntrada.Location = new System.Drawing.Point(677, 504);
            this.txb_quantEntrada.Name = "txb_quantEntrada";
            this.txb_quantEntrada.Size = new System.Drawing.Size(130, 24);
            this.txb_quantEntrada.TabIndex = 19;
            // 
            // mnth_dataEntrada
            // 
            this.mnth_dataEntrada.Location = new System.Drawing.Point(30, 219);
            this.mnth_dataEntrada.Name = "mnth_dataEntrada";
            this.mnth_dataEntrada.TabIndex = 20;
            // 
            // pln_crud
            // 
            this.pln_crud.Controls.Add(this.label2);
            this.pln_crud.Controls.Add(this.label13);
            this.pln_crud.Controls.Add(this.mnth_ultimaAtualizacao);
            this.pln_crud.Controls.Add(this.label1);
            this.pln_crud.Controls.Add(this.btn_excluir);
            this.pln_crud.Controls.Add(this.lbl_ultAtualizacao);
            this.pln_crud.Controls.Add(this.btn_limpar);
            this.pln_crud.Controls.Add(this.btn_salvar);
            this.pln_crud.Controls.Add(this.mnth_dataEntrada);
            this.pln_crud.Controls.Add(this.txb_descricao);
            this.pln_crud.Controls.Add(this.lbl_dataEntrada);
            this.pln_crud.Controls.Add(this.txb_nomeMaterial);
            this.pln_crud.Controls.Add(this.txb_quantEntrada);
            this.pln_crud.Controls.Add(this.cmb_unidadeMedida);
            this.pln_crud.Controls.Add(this.cmb_idFornecedor);
            this.pln_crud.Controls.Add(this.lbl_quantEntrada);
            this.pln_crud.Controls.Add(this.lbl_descricao);
            this.pln_crud.Controls.Add(this.txb_numeroLote);
            this.pln_crud.Controls.Add(this.lbl_unidadeMedida);
            this.pln_crud.Controls.Add(this.lbl_precoUnit);
            this.pln_crud.Controls.Add(this.lbl_nomeMaterial);
            this.pln_crud.Controls.Add(this.label9);
            this.pln_crud.Controls.Add(this.lbl_idFornecedor);
            this.pln_crud.Controls.Add(this.label10);
            this.pln_crud.Controls.Add(this.txb_precoUnit);
            this.pln_crud.Controls.Add(this.lbl_status);
            this.pln_crud.Controls.Add(this.cmb_status);
            this.pln_crud.Controls.Add(this.cmb_localArmazenamento);
            this.pln_crud.Location = new System.Drawing.Point(22, 12);
            this.pln_crud.Name = "pln_crud";
            this.pln_crud.Size = new System.Drawing.Size(1257, 849);
            this.pln_crud.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(559, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(617, 68);
            this.label13.TabIndex = 34;
            this.label13.Text = "Cadastro Materiais";
            // 
            // mnth_ultimaAtualizacao
            // 
            this.mnth_ultimaAtualizacao.Location = new System.Drawing.Point(30, 475);
            this.mnth_ultimaAtualizacao.Name = "mnth_ultimaAtualizacao";
            this.mnth_ultimaAtualizacao.TabIndex = 27;
            this.mnth_ultimaAtualizacao.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "---ultima atualizacao";
            this.label1.Visible = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Red;
            this.btn_excluir.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_excluir.Location = new System.Drawing.Point(622, 583);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(129, 77);
            this.btn_excluir.TabIndex = 24;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // lbl_ultAtualizacao
            // 
            this.lbl_ultAtualizacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_ultAtualizacao.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_ultAtualizacao.Location = new System.Drawing.Point(1019, 583);
            this.lbl_ultAtualizacao.Name = "lbl_ultAtualizacao";
            this.lbl_ultAtualizacao.Size = new System.Drawing.Size(129, 77);
            this.lbl_ultAtualizacao.TabIndex = 23;
            this.lbl_ultAtualizacao.Text = "CANCELAR";
            this.lbl_ultAtualizacao.UseVisualStyleBackColor = false;
            this.lbl_ultAtualizacao.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_limpar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_limpar.Location = new System.Drawing.Point(818, 583);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(129, 77);
            this.btn_limpar.TabIndex = 22;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_salvar.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.Location = new System.Drawing.Point(438, 583);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(129, 77);
            this.btn_salvar.TabIndex = 21;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // pctb_cadastros
            // 
            this.pctb_cadastros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_cadastros.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_cadastros.Location = new System.Drawing.Point(1304, 318);
            this.pctb_cadastros.Name = "pctb_cadastros";
            this.pctb_cadastros.Size = new System.Drawing.Size(292, 309);
            this.pctb_cadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_cadastros.TabIndex = 34;
            this.pctb_cadastros.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 702);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 35;
            this.label2.Text = "VOLTAR";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // crud_materiais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1646, 873);
            this.Controls.Add(this.pctb_cadastros);
            this.Controls.Add(this.pln_crud);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "crud_materiais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Materiais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.crud_materiais_Load);
            this.pln_crud.ResumeLayout(false);
            this.pln_crud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_idFornecedor;
        private System.Windows.Forms.Label lbl_nomeMaterial;
        private System.Windows.Forms.Label lbl_unidadeMedida;
        private System.Windows.Forms.Label lbl_dataEntrada;
        private System.Windows.Forms.Label lbl_quantEntrada;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_precoUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cmb_idFornecedor;
        private System.Windows.Forms.ComboBox cmb_unidadeMedida;
        private System.Windows.Forms.ComboBox cmb_localArmazenamento;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txb_precoUnit;
        private System.Windows.Forms.TextBox txb_nomeMaterial;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.TextBox txb_numeroLote;
        private System.Windows.Forms.TextBox txb_quantEntrada;
        private System.Windows.Forms.MonthCalendar mnth_dataEntrada;
        private System.Windows.Forms.Panel pln_crud;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button lbl_ultAtualizacao;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mnth_ultimaAtualizacao;
        private System.Windows.Forms.PictureBox pctb_cadastros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
    }
}