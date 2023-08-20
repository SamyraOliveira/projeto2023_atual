using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using projeto2023.models;
using System.Windows.Forms;
using System.Globalization;

namespace projeto2023.controllers
{
     class AddBanco_pedidos
    {

        private Connection Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public AddBanco_pedidos()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }

        #region PEDIDOS

        //INSERIR DADOS DO PEDIDO
        public void InsertPedidos(Pedidos pedido)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Pedidos VALUES (@codigo_Colaborador, @codigo_Cliente, @corCamiseta_Pedido, @tecidoCamiseta_Pedido, @formatoCamiseta_Pedido, @tipoGola_Pedido, @tecnicas_Pedido, @estampa_Pedido, @tamP_quant_Pedido, @tamM_quant_Pedido, @tamG_quant_Pedido, @disponibilizadoCliente, @quantdisponibilizadoCliente, @totalCamisetas_Pedido, @data_inicial, @data_entrega, @valorUnit_Pedido, @valorTotal_Pedido, @valorEntrada_Pedido, @valorAberto_Pedido, @formaPagamentoEntrada_Pedido, @formaPagamentoFinal_Pedido, @status_Pedido )";


            Cmd.Parameters.AddWithValue("@codigo_Colaborador", pedido.colab_codigo);
            Cmd.Parameters.AddWithValue("@codigo_Cliente ", pedido.cli_codigo);
            Cmd.Parameters.AddWithValue("@corCamiseta_Pedido  ", pedido.ped_cor);
            Cmd.Parameters.AddWithValue("@tecidoCamiseta_Pedido  ", pedido.ped_tecido);
            Cmd.Parameters.AddWithValue("@formatoCamiseta_Pedido ", pedido.ped_formato);
            Cmd.Parameters.AddWithValue("@tipoGola_Pedido ", pedido.ped_gola);
            Cmd.Parameters.AddWithValue("@tecnicas_Pedido ", pedido.ped_tecnica);
            Cmd.Parameters.AddWithValue("@estampa_Pedido  ", pedido.ped_estampa);
            Cmd.Parameters.AddWithValue("@tamP_quant_Pedido  ", pedido.ped_tamP);
            Cmd.Parameters.AddWithValue("@tamM_quant_Pedido ", pedido.ped_tamM);
            Cmd.Parameters.AddWithValue("@tamG_quant_Pedido    ", pedido.ped_tamG);
            Cmd.Parameters.AddWithValue("@quantdisponibilizadoCliente  ", pedido.ped_disponibilizadoCli);
            Cmd.Parameters.AddWithValue("@totalCamisetas_Pedido  ", pedido.ped_totalCamisetas);
            Cmd.Parameters.AddWithValue("@data_inicial  ", pedido.ped_Datainicial);
            Cmd.Parameters.AddWithValue("@data_entrega ", pedido.ped_DataEntrega);
            Cmd.Parameters.AddWithValue("@valorUnit_Pedido ", pedido.ped_valorUnitario);
            Cmd.Parameters.AddWithValue("@valorTotal_Pedido  ", pedido.ped_valorTotal);
            Cmd.Parameters.AddWithValue("@valorEntrada_Pedido  ", pedido.ped_valorEntrada);
            Cmd.Parameters.AddWithValue("@valorAberto_Pedido  ", pedido.ped_valorAberto);
            Cmd.Parameters.AddWithValue("@formaPagamentoEntrada_Pedido ", pedido.ped_formaPagamentoEntrada);
            Cmd.Parameters.AddWithValue("@formaPagamentoFinal_Pedido ", pedido.ped_formaPagamentoFinal);
            Cmd.Parameters.AddWithValue("@status_Pedido  ", pedido.ped_status);


            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir o pedido ao banco de dados. \n" + erro.Message);
            }
        }


        //LISTAR PEDIDOS

        public List<Pedidos> ListarPedidos()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Pedidos where status_Pedido = 1";

            List<Pedidos> listaPedidos = new List<Pedidos>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                   /* Pedidos pedido = new Pedidos(
                        (int)rd["codigo_Pedido"],
                        (int)rd["codigo_Cliente"],
                        (int)rd["codigo_Colaborador"],
                        (int)rd["codigo_Material"],
                        (string)rd["tipoGola_Pedido"],
                        (string)rd["corCamiseta_Pedido"],
                        (int)rd["tamP_quant_Pedido"],
                        (int)rd["tamM_quant_Pedido"],
                        (int)rd["tamG_quant_Pedido"],
                        (int)rd["totalCamisetas_Pedido"],
                        (byte[])rd["estampa_Pedido"],
                        (string)rd["nome_Material"],
                        (DateTime)rd["data_Pedido"],
                        (decimal)rd["valorUnit_Pedido"],
                        (decimal)rd["valorTotal_Pedido"],
                        (decimal)rd["valorEntrada_Pedido"],
                        (string)rd["nome_Cliente"],
                        (bool)rd["status_Pedido"]);*/
                   // listaPedidos.Add(pedido);
                }
                rd.Close();
            }
            catch (Exception erro)
            {

                throw new Exception("Erro: problema ao realizar leitura do banco.\n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }

            return listaPedidos;
        }


        // ATUALIZAR DADOS DO PEDIDO

        public void UpdatePedidos(Pedidos pedToBeUpdated)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Pedidos SET  codigo_Colaborador = @colab_codigo, codigo_Cliente = @cli_codigo, corCamiseta_Pedido = @ped_cor, tecidoCamiseta_Pedido = @ped_tecido, formatoCamiseta_Pedido = @ped_formato, tipoGola_Pedido = @ped_gola, tecnicas_Pedido = @ped_tecnica, estampa_Pedido = @ped_estampa, tamP_quant_Pedido = @ped_tamP, tamM_quant_Pedido = @ped_tamM, tamG_quant_Pedido = @ped_tamG, diponibilizadoCliente = @ped_disponibilizadoCli, quantdisponibilizadoCliente = @ped_quantDisponibilizado, totalCamisetas_Pedido = @ped_totalCamisetas, data_inicial = @ped_Datainicial, data_entrega = @ped_DataEntrega, valorUnit_Pedido = @ped_valorUnitario, valorTotal_Pedido = @ped_valorTotal, valorEntrada_Pedido = @ped_valorEntrada, valorAberto_Pedido = @ped_valorAberto, formaPagamentoEntrada_Pedido = @ped_formaPagamentoEntrada, formaPagamentoFinal_Pedido = @ped_formaPagamentoFinal, status_Pedido = @ped_status WHERE codigo_Pedido = @ped_codigo";



            Cmd.Parameters.AddWithValue("@ped_codigo", pedToBeUpdated.ped_codigo);
            Cmd.Parameters.AddWithValue("@colab_codigo", pedToBeUpdated.colab_codigo);
            Cmd.Parameters.AddWithValue("@cli_codigo", pedToBeUpdated.cli_codigo);
            Cmd.Parameters.AddWithValue("@ped_cor", pedToBeUpdated.ped_cor);
            Cmd.Parameters.AddWithValue("@ped_tecido", pedToBeUpdated.ped_tecido);
            Cmd.Parameters.AddWithValue("@ped_formato", pedToBeUpdated.ped_formato);
            Cmd.Parameters.AddWithValue("@ped_gola", pedToBeUpdated.ped_gola);
            Cmd.Parameters.AddWithValue("@ped_tecnica", pedToBeUpdated.ped_tecnica);
            Cmd.Parameters.AddWithValue("@ped_estampa", pedToBeUpdated.ped_estampa);
            Cmd.Parameters.AddWithValue("@ped_tamP", pedToBeUpdated.ped_tamP);
            Cmd.Parameters.AddWithValue("@ped_tamM", pedToBeUpdated.ped_tamM);
            Cmd.Parameters.AddWithValue("@ped_tamG", pedToBeUpdated.ped_tamG);
            Cmd.Parameters.AddWithValue("@ped_disponibilizadoCli", pedToBeUpdated.ped_disponibilizadoCli);
            Cmd.Parameters.AddWithValue("@ped_quantDisponibilizado", pedToBeUpdated.ped_quantDisponibilizado);
            Cmd.Parameters.AddWithValue("@ped_totalCamisetas", pedToBeUpdated.ped_totalCamisetas);
            Cmd.Parameters.AddWithValue("@ped_Datainicial", pedToBeUpdated.ped_Datainicial);
            Cmd.Parameters.AddWithValue("@ped_DataEntrega", pedToBeUpdated.ped_DataEntrega);
            Cmd.Parameters.AddWithValue("@ped_valorUnitario", pedToBeUpdated.ped_valorUnitario);
            Cmd.Parameters.AddWithValue("@ped_valorTotal", pedToBeUpdated.ped_valorTotal);
            Cmd.Parameters.AddWithValue("@ped_valorEntrada", pedToBeUpdated.ped_valorEntrada);
            Cmd.Parameters.AddWithValue("@ped_valorAberto", pedToBeUpdated.ped_valorAberto);
            Cmd.Parameters.AddWithValue("@ped_formaPagamentoEntrada", pedToBeUpdated.ped_formaPagamentoEntrada);
            Cmd.Parameters.AddWithValue("@ped_formaPagamentoFinal", pedToBeUpdated.ped_formaPagamentoFinal);
            Cmd.Parameters.AddWithValue("@ped_status", pedToBeUpdated.ped_status);





            /* Cmd.Parameters.AddWithValue("@codigo_Colaborador", pedido.colab_codigo);
             Cmd.Parameters.AddWithValue("@codigo_Cliente ", pedido.cli_codigo);
             Cmd.Parameters.AddWithValue("@corCamiseta_Pedido  ", pedido.ped_cor);
             Cmd.Parameters.AddWithValue("@tecidoCamiseta_Pedido  ", pedido.ped_tecido);
             Cmd.Parameters.AddWithValue("@formatoCamiseta_Pedido ", pedido.ped_formato);
             Cmd.Parameters.AddWithValue("@tipoGola_Pedido ", pedido.ped_gola);
             Cmd.Parameters.AddWithValue("@tecnicas_Pedido ", pedido.ped_tecnica);
             Cmd.Parameters.AddWithValue("@estampa_Pedido  ", pedido.ped_estampa);
             Cmd.Parameters.AddWithValue("@tamP_quant_Pedido  ", pedido.ped_tamP);
             Cmd.Parameters.AddWithValue("@tamM_quant_Pedido ", pedido.ped_tamM);
             Cmd.Parameters.AddWithValue("@tamG_quant_Pedido    ", pedido.ped_tamG);
             Cmd.Parameters.AddWithValue("@quantdisponibilizadoCliente  ", pedido.ped_disponibilizadoCli);
             Cmd.Parameters.AddWithValue("@totalCamisetas_Pedido  ", pedido.ped_totalCamisetas);
             Cmd.Parameters.AddWithValue("@data_inicial  ", pedido.ped_Datainicial);
             Cmd.Parameters.AddWithValue("@data_entrega ", pedido.ped_DataEntrega);
             Cmd.Parameters.AddWithValue("@valorUnit_Pedido ", pedido.ped_valorUnitario);
             Cmd.Parameters.AddWithValue("@valorTotal_Pedido  ", pedido.ped_valorTotal);
             Cmd.Parameters.AddWithValue("@valorEntrada_Pedido  ", pedido.ped_valorEntrada);
             Cmd.Parameters.AddWithValue("@valorAberto_Pedido  ", pedido.ped_valorAberto);
             Cmd.Parameters.AddWithValue("@formaPagamentoEntrada_Pedido ", pedido.ped_formaPagamentoEntrada);
             Cmd.Parameters.AddWithValue("@formaPagamentoFinal_Pedido ", pedido.ped_formaPagamentoFinal);
             Cmd.Parameters.AddWithValue("@status_Pedido  ", pedido.ped_status);*/


            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao atualizar o banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }


        // EXCLUIR PEDIDO
        public void DeletePedidos(int pedidoCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Pedidos SET  status_Pedido = 0 WHERE codigo_Pedido = @ped_codigo";
            Cmd.Parameters.AddWithValue("@ped_codigo", pedidoCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir pedido do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }

        //PUXAR ESTAMPA DO BANCO DE DADOS

        public byte[] ListarImagem(int pedidoCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT estampa_Pedido FROM Pedidos WHERE status_Pedido = 1";
            Cmd.Parameters.AddWithValue("@codigo_Pedido", pedidoCod);
            SqlDataReader rd = Cmd.ExecuteReader();

            byte[] image = null;
            while (rd.Read())
            {
                image = (byte[])rd["estampa_Pedido"];
            }
            rd.Close();
            return image;
        }



        #endregion


    }
}
