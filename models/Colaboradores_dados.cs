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

        public int ID_colab { get; set; }
        public string Nome_colab { get; set; }



        public Colaboradores_dados(int id_colab, string nome_colab)
        {
            ID_colab = id_colab;
            Nome_colab = nome_colab;
        }



        public override string ToString()
        {
            return Nome_colab;
        }


    }
}
