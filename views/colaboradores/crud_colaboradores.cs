using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using projeto2023.controllers;
using projeto2023.models;


namespace projeto2023.views.colaboradores
{
    public partial class crud_colaboradores : Form
    {
        public int codigo_Funcionario = -1;
        public crud_colaboradores()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int colab_codigo = 1;
            string fun_CPF = txb_cpf.Text;
         //   MessageBox.Show(fun_CPF, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string fun_cargo = cmb_cargo.Text;
            string fun_telefone = textBox3.Text;
            string fun_email = txb_email.Text;
            string fun_estado= cmb_estado.Text;
            string fun_cidade = txb_cidade.Text; 
            string fun_endereco = txb_endereco.Text;
            string fun_bairro = txb_bairro.Text;
            string fun_CEP = txb_cep.Text;
            string fun_nome = txb_nome.Text;
            DateTime fun_dataNasc = new DateTime(2007, 1, 21);
            fun_dataNasc = mnth_dataNasc.SelectionStart;
            string fun_usuario = txb_usuario.Text;
            string fun_senha = txb_senha.Text;
            int fun_status = 1;

            MessageBox.Show("FINALIZAR CADASTRO");
            try
            {
                //ligacao no banco de dados
                AddBanco colaboradorDAO = new AddBanco();

                if (codigo_Funcionario == -1)
                {
                    Colaboradores colaborador = new Colaboradores(fun_CPF, fun_cargo, fun_telefone, fun_email, fun_estado, fun_cidade, fun_endereco, fun_bairro, fun_CEP, fun_nome, fun_dataNasc, fun_usuario, Security.Hash_login(fun_senha), fun_status);
                    colaboradorDAO.InsertColaborador(colaborador);
                }
                else
                {
                    Colaboradores colaborador = new Colaboradores(colab_codigo,fun_CPF, fun_cargo, fun_telefone, fun_email, fun_estado, fun_cidade, fun_endereco, fun_bairro, fun_CEP, fun_nome, fun_dataNasc, fun_usuario, Security.Hash_login(fun_senha), fun_status);
                    colaboradorDAO.UpdateColaborador(colaborador);
                }
            }
            catch (Exception erro) {

                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txb_cpf.Focus();

                if (erro.Message.ToUpper().Contains("CPF"))
                    cmb_cargo.Focus();
                if (erro.Message.ToUpper().Contains("TELEFONE"))
                    textBox3.Focus();
                if (erro.Message.ToUpper().Contains("EMAIL"))
                    txb_email.Focus();
                if (erro.Message.ToUpper().Contains("ESTADO"))
                    cmb_estado.Focus();
                if (erro.Message.ToUpper().Contains("CIDADE"))
                    txb_cidade.Focus();
                if (erro.Message.ToUpper().Contains("ENDEREÇO"))
                    txb_endereco.Focus();
                if (erro.Message.ToUpper().Contains("BAIRRO"))
                    txb_bairro.Focus();
                if (erro.Message.ToUpper().Contains("CEP"))
                    txb_cep.Focus();
                if (erro.Message.ToUpper().Contains("NOME"))
                    txb_nome.Focus();
                if (erro.Message.ToUpper().Contains("DATA NASCIMENTO"))
                    mnth_dataNasc.Focus();
                if (erro.Message.ToUpper().Contains("USUARIO"))
                    txb_usuario.Focus();
                if (erro.Message.ToUpper().Contains("SENHA"))
                    txb_senha.Focus();


                return;
            }
            //listaColaboradores();
           btn_limpar_Click(null, null);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            //cpf
            txb_cpf.Clear();
            cmb_cargo.SelectedIndex = -1;
            //telefone
            textBox3.Clear();
            txb_email.Clear();
            cmb_estado.SelectedIndex = -1;
            txb_cidade.Clear();
            txb_endereco.Clear();
            txb_bairro.Clear();
            //cep
            txb_cep.Clear();
            txb_nome.Clear();
            txb_usuario.Clear();
            txb_senha.Clear();
            btn_excluir.Visible = false;
            codigo_Funcionario = -1;
            //ListarColaboradores();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            AddBanco funcionarioDAO = new AddBanco();

            try
            {
                funcionarioDAO.DeleteColaborador(codigo_Funcionario);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //            btnClear_Click(null, null);
            Update();
           // ListarColaboradores();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crud_colaboradores_Load(object sender, EventArgs e)
        {
            string[] estados = {
                "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
                "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí",
                "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia",
                "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins"
            };
            cmb_estado.Items.AddRange(estados);


            string[] cargos = {
                "Supervisor", "Atendente", "Operador"
            };
            cmb_cargo.Items.AddRange(cargos);

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
