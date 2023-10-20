using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Transacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int ContaBancariaId { get; set; }
        public Contas Conta { get; set; }
        public Centro_Custo Centro_Custo { get; set; }
        public int CentroDeCustoId { get; set; } // Adicionado campo CentroDeCustoId
        public string Descricao { get; set; }

        public int status;


        public Transacao(int codigo_transacao, DateTime data, decimal valor, int categoriaID, int cBancariaID, int ccustoID, string desc, int status_transacao)
        {
            Id = codigo_transacao;
            Data = data;
            Valor = valor;
            CategoriaId = categoriaID;
            ContaBancariaId = cBancariaID;
            CentroDeCustoId = ccustoID;
            Descricao = desc;
            status = status_transacao;
        }
        public Transacao(DateTime data, decimal valor, int categoriaID, int cBancariaID, int ccustoID, string desc, int status_transacao)
        {
            Data = data;
            Valor = valor;
            CategoriaId = categoriaID;
            ContaBancariaId = cBancariaID;
            CentroDeCustoId = ccustoID;
            Descricao = desc;
            status = status_transacao;
        }
    }
}
