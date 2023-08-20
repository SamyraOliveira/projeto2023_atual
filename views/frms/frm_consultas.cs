using projeto2023.controllers;
using projeto2023.models;
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

        private void colaboradores_Click(object sender, EventArgs e)
        {
            ltv_colaboradores.Visible = true;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_pedidos.Visible = false;


            // Função para carregar os colaboradores da base de dados

          /*  void CarregarColaboradoresListView()
            {
                List<Colaboradores> colaboradores = CarregarColaboradoresDoBanco();

                ltv_colaboradores.Items.Clear();

                foreach (Colaboradores colab in colaboradores)
                {
                    ListViewItem item = new ListViewItem(colab.colab_codigo.ToString());
                    item.SubItems.Add(colab.colab_nome);

                    ltv_colaboradores.Items.Add(item);
                }
            }

            // Função para carregar os colaboradores da base de dados
            List<Colaboradores> CarregarColaboradoresDoBanco()
            {
                List<Colaboradores> colaboradores = new List<Colaboradores>();

                // Conexão com o banco e consulta
                using (Connection connection = new Connection())
                {
                    SqlConnection sqlConnection = connection.RetornarConexao();
                    sqlConnection.Open();

                    string query = "SELECT codigo_Colaborador, nome_Colaborador FROM Colaboradores";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int colabId = (int)reader["codigo_Colaborador"];
                        string nomeColab = (string)reader["nome_Colaborador"];
                        colaboradores.Add(new Colaboradores(colabId, nomeColab));
                    }

                    reader.Close();
                }

                return colaboradores;
            }*/
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

        private void ltv_colaboradores_MouseClick(object sender, MouseEventArgs e)
        {
            /* int indice = ltv_colaboradores.FocusedItem.Index;
            codigo_Colaborador = ltv_colaboradores.Items[indice].SubItems[0].Text;
            int.Parse(ltv_colaboradores.Items[indice].SubItems[0].Text);
            CPF_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[1].Text;
            cargo_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[2].Text;
            telefone_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[3].Text;
            email_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[4].Text;
            estado_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[5].Text;
            cidade_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[6].Text;
            endereco_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[7].Text;
            bairro_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[8].Text;
            CEP_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[9].Text;
            nome_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[10].Text;
            dataNasc_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[11].Text;
            user_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[12].Text;
            password_Colaborador.Text = ltv_colaboradores.Items[indice].SubItems[13].Text;
            //btnExcluir_Colaborador.Visible = true;*/
            if (ltv_colaboradores.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ltv_colaboradores.SelectedItems[0];

                codigo_Colaborador.Text = selectedItem.SubItems[0].Text;
                CPF_Colaborador.Text = selectedItem.SubItems[1].Text;
                cargo_Colaborador.Text = selectedItem.SubItems[2].Text;
                telefone_Colaborador.Text = selectedItem.SubItems[3].Text;
                email_Colaborador.Text = selectedItem.SubItems[4].Text;
                estado_Colaborador.Text = selectedItem.SubItems[5].Text;
                cidade_Colaborador.Text = selectedItem.SubItems[6].Text;
                endereco_Colaborador.Text = selectedItem.SubItems[7].Text;
                bairro_Colaborador.Text = selectedItem.SubItems[8].Text;
                CEP_Colaborador.Text = selectedItem.SubItems[9].Text;
                nome_Colaborador.Text = selectedItem.SubItems[10].Text;
                dataNasc_Colaborador.Text = selectedItem.SubItems[11].Text;
                user_Colaborador.Text = selectedItem.SubItems[12].Text;
                password_Colaborador.Text = selectedItem.SubItems[13].Text;

            }


        }
    }
}
