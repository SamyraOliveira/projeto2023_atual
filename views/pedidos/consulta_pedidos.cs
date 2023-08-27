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
                dt.Columns.Add("codigo_Pedido", typeof(int));
                dt.Columns.Add("codigo_Colaborador", typeof(int));
                dt.Columns.Add("codigo_Cliente", typeof(int));
                dt.Columns.Add("corCamiseta_Pedido");
                dt.Columns.Add("tecidoCamiseta_Pedido");
                dt.Columns.Add("formatoCamiseta_Pedido");
                dt.Columns.Add("tipoGola_Pedido");
                dt.Columns.Add("tecnicas_Pedido");
               // dt.Columns.Add("ped_estampa", typeof(byte[]));
                dt.Columns.Add("tamP_quant_Pedido", typeof(int));
                dt.Columns.Add("tamM_quant_Pedido", typeof(int));
                dt.Columns.Add("tamG_quant_Pedido", typeof(int));
                dt.Columns.Add("diponibilizadoCliente", typeof(int));
                dt.Columns.Add("quantdisponibilizadoCliente", typeof(int));
                dt.Columns.Add("totalCamisetas_Pedido", typeof(int));
                dt.Columns.Add("data_inicial", typeof(DateTime));
                dt.Columns.Add("data_entrega", typeof(DateTime));
                dt.Columns.Add("valorUnit_Pedido", typeof(decimal));
                dt.Columns.Add("valorTotal_Pedido", typeof(decimal));
                dt.Columns.Add("valorEntrada_Pedido", typeof(decimal));
                dt.Columns.Add("valorAberto_Pedido", typeof(decimal));
                dt.Columns.Add("formaPagamentoEntrada_Pedido");
                dt.Columns.Add("formaPagamentoFinal_Pedido");
                dt.Columns.Add("status_Pedido");


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
                                Convert.ToInt32(item.Cells[8].Value),
                                Convert.ToInt32(item.Cells[9].Value),
                                Convert.ToInt32(item.Cells[10].Value),
                                Convert.ToInt32(item.Cells[11].Value),
                                Convert.ToInt32(item.Cells[12].Value),
                                Convert.ToInt32(item.Cells[13].Value),
                             Convert.ToDateTime(item.Cells[14].Value),
                             Convert.ToDateTime(item.Cells[15].Value),
                              Convert.ToDecimal(item.Cells[16].Value),
                              Convert.ToDecimal(item.Cells[17].Value),
                              Convert.ToDecimal(item.Cells[18].Value),
                              Convert.ToDecimal(item.Cells[19].Value),
                                                item.Cells[20].Value,
                                                item.Cells[21].Value,
                                                item.Cells[22].Value);
                }
                return dt;
            }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
