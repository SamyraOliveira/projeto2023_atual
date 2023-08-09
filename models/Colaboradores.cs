using projeto2023.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Colaboradores
    {
        //propriedades
        public int colab_codigo;
        public string colab_CPF;
        public string colab_cargo;
        public string colab_telefone;
        public string colab_email;
        public string colab_estado;
        public string colab_cidade;
        public string colab_endereco;
        public string colab_bairro;
        public string colab_CEP;
        public string colab_nome;
        public DateTime colab_dataNasc;
        public string colab_usuario;
        public string colab_senha;
        public int colab_status;

        public Colaboradores (string cpf, string cargo, string telefone, string email, string estado, string cidade, string endereco, string bairro, string cep, string nome, DateTime dataNasc, string usuario, string senha, int status)
        {
            colab_CPF = cpf;
            colab_cargo = cargo;
            colab_telefone = telefone;
            colab_email = email;
            colab_estado = estado;
            colab_cidade = cidade;
            colab_endereco = endereco;
            colab_bairro = bairro;
            colab_CEP = cep;
            colab_nome = nome;
            colab_dataNasc = dataNasc;
            colab_usuario = usuario;
            colab_senha = senha;
            colab_status = status;
        }

        public Colaboradores(int codigo, string cpf, string cargo, string telefone, string email, string estado, string cidade, string endereco, string bairro, string cep, string nome, DateTime dataNasc, string usuario, string senha, int status)
        {
            colab_codigo = codigo;
            colab_CPF = cpf;
            colab_cargo = cargo;
            colab_telefone = telefone;
            colab_email = email;
            colab_estado = estado;
            colab_cidade = cidade;
            colab_endereco = endereco;
            colab_bairro = bairro;
            colab_CEP = cep;
            colab_nome = nome;
            colab_dataNasc = dataNasc;
            colab_usuario = usuario;
            colab_senha = senha;
            colab_status = status;
        }
    
		public Colaboradores(string user, string pass)
		{
			colab_usuario = user;
			colab_senha = pass;
		}

        public string CPF
        {
            set
            {
                Validation cpf = new Validation();


                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'CPF' e obrigatorio!");

                if (value.Length == 11)
                {
                    //codigo validacao cpf
                    if (cpf.ValidarCPF(value))
                    {

                    }
                }
                else
                {
                    throw new Exception("Conteudo do campo 'CPF' invalido!");
                }
                colab_CPF = value;
            }
            get
            {
                return colab_CPF;
            }
        }

        public string EMAIL
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Preenchimento do campo 'EMAIL' e obrigatorio!");
                if (!value.Contains('@'))
                    throw new Exception("Conteudo do campo 'EMAIL' e invalido!");
                colab_email = value;
            }
            get
            {
                return colab_email;
            }
        }


        #region ANTIGOS

     
         
        /*public Funcionarios(string CPF_functionary, string cargo_functionary, string telefone_functionary, string email_functionary, bool status_functionary, string cidade_functionary, string logradouro_functionary, string usuario_functionary, string senha_functionary, DateTime dataNascimento_functionary, string nome_functionary)
		{
			CPFFuncionario = CPF_functionary;
			CargoFuncionario = cargo_functionary;
			TelefoneFuncionario = telefone_functionary;
			EmailFuncionario = email_functionary;
			StatusFuncionario = status_functionary;
			CidadeFuncionario = cidade_functionary;
			LogradouroFuncionario = logradouro_functionary;
			UsuarioFuncionario = usuario_functionary;
			SenhaFuncionario = senha_functionary;
			DataNascFuncionario = dataNascimento_functionary;
			NomeFuncionario = nome_functionary;


		}
		public Funcionarios(int id_functionary, string CPF_functionary, string cargo_functionary, string telefone_functionary, string email_functionary, bool estado_functionary, string cidade_functionary, string logradouro_functionary, string usuario_functionary, string senha_functionary, DateTime dataNascimento_functionary, string nome_functionary)
		{


			fun_codigo = id_functionary;
			fun_cpf = CPF_functionary;
			fun_cargo = cargo_functionary;
			fun_telefone = telefone_functionary;
			fun_email = email_functionary;
			fun_status = estado_functionary;
			fun_cidade = cidade_functionary;
			fun_logradouro = logradouro_functionary;
			fun_usuario = usuario_functionary;
			fun_senha = senha_functionary;
			fun_dataNasc = dataNascimento_functionary;
			fun_nome = nome_functionary;


		}

		public Funcionarios(string Usuario, string Senha)
		{
			fun_usuario = Usuario;
			fun_senha = Senha;
		}
		*/

        /*public string CPFFuncionario
		{
			set
			{
				Validation cpf = new Validation();


				if (String.IsNullOrEmpty(value))
					throw new Exception("Preenchimento do campo 'CPF' e obrigatorio!");

				if (value.Length == 11)
				{
					//codigo validacao cpf
					if (cpf.ValidarCPF(value))
					{

					}
				}
				else
				{
					throw new Exception("Conteudo do campo 'CPF' invalido!");
				}
				mskt_cpf = value;
			}
			get
			{
				return mskt_cpf;
			}
		}*/

        /*public string CargoFuncionario
		{
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
				fun_nome = value;
			}
			get
			{
				return fun_nome;
			}
		}
		*/

        /*		public string TelefoneFuncionario
                {
                    set
                    {
                        if (String.IsNullOrEmpty(value))
                            throw new Exception("Preenchimento do campo 'Telefone' e obrigatorio!");
                        if (value.Length < 11)
                            throw new Exception("Campo 'Telefone' deve conter 11 digitos!");
                        fun_telefone = value;
                    }
                    get
                    {
                        return fun_telefone;
                    }
                }*/

        /*public string EmailFuncionario
		{
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new Exception("Preenchimento do campo 'EMAIL' e obrigatorio!");
				if (!value.Contains('@'))
					throw new Exception("Conteudo do campo 'EMAIL' e invalido!");
				fun_email = value;
			}
			get
			{
				return fun_email;
			}
		}*/

        /*public bool StatusFuncionario
        {
			set
			{
				
			}
			get
			{
				return fun_status;
			}
		}*/

        /*public string CidadeFuncionario
		{
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
				fun_nome = value;
			}
			get
			{
				return fun_nome;
			}
		}*/

        /*public string LogradouroFuncionario
		{
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
				fun_nome = value;
			}
			get
			{
				return fun_nome;
			}
		}*/

        /*public string UsuarioFuncionario
		{
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new Exception("Login não pode ser vazio!");
				if (value.Length < 6)
					throw new Exception("Login deve conter mais de 6 caractereres!!");
				fun_usuario = value;
			}
			get
			{
				return fun_usuario;
			}
		}*/

        /*public string SenhaFuncionario
		{
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new Exception("Senha não pode ser vazio!");
				if (value.Length < 6)
					throw new Exception("Senha deve conter 6 caractereres!!");
				fun_senha = value;
			}
			get
			{
				return fun_senha;
			}
		}*/

        /*public DateTime DataNascFuncionario
		{
			set
			{

			}
			get
			{
				return fun_dataNasc;
			}
		}*/

        /*public string NomeFuncionario
		{
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new Exception("Preenchimento do campo 'Nome Completo' e obrigatorio!");
				fun_nome = value;
			}
			get
			{
				return fun_nome;
			}
		}
          */


        #endregion

    }
}
