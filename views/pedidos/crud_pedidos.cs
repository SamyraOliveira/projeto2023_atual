using projeto2023.controllers;
using projeto2023.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;




namespace projeto2023.views.pedidos
{

    public partial class crud_pedidos : Form
    {


        public int codigo_Pedido = -1;
        string ped_estampa;
        int P = 0, M = 0, G = 0, totalC = 0;
        decimal unitario, totalPedido = 0, entrada = 0;

        List<Colaboradores_dados> colaboradores = new List<Colaboradores_dados>();
        List<Clientes_dados> clientes = new List<Clientes_dados>();



        public crud_pedidos()
        {
            InitializeComponent();
        }

        private void btnregistrar_pedido_Click(object sender, EventArgs e)
        {
            int cod_colab = cmb_idColaborador.SelectedIndex;
            string nome_colab = txb_nomeColaborador.Text;
            int cod_cli = cmb_idCliente.SelectedIndex;
            string nome_cli = txb_nomeCliente.Text;
            string ped_cor = cmb_cores.Text;
            string ped_tecido = cmb_tecido.Text;
            string ped_formato = cmb_formato.Text;
            string ped_gola = cmb_gola.Text;
            string ped_tecnica = cmb_tecnica.Text;
            //armazenar a imagem
            FileStream estampa = new FileStream(ped_estampa, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(estampa);
            byte[] estampa_pedido = reader.ReadBytes((int)estampa.Length);
            estampa.Close();
            reader.Close();
            int ped_tamanhoP = Convert.ToInt32(txb_tamP.Text);
            int ped_tamanhoM = Convert.ToInt32(txb_tamM.Text);
            int ped_tamanhoG = Convert.ToInt32(txb_tamG.Text);
            int ped_disponibilizadocliente;
            if (check_disponibilizadocliente.Checked)
            {
                ped_disponibilizadocliente = 1;
            }
            else
            {
                ped_disponibilizadocliente = 0;
            }
            int ped_quantdisponibilizadocliente = Convert.ToInt32(txb_disponibilizadocliente.Text);
            int ped_totalCamisetas = Convert.ToInt32(txb_totalCamisetas.Text);
            DateTime peddatainicio = new DateTime(2007, 1, 21);
            peddatainicio = mnth_datainicial.SelectionStart;
            DateTime peddataentrega = new DateTime(2007, 1, 21);
            peddataentrega = mnth_dataentrega.SelectionStart;
            decimal ped_valorUnit = Convert.ToDecimal(txb_valorUnit.Text);
            decimal ped_totalValor = Convert.ToDecimal(txb_valorTotal.Text);
            decimal ped_totalEntrada = Convert.ToDecimal(txb_valorEntrada.Text);
            decimal ped_totalAberto = Convert.ToDecimal(txb_valorAberto.Text);
            string ped_pagamentoEntrada = cmb_formapagamentoEntrada.Text;
            string ped_pagamentoFinal = cmb_formapagamentoFinal.Text;
            string ped_status = " ";

            MessageBox.Show("FINALIZAR PEDIDO");

            try
            {
                //ligacao no banco de dados
                AddBanco_pedidos pedidoDAO = new AddBanco_pedidos();

                if (codigo_Pedido == -1)
                {
                    //data de entrega tem que ser verificada antes de efetuar o pedido
                    if (mnth_dataentrega == null)
                    {
                        MessageBox.Show("PARA FINALIZAR, INSIRA UMA DATA DE ENTREGA");
                    }

                    else
                    {
                        Pedidos pedido = new Pedidos(cod_colab, cod_cli, ped_cor, ped_tecido, ped_formato, ped_gola, ped_tecnica, estampa_pedido, ped_tamanhoP, ped_tamanhoM, ped_tamanhoG, ped_disponibilizadocliente, ped_quantdisponibilizadocliente, ped_totalCamisetas, peddatainicio, peddataentrega, ped_valorUnit, ped_totalValor, ped_totalEntrada, ped_totalAberto, ped_pagamentoEntrada, ped_pagamentoFinal, ped_status);
                        pedidoDAO.InsertPedidos(pedido);
                    }
                    
                }

                else
                {
                    Pedidos pedido = new Pedidos(codigo_Pedido, cod_colab, cod_cli, ped_cor, ped_tecido, ped_formato, ped_gola, ped_tecnica, estampa_pedido, ped_tamanhoP, ped_tamanhoM, ped_tamanhoG, ped_disponibilizadocliente, ped_quantdisponibilizadocliente, ped_totalCamisetas, peddatainicio, peddataentrega, ped_valorUnit, ped_totalValor, ped_totalEntrada, ped_totalAberto, ped_pagamentoEntrada, ped_pagamentoFinal, ped_status);
                    pedidoDAO.UpdatePedidos(pedido);
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
        }

        private void crud_pedidos_Load(object sender, EventArgs e)
        {
            CarregarColaboradores();

            CarregarClientes();

            string[] coresCamisetas = {
            "Branco", "Preto", "Cinza", "Azul", "Vermelho", "Rosa", "Roxo", "Laranja"
            };
            cmb_cores.Items.AddRange(coresCamisetas);


            string[] tecnicasEstamparia = {
            "Sublimação", "Transfer", "Bordado"
            };
            cmb_tecnica.Items.AddRange(tecnicasEstamparia);

            string[] tiposTecido = {
            "Algodão", "Poliéster", "Algodão-Poliéster"
            };
            cmb_tecido.Items.AddRange(tiposTecido);

            string[] formatosCamisetas = {
            "Regular", "Slim Fit", "Oversized", "Crop Top", "Regata", "Manga Longa", "Manga 3/4"
            };
            cmb_formato.Items.AddRange(formatosCamisetas);

            string[] tiposGolaCamisetas = {
            "Gola Redonda", "Gola V", "Gola Polo", "Gola Henley", "Gola Careca", "Gola Canoa"
            };
            cmb_gola.Items.AddRange(tiposGolaCamisetas);

            string[] formasPagamento = {
            "Dinheiro", "Cartão de Crédito", "Cartão de Débito", "Pix", "Transferência Bancária", "Boleto Bancário"
            };
            cmb_formapagamentoEntrada.Items.AddRange(formasPagamento);
            cmb_formapagamentoFinal.Items.AddRange(formasPagamento);


        }

        private void pctb_estampa_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (OFD_estamparia.ShowDialog() == DialogResult.OK)
                {
                    ped_estampa = OFD_estamparia.FileName;
                    if (pctb_estampa.Image != null)
                        pctb_estampa.Image.Dispose();
                    pctb_estampa.Image = Image.FromFile(ped_estampa);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            AddBanco_pedidos pedidosDAO = new AddBanco_pedidos();

            try
            {
                pedidosDAO.DeletePedidos(codigo_Pedido);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Update();
            //listaPedidos();
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet10.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            //this.pedidosTableAdapter.Fill(this.estampariadbDataSet10.Pedidos);
            btn_limpar_Click(null, null);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_nomeColaborador_TextChanged(object sender, EventArgs e)
        {

        }

        #region CARREGAR DADOS CLIENTE E COLABORADOR

         private void CarregarColaboradores()
         {

            string query = "SELECT codigo_Colaborador, nome_Colaborador FROM Colaboradores WHERE cargo_Colaborador = 'Atendente'";

             using (Connection connection = new Connection())
             {
                 SqlCommand command = new SqlCommand(query, connection.RetornarConexao());
                 SqlDataReader reader = command.ExecuteReader();

                 List<string> nomesColaboradores = new List<string>();

                 while (reader.Read())
                 {
                     int colabID = (int)reader["codigo_Colaborador"];
                     string nomeColab = (string)reader["nome_Colaborador"];
                     nomesColaboradores.Add($"{colabID}"/*- {nomeColab}"*/);
                }

                 cmb_idColaborador.DataSource = nomesColaboradores;

                 reader.Close();
             }
         }


        private void CarregarClientes()
        {
            string query = "SELECT codigo_Cliente, nome_Cliente FROM Clientes";

            using (Connection connection = new Connection())
            {
                SqlCommand command = new SqlCommand(query, connection.RetornarConexao());
                SqlDataReader reader = command.ExecuteReader();

                List<string> nomesClientes = new List<string>();

                while (reader.Read())
                {
                    int clienteID = (int)reader["codigo_Cliente"];
                   
                    nomesClientes.Add($"{clienteID}"/*- {nomesClientes}"*/);
                }

                cmb_idCliente.DataSource = nomesClientes;

                reader.Close();
            }
        }

        #endregion

        private void cmb_idColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_idColaborador.SelectedItem is int selectedColaboradorID)
            {
                Colaboradores_dados selectedColaborador = null;
                foreach (Colaboradores_dados colab in colaboradores)
                {
                    if (colab.id_Colab == selectedColaboradorID)
                    {
                        selectedColaborador = colab;
                        break;
                    }
                }

                if (selectedColaborador != null)
                {
                    txb_nomeColaborador.Text = selectedColaborador.nome_Colab;
                }
            }
        }

        private void cmb_idCliente_SelectedIndexChanged(object sender, EventArgs e)
        {


             if (cmb_idCliente.SelectedItem is int selectedClienteID)
             {
                 Clientes_dados selectedCliente = null;
                 foreach (Clientes_dados cli in clientes)
                 {
                     if (cli.id_Cli == selectedClienteID)
                     {
                         selectedCliente = cli;
                         break;
                     }
                 }

                 if (selectedCliente != null)
                 {
                     txb_nomeCliente.Text = selectedCliente.nome_Cli;
                 }
             }

        }


        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cmb_idColaborador.SelectedIndex = -1;
            txb_nomeColaborador.Clear();
            cmb_idCliente.SelectedIndex = -1;
            txb_nomeCliente.Clear();
            cmb_cores.SelectedIndex = -1;
            cmb_tecido.SelectedIndex = -1;
            cmb_formato.SelectedIndex = -1;
            cmb_gola.SelectedIndex = -1;
            cmb_tecnica.SelectedIndex = -1;
            txb_tamP.Clear();
            txb_tamM.Clear();
            txb_tamG.Clear();
            txb_disponibilizadocliente.Clear();
            txb_totalCamisetas.Clear();
            txb_valorUnit.Clear();
            txb_valorTotal.Clear();
            txb_valorEntrada.Clear();
            txb_valorAberto.Clear();
            cmb_formapagamentoEntrada.SelectedIndex = -1;
            cmb_formapagamentoFinal.SelectedIndex = -1;


        }
    }
}
