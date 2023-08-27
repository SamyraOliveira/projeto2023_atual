using projeto2023.views.pedidos;
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


        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
