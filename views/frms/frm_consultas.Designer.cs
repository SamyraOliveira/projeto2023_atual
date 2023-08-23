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
            this.components = new System.ComponentModel.Container();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estampariadbDataSet = new projeto2023.EstampariadbDataSet();
            this.menu_consultas = new System.Windows.Forms.MenuStrip();
            this.colaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.materiais = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosTableAdapter = new projeto2023.EstampariadbDataSetTableAdapters.PedidosTableAdapter();
            this.estampariadbDataSet1_COLABORADORES = new projeto2023.EstampariadbDataSet1_COLABORADORES();
            this.colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradoresTableAdapter = new projeto2023.EstampariadbDataSet1_COLABORADORESTableAdapters.ColaboradoresTableAdapter();
            this.pctb_consultas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet)).BeginInit();
            this.menu_consultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_COLABORADORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.estampariadbDataSetBindingSource;
            // 
            // estampariadbDataSetBindingSource
            // 
            this.estampariadbDataSetBindingSource.DataSource = this.estampariadbDataSet;
            this.estampariadbDataSetBindingSource.Position = 0;
            // 
            // estampariadbDataSet
            // 
            this.estampariadbDataSet.DataSetName = "EstampariadbDataSet";
            this.estampariadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.menu_consultas.Size = new System.Drawing.Size(1755, 24);
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
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // estampariadbDataSet1_COLABORADORES
            // 
            this.estampariadbDataSet1_COLABORADORES.DataSetName = "EstampariadbDataSet1_COLABORADORES";
            this.estampariadbDataSet1_COLABORADORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradoresBindingSource
            // 
            this.colaboradoresBindingSource.DataMember = "Colaboradores";
            this.colaboradoresBindingSource.DataSource = this.estampariadbDataSet1_COLABORADORES;
            // 
            // colaboradoresTableAdapter
            // 
            this.colaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // pctb_consultas
            // 
            this.pctb_consultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_consultas.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_consultas.Location = new System.Drawing.Point(1240, 319);
            this.pctb_consultas.Name = "pctb_consultas";
            this.pctb_consultas.Size = new System.Drawing.Size(292, 309);
            this.pctb_consultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_consultas.TabIndex = 5;
            this.pctb_consultas.TabStop = false;
            // 
            // frm_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1755, 853);
            this.Controls.Add(this.pctb_consultas);
            this.Controls.Add(this.menu_consultas);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet)).EndInit();
            this.menu_consultas.ResumeLayout(false);
            this.menu_consultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estampariadbDataSet1_COLABORADORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_consultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctb_consultas;
        private System.Windows.Forms.MenuStrip menu_consultas;
        private System.Windows.Forms.ToolStripMenuItem colaboradores;
        private System.Windows.Forms.ToolStripMenuItem fornecedores;
        private System.Windows.Forms.ToolStripMenuItem materiais;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem pedidos;
        private System.Windows.Forms.BindingSource estampariadbDataSetBindingSource;
        private EstampariadbDataSet estampariadbDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private EstampariadbDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private EstampariadbDataSet1_COLABORADORES estampariadbDataSet1_COLABORADORES;
        private System.Windows.Forms.BindingSource colaboradoresBindingSource;
        private EstampariadbDataSet1_COLABORADORESTableAdapters.ColaboradoresTableAdapter colaboradoresTableAdapter;
    }
}