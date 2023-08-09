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
        public int fornc_codigo;
        public string fornc_nomeFantasia;
        public string fornc_razaoSocial;
        public string fornc_cnpj;
        public string fornc_inscricaoEstadual;
        public string fornc_inscricaoMunicipal;
        public string fornc_cep;
        public string fornc_endereco;
        public string fornc_numero;
        public string fornc_cidade;
        public string fornc_estado;
        public string fornc_representante;
        public string fornc_email;
        public string fornc_telefone;
        public DateTime fornc_iniciocontrato;
        public int fornc_status;

        public Fornecedores(string fornc_nomeFantasia1, string fornc_razaoSocial1, string fornc_cnpj1, string fornc_inscricaoEstadual1, string fornc_inscricaoMunicipal1, string fornc_cep1, string fornc_endereco1, string fornc_numero1, string fornc_cidade1, string fornc_estado1, string fornc_representante1, string fornc_email1, string fornc_telefone1, DateTime fornc_iniciocontrato1, int fornc_status1)


        {

            fornc_nomeFantasia = fornc_nomeFantasia1;
            fornc_razaoSocial = fornc_razaoSocial1;
            fornc_cnpj = fornc_cnpj1;
            fornc_inscricaoEstadual = fornc_inscricaoEstadual1;
            fornc_inscricaoMunicipal = fornc_inscricaoMunicipal1;
            fornc_cep = fornc_cep1;
            fornc_endereco = fornc_endereco1;
            fornc_numero = fornc_numero1;
            fornc_cidade = fornc_cidade1;
            fornc_estado = fornc_estado1;
            fornc_representante = fornc_representante1;
            fornc_email = fornc_email1;
            fornc_telefone = fornc_telefone1;
            fornc_iniciocontrato = fornc_iniciocontrato1;
            fornc_status = fornc_status1;



        }

      

        public Fornecedores(int codigo, string fornc_nomeFantasia1, string fornc_razaoSocial1, string fornc_cnpj1, string fornc_inscricaoEstadual1, string fornc_inscricaoMunicipal1, string fornc_cep1, string fornc_endereco1, string fornc_numero1, string fornc_cidade1, string fornc_estado1, string fornc_representante1, string fornc_email1, string fornc_telefone1, DateTime fornc_iniciocontrato1, int fornc_status1)
        {
            fornc_codigo = codigo;
            fornc_nomeFantasia = fornc_nomeFantasia1;
            fornc_razaoSocial = fornc_razaoSocial1;
            fornc_cnpj = fornc_cnpj1;
            fornc_inscricaoEstadual = fornc_inscricaoEstadual1;
            fornc_inscricaoMunicipal = fornc_inscricaoMunicipal1;
            fornc_cep = fornc_cep1;
            fornc_endereco = fornc_endereco1;
            fornc_numero = fornc_numero1;
            fornc_cidade = fornc_cidade1;
            fornc_estado = fornc_estado1;
            fornc_representante = fornc_representante1;
            fornc_email = fornc_email1;
            fornc_telefone = fornc_telefone1;
            fornc_iniciocontrato = fornc_iniciocontrato1;
            fornc_status = fornc_status1;

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
                fornc_cnpj = value;
            }
            get
            {
                return fornc_cnpj;
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
                fornc_email = value;
            }
            get
            {
                return fornc_email;
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
