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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using (var frm = new relatorio_colaboradores((dt)))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("codigo_Colaborador", typeof(int));
            dt.Columns.Add("CPF_Colaborador");
            dt.Columns.Add("cargo_Colaborador");
            dt.Columns.Add("telefone_Colaborador");
            dt.Columns.Add("email_Colaborador");
            dt.Columns.Add("estado_Colaborador");
            dt.Columns.Add("cidade_Colaborador");
            dt.Columns.Add("endereco_Colaborador");
            dt.Columns.Add("bairro_Colaborador");
            dt.Columns.Add("CEP_Colaborador");
            dt.Columns.Add("nome_Colaborador");
            dt.Columns.Add("dataNasc_Colaborador", typeof(DateTime));
            dt.Columns.Add("user_Colaborador");
            dt.Columns.Add("password_Colaborador");
            dt.Columns.Add("status_Colaborador");



            foreach (DataGridViewRow item in dtv_colaboradores.Rows)
            {
                dt.Rows.Add(Convert.ToInt32(item.Cells[0].Value),
                                            item.Cells[1].Value,
                                            item.Cells[2].Value,
                                            item.Cells[3].Value,
                                            item.Cells[4].Value,
                                            item.Cells[5].Value,
                                            item.Cells[6].Value,
                                            item.Cells[7].Value,
                                            item.Cells[8].Value,
                                            item.Cells[9].Value,
                                            item.Cells[10].Value,
                         Convert.ToDateTime(item.Cells[11].Value),
                                            item.Cells[12].Value,
                                            item.Cells[13].Value,
                            Convert.ToInt32(item.Cells[14].Value));

;
            }
            return dt;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
