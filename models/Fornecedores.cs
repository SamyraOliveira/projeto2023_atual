using projeto2023.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Fornecedores
    {
        //propriedade
        public int forn_codigo;
        public string forn_nomeAbreviado;
        public string forn_CNPJ;
        public string forn_CEP;
        public string forn_endereco;
        public string forn_cidade;
        public string forn_estado;
        public string forn_telefone;
        public string forn_representante;
        public string forn_email;
        public bool forn_status;

        public Fornecedores(string nomeAbreviado, string cnpj, string cep, string endereco, string cidade, string estado, string telefone, string representante, string email, bool status)
        {
        
        forn_nomeAbreviado = nomeAbreviado;
        forn_CNPJ = cnpj;
        forn_CEP = cep;
        forn_endereco = endereco;
        forn_cidade = cidade;
        forn_estado = estado;
        forn_telefone = telefone;
        forn_representante = representante;
        forn_email = email;
        forn_status = status;

        }

      

        public Fornecedores(int codigo, string nomeAbreviado, string cnpj, string cep, string endereco, string cidade, string estado, string telefone, string representante, string email, bool status)
        {
            forn_codigo = codigo;
            forn_nomeAbreviado = nomeAbreviado;
            forn_CNPJ = cnpj;
            forn_CEP = cep;
            forn_endereco = endereco;
            forn_cidade = cidade;
            forn_estado = estado;
            forn_telefone = telefone;
            forn_representante = representante;
            forn_email = email;
            forn_status = status;

        }

        public string CNPJFornecedor
        {
            set
            {
                Validation cnpj = new Validation();

                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'CNPJ' e obrigatorio!");

                if (value.Length == 14)
                {
                    //validacao cnpj
                    if (!cnpj.ValidarCNPJ(value))
                    {

                    }
                }
                else
                {
                    throw new Exception("Conteudo do campo 'CNPJ' invalido!");
                }
                forn_CNPJ = value;
            }
            get
            {
                return forn_CNPJ;
            }
        }

        public string EmailFornecedor
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'EMAIL' e obrigatorio!");
                if (!value.Contains('@'))
                    throw new Exception("Conteudo do campo 'EMAIL' e invalido!");
                forn_email = value;
            }
            get
            {
                return forn_email;
            }
        }

        #region ANTIGOS

        /*public string NomeFornecedor
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
                forn_nomeEmpresa = value;
            }
            get
            {
                return forn_nomeEmpresa;
            }
        }*/

        /*public string NomeRepresentante
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
                forn_representante = value;
            }
            get
            {
                return forn_representante;
            }
        }*/

        /*public string CidadeFornecedor
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
                forn_cidade = value;
            }
            get
            {
                return forn_cidade;
            }
        }*/

        /*public string LogradouroFornecedor
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
                forn_logradouro = value;
            }
            get
            {
                return forn_logradouro;
            }
        }*/

        /*public bool StatusFornecedor
        {
            set
            {

            }
            get
            {
                return forn_status;
            }
        }*/

        #endregion
    }
}
