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

namespace projeto2023.views.movimentacoes
{
    public partial class crud_transacoes : Form
    {
        public crud_transacoes()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Obtenha os valores inseridos pelo usuário, incluindo se é receita ou despesa
            DateTime dataMovimentacao = new DateTime(2007, 1, 21);
            dataMovimentacao = mnth_dataMov.SelectionStart;
            decimal valorMovimentacao = decimal.Parse(txb_valor.Text);
            int categoriaId = (int)cmb_categoria.SelectedValue;
            int contaBancariaId = (int)cmb_conta.SelectedValue;
            int centroDeCustoId = (int)cmb_centroCusto.SelectedValue; // Campo para selecionar o centro de custo
            string descricao = txb_descricao.Text;
            bool isReceita = checked_receita.Checked; // Verifica se é uma receita

            // Verifique se é uma receita ou despesa e crie a transação correspondente
            if (isReceita)
            {
                Receita novaReceita = new Receita
                {
                    Data = dataMovimentacao,
                    Valor = valorMovimentacao,
                    CategoriaId = categoriaId,
                    ContaBancariaId = contaBancariaId,
                    CentroDeCustoId = centroDeCustoId,
                    Descricao = descricao
                };
                // Salve a nova receita no banco de dados ou em uma lista, dependendo da sua implementação
                // ...
            }
            else
            {
                Despesas novaDespesa = new Despesas
                {
                    Data = dataMovimentacao,
                    Valor = valorMovimentacao,
                    CategoriaId = categoriaId,
                    ContaBancariaId = contaBancariaId,
                    CentroDeCustoId = centroDeCustoId,
                    Descricao = descricao
                };
                // Salve a nova despesa no banco de dados ou em uma lista, dependendo da sua implementação
                // ...
            }
        }
    }
}
