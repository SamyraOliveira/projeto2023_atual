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
    }
}
