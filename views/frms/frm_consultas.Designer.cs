namespace projeto2023.views.frms
{
    partial class frm_consultas
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
            this.pctb_consultas = new System.Windows.Forms.PictureBox();
            this.pnl_consultas = new System.Windows.Forms.Panel();
            this.menu_consultas = new System.Windows.Forms.MenuStrip();
            this.colaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.materiais = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.ltv_pedidos = new System.Windows.Forms.ListView();
            this.ltv_colaboradores = new System.Windows.Forms.ListView();
            this.ltv_fornecedores = new System.Windows.Forms.ListView();
            this.ltv_materiais = new System.Windows.Forms.ListView();
            this.ltv_clientes = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_consultas)).BeginInit();
            this.pnl_consultas.SuspendLayout();
            this.menu_consultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctb_consultas
            // 
            this.pctb_consultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_consultas.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_consultas.Location = new System.Drawing.Point(1001, 246);
            this.pctb_consultas.Name = "pctb_consultas";
            this.pctb_consultas.Size = new System.Drawing.Size(292, 309);
            this.pctb_consultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_consultas.TabIndex = 5;
            this.pctb_consultas.TabStop = false;
            // 
            // pnl_consultas
            // 
            this.pnl_consultas.Controls.Add(this.ltv_clientes);
            this.pnl_consultas.Controls.Add(this.ltv_materiais);
            this.pnl_consultas.Controls.Add(this.ltv_fornecedores);
            this.pnl_consultas.Controls.Add(this.ltv_colaboradores);
            this.pnl_consultas.Controls.Add(this.ltv_pedidos);
            this.pnl_consultas.Location = new System.Drawing.Point(30, 71);
            this.pnl_consultas.Name = "pnl_consultas";
            this.pnl_consultas.Size = new System.Drawing.Size(955, 491);
            this.pnl_consultas.TabIndex = 4;
            // 
            // menu_consultas
            // 
            this.menu_consultas.BackColor = System.Drawing.SystemColors.Control;
            this.menu_consultas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradores,
            this.fornecedores,
            this.materiais,
            this.clientes,
            this.pedidos});
            this.menu_consultas.Location = new System.Drawing.Point(0, 0);
            this.menu_consultas.Name = "menu_consultas";
            this.menu_consultas.Size = new System.Drawing.Size(1333, 24);
            this.menu_consultas.TabIndex = 3;
            this.menu_consultas.Text = "menuStrip1";
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
            // ltv_pedidos
            // 
            this.ltv_pedidos.HideSelection = false;
            this.ltv_pedidos.Location = new System.Drawing.Point(157, 224);
            this.ltv_pedidos.Name = "ltv_pedidos";
            this.ltv_pedidos.Size = new System.Drawing.Size(286, 172);
            this.ltv_pedidos.TabIndex = 0;
            this.ltv_pedidos.UseCompatibleStateImageBehavior = false;
            this.ltv_pedidos.Visible = false;
            // 
            // ltv_colaboradores
            // 
            this.ltv_colaboradores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ltv_colaboradores.HideSelection = false;
            this.ltv_colaboradores.Location = new System.Drawing.Point(14, 3);
            this.ltv_colaboradores.Name = "ltv_colaboradores";
            this.ltv_colaboradores.Size = new System.Drawing.Size(286, 172);
            this.ltv_colaboradores.TabIndex = 1;
            this.ltv_colaboradores.UseCompatibleStateImageBehavior = false;
            this.ltv_colaboradores.View = System.Windows.Forms.View.Details;
            this.ltv_colaboradores.Visible = false;
            // 
            // ltv_fornecedores
            // 
            this.ltv_fornecedores.HideSelection = false;
            this.ltv_fornecedores.Location = new System.Drawing.Point(325, 3);
            this.ltv_fornecedores.Name = "ltv_fornecedores";
            this.ltv_fornecedores.Size = new System.Drawing.Size(286, 172);
            this.ltv_fornecedores.TabIndex = 2;
            this.ltv_fornecedores.UseCompatibleStateImageBehavior = false;
            this.ltv_fornecedores.Visible = false;
            // 
            // ltv_materiais
            // 
            this.ltv_materiais.HideSelection = false;
            this.ltv_materiais.Location = new System.Drawing.Point(569, 224);
            this.ltv_materiais.Name = "ltv_materiais";
            this.ltv_materiais.Size = new System.Drawing.Size(286, 172);
            this.ltv_materiais.TabIndex = 3;
            this.ltv_materiais.UseCompatibleStateImageBehavior = false;
            this.ltv_materiais.Visible = false;
            // 
            // ltv_clientes
            // 
            this.ltv_clientes.HideSelection = false;
            this.ltv_clientes.Location = new System.Drawing.Point(636, 3);
            this.ltv_clientes.Name = "ltv_clientes";
            this.ltv_clientes.Size = new System.Drawing.Size(286, 172);
            this.ltv_clientes.TabIndex = 4;
            this.ltv_clientes.UseCompatibleStateImageBehavior = false;
            this.ltv_clientes.Visible = false;
            // 
            // frm_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.pctb_consultas);
            this.Controls.Add(this.pnl_consultas);
            this.Controls.Add(this.menu_consultas);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctb_consultas)).EndInit();
            this.pnl_consultas.ResumeLayout(false);
            this.menu_consultas.ResumeLayout(false);
            this.menu_consultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctb_consultas;
        private System.Windows.Forms.Panel pnl_consultas;
        private System.Windows.Forms.MenuStrip menu_consultas;
        private System.Windows.Forms.ToolStripMenuItem colaboradores;
        private System.Windows.Forms.ToolStripMenuItem fornecedores;
        private System.Windows.Forms.ToolStripMenuItem materiais;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem pedidos;
        private System.Windows.Forms.ListView ltv_clientes;
        private System.Windows.Forms.ListView ltv_materiais;
        private System.Windows.Forms.ListView ltv_fornecedores;
        private System.Windows.Forms.ListView ltv_colaboradores;
        private System.Windows.Forms.ListView ltv_pedidos;
    }
}