using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using projeto2023.controllers;
using projeto2023.models;
using projeto2023.views.colaboradores;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace projeto2023.views.producao
{
    public partial class crud_producao : Form
    {
        public crud_producao()
        {
            InitializeComponent();
        }

        private void crud_producao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidosTableAdapter1.Fill(this.estampariadbDataSet1.Pedidos);
            pedidosBindingSource3.Filter = "status_Pedido = 'Em aberto'";


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pedidosTableAdapter.FillBy(this.estampariadbDataSet.Pedidos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pedidosTableAdapter1.FillBy2(this.estampariadbDataSet1.Pedidos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        /*
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvPedidosProdução.Rows[e.RowIndex];

                // Preencha os TextBox com os valores da linha selecionada
                txtCod.Text = row.Cells["cod"].Value.ToString();
                txtCor.Text = row.Cells["COR"].Value.ToString();
                txtQuantidadeP.Text = row.Cells["quantidade_p"].Value.ToString();
                txtQuantidadeM.Text = row.Cells["quantidade_m"].Value.ToString();
                txtQuantidadeG.Text = row.Cells["quantidade_g"].Value.ToString();
                txtTotalPedido.Text = row.Cells["total_pedido"].Value.ToString();
                txtEntrega.Text = row.Cells["entrega"].Value.ToString();
                txtStatus.Text = row.Cells["status"].Value.ToString();
            }
        }
        */

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dvPedidosProdução_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvPedidosProdução.Rows[e.RowIndex];
                


                // Preencha os TextBox com os valores da linha selecionada
                txb_idpedido.Text = row.Cells["codigo_Pedido"].Value.ToString();
                txb_responsavel.Text = row.Cells["codigo_Colaborador"].Value.ToString();
                txb_cor.Text = row.Cells["cor"].Value.ToString();
                txb_qp.Text = row.Cells["quantidade_p"].Value.ToString();
                txb_qm.Text = row.Cells["quantidade_m"].Value.ToString();
                txb_qg.Text = row.Cells["quantidade_g"].Value.ToString();
                txb_tecido.Text = row.Cells["tecido"].Value.ToString();
                txb_formato.Text = row.Cells["formato"].Value.ToString();
                txb_gola.Text = row.Cells["gola"].Value.ToString();
                txb_tecnica.Text = row.Cells["tecnicas"].Value.ToString();
                txb_caminho.Text = row.Cells["estampa_Pedido"].Value.ToString();
                txb_estrega.Text = row.Cells["data_entrega"].Value.ToString();
                // DateTime Data_Entrega = 

                btn_iniciar.Visible = true;
                btn_limpar.Visible = true;


                // Substitua pelo caminho real da sua imagem


            }
            string connectionString = @"Data Source=" + Environment.MachineName + ";Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT Nome_Colaborador FROM Colaboradores WHERE codigo_Colaborador = @ID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", txb_responsavel.Text);

                    try
                    {
                        object resultado = command.ExecuteScalar();

                        // Verifique se o resultado não é nulo antes de definir o texto
                        if (resultado != null)
                        {
                            txb_responsavel.Text = resultado.ToString();
                        }

                    }
                    catch (Exception erro)
                    {
                        throw new Exception("Erro problemas ao atualizar o banco de dados. \n" + erro.Message);
                    }
                }
                string sql1 = "SELECT estampa_Pedido FROM Pedidos WHERE codigo_Pedido = @codigo_Pedido;";
                using (SqlCommand command = new SqlCommand(sql1, connection))
                {
                    command.Parameters.AddWithValue("@codigo_Pedido", txb_idpedido.Text);

                    try
                    {
                        object resultado = command.ExecuteScalar();

                        // Verifique se o resultado não é nulo antes de definir o texto
                        if (resultado != null)
                        {
                            txb_caminho.Text = resultado.ToString();
                            pcb_estampa.ImageLocation = resultado.ToString();
                        }

                    }
                    catch (Exception erro)
                    {
                        throw new Exception("Erro problemas ao atualizar o banco de dados. \n" + erro.Message);
                    }
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_idpedido.Clear();
            txb_responsavel.Clear();
            txb_cor.Clear();
            txb_qp.Clear();
            txb_qm.Clear();
            txb_qg.Clear();
            txb_tecido.Clear();
            txb_formato.Clear();
            txb_gola.Clear();
            txb_tecnica.Clear();
            txb_caminho.Clear();
            txb_estrega.Clear();
            txb_caminho.Clear();
            pcb_estampa.ImageLocation = null;

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {


            int codigo_linha = -1;
            int codigo_produto = Convert.ToInt32(txb_idpedido.Text); 
            int quantidade_P = Convert.ToInt32(txb_qp.Text); 
            int quantidade_M = Convert.ToInt32(txb_qp.Text);
            int quantidade_G = Convert.ToInt32(txb_qp.Text);
            string cor = txb_cor.Text;
            string tecido = txb_tecido.Text;
            string formato = txb_formato.Text;
            string gola = txb_gola.Text;
            string tecnicas = txb_tecnica.Text;

            string inputTextentrega = txb_estrega.Text;
            DateTime Data_Entrega = DateTime.Parse(inputTextentrega);

            string estampa = pcb_estampa.ImageLocation;
            int status = 1;

            try
            {
                //ligacao no banco de dados
                AddBanco producaoDAO = new AddBanco();

                if (codigo_linha == -1)
                {
                    //data de entrega tem que ser verificada antes de efetuar o pedido
                    if (Data_Entrega == null)
                    {
                        MessageBox.Show("PARA FINALIZAR, INSIRA UMA DATA DE ENTREGA");
                    }

                    else
                    {
                        Producao pedido = new Producao(codigo_produto, quantidade_P, quantidade_M, quantidade_G, cor, tecido, formato, gola, tecnicas, Data_Entrega, status);
                        producaoDAO.InsertProducao(pedido);
                        
                    }

                }
                
                string connectionString = @"Data Source="+Environment.MachineName+";Initial Catalog=Estampariadb;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql1 = "UPDATE Pedidos SET status_Pedido = 'Em Andamento' WHERE codigo_Pedido = @codigo_Pedido;";
                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        command.Parameters.AddWithValue("@codigo_Pedido", txb_idpedido.Text);

                        try
                        {
                            object resultado = command.ExecuteScalar();
                            dvPedidosProdução.Refresh();


                        }
                        catch (Exception erro)
                        {
                            throw new Exception("Erro problemas ao atualizar o banco de dados. \n" + erro.Message);
                        }
                    }

                    connection.Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //listaPedidos();
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet10.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            // this.pedidosTableAdapter.Fill(this.estampariadbDataSet10.Pedidos);
            btn_limpar_Click(null, null);
            btn_iniciar.Visible = false;
            btn_limpar.Visible = false;
            this.Close();

            MessageBox.Show("Produção em andamento");
            Atualizar_dados_Click(null, null);

        }
        private void abrir_from(object sender, EventArgs e)
        {
            crud_producao frm = new crud_producao();
            frm.ShowDialog();

        }

        private void Atualizar_dados_Click(object sender, EventArgs e)
        {
            this.Close();
            abrir_from(null,null);


        }

        private void label4_Click(object sender, EventArgs e)
        {
            ListarProducoes Frm = new ListarProducoes();
            Frm.ShowDialog();
        }
    }
}
