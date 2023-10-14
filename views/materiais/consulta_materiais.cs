using projeto2023.views.fornecedores;
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

namespace projeto2023.views.materiais
{
    public partial class consulta_materiais : Form
    {
        public consulta_materiais()
        {
            InitializeComponent();
        }

        private void consulta_materiais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1_MATERIAIS.Materiais'. Você pode movê-la ou removê-la conforme necessário.
            this.materiaisTableAdapter.Fill(this.estampariadbDataSet1_MATERIAIS.Materiais);

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_materiais((dt)))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("codigo_Material", typeof(int));
            dt.Columns.Add("codigo_Fornecedor", typeof(int));
            dt.Columns.Add("nome_Material");
            dt.Columns.Add("descricao");
            dt.Columns.Add("unidadeMedida");
            dt.Columns.Add("precoUnitario", typeof(decimal));
            dt.Columns.Add("dataEntrada", typeof(DateTime));
            dt.Columns.Add("numeroLote");
            dt.Columns.Add("localArmazenamento");
            dt.Columns.Add("quantidade_Material", typeof(int));
            dt.Columns.Add("UltimaAtualizacao", typeof(DateTime));
            dt.Columns.Add("status_Pedido");


            foreach (DataGridViewRow item in dtv_materiais.Rows)
            {
                dt.Rows.Add(Convert.ToInt32(item.Cells[0].Value),
                            Convert.ToInt32(item.Cells[1].Value),
                                            item.Cells[2].Value,
                                            item.Cells[3].Value,
                                            item.Cells[4].Value,
                          Convert.ToDecimal(item.Cells[5].Value),
                         Convert.ToDateTime(item.Cells[6].Value),
                                            item.Cells[7].Value,
                                            item.Cells[8].Value,
                            Convert.ToInt32(item.Cells[9].Value),
                         Convert.ToDateTime(item.Cells[10].Value),
                                            item.Cells[11].Value);
            }
            return dt;
        }

        private void label_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtv_materiais_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_materiais.Rows[e.RowIndex];



                // Preencha os TextBox com os valores da linha selecionada
                cod_Material.Text = row.Cells["codigo_Material"].Value.ToString();
                cmb_idFornecedor.Text = row.Cells["codigo_Fornecedor"].Value.ToString();
                txb_nomeMaterial.Text = row.Cells["nome_Material"].Value.ToString();
                cmb_unidadeMedida.Text = row.Cells["unidadeMedida"].Value.ToString();
                txb_numeroLote.Text = row.Cells["numeroLote"].Value.ToString();
                txb_precoUnit.Text = row.Cells["precoUnitario"].Value.ToString();
                txb_descricao.Text = row.Cells["descricao"].Value.ToString();
                cmb_localArmazenamento.Text = row.Cells["localArmazenamento"].Value.ToString();
                txb_quantEntrada.Text = row.Cells["quantidade_Material"].Value.ToString();
                mnth_dataEntrada.Text = row.Cells["dataEntrada"].Value.ToString();
                mnth_ultimaAtualizacao.Text = row.Cells["UltimaAtualizacao"].Value.ToString();


                if (cbox_materiais.Checked)
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

        private void btn_ativar_Click(object sender, EventArgs e)
        {
            int cod_material = int.Parse(cod_Material.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            ativar_material(cod_material);
        }
        private void ativar_material(int cod_material)
        {
            string connectionString = @"Data Source=" + Environment.MachineName + ";Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Materiais SET status_Materiais = 1 WHERE cod_Material = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", cod_material); // Substitua pelo ID correto do colaborador que você deseja atualizar


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

                        consulta_materiais frm = new consulta_materiais();
                        frm.ShowDialog();

                    }
                }
                connection.Close();

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(cod_Material.Text);
            int fornc_codigo = int.Parse(cmb_idFornecedor.Text);
            string mat_nome = txb_nomeMaterial.Text;
            string mat_descricao = txb_descricao.Text;
            string mat_unidadeMedida = cmb_unidadeMedida.Text;
            float mat_precoUnit = float.Parse(txb_precoUnit.Text);
            DateTime mat_dataEntrada = DateTime.Parse(mnth_dataEntrada.Text);
            // mat_fornecedor = mate_fornecedor;
            int mat_numLote = int.Parse(txb_numeroLote.Text);
            string mat_localArmazenamento = cmb_localArmazenamento.Text;
            int mat_quantidade = int.Parse(txb_quantEntrada.Text);
            string mat_ultimaAtualizacao = mnth_ultimaAtualizacao.Text;
            int mat_status = 0;
            

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            AtualizarRegistroNaBaseDeDadosFornecedores(id, fornc_codigo, mat_nome, mat_descricao, mat_unidadeMedida, mat_precoUnit, mat_dataEntrada, mat_numLote, mat_localArmazenamento, mat_quantidade, mat_ultimaAtualizacao, mat_status);

            // Após salvar, você pode definir DialogResult para OK para indicar que as alterações foram salvas com sucesso
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AtualizarRegistroNaBaseDeDadosFornecedores(int id, int fornc_codigo, string mat_nome, string mat_descricao, string mat_unidadeMedida, float mat_precoUnit, DateTime mat_dataEntrada, int mat_numLote, string mat_localArmazenamento, int mat_quantidade, string mat_ultimaAtualizacao, int mat_status)

        {
            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            // Isso dependerá da sua estrutura de banco de dados e da forma como você interage com ela
            // Você precisará executar uma consulta SQL ou chamar um método apropriado aqui
            // Fornecedores fornecedor = new Fornecedores(id, fornc_nomeFantasia, fornc_razaoSocial, fornc_cnpj, fornc_inscricaoEstadual, fornc_inscricaoMunicipal, fornc_cep, fornc_endereco, fornc_numero, fornc_cidade, fornc_estado, fornc_representante, fornc_email, fornc_telefone, fornc_iniciocontrato, fornc_status);
            // fornecedorDAO.UpdateFornecedor(fornecedor);

            string connectionString = @"Data Source=" + Environment.MachineName + ";Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server
                                                                                                                                             //Connection conn = new Connection(); 


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"UPDATE Materiais SET nome_Material = @nome_Material, descricao = @descricao , unidade_Medida = @unidade_Medida, precoUnitario = @precoUnitario, dataEntrada = @dataEntrada, numeroLote = @numeroLote,"+
                            "localArmazenamento = @localArmazenamento, quantidadeMaterial = @quantidadeMaterial, ultimaAtualizacao = @ultimaAtualizacao, status_material = @status_material WHERE codigo_Material = @codigo_Material "; 

                using (SqlCommand command = new SqlCommand(sql, connection))
                {


                    command.Parameters.AddWithValue("@cod_Material", id);
                    command.Parameters.AddWithValue("@codigo_Fornedor", fornc_codigo);
                    command.Parameters.AddWithValue("@nome_Material", mat_nome);
                    command.Parameters.AddWithValue("@descricao", mat_descricao);
                    command.Parameters.AddWithValue("@unidade_Medida", mat_unidadeMedida);
                    command.Parameters.AddWithValue("@precoUnitario", mat_precoUnit);
                    command.Parameters.AddWithValue("@dataEntrada", mat_dataEntrada);
                    command.Parameters.AddWithValue("@numeroLote", mat_numLote);
                    command.Parameters.AddWithValue("@localArmazenamento", mat_localArmazenamento);
                    command.Parameters.AddWithValue("@quantidade_Material", mat_quantidade);
                    command.Parameters.AddWithValue("@ultimaAtualizacao", mat_ultimaAtualizacao);
                    command.Parameters.AddWithValue("@status_material", mat_status);

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

        private void button_excluir_Click(object sender, EventArgs e)
        {
            int cod_material = int.Parse(cod_Material.Text);

            // Implemente a lógica para atualizar o registro na base de dados com os valores atualizados
            excluir_cliente(cod_material);
        }
        private void excluir_cliente(int cod_material)
        {
            string connectionString = @"Data Source=" + Environment.MachineName + ";Initial Catalog=Estampariadb;Integrated Security=True;"; // Substitua pela sua string de conexão com o SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Materiais SET status_Material = 0 WHERE cod_Material = @ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", cod_material); // Substitua pelo ID correto do colaborador que você deseja atualizar


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

                        consulta_materiais frm = new consulta_materiais();
                        frm.ShowDialog();

                    }
                    connection.Close();
                }
            }


        }

        private void cbox_materiais_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_materiais.Checked)
            {
                // Quando o CheckBox estiver marcado (habilitado)
                materiaisBindingSource.Filter = "status_material = 0";

            }
            else
            {
                // Quando o CheckBox não estiver marcado (desabilitado)
                materiaisBindingSource.Filter = "status_material = 1";

            }

            cod_Material.Clear();
            cmb_idFornecedor.SelectedIndex = -1;
            txb_nomeMaterial.Clear();
            cmb_unidadeMedida.SelectedIndex = -1;
            txb_numeroLote.Clear();
            txb_precoUnit.Clear();
            txb_descricao.Clear();
            cmb_localArmazenamento.SelectedIndex = -1;
            txb_quantEntrada.Clear();
            //mnth_dataEntrada.SelectedIndex = -1;
            //mnth_ultimaAtualizacao.SelectedIndex = -1;

            btn_ativar.Visible = false;
            button_excluir.Visible = false;
            btn_salvar.Visible = false;

            dtv_materiais.Refresh();
        }
    }
}
