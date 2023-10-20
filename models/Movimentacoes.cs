using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Movimentacoes
    {
        public int idmov { get; set; }
        public DateTime Data_mov { get; set; }
        public decimal Valor_mov { get; set; }
        public string Descricao_mov { get; set; }
        public string TipoTransacao_mov { get; set; }
        public int CategoriaId_mov { get; set; }
        public int ContaBancariaId_mov { get; set; }
        public int CentroDeCustoId_mov { get; set; }

        public int status_mov;
        public Movimentacoes(DateTime data, decimal valor, string descricao, string tipoTransacao, int categoriaId, int contaBancariaId, int centroDeCustoId, int status)
        {
            Data_mov = data;
            Valor_mov = valor;
            Descricao_mov = descricao;
            TipoTransacao_mov = tipoTransacao;
            CategoriaId_mov = categoriaId;
            ContaBancariaId_mov = contaBancariaId;
            CentroDeCustoId_mov = centroDeCustoId;
            status_mov = status;
        }
        public Movimentacoes(int codigo_movimento, DateTime data, decimal valor, string descricao, string tipoTransacao, int categoriaId, int contaBancariaId, int centroDeCustoId, int status)
        {
            idmov = codigo_movimento;
            Data_mov = data;
            Valor_mov = valor;
            Descricao_mov = descricao;
            TipoTransacao_mov = tipoTransacao;
            CategoriaId_mov = categoriaId;
            ContaBancariaId_mov = contaBancariaId;
            CentroDeCustoId_mov = centroDeCustoId;
            status_mov = status;
        }
    }
}
