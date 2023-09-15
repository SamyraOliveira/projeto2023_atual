namespace projeto2023.views.frms
{
    partial class frm_relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_relatorios));
            this.menu_relatorios = new System.Windows.Forms.MenuStrip();
            this.colaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.materiais = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_relatorios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Materiais = new System.Windows.Forms.Button();
            this.btn_Fornecedores = new System.Windows.Forms.Button();
            this.btn_Pedidos = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_colabores = new System.Windows.Forms.Button();
            this.pctb_cadastros = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menu_relatorios.SuspendLayout();
            this.pnl_relatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_relatorios
            // 
            this.menu_relatorios.BackColor = System.Drawing.SystemColors.Control;
            this.menu_relatorios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_relatorios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradores,
            this.fornecedores,
            this.materiais,
            this.clientes,
            this.pedidos});
            this.menu_relatorios.Location = new System.Drawing.Point(0, 0);
            this.menu_relatorios.Name = "menu_relatorios";
            this.menu_relatorios.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_relatorios.Size = new System.Drawing.Size(1755, 28);
            this.menu_relatorios.TabIndex = 3;
            this.menu_relatorios.Text = "menuStrip1";
            // 
            // colaboradores
            // 
            this.colaboradores.Name = "colaboradores";
            this.colaboradores.Size = new System.Drawing.Size(121, 24);
            this.colaboradores.Text = "Colaboradores";
            this.colaboradores.Click += new System.EventHandler(this.colaboradores_Click);
            // 
            // fornecedores
            // 
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(112, 24);
            this.fornecedores.Text = "Fornecedores";
            this.fornecedores.Click += new System.EventHandler(this.fornecedores_Click);
            // 
            // materiais
            // 
            this.materiais.Name = "materiais";
            this.materiais.Size = new System.Drawing.Size(84, 24);
            this.materiais.Text = "Materiais";
            this.materiais.Click += new System.EventHandler(this.materiais_Click);
            // 
            // clientes
            // 
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(75, 24);
            this.clientes.Text = "Clientes";
            this.clientes.Click += new System.EventHandler(this.clientes_Click);
            // 
            // pedidos
            // 
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(75, 24);
            this.pedidos.Text = "Pedidos";
            this.pedidos.Click += new System.EventHandler(this.pedidos_Click);
            // 
            // pnl_relatorios
            // 
            this.pnl_relatorios.Controls.Add(this.label2);
            this.pnl_relatorios.Controls.Add(this.label1);
            this.pnl_relatorios.Controls.Add(this.btn_Materiais);
            this.pnl_relatorios.Controls.Add(this.btn_Fornecedores);
            this.pnl_relatorios.Controls.Add(this.btn_Pedidos);
            this.pnl_relatorios.Controls.Add(this.btn_Clientes);
            this.pnl_relatorios.Controls.Add(this.btn_colabores);
            this.pnl_relatorios.Controls.Add(this.pctb_cadastros);
            this.pnl_relatorios.Location = new System.Drawing.Point(30, 71);
            this.pnl_relatorios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_relatorios.Name = "pnl_relatorios";
            this.pnl_relatorios.Size = new System.Drawing.Size(1712, 723);
            this.pnl_relatorios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 68);
            this.label1.TabIndex = 19;
            this.label1.Text = "Relatórios";
            // 
            // btn_Materiais
            // 
            this.btn_Materiais.Image = global::projeto2023.Properties.Resources.menu_btnEstoque;
            this.btn_Materiais.Location = new System.Drawing.Point(724, 130);
            this.btn_Materiais.Name = "btn_Materiais";
            this.btn_Materiais.Size = new System.Drawing.Size(210, 136);
            this.btn_Materiais.TabIndex = 18;
            this.btn_Materiais.Text = "MATERIAIS";
            this.btn_Materiais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Materiais.UseVisualStyleBackColor = true;
            // 
            // btn_Fornecedores
            // 
            this.btn_Fornecedores.Image = global::projeto2023.Properties.Resources.menu_btnFornecedor;
            this.btn_Fornecedores.Location = new System.Drawing.Point(414, 130);
            this.btn_Fornecedores.Name = "btn_Fornecedores";
            this.btn_Fornecedores.Size = new System.Drawing.Size(211, 136);
            this.btn_Fornecedores.TabIndex = 17;
            this.btn_Fornecedores.Text = "FORNECEDORES";
            this.btn_Fornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Fornecedores.UseVisualStyleBackColor = true;
            // 
            // btn_Pedidos
            // 
            this.btn_Pedidos.Image = global::projeto2023.Properties.Resources.menu_btnListaProntos;
            this.btn_Pedidos.Location = new System.Drawing.Point(414, 332);
            this.btn_Pedidos.Name = "btn_Pedidos";
            this.btn_Pedidos.Size = new System.Drawing.Size(211, 136);
            this.btn_Pedidos.TabIndex = 16;
            this.btn_Pedidos.Text = "PEDIDOS";
            this.btn_Pedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pedidos.UseVisualStyleBackColor = true;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Image = global::projeto2023.Properties.Resources.menu_btnCliente;
            this.btn_Clientes.Location = new System.Drawing.Point(75, 332);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(210, 136);
            this.btn_Clientes.TabIndex = 15;
            this.btn_Clientes.Text = "CLIENTES";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Clientes.UseVisualStyleBackColor = true;
            // 
            // btn_colabores
            // 
            this.btn_colabores.Image = global::projeto2023.Properties.Resources.menu_btnCliente;
            this.btn_colabores.Location = new System.Drawing.Point(75, 130);
            this.btn_colabores.Name = "btn_colabores";
            this.btn_colabores.Size = new System.Drawing.Size(210, 136);
            this.btn_colabores.TabIndex = 14;
            this.btn_colabores.Text = "COLABORADORES";
            this.btn_colabores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_colabores.UseVisualStyleBackColor = true;
            // 
            // pctb_cadastros
            // 
            this.pctb_cadastros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_cadastros.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_cadastros.Location = new System.Drawing.Point(1088, 215);
            this.pctb_cadastros.Name = "pctb_cadastros";
            this.pctb_cadastros.Size = new System.Drawing.Size(292, 309);
            this.pctb_cadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_cadastros.TabIndex = 13;
            this.pctb_cadastros.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "VOLTAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frm_relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1755, 853);
            this.Controls.Add(this.pnl_relatorios);
            this.Controls.Add(this.menu_relatorios);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios Gerais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_relatorios.ResumeLayout(false);
            this.menu_relatorios.PerformLayout();
            this.pnl_relatorios.ResumeLayout(false);
            this.pnl_relatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu_relatorios;
        private System.Windows.Forms.ToolStripMenuItem colaboradores;
        private System.Windows.Forms.ToolStripMenuItem fornecedores;
        private System.Windows.Forms.ToolStripMenuItem materiais;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem pedidos;
        private System.Windows.Forms.Panel pnl_relatorios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Materiais;
        private System.Windows.Forms.Button btn_Fornecedores;
        private System.Windows.Forms.Button btn_Pedidos;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_colabores;
        private System.Windows.Forms.PictureBox pctb_cadastros;
        private System.Windows.Forms.Label label2;
    }
}