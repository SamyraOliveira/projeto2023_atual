using projeto2023.views.clientes;
using projeto2023.views.colaboradores;
using projeto2023.views.fornecedores;
using projeto2023.views.materiais;
using projeto2023.views.pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projeto2023.views.frms
{
    public partial class frm_cadastros : Form
    {
        public frm_cadastros()
        {
            InitializeComponent();
        }

        private void btn_colabores_Click(object sender, EventArgs e)
        {
            crud_colaboradores frm = new crud_colaboradores();
            frm.ShowDialog();
        }

        private void btn_Fornecedores_Click(object sender, EventArgs e)
        {
            crud_fornecedores frm = new crud_fornecedores();
            frm.ShowDialog();
        }

        private void btn_Materiais_Click(object sender, EventArgs e)
        {
            crud_materiais frm = new crud_materiais();
            frm.ShowDialog();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            crud_clientes frm = new crud_clientes();
            frm.ShowDialog();
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            crud_pedidos frm = new crud_pedidos();
            frm.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
