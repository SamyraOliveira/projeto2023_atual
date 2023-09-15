using projeto2023.views.colaboradores;
using projeto2023.views.fornecedores;
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

namespace projeto2023.views.clientes
{
    public partial class consulta_clientes : Form
    {
        public consulta_clientes()
        {
            InitializeComponent();
        }

        private void consulta_clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1_CLIENTES.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.estampariadbDataSet1_CLIENTES.Clientes);
            clientesBindingSource.Filter = "status_Cliente = 1";

        }

        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("codigo_Cliente", typeof(int));
            dt.Columns.Add("nome_Cliente");
            dt.Columns.Add("CPFCNPJ_Cliente");
            dt.Columns.Add("telefone_Cliente");
            dt.Columns.Add("email_Cliente");
            dt.Columns.Add("dataNasc_Cliente");
            dt.Columns.Add("estado_Cliente");
            dt.Columns.Add("cidade_Cliente");
            dt.Columns.Add("endereco_Cliente");
            dt.Columns.Add("CEP_Cliente");
            dt.Columns.Add("status_Cliente");


            foreach (DataGridViewRow item in dtv_clientes.Rows)
            {
                dt.Rows.Add(Convert.ToInt32(item.Cells[0].Value),
                                            item.Cells[1].Value,
                                            item.Cells[2].Value,
                                            item.Cells[3].Value,
                                            item.Cells[4].Value,
                         Convert.ToDateTime(item.Cells[5].Value),
                                            item.Cells[6].Value,
                                            item.Cells[7].Value,
                                            item.Cells[8].Value,
                                            item.Cells[9].Value,
                            Convert.ToInt32(item.Cells[10].Value));
            }
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_clientes((dt)))
            {
                frm.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_clientes.Checked)
            {
                // Quando o CheckBox estiver marcado (habilitado)
                clientesBindingSource.Filter = "status_Cliente = 0";

            }
            else
            {
                // Quando o CheckBox não estiver marcado (desabilitado)
                clientesBindingSource.Filter = "status_Cliente = 1";

            }

            txb_nome.Clear();
            txb_cpf.Clear();
            txb_telefone.Clear();
            txb_email.Clear();
            cmb_estado.SelectedIndex = -1;
            txb_cidade.Clear();
            txb_endereco.Clear();
            txb_cep.Clear();
            //mntc_dataNasc.SelectedIndex = -1;
            cod_cliente.Clear();

            btn_ativar.Visible = false;
            button_excluir.Visible = false;
            btn_salvar.Visible = false;

            dtv_clientes.Refresh();


            //btn_ativar.Visible = false;
            //button_excluir.Visible = false;
           // btn_salvar.Visible = false;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisa = txtPesquisa.Text.Trim();

            if (!string.IsNullOrEmpty(nomePesquisa))
            {
                clientesBindingSource.Filter = $"nome_Cliente LIKE '%{nomePesquisa}%'";
            }
            else
            {
                clientesBindingSource.RemoveFilter();
            }

            dtv_clientes.Refresh();
        }

        private void dtv_clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_clientes.Rows[e.RowIndex];

                // Preencha os TextBox com os valores da linha selecionada
                txb_nome.Text = row.Cells["nome_cliente"].Value.ToString();
                txb_cpf.Text = row.Cells["CPFCNPJ_Cliente"].Value.ToString();
                txb_telefone.Text = row.Cells["telefone_cliente"].Value.ToString();
                txb_email.Text = row.Cells["email_cliente"].Value.ToString();
                cmb_estado.Text = row.Cells["estado_cliente"].Value.ToString();
                txb_cidade.Text = row.Cells["cidade_cliente"].Value.ToString();
                txb_endereco.Text = row.Cells["endereco_cliente"].Value.ToString();
                txb_cep.Text = row.Cells["CEP_Cliente"].Value.ToString();
                cod_cliente.Text = row.Cells["codigo_Cliente"].Value.ToString();
                mntc_dataNasc.Text = row.Cells["dataNasc_Cliente"].Value.ToString();

                if (cbox_clientes.Checked)
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Obtenha os dados atualizados dos campos
            string nome = txb_nome.Text;
            string cpf = txb_cpf.Text;
            string telefone = txb_telefone.Text;
            string email = txb_email.Text;
            string estado = cmb_estado.Text;
            string cidade = txb_cidade.Text;
            string endereco = txb_endereco.Text;
            string cep = txb_cep.Text;
            string data = mntc_dataNasc.Text;
            int id = int.Parse(cod_cliente.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            AtualizarRegistroNaBaseDeDadosClientes(id, nome, cpf, telefone, email, estado, cidade, endereco, cep, data);

            // Após salvar, você pode definir DialogResult para OK para indicar que as alterações foram salvas com sucesso
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AtualizarRegistroNaBaseDeDadosClientes(int id, string nome, string cpf, string telefone, string email, string estado, string cidade, string endereco, string cep, string data)
        {
            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            // Isso dependerá da sua estrutura de banco de dados e da forma como você interage com ela
            // Você precisará executar uma consulta SQL ou chamar um método apropriado aqui

            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Clientes SET nome_Cliente = @Nome, CPFCNPJ_Cliente = @CPF, telefone_Cliente = @Telefone, email_Cliente = @Email, estado_Cliente = @Estado, cidade_Cliente = @Cidade, endereco_Cliente = @Endereco, dataNasc_Cliente = @Data, CEP_Cliente = @CEP WHERE codigo_Cliente = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@CPF", cpf);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@Cidade", cidade);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@CEP", cep);
                    command.Parameters.AddWithValue("@Data", data);
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

                        consulta_clientes frm = new  consulta_clientes();
                        frm.ShowDialog();

                    }
                }
            }
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            int id_cliente = int.Parse(cod_cliente.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            excluir_cliente(id_cliente);
        }
        private void excluir_cliente(int id_cliente)
        {
            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Clientes SET status_Cliente = 0 WHERE codigo_Cliente = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", id_cliente); // Substitua pelo ID correto do colaborador que você deseja atualizar


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

                        consulta_clientes frm = new consulta_clientes();
                        frm.ShowDialog();

                    }
                    connection.Close();
                }
            }
        }

        private void btn_ativar_Click(object sender, EventArgs e)
        {

            int id_cliente = int.Parse(cod_cliente.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            ativar_colaborador(id_cliente);
        }
        private void ativar_colaborador(int id_cliente)
        {
            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Clientes SET status_Cliente = 1 WHERE codigo_Cliente = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", id_cliente); // Substitua pelo ID correto do colaborador que você deseja atualizar


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

                        consulta_clientes frm = new consulta_clientes();
                        frm.ShowDialog();

                    }
                }
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            txb_nome.Clear();
            txb_cpf.Clear();
            txb_telefone.Clear();
            txb_email.Clear();
            cmb_estado.SelectedIndex = -1;
            txb_cidade.Clear();
            txb_endereco.Clear();
            txb_cep.Clear();
            //mntc_dataNasc.SelectedIndex = -1;
            cod_cliente.Clear();

            btn_ativar.Visible = false;
            button_excluir.Visible = false;
            btn_salvar.Visible = false; ;

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    } 
}
