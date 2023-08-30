using projeto2023.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Fornecedores_dados
    {

        public int id_Fornc { get; set; }
        public string nome_Fornc { get; set; }



        public Fornecedores_dados(int forncID, string forncColab)
        {
            id_Fornc = forncID;
            nome_Fornc = forncColab;
        }

        // public string Nome => nome_Colab;

        public override string ToString()
        {
            return nome_Fornc;
        }
    }
}
