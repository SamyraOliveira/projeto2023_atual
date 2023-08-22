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

        private void frm_consultas_Load(object sender, EventArgs e)
        {
            

            //COLABORADOR
            try 
            { 
                ltv_pedidos.Items.Clear();
                AddBanco colaboradorDAO = new AddBanco();

                List<Colaboradores> colaborador = colaboradorDAO.ListarColaboradores();
                if (colaborador.Count > 0)
                {
                    foreach (var colab in colaborador)
                    {
                        ListViewItem ltv = new ListViewItem(colab.colab_codigo.ToString());
                        ltv.SubItems.Add(colab.colab_CPF);
                        ltv.SubItems.Add(colab.colab_cargo);
                        ltv.SubItems.Add(colab.colab_telefone);
                        ltv.SubItems.Add(colab.colab_email);
                        ltv.SubItems.Add(colab.colab_estado);
                        ltv.SubItems.Add(colab.colab_cidade);
                        ltv.SubItems.Add(colab.colab_endereco);
                        ltv.SubItems.Add(colab.colab_bairro);
                        ltv.SubItems.Add(colab.colab_CEP);
                        ltv.SubItems.Add(colab.colab_nome);
                        ltv.SubItems.Add(colab.colab_dataNasc.ToLongDateString());
                        ltv.SubItems.Add(colab.colab_usuario);
                        ltv.SubItems.Add(colab.colab_senha);
                        ltv.SubItems.Add(colab.colab_status.ToString());
                        ltv_pedidos.Items.Add(ltv);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



             ltv_pedidos.Items.Clear();
              AddBanco_pedidos PedidoDAO = new AddBanco_pedidos();

              List<Pedidos> Pedido = PedidoDAO.ListarPedidos();
              if (Pedido.Count > 0)
              {
                  foreach (var ped in Pedido)
                  {
                      ListViewItem ltv = new ListViewItem(ped.ped_codigo.ToString());
                      ltv.SubItems.Add(ped.colab_codigo.ToString());
                      ltv.SubItems.Add(ped.cli_codigo.ToString());
                      ltv.SubItems.Add(ped.ped_cor);
                      ltv.SubItems.Add(ped.ped_tecido);
                      ltv.SubItems.Add(ped.ped_formato);
                      ltv.SubItems.Add(ped.ped_gola);
                      ltv.SubItems.Add(ped.ped_tecnica);
                      ltv.SubItems.Add(ped.ped_estampa.ToString());
                      ltv.SubItems.Add(ped.ped_tamP.ToString());
                      ltv.SubItems.Add(ped.ped_tamM.ToString());
                      ltv.SubItems.Add(ped.ped_tamG.ToString());
                      ltv.SubItems.Add(ped.ped_disponibilizadoCli.ToString());
                      ltv.SubItems.Add(ped.ped_quantDisponibilizado.ToString());
                      ltv.SubItems.Add(ped.ped_totalCamisetas.ToString());
                      ltv.SubItems.Add(ped.ped_Datainicial.ToString());
                      ltv.SubItems.Add(ped.ped_DataEntrega.ToString());
                      ltv.SubItems.Add(ped.ped_valorUnitario.ToString());
                      ltv.SubItems.Add(ped.ped_valorTotal.ToString());
                      ltv.SubItems.Add(ped.ped_valorEntrada.ToString());
                      ltv.SubItems.Add(ped.ped_valorAberto.ToString());
                      ltv.SubItems.Add(ped.ped_formaPagamentoEntrada);
                      ltv.SubItems.Add(ped.ped_formaPagamentoFinal);
                      ltv.SubItems.Add(ped.ped_status.ToString());
                      ltv_pedidos.Items.Add(ltv);
                  }
              }
        }


        #region list views


        private void ltv_pedidos_MouseClick(object sender, MouseEventArgs e)
        {
            int indice = ltv_pedidos.FocusedItem.Index;
            codigo_Pedido.Text = ltv_pedidos.Items[indice].SubItems[0].Text;
            codigo_Colaborador.Text = ltv_pedidos.Items[indice].SubItems[1].Text;
            codigo_Cliente.Text = ltv_pedidos.Items[indice].SubItems[2].Text;
            corCamiseta_Pedido.Text = ltv_pedidos.Items[indice].SubItems[3].Text;
            tecidoCamiseta_Pedido.Text = ltv_pedidos.Items[indice].SubItems[4].Text;
            formatoCamiseta_Pedido.Text = ltv_pedidos.Items[indice].SubItems[5].Text;
            tipoGola_Pedido.Text = ltv_pedidos.Items[indice].SubItems[6].Text;
            tecnicas_Pedido.Text = ltv_pedidos.Items[indice].SubItems[7].Text;
            estampa_Pedido.Text = ltv_pedidos.Items[indice].SubItems[8].Text;
            tamP_quant_Pedido.Text = ltv_pedidos.Items[indice].SubItems[9].Text;
            tamM_quant_Pedido.Text = ltv_pedidos.Items[indice].SubItems[10].Text;
            tamG_quant_Pedido.Text = ltv_pedidos.Items[indice].SubItems[11].Text;
            disponibilizadoCliente.Text = ltv_pedidos.Items[indice].SubItems[12].Text;
            quantdisponibilizadoCliente.Text = ltv_pedidos.Items[indice].SubItems[13].Text;
            totalCamisetas_Pedido.Text = ltv_pedidos.Items[indice].SubItems[14].Text;
            data_inicial.Text = ltv_pedidos.Items[indice].SubItems[15].Text;
            data_entrega.Text = ltv_pedidos.Items[indice].SubItems[16].Text;
            valorUnit_Pedido.Text = ltv_pedidos.Items[indice].SubItems[17].Text;
            valorTotal_Pedido.Text = ltv_pedidos.Items[indice].SubItems[18].Text;
            valorEntrada_Pedido.Text = ltv_pedidos.Items[indice].SubItems[19].Text;
            valorAberto_Pedido.Text = ltv_pedidos.Items[indice].SubItems[20].Text;
            formaPagamentoEntrada_Pedido.Text = ltv_pedidos.Items[indice].SubItems[21].Text;
            formaPagamentoFinal_Pedido.Text = ltv_pedidos.Items[indice].SubItems[22].Text;
            status_Pedido.Text = ltv_pedidos.Items[indice].SubItems[23].Text;
        }

        #endregion


        #region click panel
        private void colaboradores_Click(object sender, EventArgs e)
        {
            ltv_pedidos.Visible = false;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_colaboradores.Visible = true;
        }

        private void fornecedores_Click(object sender, EventArgs e)
        {
            ltv_pedidos.Visible = false;
            ltv_fornecedores.Visible = true;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_colaboradores.Visible = false;
        }

        private void materiais_Click(object sender, EventArgs e)
        {
            ltv_pedidos.Visible = false;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = true;
            ltv_clientes.Visible = false;
            ltv_colaboradores.Visible = false;
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            ltv_pedidos.Visible = false;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = true;
            ltv_colaboradores.Visible = false;
        }

        private void pedidos_Click(object sender, EventArgs e)
        {
            ltv_pedidos.Visible = true;
            ltv_fornecedores.Visible = false;
            ltv_materiais.Visible = false;
            ltv_clientes.Visible = false;
            ltv_colaboradores.Visible = false;
        }


        #endregion
    }
}