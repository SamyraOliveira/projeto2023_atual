using projeto2023.controllers;
using projeto2023.models;
using projeto2023.views.colaboradores;
using projeto2023.views.pedidos;
using projeto2023.views.fornecedores;
using projeto2023.views.clientes;
using projeto2023.views.materiais;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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






        #region click panel
        private void colaboradores_Click(object sender, EventArgs e)
        {
           // ltv_pedidos.Visible = false;
           // dtv_colaboradores.Visible = true;
            consulta_colaboradores frm = new consulta_colaboradores();
            frm.ShowDialog();
            /*ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_colaboradores.Visible = true;*/
        }

        private void fornecedores_Click(object sender, EventArgs e)
        {
            consulta_fornecedores frm = new consulta_fornecedores();
            frm.ShowDialog();
            // ltv_pedidos.Visible = false;
            /*ltv_fornecedores.Visible = true;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_colaboradores.Visible = false;*/
        }

        private void materiais_Click(object sender, EventArgs e)
        {
           // ltv_pedidos.Visible = false;
           /* ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = true;
            ltv_clientes.Visible = false;
            ltv_colaboradores.Visible = false;*/
        }

        private void clientes_Click(object sender, EventArgs e)
        {

            consulta_clientes frm = new consulta_clientes();
            frm.ShowDialog();
            // ltv_pedidos.Visible = false;
            /* ltv_fornecedores.Visible = false;
             ltv_materiais.Visible = false;
             ltv_clientes.Visible = true;
             ltv_colaboradores.Visible = false;*/
        }

        private void pedidos_Click(object sender, EventArgs e)
        {
            consulta_pedidos frm = new consulta_pedidos();
            frm.ShowDialog();
            //  ltv_pedidos.Visible = true;
            /* ltv_fornecedores.Visible = false;
             ltv_materiais.Visible = false;
             ltv_clientes.Visible = false;
             ltv_colaboradores.Visible = false;*/
        }


        #endregion

    }
}