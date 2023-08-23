using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2023.views.colaboradores
{
    public partial class consulta_colaboradores : Form
    {
        public consulta_colaboradores()
        {
            InitializeComponent();
        }

        private void consulta_colaboradores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estampariadbDataSet1_COLABORADORES.Colaboradores'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradoresTableAdapter.Fill(this.estampariadbDataSet1_COLABORADORES.Colaboradores);

        }
    }
}
