
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using projeto2023.models;
using System.Collections.Generic;

namespace projeto2023.controllers
{
    class ListaUsuario
    {

        private Connection Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public ListaUsuario()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        internal void LerUsuarios(ListView listView1)
        {

            try
            {
                Cmd.Connection = Con.RetornarConexao();
                Cmd.CommandText = "SELECT * FROM Colaboradores where status_Colaborador = 1";

                List<Colaboradores> listaColaboradores = new List<Colaboradores>();
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        Colaboradores Colaborador = new Colaboradores((int)rd["codigo_Colaborador"], (string)rd["CPF_Colaborador"], (string)rd["cargo_Colaborador"], (string)rd["telefone_Colaborador"], (string)rd["email_Colaborador"], (string)rd["estado_Colaborador"], (string)rd["cidade_Colaborador"], (string)rd["endereco_Colaborador"], (string)rd["bairro_Colaborador"], (string)rd["CEP_Colaborador"], (string)rd["nome_Colaborador"], (DateTime)rd["dataNasc_Colaborador"], (string)rd["user_Colaborador"], (string)rd["password_Colaborador"], (int)rd["status_Colaborador"]);
                        //listaColaboradores.Add(Colaborador);

                        ListViewItem dados_colab = new ListViewItem();
                        dados_colab.SubItems.Add(Colaborador.colab_nome);
                        dados_colab.SubItems.Add(Colaborador.colab_CPF);

                        listView1.Items.Add(dados_colab);
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

                ListViewItem item = new ListViewItem();
                //item.SubItems.Add(nome);
                //item.SubItems.Add(setor);

                listView1.Items.Add(item);


                /* while (reader.Read())
                 {
                     string id = reader["id"].ToString();
                     string nome = reader["nome"].ToString();
                     string setor = reader["id_setor"].ToString();

                     ListViewItem item = new ListViewItem(id);
                     item.SubItems.Add(nome);
                     item.SubItems.Add(setor);

                     listView1.Items.Add(item);
                 }
                */
            }
            catch(Exception erro) { throw new Exception(erro.Message); }
        }

        internal class ListaDeUsuarios
        {
        }
    }
}


   

