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

namespace projeto2023.views.clientes
{
    public partial class consulta_clientes : Form
    {
        public consulta_clientes()
        {
            InitializeComponent();
        }

        private void consulta_clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1_CLIENTES.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.estampariadbDataSet1_CLIENTES.Clientes);

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_clientes((dt)))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("codigo_Cliente", typeof(int));
            dt.Columns.Add("nome_Cliente");
            dt.Columns.Add("CPFCNPJ_Cliente");
            dt.Columns.Add("telefone_Cliente");
            dt.Columns.Add("email_Cliente");
            dt.Columns.Add("dataNasc_Cliente");
            dt.Columns.Add("estado_Cliente");
            dt.Columns.Add("cidade_Cliente");
            dt.Columns.Add("endereco_Cliente");
            dt.Columns.Add("CEP_Cliente");
            dt.Columns.Add("status_Cliente");


            foreach (DataGridViewRow item in dtv_clientes.Rows)
            {
                dt.Rows.Add(Convert.ToInt32(item.Cells[0].Value),
                                            item.Cells[1].Value,
                                            item.Cells[2].Value,
                                            item.Cells[3].Value,
                                            item.Cells[4].Value,
                         Convert.ToDateTime(item.Cells[5].Value),
                                            item.Cells[6].Value,
                                            item.Cells[7].Value,
                                            item.Cells[8].Value,
                                            item.Cells[9].Value,
                            Convert.ToInt32(item.Cells[10].Value));
            }
            return dt;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
