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

namespace projeto2023.views.pedidos
{
    public partial class crud_pedidos : Form
    {
        public crud_pedidos()
        {
            InitializeComponent();
        }

        private void btnregistrar_pedido_Click(object sender, EventArgs e)
        {
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
            int ped_disponibilizadocliente = Convert.ToInt32(txb_disponibilizadocliente.Text);
            int ped_totalCamisetas = Convert.ToInt32(txb_totalCamisetas.Text);
            DateTime peddatainicio = new DateTime(2007, 1, 21);
            peddatainicio = mnth_datainicial.SelectionStart;
            DateTime peddataentrega = new DateTime(2007, 1, 21);
            peddataentrega = mnth_datainicial.SelectionStart;
            decimal ped_valorUnit = Convert.ToDecimal(txb_valorUnit.Text);
            decimal ped_totalValor = Convert.ToDecimal(txb_valorTotal.Text);
            decimal ped_totalEntrada = Convert.ToDecimal(txb_valorEntrada.Text);
            decimal ped_totalAberto = Convert.ToDecimal(txb_valorAberto.Text);
            string ped_pagamentoEntrada = cmb_formapagamentoEntrada.Text;
            string ped_pagamentoFinal = cmb_formapagamentoFinal.Text;
            int ped_status = 1;

            MessageBox.Show("FINALIZAR PEDIDO");

            try
            {
                //ligacao no banco de dados
                AddBanco pedidoDAO = new AddBanco();

                if (codigo_Pedido == -1)
                {
                    Pedidos pedido = new Pedidos(cli_codigo, fun_codigo, mate_codigo, ped_gola, ped_corCamiseta, ped_tamanhoP, ped_tamanhoM, ped_tamanhoG, ped_totalCamisetas, estampa_pedido, ped_nomeMaterial, pedDataPedido, ped_valorUnit, ped_totalValor, ped_totalEntrada, pedNomeCliente, ped_status);
                    pedidoDAO.InsertPedidos(pedido);
                }
                else
                {
                    Pedidos pedido = new Pedidos(codigo_Pedido, cli_codigo, fun_codigo, mate_codigo, ped_gola, ped_corCamiseta, ped_tamanhoP, ped_tamanhoM, ped_tamanhoG, ped_totalCamisetas, estampa_pedido, ped_nomeMaterial, pedDataPedido, ped_valorUnit, ped_totalValor, ped_totalEntrada, pedNomeCliente, ped_status);
                    pedidoDAO.UpdatePedidos(pedido);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listaPedidos();
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet10.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidosTableAdapter.Fill(this.estampariadbDataSet10.Pedidos);
            btnClear_Pedidos_Click(null, null);
        }

        private void crud_pedidos_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        #region CARREGAR DADOS CLIENTE E COLABORADOR
        private void CarregarClientes()
        {
    
            string connectionString = "Estampariadb";
            string query = "SELECT codigo_Cliente, nome_Cliente FROM Clientes";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();



                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    int clienteID = (int)reader["ID"];
                    string nomeCliente = (string)reader["Nome"];
                    cmb_idCliente.Items.Add(new Clientes_dados(clienteID, nomeCliente));
                }

                reader.Close();
            }
        }


        private void CarregarColaboradores()
        {
            string connectionString = "Estampariadb";
            string query = "SELECT codigo_Colaborador, nome_Colaborador FROM Colaboradores";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();



                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    int clienteID = (int)reader["ID"];
                    string nomeCliente = (string)reader["Nome"];
                    cmb_idCliente.Items.Add(new Clientes_dados(clienteID, nomeCliente));
                }



                reader.Close();
            }
        }



        private void cmb_idColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_idColaborador.SelectedItem is Colaboradores_dados selectedColaboradores)
            {
                txb_nomeColaborador.Text = selectedColaboradores.Nome_colab;
            }
        }

        private void cmb_idCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_idCliente.SelectedItem is Clientes_dados selectedClientes)
            {
                txb_nomeCliente.Text = selectedClientes.Nome_cli;
            }
        }
        #endregion
    }
}
