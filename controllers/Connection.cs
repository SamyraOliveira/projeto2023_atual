using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace projeto2023.controllers
{
    public class Connection : IDisposable
    {
        public readonly SqlConnection con;
        public readonly string DataBase = "Estampariadb";

        public Connection()
        {
            try
            {

                string stringConnection = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;";
                con = new SqlConnection(stringConnection);
                con.Open();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se concectar ao banco" + erro);
            }


        }

        public void FecharConexao()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Close();
        }

        //retornar conexao aberta
        public SqlConnection RetornarConexao()
        {
            return con;
        }

        public void Dispose()
        {
            FecharConexao();
            con.Dispose();
        }

    }
}
