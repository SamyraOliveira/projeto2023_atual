using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.controllers
{
    public class Connection
    {
        public readonly SqlConnection con;
        public readonly string DataBase = "Estampariadb";

        public Connection()
        {
            //Abrir conexao com bando de dados 
            string stringConnection = @"Data Source=" + Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security = true";
            con = new SqlConnection(stringConnection);
            con.Open();
        }

        public void FecharConexao()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        //retornar conexao aberta
        public SqlConnection RetornarConexao()
        {
            return con;
        }
    }
}
