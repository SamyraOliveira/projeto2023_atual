using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class FechamentoCaixa
    {
        public int Id { get; set; }
        public DateTime DataFechamento { get; set; }
        public decimal SaldoInicial { get; set; }
        public List<Transacao> Transacoes { get; set; }
        public decimal SaldoFinal { get; set; }

        public int status;

        public FechamentoCaixa(int codigo_fechamento, DateTime data, decimal saldoI, List<Transacao> transacoes, decimal saldoF, int status_fechamento)
        {
            Id = codigo_fechamento;
            DataFechamento = data;
            SaldoInicial = saldoI;
            Transacoes = transacoes;
            SaldoFinal = saldoF;
            status = status_fechamento;
        }

        public FechamentoCaixa(DateTime data, decimal saldoI, List<Transacao> transacoes, decimal saldoF, int status_fechamento)
        {
            DataFechamento = data;
            SaldoInicial = saldoI;
            Transacoes = transacoes;
            SaldoFinal = saldoF;
            status = status_fechamento;
        }

    }
}
