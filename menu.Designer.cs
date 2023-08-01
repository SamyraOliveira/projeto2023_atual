namespace projeto2023
{
    partial class menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cadastros = new System.Windows.Forms.Button();
            this.btn_movimentacoes = new System.Windows.Forms.Button();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastros
            // 
            this.btn_cadastros.Image = global::projeto2023.Properties.Resources.menu_btnCliente;
            this.btn_cadastros.Location = new System.Drawing.Point(196, 163);
            this.btn_cadastros.Name = "btn_cadastros";
            this.btn_cadastros.Size = new System.Drawing.Size(201, 136);
            this.btn_cadastros.TabIndex = 0;
            this.btn_cadastros.Text = "CADASTROS";
            this.btn_cadastros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastros.UseVisualStyleBackColor = true;
            this.btn_cadastros.Click += new System.EventHandler(this.btn_cadastros_Click);
            // 
            // btn_movimentacoes
            // 
            this.btn_movimentacoes.Image = global::projeto2023.Properties.Resources.menu_btnEstoque;
            this.btn_movimentacoes.Location = new System.Drawing.Point(196, 365);
            this.btn_movimentacoes.Name = "btn_movimentacoes";
            this.btn_movimentacoes.Size = new System.Drawing.Size(201, 136);
            this.btn_movimentacoes.TabIndex = 1;
            this.btn_movimentacoes.Text = "MOVIMENTACOES";
            this.btn_movimentacoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_movimentacoes.UseVisualStyleBackColor = true;
            this.btn_movimentacoes.Click += new System.EventHandler(this.btn_movimentacoes_Click);
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.Image = global::projeto2023.Properties.Resources.menu_btnListaProntos;
            this.btn_relatorios.Location = new System.Drawing.Point(535, 365);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Size = new System.Drawing.Size(201, 136);
            this.btn_relatorios.TabIndex = 2;
            this.btn_relatorios.Text = "RELATORIOS";
            this.btn_relatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_relatorios.UseVisualStyleBackColor = true;
            this.btn_relatorios.Click += new System.EventHandler(this.btn_relatorios_Click);
            // 
            // btn_consultas
            // 
            this.btn_consultas.Image = global::projeto2023.Properties.Resources.menu_btnFornecedor;
            this.btn_consultas.Location = new System.Drawing.Point(535, 163);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(201, 136);
            this.btn_consultas.TabIndex = 3;
            this.btn_consultas.Text = "CONSULTAS";
            this.btn_consultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consultas.UseVisualStyleBackColor = true;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.BackgroundImage = global::projeto2023.Properties.Resources.menu_fundo;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.btn_consultas);
            this.Controls.Add(this.btn_relatorios);
            this.Controls.Add(this.btn_movimentacoes);
            this.Controls.Add(this.btn_cadastros);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "menu";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastros;
        private System.Windows.Forms.Button btn_movimentacoes;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.Button btn_consultas;
    }
}

