using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Producao
    {
        //PROPRIEDADE
        public int codigo_linha;
        public int codigo_produto;
        public int quantidade_P;
        public int quantidade_M;
        public int quantidade_G;
        public string cor;
        public string tecido;
        public string formato;
        public string gola;
        public string tecnicas;
        public DateTime Data_Entrega;
        public int[] materiais;
        public int tempo_producao;
        public int tempo_paradas;
        public DateTime hora_inicio;
        public DateTime hora_fim;
        public string estampa;
        public int status;
        public int produzido_P;
        public int produzido_M;
        public int produzido_G;




        public Producao(int codigoproduto, int quantidadeP, int quantidadeM, int quantidadeG, string cor_pedido,
            string prodtecido, string prodformato, string prodgola, string prodtecnicas, DateTime data_entrega_prod, int status_prod)
        {


            codigo_produto = codigoproduto;
            quantidade_P = quantidadeP;
            quantidade_M = quantidadeM;
            quantidade_G = quantidadeG;
            cor = cor_pedido;
            tecido = prodtecido;
            formato = prodformato;
            gola = prodgola;
            tecnicas = prodtecnicas;
            Data_Entrega = data_entrega_prod;
            status = status_prod;


        }
        public Producao(int codigoLinha, int codigoproduto, int quantidadeP, int quantidadeM, int quantidadeG, string cor_pedido,
           string prodtecido, string prodformato, string prodgola, string prodtecnicas, DateTime data_entrega_prod, int[] id_materiais, int temp_prod,
           DateTime hora_inicio_prod, DateTime hora_fim_prod, int temp_paradas, int status_prod, string prodestampa, int produzidoP, int produzidoM, int produzidoG)
        {


            codigo_linha = codigoLinha;
            codigo_produto = codigoproduto;
            quantidade_P = quantidadeP;
            quantidade_M = quantidadeM;
            quantidade_G = quantidadeG;
            cor = cor_pedido;
            tecido = prodtecido;
            formato = prodformato;
            gola = prodgola;
            tecnicas = prodtecnicas;
            Data_Entrega = data_entrega_prod;
            materiais = id_materiais;
            tempo_producao = temp_prod;
            hora_inicio = hora_inicio_prod;
            hora_fim = hora_fim_prod;
            tempo_paradas = temp_paradas;
            status = status_prod;
            estampa = prodestampa;
            produzido_P = produzidoP;
            produzido_M = produzidoM;
            produzido_G = produzidoG;


        }
        public class ProducaoX
        {
            public ProducaoX(int iD, string nome)
            {
                ID = iD;
                Nome = nome;
            }

            public int ID { get; set; }
            public string Nome { get; set; }
            // Outros campos, se necessário
        }




    }
}
