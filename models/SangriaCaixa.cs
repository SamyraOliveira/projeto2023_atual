using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class SangriaCaixa
    {
        public int Id { get; set; }
        public DateTime DataSangria { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        public int status;


        public SangriaCaixa(int codigo_sangria, DateTime data, decimal valor, string desc, int status_sangriaCX)
        {
            Id = codigo_sangria;
            DataSangria = data;
            Valor = valor;
            Descricao = desc;
            status = status_sangriaCX;
        }


        public SangriaCaixa(DateTime data, decimal valor, string desc, int status_sangriaCX)
        {
            DataSangria = data;
            Valor = valor;
            Descricao = desc;
            status = status_sangriaCX;
        }
    }
}
