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
    public partial class frm_consultas : Form
    {
        public frm_consultas()
        {
            InitializeComponent();
        }

        private void colaboradores_Click(object sender, EventArgs e)
        {
            ltv_colaboradores.Visible = true;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_pedidos.Visible = false;
        }

        private void fornecedores_Click(object sender, EventArgs e)
        {
            ltv_colaboradores.Visible = false;
            ltv_fornecedores.Visible = true;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_pedidos.Visible = false;
        }

        private void materiais_Click(object sender, EventArgs e)
        {
            ltv_colaboradores.Visible = false;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = true;
            ltv_clientes.Visible = false;
            ltv_pedidos.Visible = false;
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            ltv_colaboradores.Visible = false;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = true;
            ltv_pedidos.Visible = false;
        }

        private void pedidos_Click(object sender, EventArgs e)
        {
            ltv_colaboradores.Visible = false;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_pedidos.Visible = true;
        }
    }
}
