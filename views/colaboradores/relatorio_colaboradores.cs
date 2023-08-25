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
    public partial class relatorio_colaboradores : Form
    {
        DataTable dt = new DataTable();
        public relatorio_colaboradores(DataTable dt)
        {
            InitializeComponent();
        }

        private void relatorio_colaboradores_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new
                    Microsoft.Reporting.WinForms.ReportDataSource("colaboradores", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
