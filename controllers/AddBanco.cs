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
using projeto2023.views.colaboradores;
using projeto2023.views.producao;

namespace projeto2023.controllers
{
    class AddBanco
    {
       
        private Connection Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public AddBanco()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }

        #region LOGIN 

                //SUPERVISOR

                public bool validarloginSupervisor( Colaboradores colab)
                {
                    Cmd.Connection = Con.RetornarConexao();
                    Cmd.CommandText = @"SELECT * FROM Colaboradores WHERE user_Colaborador = @user_Colaborador AND password_Colaborador = @password_Colaborador";
                    Cmd.Parameters.AddWithValue("@user_Colaborador", colab.colab_usuario);
                    Cmd.Parameters.AddWithValue("@password_Colaborador", colab.colab_senha);
                    try
                    {
                        SqlDataReader rd = Cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            rd.Close();
                            return true;
                        }
                    }
                    catch (Exception erro)
                    {
                        throw new Exception("ERRO: erro de login.\n" + erro.Message);
                    }
                    finally
                    {
                        Con.FecharConexao();
                    }
                    return false;
                }


                //ATENDENTE

                public bool validarloginAtendente(Colaboradores colab)
                {
                    Cmd.Connection = Con.RetornarConexao();
                    Cmd.CommandText = @"SELECT * FROM Colaboradores WHERE user_Colaborador = @user_Colaborador AND password_Colaborador = @password_Colaborador";
                    Cmd.Parameters.AddWithValue("@user_Colaborador", colab.colab_usuario);
                    Cmd.Parameters.AddWithValue("@password_Colaborador", colab.colab_senha);
            try
                    {
                        SqlDataReader rd = Cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            rd.Close();
                            return true;
                        }
                    }
                    catch (Exception erro)
                    {
                        throw new Exception("ERRO: erro de login.\n" + erro.Message);
                    }
                    finally
                    {
                        Con.FecharConexao();
                    }
                    return false;
                }

                
                //OPERADOR

                public bool validarloginOperador(Colaboradores colab)
                {
                    Cmd.Connection = Con.RetornarConexao();
                    Cmd.CommandText = @"SELECT * FROM Colaboradores WHERE user_Colaborador = @user_Colaborador AND password_Colaborador = @password_Colaborador";
                    Cmd.Parameters.AddWithValue("@user_Colaborador", colab.colab_usuario);
                    Cmd.Parameters.AddWithValue("@password_Colaborador", colab.colab_senha);
            try
                    {
                        SqlDataReader rd = Cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            rd.Close();
                            return true;
                        }
                    }
                    catch (Exception erro)
                    {
                        throw new Exception("ERRO: erro de login.\n" + erro.Message);
                    }
                    finally
                    {
                        Con.FecharConexao();
                    }
                    return false;
                }


        #endregion


        #region COLABORADORES

        //INSERIR DADOS COLABORADOR
        public void InsertColaborador(Colaboradores Colaborador)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Colaboradores (CPF_Colaborador, cargo_Colaborador, telefone_Colaborador, email_Colaborador, estado_Colaborador, cidade_Colaborador, endereco_Colaborador, bairro_Colaborador, CEP_Colaborador, nome_Colaborador, dataNasc_Colaborador, user_Colaborador, password_Colaborador, status_Colaborador) VALUES (@CPF_Colaborador, @cargo_Colaborador, @telefone_Colaborador, @email_Colaborador, @estado_Colaborador, @cidade_Colaborador, @endereco_Colaborador, @bairro_Colaborador, @CEP_Colaborador, @nome_Colaborador, @dataNasc_Colaborador, @user_Colaborador, @password_Colaborador, @status_Colaborador)";
            Cmd.Parameters.AddWithValue("@CPF_Colaborador", Colaborador.colab_CPF);
            Cmd.Parameters.AddWithValue("@cargo_Colaborador", Colaborador.colab_cargo);
            Cmd.Parameters.AddWithValue("@telefone_Colaborador", Colaborador.colab_telefone);
            Cmd.Parameters.AddWithValue("@email_Colaborador", Colaborador.colab_email);
            Cmd.Parameters.AddWithValue("@estado_Colaborador", Colaborador.colab_estado);
            Cmd.Parameters.AddWithValue("@cidade_Colaborador", Colaborador.colab_cidade);
            Cmd.Parameters.AddWithValue("@endereco_Colaborador", Colaborador.colab_endereco);
            Cmd.Parameters.AddWithValue("@bairro_Colaborador", Colaborador.colab_bairro);
            Cmd.Parameters.AddWithValue("@CEP_Colaborador", Colaborador.colab_CEP);
            Cmd.Parameters.AddWithValue("@nome_Colaborador", Colaborador.colab_nome);
            Cmd.Parameters.AddWithValue("@dataNasc_Colaborador", Colaborador.colab_dataNasc);
            Cmd.Parameters.AddWithValue("@user_Colaborador", Colaborador.colab_usuario);
            Cmd.Parameters.AddWithValue("@password_Colaborador", Colaborador.colab_senha);
            Cmd.Parameters.AddWithValue("@status_Colaborador ", Colaborador.colab_status);

            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir o colaborador ao banco de dados. \n" + erro.Message);
            }
        }

        //LISTAR DADOS DO COLABORADOR

        public List<Colaboradores> ListarColaboradores()
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
                    listaColaboradores.Add(Colaborador);
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

            return listaColaboradores;
        }


        // ATUALIZAR DADOS NO BANCO

        public void UpdateColaborador(Colaboradores colabToBeUpdated)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Colaboradores SET  CPF_Colaborador = @colab_CPF, cargo_Colaborador = @colab_cargo, telefone_Colaborador = @colab_telefone, email_Colaborador = @colab_email, estado_Colaborador = @colab_estado, cidade_Colaborador = @colab_cidade, endereco_Colaborador = @colab_endereco, bairro_Colaborador = @colab_bairro, CEP_Colaborador = @colab_CEP, nome_Colaborador = @colab_nome, dataNasc_Colaborador = @colab_dataNasc, user_Colaborador = @colab_usuario, password_Colaborador = @colab_senha, status_Colaborador = @colab_status  WHERE codigo_Colaborador  = @colab_codigo ";
            Cmd.Parameters.AddWithValue("@colab_codigo", colabToBeUpdated.colab_codigo);
            Cmd.Parameters.AddWithValue("@colab_CPF", colabToBeUpdated.colab_CPF);
            Cmd.Parameters.AddWithValue("@colab_cargo", colabToBeUpdated.colab_cargo);
            Cmd.Parameters.AddWithValue("@colab_telefone", colabToBeUpdated.colab_telefone);
            Cmd.Parameters.AddWithValue("@colab_email", colabToBeUpdated.colab_email);
            Cmd.Parameters.AddWithValue("@colab_estado", colabToBeUpdated.colab_estado);
            Cmd.Parameters.AddWithValue("@colab_cidade", colabToBeUpdated.colab_cidade);
            Cmd.Parameters.AddWithValue("@colab_endereco", colabToBeUpdated.colab_endereco);
            Cmd.Parameters.AddWithValue("@colab_bairro", colabToBeUpdated.colab_bairro);
            Cmd.Parameters.AddWithValue("@colab_CEP", colabToBeUpdated.colab_CEP);
            Cmd.Parameters.AddWithValue("@colab_nome", colabToBeUpdated.colab_nome);
            Cmd.Parameters.AddWithValue("@colab_dataNasc", colabToBeUpdated.colab_dataNasc);
            Cmd.Parameters.AddWithValue("@colab_usuario", colabToBeUpdated.colab_usuario);
            Cmd.Parameters.AddWithValue("@colab_senha", colabToBeUpdated.colab_senha);
            Cmd.Parameters.AddWithValue("@colab_status", colabToBeUpdated.colab_status);

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


        // EXCLUIR DADOS COLABORADOR

        public void DeleteColaborador(int ColaboradorCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Colaboradores SET  status_Colaborador = 0 WHERE codigo_Colaborador  = @colab_codigo ";
            Cmd.Parameters.AddWithValue("@colab_codigo", ColaboradorCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir Colaborador do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }


        #endregion


        #region FORNECEDORES


        //INSERIR DADOS FORNECEDOR

        public void InsertFornecedor(Fornecedores fornecedor)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Fornecedores VALUES (@nomefantasia_Fornecedor, @razaosocial_Fornecedor, @cnpj_Fornecedor, @inscricaoEstadual_Fornecedor, @inscricaoMunicipal_Fornecedor, @cep_Fornecedor, @endereco_Fornecedor, @numero_Fornecedor, @cidade_Fornecedor, @estado_Fornecedor, @representante_Fornecedor, @email_Fornecedor, @telefone_Fornecedor, @iniciocontrato_Fornecedor, @status_Fornecedor)";


            Cmd.Parameters.AddWithValue("@nomefantasia_Fornecedor", fornecedor.fornc_nomeFantasia);
            Cmd.Parameters.AddWithValue("@razaosocial_Fornecedor", fornecedor.fornc_razaoSocial);
            Cmd.Parameters.AddWithValue("@cnpj_Fornecedor", fornecedor.fornc_cnpj);
            Cmd.Parameters.AddWithValue("@inscricaoEstadual_Fornecedor", fornecedor.fornc_inscricaoEstadual);
            Cmd.Parameters.AddWithValue("@inscricaoMunicipal_Fornecedor", fornecedor.fornc_inscricaoMunicipal);
            Cmd.Parameters.AddWithValue("@cep_Fornecedor", fornecedor.fornc_cep);
            Cmd.Parameters.AddWithValue("@endereco_Fornecedor", fornecedor.fornc_endereco);
            Cmd.Parameters.AddWithValue("@numero_Fornecedor", fornecedor.fornc_numero);
            Cmd.Parameters.AddWithValue("@cidade_Fornecedor", fornecedor.fornc_cidade);
            Cmd.Parameters.AddWithValue("@estado_Fornecedor", fornecedor.fornc_estado);
            Cmd.Parameters.AddWithValue("@representante_Fornecedor", fornecedor.fornc_representante);
            Cmd.Parameters.AddWithValue("@email_Fornecedor", fornecedor.fornc_email);
            Cmd.Parameters.AddWithValue("@telefone_Fornecedor", fornecedor.fornc_telefone);
            Cmd.Parameters.AddWithValue("@iniciocontrato_Fornecedor", fornecedor.fornc_iniciocontrato);
            Cmd.Parameters.AddWithValue("@status_Fornecedor", fornecedor.fornc_status); 


            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir o Fornecedor ao banco de dados. \n" + erro.Message);
            }
        }



        //LISTAR DADOS FORNECEDOR

        public List<Fornecedores> ListarFornecedores()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Fornecedores where status_Fornecedor = 1";

            List<Fornecedores> listaFornecedores = new List<Fornecedores>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Fornecedores fornecedor = new Fornecedores((int)rd["codigo_Fornecedor"], (string)rd["nomefantasia_Fornecedor"], (string)rd["razaosocial_Fornecedor"], (string)rd["cnpj_Fornecedor"], (string)rd["inscricaoEstadual_Fornecedor"], (string)rd["inscricaoMunicipal_Fornecedor"], (string)rd["cep_Fornecedor"], (string)rd["endereco_Fornecedor"], (string)rd["numero_Fornecedor"], (string)rd["cidade_Fornecedor"], (string)rd["estado_Fornecedor"], (string)rd["representante_Fornecedor"], (string)rd["email_Fornecedor"], (string)rd["telefone_Fornecedor"], (DateTime)rd["iniciocontrato_Fornecedor"], (int)rd["status_Fornecedor"]);
                    listaFornecedores.Add(fornecedor);
                }

                {

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

            return listaFornecedores;
        }



        // ATUALIZAR BANCO DE DADOS
        public void UpdateFornecedor(Fornecedores fornToBeUpdated)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Fornecedores SET nomefantasia_Fornecedor = @fornc_nomeFantasia, razaosocial_Fornecedor = @fornc_razaoSocial , cnpj_Fornecedor = @fornc_cnpj, inscricaoEstadual_Fornecedor = @fornc_inscricaoEstadual, inscricaoMunicipal_Fornecedor = @fornc_inscricaoMunicipal, cep_Fornecedor = @fornc_cep, endereco_Fornecedor = @fornc_endereco, numero_Fornecedor = @fornc_numero, cidade_Fornecedor = @fornc_cidade, estado_Fornecedor = @fornc_estado, representante_Fornecedor = @fornc_representante, email_Fornecedor = @fornc_email, telefone_Fornecedor = @fornc_telefone, iniciocontrato_Fornecedor = @fornc_iniciocontrato, status_Fornecedor = @fornc_status WHERE codigo_Fornecedor = @fornc_codigo ";
            Cmd.Parameters.AddWithValue("@fornc_codigo", fornToBeUpdated.fornc_codigo);
            Cmd.Parameters.AddWithValue("@fornc_nomeFantasia", fornToBeUpdated.fornc_nomeFantasia);
            Cmd.Parameters.AddWithValue("@fornc_razaoSocial", fornToBeUpdated.fornc_razaoSocial);
            Cmd.Parameters.AddWithValue("@fornc_cnpj", fornToBeUpdated.fornc_cnpj);
            Cmd.Parameters.AddWithValue("@fornc_inscricaoEstadual", fornToBeUpdated.fornc_inscricaoEstadual);
            Cmd.Parameters.AddWithValue("@fornc_inscricaoMunicipal", fornToBeUpdated.fornc_inscricaoMunicipal);
            Cmd.Parameters.AddWithValue("@fornc_cep", fornToBeUpdated.fornc_cep);
            Cmd.Parameters.AddWithValue("@fornc_endereco", fornToBeUpdated.fornc_endereco);
            Cmd.Parameters.AddWithValue("@fornc_numero", fornToBeUpdated.fornc_numero);
            Cmd.Parameters.AddWithValue("@fornc_cidade", fornToBeUpdated.fornc_cidade);
            Cmd.Parameters.AddWithValue("@fornc_estado", fornToBeUpdated.fornc_estado);
            Cmd.Parameters.AddWithValue("@fornc_representante", fornToBeUpdated.fornc_representante);
            Cmd.Parameters.AddWithValue("@fornc_email", fornToBeUpdated.fornc_email);
            Cmd.Parameters.AddWithValue("@fornc_telefone", fornToBeUpdated.fornc_telefone);
            Cmd.Parameters.AddWithValue("@fornc_iniciocontrato", fornToBeUpdated.fornc_iniciocontrato);
            Cmd.Parameters.AddWithValue("@fornc_status", fornToBeUpdated.fornc_status);


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



        //EXCLUIR DADOS FORNECEDOR
        public void DeleteFornecedor(int fornecedorCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Fornecedores SET  status_Fornecedor = 0 WHERE codigo_Fornecedor  = @fornc_codigo ";
            Cmd.Parameters.AddWithValue("@fornc_codigo", fornecedorCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir fornecedor do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }


        #endregion


        #region MATERIAIS


        //INSERIR DADOS DO MATERIAL

        public void InsertMateriais(Materiais Material)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO Materiais VALUES (@codigo_Fornecedor, @nome_Material, @descricao, @unidadeMedida, @precoUnitario, @dataEntrada, @numeroLote, @localArmazenamento, @quantidade_Material, @UltimaAtualizacao, @status_material)";

            string mat_precoUnit = Material.mat_precoUnit.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"));
            Cmd.Parameters.AddWithValue("@codigo_Fornecedor", Material.fornc_codigo);
            Cmd.Parameters.AddWithValue("@nome_Material", Material.mat_nome);
            Cmd.Parameters.AddWithValue("@descricao", Material.mat_descricao);
            Cmd.Parameters.AddWithValue("@unidadeMedida", Material.mat_unidadeMedida);
            Cmd.Parameters.AddWithValue("@precoUnitario", decimal.Parse(mat_precoUnit) * Material.mat_quantidade);
            Cmd.Parameters.AddWithValue("@dataEntrada", Material.mat_dataEntrada);
           // Cmd.Parameters.AddWithValue("@fornecedor", Material.mat_fornecedor);
            Cmd.Parameters.AddWithValue("@numeroLote", Material.mat_numLote);
            Cmd.Parameters.AddWithValue("@localArmazenamento", Material.mat_localArmazenamento);
            Cmd.Parameters.AddWithValue("@quantidade_Material", Material.mat_quantidade);
            Cmd.Parameters.AddWithValue("@UltimaAtualizacao", Material.mat_ultimaAtualizacao);
            Cmd.Parameters.AddWithValue("@status_Material", Material.mat_status);
            // Cmd.Parameters.AddWithValue("@valor_Total", float.Parse(preco) * Material.mat_quantidade);

            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir o Material ao banco de dados. \n" + erro.Message);
            }
        }


        // LISTAR DADOS MATERIAL

        public List<Materiais> ListarMateriais()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Materiais where status_Material = 1";

            List<Materiais> listaMateriais = new List<Materiais>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    Materiais Material = new Materiais((int)rd["codigo_Material"], (int)rd["codigo_Fornecedor"], (string)rd["nome_Material"], (string)rd["descricao"], (string)rd["unidadeMedida"], (decimal)rd["precoUnitario"], (DateTime)rd["dataEntrada"], (string)rd["numeroLote"], (string)rd["localArmazenamento"], (int)rd["quantidade_Material"], (DateTime)rd["UltimaAtualizacao"], (string)rd["status_Material"]);

                    listaMateriais.Add(Material);
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

            return listaMateriais;
        }


        // ATUALIZAR DADOS NO BANCO

        public void UpdateMateriais(Materiais matToBeUpdated)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Materiais SET codigo_Fornecedor = @fornc_codigo, nome_Material = @mat_nome, descricao = @mat_descricao, unidadeMedida = @mat_unidadeMedida, precoUnitario= @mat_precoUnit, dataEntrada= @mat_dataEntrada, numeroLote= @mat_numLote, localArmazenamento= @mat_localArmazenamento, quantidade_Material= @mat_quantidade, UltimaAtualizacao= @mat_ultimaAtualizacao, status_Material = @mat_status, WHERE codigo_Material = @mat_codigo";
            Cmd.Parameters.AddWithValue("@mat_codigo", matToBeUpdated.mat_codigo);
            Cmd.Parameters.AddWithValue("@fornc_codigo", matToBeUpdated.fornc_codigo);
            Cmd.Parameters.AddWithValue("@mat_nome", matToBeUpdated.mat_nome);
            Cmd.Parameters.AddWithValue("@mat_descricao", matToBeUpdated.mat_descricao);
            Cmd.Parameters.AddWithValue("@mat_unidadeMedida", matToBeUpdated.mat_unidadeMedida);
            Cmd.Parameters.AddWithValue("@mat_precoUnit", matToBeUpdated.mat_precoUnit);
            Cmd.Parameters.AddWithValue("@mat_dataEntrada", matToBeUpdated.mat_dataEntrada);
            //Cmd.Parameters.AddWithValue("@mat_fornecedor", matToBeUpdated.mat_fornecedor);
            Cmd.Parameters.AddWithValue("@mat_numLote", matToBeUpdated.mat_numLote);
            Cmd.Parameters.AddWithValue("@mat_localArmazenamento", matToBeUpdated.mat_localArmazenamento);
            Cmd.Parameters.AddWithValue("@mat_quantidade", matToBeUpdated.mat_quantidade);
            Cmd.Parameters.AddWithValue("@mat_ultimaAtualizacao", matToBeUpdated.mat_ultimaAtualizacao);
            Cmd.Parameters.AddWithValue("@mat_status", matToBeUpdated.mat_status);

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


        //EXCLUIR DADOS DO MATERIAL

        public void DeleteMaterial(int MaterialCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Materiais SET  status_Material = 0 WHERE codigo_Material  = @mat_codigo";
            Cmd.Parameters.AddWithValue("@mat_codigo", MaterialCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir Material do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }


        #endregion


        #region CLIENTES

        //INSERIR DADOS DO CLIENTE

        public void InsertClientes(Clientes Cliente)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Clientes VALUES (@nome_Cliente, @CPFCNPJ_Cliente, @telefone_Cliente, @email_Cliente, @dataNasc_Cliente, @estado_Cliente, @cidade_Cliente, @endereco_Cliente, @CEP_Cliente, @status_Cliente)";

            Cmd.Parameters.AddWithValue("@nome_Cliente", Cliente.cli_nome);
            Cmd.Parameters.AddWithValue("@CPFCNPJ_Cliente", Cliente.cli_CPFCNPJ);
            Cmd.Parameters.AddWithValue("@telefone_Cliente", Cliente.cli_telefone);
            Cmd.Parameters.AddWithValue("@email_Cliente", Cliente.cli_email);
            Cmd.Parameters.AddWithValue("@dataNasc_Cliente", Cliente.cli_dataNasc);
            Cmd.Parameters.AddWithValue("@estado_Cliente", Cliente.cli_estado);
            Cmd.Parameters.AddWithValue("@cidade_Cliente", Cliente.cli_cidade);
            Cmd.Parameters.AddWithValue("@endereco_Cliente", Cliente.cli_endereco);
            Cmd.Parameters.AddWithValue("@CEP_Cliente", Cliente.cli_CEP);
            Cmd.Parameters.AddWithValue("@status_Cliente", Cliente.cli_status);


            // try
            // {
            Cmd.ExecuteNonQuery();
            Con.FecharConexao();
            //}
            // catch (Exception erro)
            //{
            //    throw new Exception("Erro problemas ao inserir o Cliente ao banco de dados. \n" + erro.Message);
            //
            //}
        }

        //LISTAR DADOS DO CLIENTE

        public List<Clientes> ListarClientes()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Clientes where status_Cliente = 1";

            List<Clientes> listaClientes = new List<Clientes>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Clientes Cliente = new Clientes((int)rd["codigo_Cliente"], (string)rd["nome_Cliente"], (string)rd["CPFCNPJ_Cliente"], (string)rd["telefone_Cliente"], (string)rd["email_Cliente"], (DateTime)rd["dataNasc_Cliente"], (string)rd["estado_Cliente"], (string)rd["cidade_Cliente"], (string)rd["endereco_Cliente"], (string)rd["CEP_Cliente"], (int)rd["status_Cliente"]);
                    listaClientes.Add(Cliente);
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

            return listaClientes;
        }


        // ATUALIZAR DADOS NO BANCO

        public void UpdateClientes(Clientes cliToBeUpdated)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Clientes SET nome_Cliente = @cli_nome, CPFCNPJ_Cliente = @cli_CPFCNPJ, telefone_Cliente = cli_telefone, email_Cliente = @cli_email, dataNasc_Cliente  = @cli_dataNasc, estado_Cliente = @cli_estado, cidade_Cliente = @cli_cidade, endereco_Cliente = @cli_endereco, CEP_Cliente = @cli_CEP, status_Cliente = @cli_status WHERE codigo_Cliente = @cli_codigo ";



            Cmd.Parameters.AddWithValue("@cli_codigo ", cliToBeUpdated.cli_codigo);
            Cmd.Parameters.AddWithValue("@cli_nome", cliToBeUpdated.cli_nome);
            Cmd.Parameters.AddWithValue("@cli_CPFCNPJ", cliToBeUpdated.cli_CPFCNPJ);
            Cmd.Parameters.AddWithValue("@cli_telefone", cliToBeUpdated.cli_telefone);
            Cmd.Parameters.AddWithValue("@cli_email", cliToBeUpdated.cli_email);
            Cmd.Parameters.AddWithValue("@cli_dataNasc", cliToBeUpdated.cli_dataNasc);
            Cmd.Parameters.AddWithValue("@cli_estado", cliToBeUpdated.cli_estado);
            Cmd.Parameters.AddWithValue("@cli_cidade", cliToBeUpdated.cli_cidade);
            Cmd.Parameters.AddWithValue("@cli_endereco", cliToBeUpdated.cli_endereco);
            Cmd.Parameters.AddWithValue("@cli_CEP", cliToBeUpdated.cli_CEP);
            Cmd.Parameters.AddWithValue("@cli_status", cliToBeUpdated.cli_status);


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


        //EXCLUIR DADOS DO CLIENTE

        public void DeleteClientes(int ClienteCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Clientes SET  status_Cliente = 0 WHERE codigo_Cliente  = @cli_codigo ";
            Cmd.Parameters.AddWithValue("@cli_codigo", ClienteCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir Cliente do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }


        #endregion


        #region PEDIDOS

        //INSERIR DADOS DO PEDIDO
        public void InsertPedidos(Pedidos pedido)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Pedidos VALUES (@codigo_Colaborador, @codigo_Cliente, @corCamiseta_Pedido, @tecidoCamiseta_Pedido, @formatoCamiseta_Pedido, @tipoGola_Pedido, @tecnicas_Pedido, @tamP_quant_Pedido, @tamM_quant_Pedido, @tamG_quant_Pedido, @diponibilizadoCliente, @quantdisponibilizadoCliente, @totalCamisetas_Pedido, @data_inicial, @data_entrega, @valorUnit_Pedido, @valorTotal_Pedido, @valorEntrada_Pedido, @valorAberto_Pedido, @formaPagamentoEntrada_Pedido, @formaPagamentoFinal_Pedido, @status_Pedido, @estampa_Pedido)";


            Cmd.Parameters.AddWithValue("@codigo_Colaborador", pedido.colab_codigo);
            Cmd.Parameters.AddWithValue("@codigo_Cliente", pedido.cli_codigo);
            Cmd.Parameters.AddWithValue("@corCamiseta_Pedido", pedido.ped_cor);
            Cmd.Parameters.AddWithValue("@tecidoCamiseta_Pedido", pedido.ped_tecido);
            Cmd.Parameters.AddWithValue("@formatoCamiseta_Pedido", pedido.ped_formato);
            Cmd.Parameters.AddWithValue("@tipoGola_Pedido", pedido.ped_gola);
            Cmd.Parameters.AddWithValue("@tecnicas_Pedido", pedido.ped_tecnica);
            Cmd.Parameters.AddWithValue("@tamP_quant_Pedido", pedido.ped_tamP);
            Cmd.Parameters.AddWithValue("@tamM_quant_Pedido", pedido.ped_tamM);
            Cmd.Parameters.AddWithValue("@tamG_quant_Pedido", pedido.ped_tamG);
            Cmd.Parameters.AddWithValue("diponibilizadoCliente", pedido.ped_disponibilizadoCli);
            Cmd.Parameters.AddWithValue("@quantdisponibilizadoCliente", pedido.ped_quantDisponibilizado);
            Cmd.Parameters.AddWithValue("@totalCamisetas_Pedido", pedido.ped_totalCamisetas);
            Cmd.Parameters.AddWithValue("@data_inicial", pedido.ped_Datainicial);
            Cmd.Parameters.AddWithValue("@data_entrega", pedido.ped_DataEntrega);
            Cmd.Parameters.AddWithValue("@valorUnit_Pedido", pedido.ped_valorUnitario);
            Cmd.Parameters.AddWithValue("@valorTotal_Pedido", pedido.ped_valorTotal);
            Cmd.Parameters.AddWithValue("@valorEntrada_Pedido", pedido.ped_valorEntrada);
            Cmd.Parameters.AddWithValue("@valorAberto_Pedido", pedido.ped_valorAberto);
            Cmd.Parameters.AddWithValue("@formaPagamentoEntrada_Pedido", pedido.ped_formaPagamentoEntrada);
            Cmd.Parameters.AddWithValue("@formaPagamentoFinal_Pedido", pedido.ped_formaPagamentoFinal);
            Cmd.Parameters.AddWithValue("@status_Pedido", pedido.ped_status);
            Cmd.Parameters.AddWithValue("@estampa_Pedido", pedido.ped_estampa);


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

                    Pedidos pedido = new Pedidos((int)rd["codigo_Pedido"], (int)rd["codigo_Colaborador"], (int)rd["codigo_Cliente"], (string)rd["corCamiseta_Pedido"], (string)rd["tecidoCamiseta_Pedido"], (string)rd["formatoCamiseta_Pedido"], (string)rd["tipoGola_Pedido"], (string)rd["tecnicas_Pedido"], (string)rd["estampa_Pedido"], (int)rd["tamP_quant_Pedido"], (int)rd["tamM_quant_Pedido"], (int)rd["tamG_quant_Pedido"], (int)rd["diponibilizadoCliente"], (int)rd["quantdisponibilizadoCliente"], (int)rd["totalCamisetas_Pedido"], (DateTime)rd["data_inicial"], (DateTime)rd["data_entrega"], (decimal)rd["valorUnit_Pedido"], (decimal)rd["valorTotal_Pedido"], (decimal)rd["valorEntrada_Pedido"], (decimal)rd["valorAberto_Pedido"], (string)rd["formaPagamentoEntrada_Pedido"], (string)rd["formaPagamentoFinal_Pedido"], (string)rd["status_Pedido"]);


                    listaPedidos.Add(pedido);
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


        #region PRODUÇÃO
        //INSERIR DADOS COLABORADOR
        public void InsertProducao(Producao producao)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO PRODUCOES (ID_produto, Quantidade_P, Quantidade_M, Quantidade_G, COR, Tecido, Formato, Tipo_Gola, Tecnicas, Data_Entrega, Status) VALUES (@codigo_produto, @quantidade_P, @quantidade_M, @quantidade_G, @cor, @tecido, @formato, @gola, @tecnicas, @Data_Entrega, @status)";
            Cmd.Parameters.AddWithValue("@codigo_produto", producao.codigo_produto);
            Cmd.Parameters.AddWithValue("@quantidade_P", producao.quantidade_P);
            Cmd.Parameters.AddWithValue("@quantidade_M", producao.quantidade_M);
            Cmd.Parameters.AddWithValue("@quantidade_G", producao.quantidade_G);
            Cmd.Parameters.AddWithValue("@cor", producao.cor);
            Cmd.Parameters.AddWithValue("@tecido", producao.tecido);
            Cmd.Parameters.AddWithValue("@formato", producao.formato);
            Cmd.Parameters.AddWithValue("@gola", producao.gola);
            Cmd.Parameters.AddWithValue("@tecnicas", producao.tecnicas);
            Cmd.Parameters.AddWithValue("@Data_Entrega", producao.Data_Entrega);
            Cmd.Parameters.AddWithValue("@status", producao.status);

            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();

            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir o producao ao banco de dados. \n" + erro.Message);
            }
        }
        #endregion




        #region MOVIMENTAÇÕES


        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertMovimentacao(Movimentacoes movimentacao)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Movimentacoes VALUES (@Data, @Valor, @Descricao, @TipoTransacao, @CategoriaId, @ContaBancariaId, @CentroDeCustoId, @status_movimentacao)";

            // definindo sql de insersão e atribuindo os parâmetros

            Cmd.Parameters.AddWithValue("@Data", movimentacao.Data_mov);
            Cmd.Parameters.AddWithValue("@Valor", movimentacao.Valor_mov);
            Cmd.Parameters.AddWithValue("@Descricao", movimentacao.Descricao_mov);
            Cmd.Parameters.AddWithValue("@TipoTransacao", movimentacao.TipoTransacao_mov);
            Cmd.Parameters.AddWithValue("@CategoriaId", movimentacao.CategoriaId_mov);
            Cmd.Parameters.AddWithValue("@ContaBancariaId", movimentacao.ContaBancariaId_mov);
            Cmd.Parameters.AddWithValue("@CentroDeCustoId", movimentacao.CentroDeCustoId_mov);
            Cmd.Parameters.AddWithValue("@status_movimentacao", movimentacao.status_mov);


            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a movimentação ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateMovimentacao(Movimentacoes movimentacao)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Movimentacoes SET  Id = @idmov, Data = @Data_mov, Valor = @Valor_mov, Descricao = @Descricao_mov, TipoTransacao = @TipoTransacao_mov, CategoriaId = @CategoriaId_mov, ContaBancariaId = @ContaBancariaId_mov, CentroDeCustoId = @CentroDeCustoId_mov WHERE status_movimentacao = @status_mov";

        }

        // Método para excluir a movimentação financeira
        public void DeleteMovimentacao(int movimentoCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Movimentacoes SET  status_movimentacao = 0 WHERE Id = @idmov";
            Cmd.Parameters.AddWithValue("@status_mov", movimentoCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir movimento do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Movimentacoes> ListarMovimentacoes()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Movimentacoes where status_mov = 1";

            List<Movimentacoes> listaMovimentos = new List<Movimentacoes>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    Movimentacoes pedido = new Movimentacoes((int)rd["Id"], (DateTime)rd["Data"], (decimal)rd["Valor"], (string)rd["Descricao"], (string)rd["TipoTransacao"], (int)rd["CategoriaId"], (int)rd["ContaBancariaId"], (int)rd["CentroDeCustoId"], (int)rd["status_movimentacao"]);


                    listaMovimentos.Add(pedido);
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

            return listaMovimentos;
        }



        #endregion


        #region CATEGORIAS

        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertCategoria(Categoria categoria)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Categoria VALUES (@Nome, @Descricao, @status_categoria)";

            // definindo sql de insersão e atribuindo os parâmetros

            Cmd.Parameters.AddWithValue("@Nome", categoria.Nome_categoria);
            Cmd.Parameters.AddWithValue("@Descricao", categoria.Descricao_categoria);
            Cmd.Parameters.AddWithValue("@status_categoria", categoria.status_categoria);

            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a categoria ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateCategoria(Categoria categoria)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Categoria SET  Nome = @Nome_categoria, Descricao = @Descricao_categoria, status_categoria = @status_categoria WHERE codigo_Categoria = @codigo_categoria";

        }

        // Método para excluir a movimentação financeira
        public void DeleteCategoria(int categoriaCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Categoria SET  status_categoria = 0 WHERE codigo_Categoria = @codigo_categoria";
            Cmd.Parameters.AddWithValue("@codigo_categoria", categoriaCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir Categoria do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Categoria> ListarCategoria()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Categoria where status_categoria = 1";

            List<Categoria> listaCategorias = new List<Categoria>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    Categoria categoria = new Categoria((int)rd["codigo_Categoria"], (string)rd["Nome"], (string)rd["Descricao"], (int)rd["status_cate"]);


                    listaCategorias.Add(categoria);
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

            return listaCategorias;
        }


        #endregion


        #region CONTA


        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertConta(Contas conta)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Contas VALUES (@Nome, @TipoConta, @SaldoInicial, @Descricao, @status_conta)";

            // definindo sql de insersão e atribuindo os parâmetros

            Cmd.Parameters.AddWithValue("@Nome", conta.Nome_conta);
            Cmd.Parameters.AddWithValue("@TipoConta", conta.TipoConta_conta);
            Cmd.Parameters.AddWithValue("@SaldoInicial", conta.SaldoInicial_conta);
            Cmd.Parameters.AddWithValue("@Descricao", conta.Descricao_conta);
            Cmd.Parameters.AddWithValue("@status_conta", conta.cont_status);



            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a conta ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateConta(Categoria conta)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Contas SET  Nome = @Nome_conta, TipoConta = @TipoConta_conta, SaldoInicial = @SaldoInicial_conta, Descricao = @Descricao_conta, status_conta = cont_status   WHERE Id = @Id_conta";

        }

        // Método para excluir a movimentação financeira
        public void DeleteConta(int contaCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Categoria SET  status_conta = 0 WHERE Id = @Id_conta";
            Cmd.Parameters.AddWithValue("@Id_conta", contaCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir Conta do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }
        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Contas> ListarConta()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Contas where status_conta = 1";

            List<Contas> listaContas = new List<Contas>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    Contas conta = new Contas((int)rd["Id"], (string)rd["Nome"], (string)rd["TipoConta"], (decimal)rd["SaldoInicial"], (string)rd["Descricao"], (int)rd["status_conta"]);


                    listaContas.Add(conta);
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

            return listaContas;
        }


        #endregion


        #region RECEITA

        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertReceita(Receita receita)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Receitas VALUES (@Data, @Valor, @codigo_CategoriaID, @codigo_cbancariaID, @codigo_ccustoID, @Descricao, @status_Receita)";

            // definindo sql de insersão e atribuindo os parâmetros

            Cmd.Parameters.AddWithValue("@Data", receita.Data_receita);
            Cmd.Parameters.AddWithValue("@Valor", receita.Valor_receita);
            Cmd.Parameters.AddWithValue("@codigo_CategoriaID", receita.CategoriaId_receita);
            Cmd.Parameters.AddWithValue("@codigo_cbancariaID", receita.ContaBancariaId_receita);
            Cmd.Parameters.AddWithValue("@codigo_ccustoID", receita.CentroDeCustoId_receita);
            Cmd.Parameters.AddWithValue("@Descricao", receita.Descricao_receita);
            Cmd.Parameters.AddWithValue("@status_Receita", receita.status);




            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a receita ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateReceita(Receita receita)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Receitas SET  Data = @Data_receita, Valor = @Valor_receita, codigo_CategoriaID = @CategoriaId_receita, codigo_cbancariaID = @ContaBancariaId_receita, codigo_ccustoID = @CentroDeCustoId_receita, status_Receita = @status  WHERE codigo_Receita = @Id_receita";

        }

        // Método para excluir a movimentação financeira
        public void DeleteReceita(int receitaCod)
        {

            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Receitas SET  status_Receita = 0 WHERE codigo_Receita = @Id_receita";
            Cmd.Parameters.AddWithValue("@Id_receita", receitaCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir receita do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }


        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Receita> ListarReceita()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Receitas where status_Receita = 1";

            List<Receita> listaReceita = new List<Receita>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    Receita receita = new Receita((int)rd["codigo_Receita"], (DateTime)rd["Data"], (decimal)rd["Valor"], (int)rd["codigo_CategoriaID"], (int)rd["codigo_cbancariaID"], (int)rd["codigo_ccustoID"], (string)rd["Descricao"], (string)rd["status_Receita"]);


                    listaReceita.Add(receita);
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

            return listaReceita;
        }


        #endregion


        #region DESPESA


        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertDespesa(Despesas despesas)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Despesas VALUES (@Data, @Valor, @codigo_CategoriaID, @codigo_cbancariaID, @codigo_ccustoID, @Descricao, @status_Despesa)";

            // definindo sql de insersão e atribuindo os parâmetros

            Cmd.Parameters.AddWithValue("@Data", despesas.Data_despesa);
            Cmd.Parameters.AddWithValue("@Valor", despesas.Valor_despesa);
            Cmd.Parameters.AddWithValue("@codigo_CategoriaID", despesas.CategoriaId_despesa);
            Cmd.Parameters.AddWithValue("@codigo_cbancariaID", despesas.ContaBancariaId_despesa);
            Cmd.Parameters.AddWithValue("@codigo_ccustoID", despesas.CentroDeCustoId_despesa);
            Cmd.Parameters.AddWithValue("@Descricao", despesas.Descricao_despesa);
            Cmd.Parameters.AddWithValue("@status_Despesa", despesas.status);


            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a despesa ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateDespesa(Despesas despesas)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Despesas SET  Data = @Data_despesa, Valor = @Valor_despesa, codigo_CategoriaID = @CategoriaId_despesa, codigo_cbancariaID = @ContaBancariaId_despesa, codigo_ccustoID = @CentroDeCustoId_despesa, status_Despesa = @status   WHERE codigo_Despesa = @Id_despesa";
        }

        // Método para excluir a movimentação financeira
        public void DeleteDespesa(int despesasCod)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Despesas SET  status_Despesa = 0 WHERE codigo_Despesa = @Id_despesa";
            Cmd.Parameters.AddWithValue("@Id_despesa", despesasCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir despesa do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }

        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Despesas> ListarDespesa()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Despesas where status_Despesa = 1";

            List<Despesas> listaDespesa = new List<Despesas>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    Despesas despesa = new Despesas((int)rd["codigo_Despesa"], (DateTime)rd["Data"], (decimal)rd["Valor"], (int)rd["codigo_CategoriaID"], (int)rd["codigo_cbancariaID"], (int)rd["codigo_ccustoID"], (string)rd["Descricao"], (string)rd["status_Despesa"]);


                    listaDespesa.Add(despesa);
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

            return listaDespesa;

        }


        #endregion


        #region CCUSTO
        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertCCusto(Centro_Custo ccusto)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  CentroCusto VALUES (@Nome, @Descricao, @statusCCusto)";

            // definindo sql de insersão e atribuindo os parâmetros

            Cmd.Parameters.AddWithValue("@Nome", ccusto.Nome);
            Cmd.Parameters.AddWithValue("@Descricao", ccusto.Descricao);
            Cmd.Parameters.AddWithValue("@statusCCusto", ccusto.status);


            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a centro de custo ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateCCusto(Centro_Custo ccusto)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE CentroCusto SET  Nome = @Nome, Descricao = @Descricao, statusCCusto = @status WHERE codigo_centroCusto = @Id";

        }

        // Método para excluir a movimentação financeira
        public void DeleteCCusto(int ccustoCod)
        {

            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE CentroCusto SET  statusCCusto = 0 WHERE codigo_centroCusto = @Id";
            Cmd.Parameters.AddWithValue("@Id", ccustoCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir centro de custo do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }

        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Centro_Custo> ListarCCusto()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM CentroCusto where status = 1";

            List<Centro_Custo> listaCCusto = new List<Centro_Custo>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    Centro_Custo ccusto = new Centro_Custo((int)rd["codigo_centroCusto"], (string)rd["Nome"], (string)rd["Descricao"], (int)rd["statusCCusto"]);


                    listaCCusto.Add(ccusto);
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

            return listaCCusto;
        }
        #endregion


        #region SANGRIA

        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertSangria(SangriaCaixa sangria)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  SangriaCX VALUES (@Data, @Valor, @Descricao, @status_sangriaCX)";

            // definindo sql de insersão e atribuindo os parâmetros

            Cmd.Parameters.AddWithValue("@Data", sangria.DataSangria);
            Cmd.Parameters.AddWithValue("@Valor", sangria.Valor);
            Cmd.Parameters.AddWithValue("@Descricao", sangria.Descricao);
            Cmd.Parameters.AddWithValue("@status_sangriaCX", sangria.status);



            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a sangria ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateSangria(SangriaCaixa sangria)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE SangriaCX SET  Data = @DataSangria, Valor = @Valor, Descricao = @Descricao, status_sangriaCX = @status WHERE codigo_SangriaCX = @Id";

        }

        // Método para excluir a movimentação financeira
        public void DeleteSangria(int sangriaCod)
        {

            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE SangriaCX SET  status_sangriaCX = 0 WHERE codigo_sangriaCX = @Id";
            Cmd.Parameters.AddWithValue("@Id", sangriaCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir sangria do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }

        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<SangriaCaixa> ListarSangria()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM SangriaCX where status = 1";

            List<SangriaCaixa> listaSangria = new List<SangriaCaixa>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    SangriaCaixa sangria = new SangriaCaixa((int)rd["codigo_sangriaCX"], (DateTime)rd["Data"], (decimal)rd["Valor"], (string)rd["Descricao"], (int)rd["status_sangriaCX"]);


                    listaSangria.Add(sangria);
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

            return listaSangria;
        }
        #endregion


        #region TRANSACAO

        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertTransacao(Transacao transacao)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  Transacoes VALUES (@Data, @Valor,@categoriaID, @cBancariaID, @cCustoID, @Descricao, @status_transacao)";

            // definindo sql de insersão e atribuindo os parâmetros           

            Cmd.Parameters.AddWithValue("@Data", transacao.Data);
            Cmd.Parameters.AddWithValue("@Valor", transacao.Valor);
            Cmd.Parameters.AddWithValue("@categoriaID", transacao.CategoriaId);
            Cmd.Parameters.AddWithValue("@cBancariaID", transacao.ContaBancariaId);
            Cmd.Parameters.AddWithValue("@cCustoID", transacao.CentroDeCustoId);
            Cmd.Parameters.AddWithValue("@Descricao", transacao.Descricao);
            Cmd.Parameters.AddWithValue("@status_transacao", transacao.status);


            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a transacao ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateTransacao(Transacao transacao)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Transacoes SET  Data = @Data, Valor = @Valor, categoriaID = @CategoriaId, cBancariaID = @ContaBancariaId, cCustoID = @CentroDeCustoId, Descricao = @Descricao, status_transacao = @status WHERE codigo_transacao = @Id";

        }

        // Método para excluir a movimentação financeira
        public void DeleteTransacao(int transacaoCod)
        {

            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE Transacoes SET  status_transacao = 0 WHERE codigo_transacao = @Id";
            Cmd.Parameters.AddWithValue("@Id", transacaoCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir transacao do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }

        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Transacao> ListarTransacao()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM Transacoes where status = 1";

            List<Transacao> listaTransacao = new List<Transacao>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    Transacao transacao = new Transacao((int)rd["codigo_transacao"], (DateTime)rd["Data"], (decimal)rd["Valor"], (int)rd["categoriaID"], (int)rd["cBancariaID"], (int)rd["cCustoID"], (string)rd["Descricao"], (int)rd["status_transacao"]);

                    listaTransacao.Add(transacao);
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

            return listaTransacao;
        }
        #endregion


        #region FECHAMENTO

        // método booleano para informar se obteve sucesso ao salvar as informações no banco de dado
        public void InsertFechamentoCX(FechamentoCaixa fechamentoCX)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"INSERT INTO  FechamentoCX VALUES (@Data, @SaldoInicial,@Transacao, @SaldoFinal, @status_fechamento)";

            // definindo sql de insersão e atribuindo os parâmetros           

            Cmd.Parameters.AddWithValue("@Data", fechamentoCX.DataFechamento);
            Cmd.Parameters.AddWithValue("@SaldoInicial", fechamentoCX.SaldoInicial);
            Cmd.Parameters.AddWithValue("@Transacoes", fechamentoCX.Transacoes); // fica o id da transação
            Cmd.Parameters.AddWithValue("@SaldoFinal", fechamentoCX.SaldoFinal);
            Cmd.Parameters.AddWithValue("@status_fechamento", fechamentoCX.status);

            try
            {
                Cmd.ExecuteNonQuery();
                Con.FecharConexao();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas ao inserir a fechamento  ao banco de dados. \n" + erro.Message);
            }
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public void UpdateFechamentoCX(FechamentoCaixa fechamentoCX)
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE FechamentoCX SET  Data = @DataFechamento, SaldoInicial = @SaldoInicial, Transacoes = @Transacoes, SaldoFinal = @SaldoFinal, status_fechamento = @status WHERE codigo_fechamentoCX = @Id";

        }

        // Método para excluir a movimentação financeira
        public void DeleteFechamentoCX(int fechamentoCXCod)
        {

            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = @"UPDATE FechamentoCX SET  status_fechamento = 0 WHERE codigo_fechamentoCX = @Id";
            Cmd.Parameters.AddWithValue("@Id", fechamentoCXCod);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro problemas excluir fechamento do banco de dados. \n" + erro.Message);
            }
            finally
            {
                Con.FecharConexao();
            }

        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<FechamentoCaixa> ListarFechamentoCX()
        {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM FechamentoCX where status = 1";

            List<FechamentoCaixa> listafechamentoCX = new List<FechamentoCaixa>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {

                    FechamentoCaixa fechamentoCX = new FechamentoCaixa((int)rd["codigo_fechamentoCX"], (DateTime)rd["Data"], (decimal)rd["SaldoInicial"], (List<Transacao>)rd["Transacoes"], (decimal)rd["SaldoFinal"], (int)rd["status_fechamentoCX"]);

                    listafechamentoCX.Add(fechamentoCX);
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

            return listafechamentoCX;
        }

        #endregion


        #region ESTOQUE
        #endregion


    }
}
