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
    }
}
