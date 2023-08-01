namespace projeto2023.views.frms
{
    partial class frm_movimentacoes
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
            this.pctb_movimentacoes = new System.Windows.Forms.PictureBox();
            this.pnl_movimentacoes = new System.Windows.Forms.Panel();
            this.menu_movimentacoes = new System.Windows.Forms.MenuStrip();
            this.colaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.materiais = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidos = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_movimentacoes)).BeginInit();
            this.menu_movimentacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctb_movimentacoes
            // 
            this.pctb_movimentacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_movimentacoes.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_movimentacoes.Location = new System.Drawing.Point(1001, 177);
            this.pctb_movimentacoes.Name = "pctb_movimentacoes";
            this.pctb_movimentacoes.Size = new System.Drawing.Size(292, 309);
            this.pctb_movimentacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_movimentacoes.TabIndex = 5;
            this.pctb_movimentacoes.TabStop = false;
            // 
            // pnl_movimentacoes
            // 
            this.pnl_movimentacoes.Location = new System.Drawing.Point(30, 71);
            this.pnl_movimentacoes.Name = "pnl_movimentacoes";
            this.pnl_movimentacoes.Size = new System.Drawing.Size(955, 491);
            this.pnl_movimentacoes.TabIndex = 4;
            // 
            // menu_movimentacoes
            // 
            this.menu_movimentacoes.BackColor = System.Drawing.SystemColors.Control;
            this.menu_movimentacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradores,
            this.fornecedores,
            this.materiais,
            this.clientes,
            this.pedidos});
            this.menu_movimentacoes.Location = new System.Drawing.Point(0, 0);
            this.menu_movimentacoes.Name = "menu_movimentacoes";
            this.menu_movimentacoes.Size = new System.Drawing.Size(1333, 24);
            this.menu_movimentacoes.TabIndex = 3;
            this.menu_movimentacoes.Text = "menuStrip1";
            // 
            // colaboradores
            // 
            this.colaboradores.Name = "colaboradores";
            this.colaboradores.Size = new System.Drawing.Size(96, 20);
            this.colaboradores.Text = "Colaboradores";
            // 
            // fornecedores
            // 
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(90, 20);
            this.fornecedores.Text = "Fornecedores";
            // 
            // materiais
            // 
            this.materiais.Name = "materiais";
            this.materiais.Size = new System.Drawing.Size(67, 20);
            this.materiais.Text = "Materiais";
            // 
            // clientes
            // 
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(61, 20);
            this.clientes.Text = "Clientes";
            // 
            // pedidos
            // 
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(61, 20);
            this.pedidos.Text = "Pedidos";
            // 
            // frm_movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.pctb_movimentacoes);
            this.Controls.Add(this.pnl_movimentacoes);
            this.Controls.Add(this.menu_movimentacoes);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_movimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_movimentacoes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctb_movimentacoes)).EndInit();
            this.menu_movimentacoes.ResumeLayout(false);
            this.menu_movimentacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctb_movimentacoes;
        private System.Windows.Forms.Panel pnl_movimentacoes;
        private System.Windows.Forms.MenuStrip menu_movimentacoes;
        private System.Windows.Forms.ToolStripMenuItem colaboradores;
        private System.Windows.Forms.ToolStripMenuItem fornecedores;
        private System.Windows.Forms.ToolStripMenuItem materiais;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem pedidos;
    }
}