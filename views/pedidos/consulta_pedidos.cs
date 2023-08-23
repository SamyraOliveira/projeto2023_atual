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
            using (var frm = new relatorio_pedidos())
            {
                frm.ShowDialog();
            }
        }
    }
}
