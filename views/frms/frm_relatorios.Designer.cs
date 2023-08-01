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
            this.menu_relatorios = new System.Windows.Forms.MenuStrip();
            this.colaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.materiais = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_relatorios = new System.Windows.Forms.Panel();
            this.pctb_relatorios = new System.Windows.Forms.PictureBox();
            this.menu_relatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_relatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_relatorios
            // 
            this.menu_relatorios.BackColor = System.Drawing.SystemColors.Control;
            this.menu_relatorios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradores,
            this.fornecedores,
            this.materiais,
            this.clientes,
            this.pedidos});
            this.menu_relatorios.Location = new System.Drawing.Point(0, 0);
            this.menu_relatorios.Name = "menu_relatorios";
            this.menu_relatorios.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_relatorios.Size = new System.Drawing.Size(1333, 24);
            this.menu_relatorios.TabIndex = 3;
            this.menu_relatorios.Text = "menuStrip1";
            // 
            // colaboradores
            // 
            this.colaboradores.Name = "colaboradores";
            this.colaboradores.Size = new System.Drawing.Size(96, 20);
            this.colaboradores.Text = "Colaboradores";
            this.colaboradores.Click += new System.EventHandler(this.colaboradores_Click);
            // 
            // fornecedores
            // 
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(90, 20);
            this.fornecedores.Text = "Fornecedores";
            this.fornecedores.Click += new System.EventHandler(this.fornecedores_Click);
            // 
            // materiais
            // 
            this.materiais.Name = "materiais";
            this.materiais.Size = new System.Drawing.Size(67, 20);
            this.materiais.Text = "Materiais";
            this.materiais.Click += new System.EventHandler(this.materiais_Click);
            // 
            // clientes
            // 
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(61, 20);
            this.clientes.Text = "Clientes";
            this.clientes.Click += new System.EventHandler(this.clientes_Click);
            // 
            // pedidos
            // 
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(61, 20);
            this.pedidos.Text = "Pedidos";
            this.pedidos.Click += new System.EventHandler(this.pedidos_Click);
            // 
            // pnl_relatorios
            // 
            this.pnl_relatorios.Location = new System.Drawing.Point(30, 71);
            this.pnl_relatorios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_relatorios.Name = "pnl_relatorios";
            this.pnl_relatorios.Size = new System.Drawing.Size(925, 453);
            this.pnl_relatorios.TabIndex = 0;
            // 
            // pctb_relatorios
            // 
            this.pctb_relatorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_relatorios.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_relatorios.Location = new System.Drawing.Point(1001, 177);
            this.pctb_relatorios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pctb_relatorios.Name = "pctb_relatorios";
            this.pctb_relatorios.Size = new System.Drawing.Size(292, 309);
            this.pctb_relatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_relatorios.TabIndex = 5;
            this.pctb_relatorios.TabStop = false;
            // 
            // frm_relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.pnl_relatorios);
            this.Controls.Add(this.pctb_relatorios);
            this.Controls.Add(this.menu_relatorios);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_relatorios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_relatorios.ResumeLayout(false);
            this.menu_relatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_relatorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctb_relatorios;
        private System.Windows.Forms.MenuStrip menu_relatorios;
        private System.Windows.Forms.ToolStripMenuItem colaboradores;
        private System.Windows.Forms.ToolStripMenuItem fornecedores;
        private System.Windows.Forms.ToolStripMenuItem materiais;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem pedidos;
        private System.Windows.Forms.Panel pnl_relatorios;
    }
}