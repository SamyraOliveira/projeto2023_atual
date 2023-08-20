using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace projeto2023.models
{
    public class Clientes_dados
    {
    

        public int id_Cli { get; set; }
        public string nome_Cli { get; set; }

        public Clientes_dados(int id_cli, string nome_cli)
        {
            id_Cli = id_cli;
            nome_Cli = nome_cli;
        }


        public override string ToString()
        {
           return nome_Cli;
        }



    }
}
