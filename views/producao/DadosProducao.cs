using System;

namespace projeto2023.views.producao
{
    public class DadosProducao
    {
        public int ID_Linha { get; set; }
        public int ID_Produto { get; set; }
        public int Quantidade_P { get; set; }
        public int Quantidade_M { get; set; }
        public int Quantidade_G { get; set; }
        public string Tecnicas { get; set; }
        public string COR { get; set; }
        public string Tecido { get; set; }
        public string Tipo_Gola { get; set; }
        public string Formato { get; set; }
        public DateTime Data_Entrega { get; set; }
    }

}