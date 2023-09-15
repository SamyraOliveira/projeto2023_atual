using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2023.views.producao
{
    public partial class crud_producao : Form
    {
        public crud_producao()
        {
            InitializeComponent();
        }

        private void crud_producao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidosTableAdapter1.Fill(this.estampariadbDataSet1.Pedidos);
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pedidosTableAdapter.FillBy(this.estampariadbDataSet.Pedidos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pedidosTableAdapter1.FillBy2(this.estampariadbDataSet1.Pedidos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvPedidosProdução.Rows[e.RowIndex];

                // Preencha os TextBox com os valores da linha selecionada
                txtCod.Text = row.Cells["cod"].Value.ToString();
                txtCor.Text = row.Cells["COR"].Value.ToString();
                txtQuantidadeP.Text = row.Cells["quantidade_p"].Value.ToString();
                txtQuantidadeM.Text = row.Cells["quantidade_m"].Value.ToString();
                txtQuantidadeG.Text = row.Cells["quantidade_g"].Value.ToString();
                txtTotalPedido.Text = row.Cells["total_pedido"].Value.ToString();
                txtEntrega.Text = row.Cells["entrega"].Value.ToString();
                txtStatus.Text = row.Cells["status"].Value.ToString();
            }
        }
    }
}
