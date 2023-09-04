using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2023.views.materiais
{
    public partial class relatorio_materiais : Form
    {
        DataTable dt = new DataTable();
        public relatorio_materiais(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void relatorio_materiais_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new
                    Microsoft.Reporting.WinForms.ReportDataSource("materiais", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
