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
    public partial class relatorio_pedidos : Form
    {
        DataTable dt = new DataTable();
        public relatorio_pedidos()
        {
            InitializeComponent();
        }

        private void relatorio_pedidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
