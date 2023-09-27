using projeto2023.controllers;
using projeto2023.models;
using projeto2023.views.clientes;
using projeto2023.views.pedidos;
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

namespace projeto2023.views.fornecedores
{
    public partial class consulta_fornecedores : Form
    {
        public consulta_fornecedores()
        {
            InitializeComponent();
        }

        private void consulta_fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1_FORNECEDORES.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.estampariadbDataSet1_FORNECEDORES.Fornecedores);
            fornecedoresBindingSource.Filter = "status_Fornecedor = 1";

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_fornecedores((dt)))
            {
                frm.ShowDialog();
            }
        }


        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("codigo_Fornecedor", typeof(int));
            dt.Columns.Add("nomefantasia_Fornecedor");
            dt.Columns.Add("razaosocial_Fornecedor");
            dt.Columns.Add("cnpj_Fornecedor");
            dt.Columns.Add("inscricaoEstadual_Fornecedor");
            dt.Columns.Add("inscricaoMunicipal_Fornecedor");
            dt.Columns.Add("cep_Fornecedor");
            dt.Columns.Add("endereco_Fornecedor");
            dt.Columns.Add("numero_Fornecedor");
            dt.Columns.Add("cidade_Fornecedor");
            dt.Columns.Add("estado_Fornecedor");
            dt.Columns.Add("representante_Fornecedor");
            dt.Columns.Add("email_Fornecedor");
            dt.Columns.Add("telefone_Fornecedor");
            dt.Columns.Add("iniciocontrato_Fornecedor", typeof(DateTime));
            dt.Columns.Add("status_Fornecedor", typeof(int));


            foreach (DataGridViewRow item in dtv_fornecedores.Rows)
            {
                dt.Rows.Add(Convert.ToInt32(item.Cells[0].Value),
                                            item.Cells[1].Value,
                                            item.Cells[2].Value,
                                            item.Cells[3].Value,
                                            item.Cells[4].Value,
                                            item.Cells[5].Value,
                                            item.Cells[6].Value,
                                            item.Cells[7].Value,
                                            item.Cells[8].Value,
                                            item.Cells[9].Value,
                                            item.Cells[10].Value,
                                            item.Cells[11].Value,
                                            item.Cells[12].Value,
                                            item.Cells[13].Value,
                         Convert.ToDateTime(item.Cells[14].Value),
                            Convert.ToInt32(item.Cells[15].Value));
            }
            return dt;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_fornecedores((dt)))
            {
                frm.ShowDialog();
            }
        }

        private void txtpesqForn_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisa = txtpesqForn.Text.Trim();

            if (!string.IsNullOrEmpty(nomePesquisa))
            {
                fornecedoresBindingSource.Filter = $"nomefantasia_Fornecedor LIKE '%{nomePesquisa}%'";
            }
            else
            {
                fornecedoresBindingSource.RemoveFilter();
            }

            dtv_fornecedores.Refresh();
        }

        private void cbox_fornecedores_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_fornecedores.Checked)
            {
                // Quando o CheckBox estiver marcado (habilitado)
                fornecedoresBindingSource.Filter = "status_Fornecedor = 0";

            }
            else
            {
                // Quando o CheckBox não estiver marcado (desabilitado)
                fornecedoresBindingSource.Filter = "status_Fornecedor= 1";

            }


            txb_nomefantasia.Clear();
            txb_razaosocial.Clear();
            txb_cnpj.Clear();
            txb_inscricaoEstadual.Clear();
            txb_inscricaoMunicipal.Clear();
            txb_cep.Clear();
            txb_endereco.Clear();
            txb_numero.Clear();
            txb_cidade.Clear();
            cmb_estado.SelectedIndex = -1;
            txb_representante.Clear();
            txb_email.Clear();
            txb_contato.Clear();

            btn_ativar.Visible = false;
            button_excluir.Visible = false;
            btn_salvar.Visible = false;

            dtv_fornecedores.Refresh();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string fornc_nomeFantasia = txb_nomefantasia.Text;
            string fornc_razaoSocial = txb_razaosocial.Text;
            string fornc_cnpj = txb_cnpj.Text;
            string fornc_inscricaoEstadual = txb_inscricaoEstadual.Text;
            string fornc_inscricaoMunicipal = txb_inscricaoMunicipal.Text;
            string fornc_cep = txb_cep.Text;
            string fornc_endereco = txb_endereco.Text;
            string fornc_numero = txb_numero.Text;
            string fornc_cidade = txb_cidade.Text;
            string fornc_estado = cmb_estado.Text;
            string fornc_representante = txb_representante.Text;
            string fornc_email = txb_email.Text;
            string fornc_telefone = txb_contato.Text;
           // DateTime fornc_iniciocontrato = new DateTime(2007, 1, 21);
            //fornc_iniciocontrato = mnth_contrato.SelectionStart;
            int id = int.Parse(cod_fornecedores.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            AtualizarRegistroNaBaseDeDadosFornecedores(id, fornc_nomeFantasia, fornc_razaoSocial, fornc_cnpj, fornc_inscricaoEstadual, fornc_inscricaoMunicipal, fornc_cep, fornc_endereco, fornc_numero, fornc_cidade, fornc_representante, fornc_estado, fornc_email, fornc_telefone);

            // Após salvar, você pode definir DialogResult para OK para indicar que as alterações foram salvas com sucesso
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AtualizarRegistroNaBaseDeDadosFornecedores(int id, string fornc_nomeFantasia, string fornc_razaoSocial, string fornc_cnpj, string fornc_inscricaoEstadual, string fornc_inscricaoMunicipal, string fornc_cep, string fornc_endereco, string fornc_numero, string fornc_cidade, string fornc_representante, string fornc_estado, string fornc_email, string fornc_telefone)

        {
            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            // Isso dependerá da sua estrutura de banco de dados e da forma como você interage com ela
            // Você precisará executar uma consulta SQL ou chamar um método apropriado aqui
            // Fornecedores fornecedor = new Fornecedores(id, fornc_nomeFantasia, fornc_razaoSocial, fornc_cnpj, fornc_inscricaoEstadual, fornc_inscricaoMunicipal, fornc_cep, fornc_endereco, fornc_numero, fornc_cidade, fornc_estado, fornc_representante, fornc_email, fornc_telefone, fornc_iniciocontrato, fornc_status);
            // fornecedorDAO.UpdateFornecedor(fornecedor);

            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server
            //Connection conn = new Connection(); 
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"UPDATE Fornecedores SET nomefantasia_Fornecedor = @fornc_nomeFantasia, razaosocial_Fornecedor = @fornc_razaoSocial , cnpj_Fornecedor = @fornc_cnpj, inscricaoEstadual_Fornecedor = @fornc_inscricaoEstadual, inscricaoMunicipal_Fornecedor = @fornc_inscricaoMunicipal, cep_Fornecedor = @fornc_cep, endereco_Fornecedor = @fornc_endereco, numero_Fornecedor = @fornc_numero, cidade_Fornecedor = @fornc_cidade, estado_Fornecedor = @fornc_estado, representante_Fornecedor = @fornc_representante,"+
                     "email_Fornecedor = @fornc_email, telefone_Fornecedor = @fornc_telefone  WHERE codigo_Fornecedor = @fornc_codigo ";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {


                    command.Parameters.AddWithValue("@fornc_codigo", id);
                    command.Parameters.AddWithValue("@fornc_nomeFantasia", fornc_nomeFantasia);
                    command.Parameters.AddWithValue("@fornc_razaoSocial", fornc_razaoSocial);
                    command.Parameters.AddWithValue("@fornc_cnpj", fornc_cnpj);
                    command.Parameters.AddWithValue("@fornc_inscricaoEstadual", fornc_inscricaoEstadual );
                    command.Parameters.AddWithValue("@fornc_inscricaoMunicipal", fornc_inscricaoMunicipal);
                    command.Parameters.AddWithValue("@fornc_cep", fornc_cep);
                    command.Parameters.AddWithValue("@fornc_endereco",fornc_endereco);
                    command.Parameters.AddWithValue("@fornc_numero", fornc_numero);
                    command.Parameters.AddWithValue("@fornc_cidade", fornc_cidade);
                    command.Parameters.AddWithValue("@fornc_estado", fornc_estado);
                    command.Parameters.AddWithValue("@fornc_representante", fornc_representante);
                    command.Parameters.AddWithValue("@fornc_email", fornc_email);
                    command.Parameters.AddWithValue("@fornc_telefone", fornc_telefone);
                    //command.Parameters.AddWithValue("@fornc_iniciocontrato", fornc_iniciocontrato);
                   // command.Parameters.AddWithValue("@fornc_status", fornc_status);


                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        throw new Exception("Erro problemas ao atualizar o banco de dados. \n" + erro.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Registro atualizado com sucesso.");

                        consulta_fornecedores frm = new consulta_fornecedores();
                        frm.ShowDialog();

                    }
                }
            }
        }


        private void dtv_fornecedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_fornecedores.Rows[e.RowIndex];



                // Preencha os TextBox com os valores da linha selecionada
                txb_nomefantasia.Text = row.Cells["nomefantasia_Fornecedor"].Value.ToString();
                txb_razaosocial.Text = row.Cells["razaosocial_Fornecedor"].Value.ToString();
                txb_inscricaoEstadual.Text = row.Cells["inscricaoEstadual_Fornecedor"].Value.ToString();
                txb_inscricaoMunicipal.Text = row.Cells["inscricaoMunicipal_Fornecedor"].Value.ToString();
                txb_cep.Text = row.Cells["cep_Fornecedor"].Value.ToString();
                txb_endereco.Text = row.Cells["endereco_Fornecedor"].Value.ToString();
                txb_numero.Text = row.Cells["numero_Fornecedor"].Value.ToString();
                txb_cidade.Text = row.Cells["cidade_Fornecedor"].Value.ToString();
                cmb_estado.Text = row.Cells["estado_Fornecedor"].Value.ToString();
                txb_email.Text = row.Cells["email_Fornecedor"].Value.ToString();
                txb_contato.Text = row.Cells["telefone_Fornecedor"].Value.ToString();
                txb_representante.Text = row.Cells["representante_Fornecedor"].Value.ToString();
                cod_fornecedores.Text = row.Cells["codigo_Fornecedor"].Value.ToString();

                if (cbox_fornecedores.Checked)
                {
                    btn_ativar.Visible = true;
                    button_excluir.Visible = false;
                    btn_salvar.Visible = false;
                }
                else
                {
                    button_excluir.Visible = true;
                    btn_salvar.Visible = true;
                    btn_ativar.Visible = false;
                }
            }
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {

            int id_fornecedor = int.Parse(cod_fornecedores.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            excluir_cliente(id_fornecedor);
        }
        private void excluir_cliente(int id_fornecedor)
        {
            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Fornecedores SET status_Fornecedor = 0 WHERE codigo_Fornecedor = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", id_fornecedor); // Substitua pelo ID correto do colaborador que você deseja atualizar


                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        throw new Exception("Erro problemas ao atualizar o banco de dados. \n" + erro.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Registro atualizado com sucesso.");

                        consulta_fornecedores frm = new consulta_fornecedores();
                        frm.ShowDialog();

                    }
                    connection.Close();
                }
            }


        }

        private void btn_ativar_Click(object sender, EventArgs e)
        {

            int id_fornecedor = int.Parse(cod_fornecedores.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            ativar_colaborador(id_fornecedor);
        }
        private void ativar_colaborador(int id_fornecedor)
        {
            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Fornecedores SET status_Fornecedor = 1 WHERE codigo_Fornecedor = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", id_fornecedor); // Substitua pelo ID correto do colaborador que você deseja atualizar


                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        throw new Exception("Erro problemas ao atualizar o banco de dados. \n" + erro.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Registro atualizado com sucesso.");

                        consulta_fornecedores frm = new consulta_fornecedores();
                        frm.ShowDialog();

                    }
                }
                connection.Close();

            }
        }

    }
}
