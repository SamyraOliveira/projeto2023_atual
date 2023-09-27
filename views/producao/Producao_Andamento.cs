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
using Connection = projeto2023.controllers.Connection;

namespace projeto2023.views.producao
{
    public partial class Producao_Andamento : Form
    {
        private int idLinha;
        private SqlConnection connection;

        public Producao_Andamento(int idLinha)
        {
            InitializeComponent();
            this.idLinha = idLinha;

            PreencherDadosDaProducao();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Producao_Andamento_Load(object sender, EventArgs e)
        {

        }


        private void PreencherDadosDaProducao()
        {


            // Implemente a lógica para consultar os dados da produção com base em this.idLinha
            // Substitua o exemplo abaixo pela sua lógica de consulta real

            //string outrosDadosProducao = ConsultarOutrosDadosProducao(this.idLinha);

            // Preencha os controles no formulário com os dados obtidos na consulta

            //txb_ID.Text = outrosDadosProducao;
            // Continue preenchendo outros controles conforme necessário

            //string outrosDadosProducao = ConsultarOutrosDadosProducao(this.idLinha);
            DadosProducao outrosDadosProducao = ConsultarOutrosDadosProducao(this.idLinha);

            // Preencha os controles no formulário com os dados obtidos na consulta
            if (outrosDadosProducao != null)
            {
                txb_ID.Text = outrosDadosProducao.ID_Linha.ToString();
                txb_ID_Produto.Text = outrosDadosProducao.ID_Produto.ToString();
                txb_Quantidade_P.Text = outrosDadosProducao.Quantidade_P.ToString();
                txb_Quantidade_M.Text = outrosDadosProducao.Quantidade_M.ToString();
                txb_Quantidade_G.Text = outrosDadosProducao.Quantidade_G.ToString();
                txb_Tecnicas.Text = outrosDadosProducao.Tecnicas;
                txb_Tecido.Text = outrosDadosProducao.Tecido;
                txb_Tipo_Gola.Text = outrosDadosProducao.Tipo_Gola;
                txb_Formato.Text = outrosDadosProducao.Formato;
                txb_Data_Entrega.Text = outrosDadosProducao.Data_Entrega.ToString("dd/MM/yyyy");
                txb_Cor.Text = outrosDadosProducao.COR;

                DateTime dataAtual = DateTime.Now;
                DateTime dataEntrega = outrosDadosProducao.Data_Entrega;

                // Calcule o número de dias restantes
                TimeSpan diferenca = dataEntrega - dataAtual;
                int diasRestantes = diferenca.Days;

                int quantidadeP = int.Parse(txb_Quantidade_P.Text);
                int quantidadeM = int.Parse(txb_Quantidade_M.Text);
                int quantidadeG = int.Parse(txb_Quantidade_G.Text);

                // Calcule a soma das quantidades
                int somaTotal = quantidadeP + quantidadeM + quantidadeG;

                // Atualize o txb_total_pçs com o resultado da soma
                txb_total_pçs.Text = somaTotal.ToString();

                // Preencha o txb_dias_restante com o número de dias restantes
                txb_dias_restante.Text = diasRestantes.ToString();



            }
            else
            {
                // Lidere com o caso em que os dados não foram encontrados
                MessageBox.Show("Dados de produção não encontrados.");
            }




        }
        public DadosProducao ConsultarOutrosDadosProducao(int idLinha)
        {
            DadosProducao dadosProducao = null;
            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            // Implemente a lógica para consultar os dados da produção com base no ID_Linha
            // Substitua o exemplo fictício abaixo pela consulta real do seu banco de dados
            string query = "SELECT ID_Linha, ID_Produto, Quantidade_P, Quantidade_M, Quantidade_G, COR, Tecnicas, Tecido, Tipo_Gola, Formato, Data_Entrega FROM PRODUCOES WHERE ID_Linha = @ID_Linha";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Linha", idLinha);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Preencha o objeto DadosProducao com os dados da consulta
                    dadosProducao = new DadosProducao
                    {
                        ID_Linha = (int)reader["ID_Linha"],
                        ID_Produto = (int)reader["ID_Produto"],
                        Quantidade_P = (int)reader["Quantidade_P"],
                        Quantidade_M = (int)reader["Quantidade_M"],
                        Quantidade_G = (int)reader["Quantidade_G"],
                        COR = reader["COR"].ToString(),
                        Tecnicas = reader["Tecnicas"].ToString(),
                        Tecido = reader["Tecido"].ToString(),
                        Tipo_Gola = reader["Tipo_Gola"].ToString(),
                        Formato = reader["Formato"].ToString(),
                        Data_Entrega = (DateTime)reader["Data_Entrega"]

                    };
                }

                reader.Close();
            }

            return dadosProducao;
        }

        private void txb_ID_Produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Cor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_total_pçs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Quantidade_G_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Quantidade_M_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Quantidade_P_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Tecnicas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Tecido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Tipo_Gola_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Formato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_dias_restante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Data_Entrega_TextChanged(object sender, EventArgs e)
        {

        }
    }














    /*



    string sql1 = "SELECT Quantidade_P FROM PRODUCOES WHERE ID_Linha = @Id_Linha;";
    using (SqlCommand command = new SqlCommand(sql1, connection))
    {
        command.Parameters.AddWithValue("@Id_Linha", idLinha);


        try
        {
            object resultado = command.ExecuteScalar();

            // Verifique se o resultado não é nulo antes de definir o texto
            if (resultado != null)
            {
                txbStatus.Text = resultado.ToString();
            }

        }
        catch (Exception erro)
        {
            throw new Exception("Erro problemas ao atualizar o banco de dados. \n" + erro.Message);
        }
        return "em andamento";
    }
    */
}

            // Restante do código do formulário
        

    