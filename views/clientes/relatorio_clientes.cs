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
    public partial class relatorio_clientes : Form
    {
        DataTable dt = new DataTable();
        public relatorio_clientes(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            
        }

        private void relatorio_clientes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new
                    Microsoft.Reporting.WinForms.ReportDataSource("clientes", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
