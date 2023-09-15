using projeto2023.controllers;
using projeto2023.models;
using projeto2023.views.pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static projeto2023.models.Colaboradores;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace projeto2023.views.colaboradores
{
    public partial class consulta_colaboradores : Form
    {
        public consulta_colaboradores()
        {
            InitializeComponent();
        }

        private void consulta_colaboradores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1.Colaboradores'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradoresTableAdapter1.Fill(this.estampariadbDataSet1.Colaboradores);
            colaboradoresBindingSource2.Filter = "status_Colaborador = 1";
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1_COLABORADORES.Colaboradores'. Você pode movê-la ou removê-la conforme necessário.
            //con = new Connection();
            //this.colaboradoresTableAdapter.Fill(this.estampariadbDataSet1_COLABORADORES.Colaboradores);


        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_colaboradores((dt)))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("codigo_Colaborador", typeof(int));
            dt.Columns.Add("CPF_Colaborador");
            dt.Columns.Add("cargo_Colaborador");
            dt.Columns.Add("telefone_Colaborador");
            dt.Columns.Add("email_Colaborador");
            dt.Columns.Add("estado_Colaborador");
            dt.Columns.Add("cidade_Colaborador");
            dt.Columns.Add("endereco_Colaborador");
            dt.Columns.Add("bairro_Colaborador");
            dt.Columns.Add("CEP_Colaborador");
            dt.Columns.Add("nome_Colaborador");
            dt.Columns.Add("dataNasc_Colaborador", typeof(DateTime));
            dt.Columns.Add("user_Colaborador");
            dt.Columns.Add("password_Colaborador");
            dt.Columns.Add("status_Colaborador");

            foreach (DataGridViewRow item in dtv_colaboradores.Rows)
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
                         Convert.ToDateTime(item.Cells[11].Value),
                                            item.Cells[12].Value,
                                            item.Cells[13].Value,
                            Convert.ToInt32(item.Cells[14].Value));

                ;
            }
            return dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtv_colaboradores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_colaboradores.Rows[e.RowIndex];

                // Preencha os TextBox com os valores da linha selecionada
                txb_nome.Text = row.Cells["nome_colaborador"].Value.ToString();
                txb_usuario.Text = row.Cells["nome_colaborador"].Value.ToString();
                txb_senha.Text = row.Cells["pass_colaborador"].Value.ToString();
                txb_cpf.Text = row.Cells["cpf_colaborador"].Value.ToString();
                cmb_cargo.Text = row.Cells["cargo_colaborador"].Value.ToString();
                tcbtelefone.Text = row.Cells["telefone_colaborador"].Value.ToString();
                txb_email.Text = row.Cells["email_colaborador"].Value.ToString();
                txb_estado.Text = row.Cells["estado_colaborador"].Value.ToString();
                txb_cidade.Text = row.Cells["cidade_colaborador"].Value.ToString();
                txb_endereco.Text = row.Cells["endereco_colaborador"].Value.ToString();
                txb_bairro.Text = row.Cells["bairro_colaborador"].Value.ToString();
                txb_cep.Text = row.Cells["cep_colaborador"].Value.ToString();
                cod_colab.Text = row.Cells["cod_colaborador"].Value.ToString();

                //button_excluir.Visible = true;
                //btn_salvar.Visible = true;
                if (checkbox_status.Checked)
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
            
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            //cpf
            txb_cpf.Clear();
            cmb_cargo.SelectedIndex = -1;
            //telefone
            txb_endereco.Clear();
            txb_estado.SelectedIndex = -1;
            tcbtelefone.Clear();
            txb_email.Clear();
            //cmb_estado.SelectedIndex = -1;
            txb_cidade.Clear();
            txb_endereco.Clear();
            txb_bairro.Clear();
            //cep
            txb_cep.Clear();
            txb_nome.Clear();
            txb_usuario.Clear();
            txb_senha.Clear();
            cod_colab.Clear();

            btn_ativar.Visible = true;
            button_excluir.Visible = false;
            btn_salvar.Visible = false;

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Obtenha os dados atualizados dos campos
            string nome = txb_nome.Text;
            string usuario = txb_usuario.Text;
            string senha = txb_senha.Text;
            string cpf = txb_cpf.Text;
            string cargo = cmb_cargo.Text;
            string telefone = tcbtelefone.Text;
            string email = txb_email.Text;
            string estado = txb_estado.Text;
            string cidade = txb_cidade.Text;
            string endereco = txb_endereco.Text;
            string bairro = txb_bairro.Text;
            string cep = txb_cep.Text;
            int id = int.Parse(cod_colab.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            AtualizarRegistroNaBaseDeDados(id, nome, usuario, senha, cpf, cargo, telefone, email, estado, cidade, endereco, bairro, cep);

            // Após salvar, você pode definir DialogResult para OK para indicar que as alterações foram salvas com sucesso
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AtualizarRegistroNaBaseDeDados(int id, string nome, string usuario, string senha, string cpf, string cargo, string telefone, string email, string estado, string cidade, string endereco, string bairro, string cep)
        {
            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            // Isso dependerá da sua estrutura de banco de dados e da forma como você interage com ela
            // Você precisará executar uma consulta SQL ou chamar um método apropriado aqui

            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Colaboradores SET nome_Colaborador = @Nome, user_Colaborador = @Usuario, password_Colaborador = @Senha, CPF_Colaborador = @CPF, cargo_Colaborador = @Cargo, telefone_Colaborador = @Telefone, email_Colaborador = @Email, estado_Colaborador = @Estado, cidade_Colaborador = @Cidade, endereco_Colaborador = @Endereco, bairro_Colaborador = @Bairro, CEP_Colaborador = @CEP WHERE codigo_Colaborador = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Senha", senha);
                    command.Parameters.AddWithValue("@CPF", cpf);
                    command.Parameters.AddWithValue("@Cargo", cargo);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@Cidade", cidade);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@Bairro", bairro);
                    command.Parameters.AddWithValue("@CEP", cep);
                    command.Parameters.AddWithValue("@ID", id); // Substitua pelo ID correto do colaborador que você deseja atualizar

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

                        consulta_colaboradores frm = new consulta_colaboradores();
                        frm.ShowDialog();

                    }
                }
            }
        }

        private void excluir_colaborador(int id_colaborador)
        {
            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Colaboradores SET status_Colaborador = 0 WHERE codigo_Colaborador = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", id_colaborador); // Substitua pelo ID correto do colaborador que você deseja atualizar


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

                        consulta_colaboradores frm = new consulta_colaboradores();
                        frm.ShowDialog();

                    }
                    connection.Close();
                }
            }
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {

            int id_colaborador = int.Parse(cod_colab.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            excluir_colaborador(id_colaborador);
        }


        private void checkbox_status_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_status.Checked)
            {
                // Quando o CheckBox estiver marcado (habilitado)
                colaboradoresBindingSource2.Filter = "status_Colaborador = 0";
                button_excluir.Visible = true;
                btn_salvar.Visible = true;
            }
            else
            {
                // Quando o CheckBox não estiver marcado (desabilitado)
                colaboradoresBindingSource2.Filter = "status_Colaborador = 1";
                button_excluir.Visible = false;
                btn_salvar.Visible = false;
            }
            dtv_colaboradores.Refresh();
            //cpf
            txb_cpf.Clear();
            cmb_cargo.SelectedIndex = -1;
            //telefone
            txb_endereco.Clear();
            txb_estado.SelectedIndex = -1;
            tcbtelefone.Clear();
            txb_email.Clear();
            //cmb_estado.SelectedIndex = -1;
            txb_cidade.Clear();
            txb_endereco.Clear();
            txb_bairro.Clear();
            //cep
            txb_cep.Clear();
            txb_nome.Clear();
            txb_usuario.Clear();
            txb_senha.Clear();
            cod_colab.Clear();

            btn_ativar.Visible = true;
            button_excluir.Visible = false;
            btn_salvar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id_colaborador = int.Parse(cod_colab.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            ativar_colaborador(id_colaborador);
        }
        private void ativar_colaborador(int id_colaborador)
        {
            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Colaboradores SET status_Colaborador = 1 WHERE codigo_Colaborador = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", id_colaborador); // Substitua pelo ID correto do colaborador que você deseja atualizar


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

                        consulta_colaboradores frm = new consulta_colaboradores();
                        frm.ShowDialog();

                    }

                }

            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisa = txtPesquisa.Text.Trim();

            if (!string.IsNullOrEmpty(nomePesquisa))
            {
                colaboradoresBindingSource2.Filter = $"nome_colaborador LIKE '%{nomePesquisa}%'";
            }
            else
            {
                colaboradoresBindingSource2.RemoveFilter();
            }

            dtv_colaboradores.Refresh();
        }
    }
}
