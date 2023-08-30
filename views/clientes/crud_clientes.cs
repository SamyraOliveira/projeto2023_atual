using projeto2023.controllers;
using projeto2023.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2023.views.clientes
{
    public partial class crud_clientes : Form
    {

        public int codigo_Cliente = -1;

        public crud_clientes()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string cli_nome = txb_nome.Text;
            string cli_CPF = txb_cpf.Text;
            string cli_telefone = txb_telefone.Text;
            string cli_email = txb_email.Text;
            DateTime cli_dataNasc = new DateTime(2007, 1, 21);
            cli_dataNasc = mntc_dataNasc.SelectionStart;
            string cli_estado = cmb_estado.Text;
            string cli_cidade = txb_cidade.Text;
            string cli_endereco = txb_endereco.Text;
            string cli_CEP = txb_cep.Text;
            int cli_status = 1;


            MessageBox.Show("FINALIZAR CADASTRO");
            try
            {

                //ligacao no banco de dados
                AddBanco clienteDAO = new AddBanco();
                if (codigo_Cliente == -1)
                {
                    Clientes cliente = new Clientes(cli_nome, cli_CPF, cli_telefone, cli_email, cli_dataNasc, cli_estado, cli_cidade, cli_endereco, cli_CEP, cli_status);
                    clienteDAO.InsertClientes(cliente);
                }
                else
                {
                    Clientes cliente = new Clientes(codigo_Cliente, cli_nome, cli_CPF, cli_telefone, cli_email, cli_dataNasc, cli_estado, cli_cidade, cli_endereco, cli_CEP, cli_status);
                    clienteDAO.UpdateClientes(cliente);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txb_nome.Focus();
                if (erro.Message.ToUpper().Contains("CPF/CNPJ"))
                    txb_cpf.Focus();
                if (erro.Message.ToUpper().Contains("TELEFONE"))
                    txb_telefone.Focus();
                if (erro.Message.ToUpper().Contains("EMAIL"))
                    txb_email.Focus();
                if (erro.Message.ToUpper().Contains("DATA NASCIMENTO"))
                    mntc_dataNasc.Focus();
                if (erro.Message.ToUpper().Contains("ESTADO"))
                    cmb_estado.Focus();
                if (erro.Message.ToUpper().Contains("CIDADE"))
                    txb_cidade.Focus();
                if (erro.Message.ToUpper().Contains("ENDEREÇO"))
                    txb_endereco.Focus();
                if (erro.Message.ToUpper().Contains("CEP"))
                    txb_cep.Focus();


                return;

            }
            //listaClientes();


            btn_limpar_Click(null, null);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            AddBanco clientesDAO = new AddBanco();

            try
            {
                clientesDAO.DeleteClientes(codigo_Cliente);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Update();
            //listaClientes();
            //btn_limpar(null, null);

            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet8.Clientes'. Você pode movê-la ou removê-la conforme necessário.
           // this.clientesTableAdapter1.Fill(this.estampariadbDataSet12Clientes.Clientes);

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_nome.Clear();
            txb_cpf.Clear();
            txb_telefone.Clear();
            txb_email.Clear();
            cmb_estado.SelectedIndex = -1;
            txb_cidade.Clear();
            txb_endereco.Clear();
            txb_cep.Clear();
            btn_excluir.Visible = false;
            codigo_Cliente = -1;
            //listaClientes();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crud_clientes_Load(object sender, EventArgs e)
        {
            string[] estados = {
                "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
                "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí",
                "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia",
                "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins"
            };
            cmb_estado.Items.AddRange(estados);
        }
    }
}
