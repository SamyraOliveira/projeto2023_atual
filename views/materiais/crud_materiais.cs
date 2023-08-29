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

namespace projeto2023.views.materiais
{
    public partial class crud_materiais : Form
    {
        public int codigo_Material = -1;
        public crud_materiais()
        {
            InitializeComponent();
        }

        private void crud_materiais_Load(object sender, EventArgs e)
        {
            string[] medidas = {
                "Metro", "KG", "UN", "Peça", "Rolo", "Gramas", "Centímetro",
                "Pacote", "Fio", "Metro Quadrado"
            };
            cmb_unidadeMedida.Items.AddRange(medidas);


            string[] armazenamento = {
                "Almoxarifado Geral", "Almoxarifado de Tecidos", "Almoxarifado de Tintas e Produtos Químicos", "Estoque de Pré-Produtos", "Acabamento", "Itens Pronta Entrega", "Armazenamento de Arte e Matrizes",
                "Locais e Expedição"
            };
            cmb_unidadeMedida.Items.AddRange(armazenamento);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cmb_idFornecedor.SelectedIndex = -1;
            txb_nomeMaterial.Clear();
            txb_descricao.Clear();
            cmb_unidadeMedida.SelectedIndex = -1;
            txb_precoUnit.Clear();
           // mnth_dataEntrada.Value = DateTime.Now;
            txb_numeroLote.Clear();
            cmb_localArmazenamento.SelectedIndex = -1;
           // txb_quantEntrada.Value = DateTime.Now;
            cmb_status.SelectedIndex = -1;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            AddBanco materiaisDAO = new AddBanco();

            try
            {
                materiaisDAO.DeleteClientes(codigo_Material);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Update();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int codigo_Fornecedor = cmb_idFornecedor.SelectedIndex;
            string mat_nomeMaterial = txb_nomeMaterial.Text;
            string mat_descricao = txb_descricao.Text;
            decimal mat_precoUnitario = Convert.ToDecimal(txb_precoUnit.Text);
            string mat_numLote = txb_numeroLote.Text;
            DateTime mat_dataInicio = new DateTime(2007, 1, 21);
            mat_dataInicio = mnth_dataEntrada.SelectionStart;
            string mat_armazenamento = cmb_localArmazenamento.Text;
            int mat_quantidade = Convert.ToInt32( txb_quantEntrada.Text);
            string mat_status = "" ;


            MessageBox.Show("FINALIZAR CADASTRO");
            try
            {

                //ligacao no banco de dados
                AddBanco materiaisDAO = new AddBanco();
                if (codigo_Material == -1)
                {
                    Clientes cliente = new Clientes(cli_nome, cli_CPF, cli_telefone, cli_email, cli_dataNasc, cli_estado, cli_cidade, cli_endereco, cli_CEP, cli_status);
                    materiaisDAO.InsertClientes(cliente);
                }
                else
                {
                    Clientes cliente = new Clientes(codigo_Material, cli_nome, cli_CPF, cli_telefone, cli_email, cli_dataNasc, cli_estado, cli_cidade, cli_endereco, cli_CEP, cli_status);
                    materiaisDAO.UpdateClientes(cliente);
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
    }
}
