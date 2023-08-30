using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Materiais
    {
        //propriedade
        public int mat_codigo;
        public int fornc_codigo;
        public string mat_nome;
        public string mat_descricao;
        public string mat_unidadeMedida;
        public decimal mat_precoUnit;
        public DateTime mat_dataEntrada;
       // public string mat_fornecedor;
        public string mat_numLote;
        public string mat_localArmazenamento;
        public int mat_quantidade;
        public DateTime mat_ultimaAtualizacao;
        public string mat_status;


        public Materiais(int forn_codigo, string mate_nome, string mate_descricao, string mate_unidadeMedida, decimal mate_precoUnit, DateTime mate_dataEntrada, string mate_numLote, string mate_localArmazenamento, int mate_quantidade, DateTime mate_ultimaAtualizacao, string mate_status)
        {
             fornc_codigo = forn_codigo;
             mat_nome = mate_nome;
             mat_descricao = mate_descricao;
             mat_unidadeMedida = mate_unidadeMedida;
             mat_precoUnit = mate_precoUnit;
             mat_dataEntrada = mate_dataEntrada;
            // mat_fornecedor = mate_fornecedor;
             mat_numLote = mate_numLote;
             mat_localArmazenamento = mate_localArmazenamento;
             mat_quantidade = mate_quantidade;
             mat_ultimaAtualizacao = mate_ultimaAtualizacao;
             mat_status = mate_status;
        }

    public Materiais(int mate_codigo, int forn_codigo, string mate_nome, string mate_descricao, string mate_unidadeMedida, decimal mate_precoUnit, DateTime mate_dataEntrada, string mate_numLote, string mate_localArmazenamento, int mate_quantidade, DateTime mate_ultimaAtualizacao, string mate_status)
        {
             mat_codigo = mate_codigo;
             fornc_codigo = forn_codigo;
             mat_nome = mate_nome;
             mat_descricao = mate_descricao;
             mat_unidadeMedida = mate_unidadeMedida;
             mat_precoUnit = mate_precoUnit;
             mat_dataEntrada = mate_dataEntrada;
           //  mat_fornecedor = mate_fornecedor;
             mat_numLote = mate_numLote;
             mat_localArmazenamento = mate_localArmazenamento;
             mat_quantidade = mate_quantidade;
             mat_ultimaAtualizacao = mate_ultimaAtualizacao;
             mat_status = mate_status;
        }


        #region ANTIGOS 

        /*public int IdentificadorFornecedor
        {
            set
            {

            }
            get
            {
                return forn_codigo;
            }
        }*/

       /* public string NomeMaterial
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
                mat_nome = value;
            }
            get
            {
                return mat_nome;
            }
        }*/

       /* public string DescricaoMaterial
        {
            set
            {

            }
            get
            {
                return mat_descricao;
            }
        }*/
        /*public int QuantidadeMaterial
        {
            set
            {

            }
            get
            {
                return mat_quantidade;
            }
        }*/

        /*public bool StatusMaterial
        {
            set
            {

            }
            get
            {
                return mat_status;
            }

        }*/

        #endregion


    }
}
