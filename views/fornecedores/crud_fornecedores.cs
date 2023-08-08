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
        public crud_fornecedores()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {


            string fornc_nomeFantasia = txb_nomefantasia.Text;
            string fornc_razaoSocial = txb_razaosocial.Text;
            string fornc_cnpj = txb_cnpj.Text;
            string fornc_inscricaoEstadual = txb_inscricaoEstadual.Text;
            string fornc_inscricaoMunicipal = txb_inscricaoMunicipal.Text;
            string fornc_cep = txb_cep.Text;
            string fornc_endereco =txb_endereco.Text;
            string fornc_numero =txb_numero.Text;
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
                    Fornecedores fornecedor = new Fornecedores(fornc_nomeAbreviado, fornc_CNPJ, fornc_CEP, fornc_endereco, fornc_cidade, fornc_estado, fornc_telefone, fornc_nomeRepresentante, fornc_email, fornc_status);
                    fornecedorDAO.InsertFornecedor(fornecedor);
                }
                else
                {
                    Fornecedores fornecedor = new Fornecedores(codigo_Fornecedor, fornc_nomeAbreviado, fornc_CNPJ, fornc_CEP, fornc_endereco, fornc_cidade, fornc_estado, fornc_telefone, fornc_nomeRepresentante, fornc_email, fornc_status);
                    fornecedorDAO.UpdateFornecedor(fornecedor);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txbnomeAbreviado_Fornecedor.Focus();
                if (erro.Message.ToUpper().Contains("NOME REPRESENTANTE"))
                    txbCNPJ_Fornecedor.Focus();
                if (erro.Message.ToUpper().Contains("CNPJ"))
                    txbCEP_Fornecedor.Focus();
                if (erro.Message.ToUpper().Contains("TELEFONE"))
                    txbendereco_Fornecedor.Focus();
                if (erro.Message.ToUpper().Contains("EMAIL"))
                    txbcidade_Fornecedor.Focus();
                if (erro.Message.ToUpper().Contains("NOME REPRESENTANTE"))
                    cmbEstado.Focus();
                if (erro.Message.ToUpper().Contains("CNPJ"))
                    txbtelefone_Fornecedor.Focus();
                if (erro.Message.ToUpper().Contains("TELEFONE"))
                    txbrepresentante_Fornecedor.Focus();
                if (erro.Message.ToUpper().Contains("EMAIL"))
                    txbemail_Fornecedor.Focus();
                return;
            }
            listaFornecedores();
            //btn_LimparCamposFornecedor_Click(null, null);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
