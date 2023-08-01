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
        public int forn_codigo;
        public string mat_nome;
        public int mat_quantidade;
        public decimal preco;
        public bool mat_status;


        public Materiais(int codigo_fornecedor, string material,  int quantidade, decimal valor, bool status)
        {
            forn_codigo = codigo_fornecedor;
            mat_nome = material;
            preco = valor;
            mat_quantidade = quantidade;
            mat_status = status;
        }

        public Materiais(int codigo,int codigo_fornecedor, string material, int quantidade, decimal valor, bool status)
        {
            mat_codigo = codigo;
            forn_codigo = codigo_fornecedor;
            mat_nome = material;
            preco = valor;
            mat_quantidade = quantidade;
            mat_status = status;
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
