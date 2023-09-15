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



        #endregion

        private void btn_Fornecedores_Click(object sender, EventArgs e)
        {
            consulta_fornecedores frm = new consulta_fornecedores();
            frm.ShowDialog();
        }

        private void btn_Materiais_Click(object sender, EventArgs e)
        {
            consulta_materiais frm = new consulta_materiais();
            frm.ShowDialog();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            consulta_clientes  frm = new consulta_clientes();
            frm.ShowDialog();
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            consulta_pedidos frm = new consulta_pedidos();
            frm.ShowDialog();
        }

        private void btn_colabores_Click(object sender, EventArgs e)
        {
            consulta_colaboradores frm = new consulta_colaboradores();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}