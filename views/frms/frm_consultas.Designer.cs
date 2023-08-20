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
            this.ltv_clientes = new System.Windows.Forms.ListView();
            this.ltv_materiais = new System.Windows.Forms.ListView();
            this.ltv_fornecedores = new System.Windows.Forms.ListView();
            this.ltv_colaboradores = new System.Windows.Forms.ListView();
            this.codigo_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cargo_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataNasc_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cidade_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endereco_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CEP_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltv_pedidos = new System.Windows.Forms.ListView();
            this.menu_consultas = new System.Windows.Forms.MenuStrip();
            this.colaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.materiais = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.bairro_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password_Colaborador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.pnl_consultas.Size = new System.Drawing.Size(955, 609);
            this.pnl_consultas.TabIndex = 4;
            // 
            // ltv_clientes
            // 
            this.ltv_clientes.HideSelection = false;
            this.ltv_clientes.Location = new System.Drawing.Point(374, 434);
            this.ltv_clientes.Name = "ltv_clientes";
            this.ltv_clientes.Size = new System.Drawing.Size(286, 172);
            this.ltv_clientes.TabIndex = 4;
            this.ltv_clientes.UseCompatibleStateImageBehavior = false;
            this.ltv_clientes.Visible = false;
            // 
            // ltv_materiais
            // 
            this.ltv_materiais.HideSelection = false;
            this.ltv_materiais.Location = new System.Drawing.Point(666, 434);
            this.ltv_materiais.Name = "ltv_materiais";
            this.ltv_materiais.Size = new System.Drawing.Size(286, 172);
            this.ltv_materiais.TabIndex = 3;
            this.ltv_materiais.UseCompatibleStateImageBehavior = false;
            this.ltv_materiais.Visible = false;
            // 
            // ltv_fornecedores
            // 
            this.ltv_fornecedores.HideSelection = false;
            this.ltv_fornecedores.Location = new System.Drawing.Point(666, 256);
            this.ltv_fornecedores.Name = "ltv_fornecedores";
            this.ltv_fornecedores.Size = new System.Drawing.Size(286, 172);
            this.ltv_fornecedores.TabIndex = 2;
            this.ltv_fornecedores.UseCompatibleStateImageBehavior = false;
            this.ltv_fornecedores.Visible = false;
            // 
            // ltv_colaboradores
            // 
            this.ltv_colaboradores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ltv_colaboradores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo_Colaborador,
            this.CPF_Colaborador,
            this.cargo_Colaborador,
            this.telefone_Colaborador,
            this.email_Colaborador,
            this.estado_Colaborador,
            this.cidade_Colaborador,
            this.endereco_Colaborador,
            this.bairro_Colaborador,
            this.CEP_Colaborador,
            this.nome_Colaborador,
            this.dataNasc_Colaborador,
            this.user_Colaborador,
            this.password_Colaborador,
            this.status_Colaborador});
            this.ltv_colaboradores.HideSelection = false;
            this.ltv_colaboradores.Location = new System.Drawing.Point(3, 62);
            this.ltv_colaboradores.Name = "ltv_colaboradores";
            this.ltv_colaboradores.Size = new System.Drawing.Size(949, 172);
            this.ltv_colaboradores.TabIndex = 1;
            this.ltv_colaboradores.UseCompatibleStateImageBehavior = false;
            this.ltv_colaboradores.View = System.Windows.Forms.View.Details;
            this.ltv_colaboradores.Visible = false;
            this.ltv_colaboradores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ltv_colaboradores_MouseClick);
            // 
            // codigo_Colaborador
            // 
            this.codigo_Colaborador.Text = "Codigo";
            // 
            // CPF_Colaborador
            // 
            this.CPF_Colaborador.Text = "CPF";
            // 
            // cargo_Colaborador
            // 
            this.cargo_Colaborador.Text = "Cargo";
            // 
            // telefone_Colaborador
            // 
            this.telefone_Colaborador.Text = "Telefone";
            // 
            // email_Colaborador
            // 
            this.email_Colaborador.Text = "Email";
            // 
            // dataNasc_Colaborador
            // 
            this.dataNasc_Colaborador.DisplayIndex = 5;
            this.dataNasc_Colaborador.Text = "Data Nascimento";
            // 
            // estado_Colaborador
            // 
            this.estado_Colaborador.DisplayIndex = 6;
            this.estado_Colaborador.Text = "Estado";
            // 
            // cidade_Colaborador
            // 
            this.cidade_Colaborador.DisplayIndex = 7;
            this.cidade_Colaborador.Text = "Cidade";
            // 
            // endereco_Colaborador
            // 
            this.endereco_Colaborador.DisplayIndex = 8;
            this.endereco_Colaborador.Text = "Endereco";
            // 
            // CEP_Colaborador
            // 
            this.CEP_Colaborador.Text = "CEP";
            // 
            // status_Colaborador
            // 
            this.status_Colaborador.DisplayIndex = 10;
            this.status_Colaborador.Text = "Status";
            // 
            // ltv_pedidos
            // 
            this.ltv_pedidos.HideSelection = false;
            this.ltv_pedidos.Location = new System.Drawing.Point(3, 434);
            this.ltv_pedidos.Name = "ltv_pedidos";
            this.ltv_pedidos.Size = new System.Drawing.Size(286, 172);
            this.ltv_pedidos.TabIndex = 0;
            this.ltv_pedidos.UseCompatibleStateImageBehavior = false;
            this.ltv_pedidos.Visible = false;
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
            // bairro_Colaborador
            // 
            this.bairro_Colaborador.DisplayIndex = 11;
            this.bairro_Colaborador.Text = "Bairro";
            // 
            // nome_Colaborador
            // 
            this.nome_Colaborador.DisplayIndex = 12;
            // 
            // user_Colaborador
            // 
            this.user_Colaborador.DisplayIndex = 13;
            this.user_Colaborador.Text = "Usuario";
            // 
            // password_Colaborador
            // 
            this.password_Colaborador.DisplayIndex = 14;
            this.password_Colaborador.Text = "Senha";
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
        private System.Windows.Forms.ColumnHeader codigo_Colaborador;
        private System.Windows.Forms.ColumnHeader CPF_Colaborador;
        private System.Windows.Forms.ColumnHeader cargo_Colaborador;
        private System.Windows.Forms.ColumnHeader telefone_Colaborador;
        private System.Windows.Forms.ColumnHeader email_Colaborador;
        private System.Windows.Forms.ColumnHeader dataNasc_Colaborador;
        private System.Windows.Forms.ColumnHeader estado_Colaborador;
        private System.Windows.Forms.ColumnHeader cidade_Colaborador;
        private System.Windows.Forms.ColumnHeader endereco_Colaborador;
        private System.Windows.Forms.ColumnHeader CEP_Colaborador;
        private System.Windows.Forms.ColumnHeader status_Colaborador;
        private System.Windows.Forms.ColumnHeader bairro_Colaborador;
        private System.Windows.Forms.ColumnHeader nome_Colaborador;
        private System.Windows.Forms.ColumnHeader user_Colaborador;
        private System.Windows.Forms.ColumnHeader password_Colaborador;
    }
}