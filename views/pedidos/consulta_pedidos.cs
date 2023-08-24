using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2023.views.pedidos
{
    public partial class consulta_pedidos : Form
    {
        public consulta_pedidos()
        {
            InitializeComponent();
        }

        private void consulta_pedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidosTableAdapter.Fill(this.estampariadbDataSet.Pedidos);

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_pedidos((dt)))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("ped_codigo", typeof(int));
            dt.Columns.Add("colab_codigo", typeof(int));
            dt.Columns.Add("cli_codigo", typeof(int));
            dt.Columns.Add("ped_cor");
            dt.Columns.Add("ped_tecido");
            dt.Columns.Add("ped_formato");
            dt.Columns.Add("ped_gola");
            dt.Columns.Add("ped_tecnica");
           // dt.Columns.Add("ped_estampa", typeof(byte[]));
            dt.Columns.Add("ped_tamP", typeof(int));
            dt.Columns.Add("ped_tamM", typeof(int));
            dt.Columns.Add("ped_tamG", typeof(int));
            dt.Columns.Add("ped_disponibilizadoCli", typeof(int));
            dt.Columns.Add("ped_quantDisponibilizado", typeof(int));
            dt.Columns.Add("ped_totalCamisetas", typeof(int));
            dt.Columns.Add("ped_Datainicial", typeof(DateTime));
            dt.Columns.Add("ped_DataEntrega", typeof(DateTime));
            dt.Columns.Add("ped_valorUnitario", typeof(decimal));
            dt.Columns.Add("ped_valorTotal", typeof(decimal));
            dt.Columns.Add("ped_valorEntrada", typeof(decimal));
            dt.Columns.Add("ped_valorAberto", typeof(decimal));
            dt.Columns.Add("ped_formaPagamentoEntrada");
            dt.Columns.Add("ped_formaPagamentoFinal");
            dt.Columns.Add("ped_status");


            foreach (DataGridViewRow item in dtv_pedidos.Rows)
            {
                dt.Rows.Add(Convert.ToInt32(item.Cells[0].Value),
                            Convert.ToInt32(item.Cells[1].Value),
                            Convert.ToInt32(item.Cells[2].Value),
                                            item.Cells[3].Value,
                                            item.Cells[4].Value,
                                            item.Cells[5].Value,
                                            item.Cells[6].Value,
                                            item.Cells[7].Value,
                            // Convert.ToByte(item.Cells[8].Value),
                            Convert.ToInt32(item.Cells[9].Value),
                            Convert.ToInt32(item.Cells[10].Value),
                            Convert.ToInt32(item.Cells[11].Value),
                            Convert.ToInt32(item.Cells[12].Value),
                            Convert.ToInt32(item.Cells[13].Value),
                            Convert.ToInt32(item.Cells[14].Value),
                         Convert.ToDateTime(item.Cells[15].Value),
                         Convert.ToDateTime(item.Cells[16].Value),
                          Convert.ToDecimal(item.Cells[17].Value),
                          Convert.ToDecimal(item.Cells[18].Value),
                          Convert.ToDecimal(item.Cells[19].Value),
                          Convert.ToDecimal(item.Cells[20].Value),
                                            item.Cells[21].Value,
                                            item.Cells[22].Value,
                                            item.Cells[23].Value);
            }
            return dt;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
