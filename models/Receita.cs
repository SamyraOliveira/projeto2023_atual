using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Receita
    {
        public int Id_receita { get; set; }
        public DateTime Data_receita { get; set; }
        public decimal Valor_receita { get; set; }
        public int CategoriaId_receita { get; set; }
        public Categoria Categoria_receita { get; set; }
        public int ContaBancariaId_receita { get; set; }
        public Contas ContaBancaria_receita { get; set; }
        public int CentroDeCustoId_receita { get; set; } // Adicionado campo CentroDeCustoId
        public Centro_Custo CentroDeCusto_receita { get; set; } // Adicionado relacionamento com CentroDeCusto
        public string Descricao_receita { get; set; }

        public string status;

        public Receita(int id, DateTime data, decimal valor, int categoriaID, int cbancariaID, int ccustoID, string desc, string status_receita)
        {
            Id_receita = id;
            Data_receita = data;
            Valor_receita = valor;
            CategoriaId_receita = categoriaID;
            ContaBancariaId_receita = cbancariaID;
            CentroDeCustoId_receita = ccustoID;
            Descricao_receita = desc;
            status = status_receita;
        }
        public Receita(DateTime data, decimal valor, int categoriaID, int cbancariaID, int ccustoID, string desc, string status_receita)
        {
            Data_receita = data;
            Valor_receita = valor;
            CategoriaId_receita = categoriaID;
            ContaBancariaId_receita = cbancariaID;
            CentroDeCustoId_receita = ccustoID;
            Descricao_receita = desc;
            status = status_receita;
        }
    }
}
