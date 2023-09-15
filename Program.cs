using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto2023.models;
using projeto2023.views.clientes;
using projeto2023.views.colaboradores;
using projeto2023.views.fornecedores;
using projeto2023.views.frms;
using projeto2023.views.producao;

namespace projeto2023
{
    public class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //Application.Run(new frm_cadastros());
        }
    }
}
