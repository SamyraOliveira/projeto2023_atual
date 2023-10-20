using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Despesas
    {

        public int Id_despesa { get; set; }
        public DateTime Data_despesa { get; set; }
        public decimal Valor_despesa { get; set; }
        public int CategoriaId_despesa { get; set; }
        public Categoria Categoria_despesa { get; set; }
        public int ContaBancariaId_despesa { get; set; }
        public Contas ContaBancaria_despesa { get; set; }
        public int CentroDeCustoId_despesa { get; set; } // Adicionado campo CentroDeCustoId
        public Centro_Custo CentroDeCusto_despesa { get; set; } // Adicionado relacionamento com CentroDeCusto
        public string Descricao_despesa { get; set; }

        public string status;


        public Despesas(int id, DateTime data, decimal valor, int categoriaID, int cbancariaID, int ccustoID, string desc, string status_despesa)
        {
            Id_despesa = id;
            Data_despesa = data;
            Valor_despesa = valor;
            CategoriaId_despesa = categoriaID;
            ContaBancariaId_despesa = cbancariaID;
            CentroDeCustoId_despesa = ccustoID;
            Descricao_despesa = desc;
            status = status_despesa;
        }
        public Despesas(DateTime data, decimal valor, int categoriaID, int cbancariaID, int ccustoID, string desc, string status_despesa)

        {
            Data_despesa = data;
            Valor_despesa = valor;
            CategoriaId_despesa = categoriaID;
            ContaBancariaId_despesa = cbancariaID;
            CentroDeCustoId_despesa = ccustoID;
            Descricao_despesa = desc;
            status = status_despesa;
        }

    }
}
