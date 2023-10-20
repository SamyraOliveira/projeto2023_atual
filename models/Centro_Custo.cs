using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Centro_Custo
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public int status;

        public Centro_Custo(int codigo_ccusto, string nome_ccusto, string desc, int status_ccusto)
        {
            Id = codigo_ccusto;
            Nome = nome_ccusto;
            Descricao = desc;
            status = status_ccusto;
        }

        public Centro_Custo(string nome_ccusto, string desc, int status_ccusto)
        {
            Nome = nome_ccusto;
            Descricao = desc;
            status = status_ccusto;
        }
    }
}
