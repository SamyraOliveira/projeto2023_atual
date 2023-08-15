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
        public int ID_cli { get; set; }
        public string Nome_cli { get; set; }



        public Clientes_dados(int id_cli, string nome_cli)
        {
            ID_cli = id_cli;
            Nome_cli = nome_cli;
        }



        public override string ToString()
        {
            return Nome_cli;
        }



    }
}
