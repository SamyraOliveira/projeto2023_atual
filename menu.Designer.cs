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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.label1 = new System.Windows.Forms.Label();
            this.pctb_cadastros = new System.Windows.Forms.PictureBox();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.btn_movimentacoes = new System.Windows.Forms.Button();
            this.btn_cadastros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGOUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pctb_cadastros
            // 
            this.pctb_cadastros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_cadastros.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_cadastros.Location = new System.Drawing.Point(1028, 243);
            this.pctb_cadastros.Name = "pctb_cadastros";
            this.pctb_cadastros.Size = new System.Drawing.Size(508, 474);
            this.pctb_cadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_cadastros.TabIndex = 4;
            this.pctb_cadastros.TabStop = false;
            // 
            // btn_consultas
            // 
            this.btn_consultas.Image = global::projeto2023.Properties.Resources.menu_btnFornecedor;
            this.btn_consultas.Location = new System.Drawing.Point(601, 153);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(201, 136);
            this.btn_consultas.TabIndex = 3;
            this.btn_consultas.Text = "CONSULTAS";
            this.btn_consultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_consultas.UseVisualStyleBackColor = true;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.Image = global::projeto2023.Properties.Resources.menu_btnListaProntos;
            this.btn_relatorios.Location = new System.Drawing.Point(601, 355);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Size = new System.Drawing.Size(201, 136);
            this.btn_relatorios.TabIndex = 2;
            this.btn_relatorios.Text = "RELATORIOS";
            this.btn_relatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_relatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_relatorios.UseVisualStyleBackColor = true;
            this.btn_relatorios.Click += new System.EventHandler(this.btn_relatorios_Click);
            // 
            // btn_movimentacoes
            // 
            this.btn_movimentacoes.Image = global::projeto2023.Properties.Resources.menu_btnEstoque;
            this.btn_movimentacoes.Location = new System.Drawing.Point(262, 355);
            this.btn_movimentacoes.Name = "btn_movimentacoes";
            this.btn_movimentacoes.Size = new System.Drawing.Size(201, 136);
            this.btn_movimentacoes.TabIndex = 1;
            this.btn_movimentacoes.Text = "MOVIMENTACOES";
            this.btn_movimentacoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_movimentacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_movimentacoes.UseVisualStyleBackColor = true;
            this.btn_movimentacoes.Click += new System.EventHandler(this.btn_movimentacoes_Click);
            // 
            // btn_cadastros
            // 
            this.btn_cadastros.Image = global::projeto2023.Properties.Resources.menu_btnCliente;
            this.btn_cadastros.Location = new System.Drawing.Point(262, 153);
            this.btn_cadastros.Name = "btn_cadastros";
            this.btn_cadastros.Size = new System.Drawing.Size(201, 136);
            this.btn_cadastros.TabIndex = 0;
            this.btn_cadastros.Text = "CADASTROS";
            this.btn_cadastros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cadastros.UseVisualStyleBackColor = true;
            this.btn_cadastros.Click += new System.EventHandler(this.btn_cadastros_Click);
            // 
            // button1
            // 
            this.button1.Image = global::projeto2023.Properties.Resources.menu_btnEstoque;
            this.button1.Location = new System.Drawing.Point(262, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 136);
            this.button1.TabIndex = 6;
            this.button1.Text = "PRODUÇÃO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1755, 845);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctb_cadastros);
            this.Controls.Add(this.btn_consultas);
            this.Controls.Add(this.btn_relatorios);
            this.Controls.Add(this.btn_movimentacoes);
            this.Controls.Add(this.btn_cadastros);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastros;
        private System.Windows.Forms.Button btn_movimentacoes;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.PictureBox pctb_cadastros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

