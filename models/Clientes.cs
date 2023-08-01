using projeto2023.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Clientes
    {

        //propriedade
        public int cli_codigo;
        public string cli_nome;
        public string cli_CPFCNPJ;
        public string cli_telefone;
        public string cli_email;
        public DateTime cli_dataNasc;
        public string cli_estado;
        public string cli_cidade;
        public string cli_endereco;
        public string cli_CEP;
        public bool cli_status;


        public Clientes(string nome, string cpfcnpj, string telefone, string email, DateTime dataNasc, string estado, string cidade, string endereco, string cep, bool status )
        {
            cli_nome = nome;
            cli_CPFCNPJ = cpfcnpj;
            cli_telefone = telefone;
            cli_email = email;
            cli_dataNasc = dataNasc;
            cli_estado = estado;
            cli_cidade = cidade;
            cli_endereco = endereco;
            cli_CEP = cep;
            cli_status = status;
        }

        public Clientes(int codigo,string nome, string cpfcnpj, string telefone, string email, DateTime dataNasc, string estado, string cidade, string endereco, string cep, bool status)
        {
            cli_codigo = codigo;
            cli_nome = nome;
            cli_CPFCNPJ = cpfcnpj;
            cli_telefone = telefone;
            cli_email = email;
            cli_dataNasc = dataNasc;
            cli_estado = estado;
            cli_cidade = cidade;
            cli_endereco = endereco;
            cli_CEP = cep;
            cli_status = status;

        }

        public string CPFCNPJCliente
        {
            set
            {
                //ARRUMAR
                Validation cpf = new Validation();
                Validation cnpj = new Validation();

                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'CPF/CNPJ' e obrigatorio!");

                if (value.Length == 11)
                {
                    //codigo validacao cpf
                    if (cpf.ValidarCPF(value))
                    {

                    }

                }
                else if (value.Length == 14)
                {
                    //validacao cnpj
                    if (!cnpj.ValidarCNPJ(value))
                    {

                    }
                }
                else
                {
                    throw new Exception("Conteudo do campo 'CPF/CNPJ' invalido!");
                }
                cli_CPFCNPJ = value;
            }
            get
            {
                return cli_CPFCNPJ;
            }
        }

        #region ANTIGOS

        /*public string NomeCliente
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
                cli_nome = value;
            }
            get
            {
                return cli_nome;
            }
        }*/


        /*public string EmailCliente
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'EMAIL' e obrigatorio!");
                if (!value.Contains('@'))
                    throw new Exception("Conteudo do campo 'EMAIL'  invalido!");
                cli_email = value;
            }
            get
            {
                return cli_email;
            }
        }*/

        /*public string TelefoneCliente
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'Telefone' e obrigatorio!");
                if (value.Length < 11)
                    throw new Exception("Campo 'Telefone' deve conter 11 digitos!");
                cli_telefone = value;
            }
            get
            {
                return cli_telefone;
            }
        }*/

        /* public DateTime DataNascCliente
         {
             set
             {

             }
             get
             {
                 return cli_dataNasc;
             }
         }*/

        /* public string CidadeCliente
         {
             set
             {
                 if (String.IsNullOrEmpty(value))
                     throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
                 cli_cidade = value;
             }
             get
             {
                 return cli_cidade;
             }
         }*/

        /*  public string LogradouroCliente
          {
              set
              {
                  if (String.IsNullOrEmpty(value))
                      throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
                  cli_logradouro = value;
              }
              get
              {
                  return cli_logradouro;
              }
          }
          */
        /* public bool StatusCliente
         {
             set
             {

             }
             get
             {
                 return cli_status;
             }
         }*/

        #endregion
    }

}
