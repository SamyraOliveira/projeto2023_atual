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

namespace projeto2023.views.fornecedores
{
    public partial class crud_fornecedores : Form
    {
        public int codigo_Fornecedor = -1;
        public crud_fornecedores()
        {
            InitializeComponent();
        }

        private void crud_fornecedores_Load(object sender, EventArgs e)
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

        private void btn_salvar_n_Click(object sender, EventArgs e)
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
            DateTime fornc_iniciocontrato = new DateTime(2007, 1, 21);
            fornc_iniciocontrato = mnth_contrato.SelectionStart;
            int fornc_status = 1;


            MessageBox.Show("FINALIZAR CADASTRO");
            try
            {
                //ligacao no banco de dados
                AddBanco fornecedorDAO = new AddBanco();

                if (codigo_Fornecedor == -1)
                {
                    Fornecedores fornecedor = new Fornecedores(fornc_nomeFantasia, fornc_razaoSocial, fornc_cnpj, fornc_inscricaoEstadual, fornc_inscricaoMunicipal, fornc_cep, fornc_endereco, fornc_numero, fornc_cidade, fornc_estado, fornc_representante, fornc_email, fornc_telefone, fornc_iniciocontrato, fornc_status);
                    fornecedorDAO.InsertFornecedor(fornecedor);
                }
                else
                {
                    Fornecedores fornecedor = new Fornecedores(codigo_Fornecedor, fornc_nomeFantasia, fornc_razaoSocial, fornc_cnpj, fornc_inscricaoEstadual, fornc_inscricaoMunicipal, fornc_cep, fornc_endereco, fornc_numero, fornc_cidade, fornc_estado, fornc_representante, fornc_email, fornc_telefone, fornc_iniciocontrato, fornc_status);
                    fornecedorDAO.UpdateFornecedor(fornecedor);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txb_nomefantasia.Focus();
                if (erro.Message.ToUpper().Contains(" "))

                    txb_razaosocial.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    txb_cnpj.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    txb_inscricaoEstadual.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    txb_inscricaoMunicipal.Focus();
                if (erro.Message.ToUpper().Contains(" "))

                    txb_cep.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    txb_endereco.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    txb_numero.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    txb_cidade.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    cmb_estado.Focus();
                if (erro.Message.ToUpper().Contains(" "))

                    txb_representante.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    txb_email.Focus();
                if (erro.Message.ToUpper().Contains(""))

                    txb_contato.Focus();
                if (erro.Message.ToUpper().Contains(""))
                    mnth_contrato.Focus();

                return;
            }
            //listaFornecedores();
            btn_limpar_n_Click(null, null);

        }

        private void btn_excluir_n_Click(object sender, EventArgs e)
        {
            AddBanco fornecedoresDAO = new AddBanco();

            try
            {
                fornecedoresDAO.DeleteFornecedor(codigo_Fornecedor);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Update();

            btn_limpar_n_Click(null, null);
        }

        private void btn_limpar_n_Click(object sender, EventArgs e)
        {
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
            btn_excluir_n.Visible = false;
            codigo_Fornecedor = -1;
            // listaFornecedores();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
