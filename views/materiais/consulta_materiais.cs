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
    }
}
