using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace projeto2023.models
{
    public class Colaboradores_dados
    {

        public int id_Colab { get; set; }
        public string nome_Colab { get; set; }



        public Colaboradores_dados(int id_colab, string nome_colab)
        {
            id_Colab = id_colab;
            nome_Colab = nome_colab;
        }

       // public string Nome => nome_Colab;

        public override string ToString()
        {
            return nome_Colab;
        }


    }
}
