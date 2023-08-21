using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Pedidos
    {
        //PROPRIEDADE
        public int ped_codigo;
        public int colab_codigo;
        public string colab_nome;
        public int cli_codigo;
        public string cli_nome;
        public string ped_cor;
        public string ped_tecido;
        public string ped_formato;
        public string ped_gola;
        public string ped_tecnica;
        public byte [] ped_estampa;
        public int ped_tamP;
        public int ped_tamM;
        public int ped_tamG;
        public int ped_disponibilizadoCli;
        public int ped_quantDisponibilizado;
        public int ped_totalCamisetas;
        public DateTime ped_Datainicial;
        public DateTime ped_DataEntrega;
        public decimal ped_valorUnitario;
        public decimal ped_valorTotal;
        public decimal ped_valorEntrada;
        public decimal ped_valorAberto;
        public string ped_formaPagamentoEntrada;
        public string ped_formaPagamentoFinal;
        public string ped_status;



        public Pedidos(int codigoColaborador, int codigoCliente, string cor, string tecido, string formato, string gola, string tecnica, byte [] estampa, int tamP, int tamM, int tamG, int disponibilizadoCliente,int quantdisponibilizado, int totalCamisetas, DateTime dataInicial, DateTime dataEntrega, decimal valor_unitario, decimal valor_total, decimal valor_entrada, decimal valor_aberto, string formaPagamentoEntrada, string formaPagamentoFinal, string status)
        {


          colab_codigo = codigoColaborador;
          cli_codigo = codigoCliente;
          ped_cor = cor;
          ped_tecido = tecido;
          ped_formato = formato;
          ped_gola = gola;
          ped_tecnica = tecnica;
          ped_estampa = estampa;
          ped_tamP = tamP;
          ped_tamM = tamM;
          ped_tamG = tamG;
          ped_disponibilizadoCli = disponibilizadoCliente;
          ped_quantDisponibilizado = quantdisponibilizado;
          ped_totalCamisetas = totalCamisetas;
          ped_Datainicial= dataInicial;
          ped_DataEntrega = dataEntrega;
          ped_valorUnitario = valor_unitario;
          ped_valorTotal = valor_total;
          ped_valorEntrada = valor_entrada ;
          ped_valorAberto = valor_aberto;
          ped_formaPagamentoEntrada = formaPagamentoEntrada;
          ped_formaPagamentoFinal = formaPagamentoFinal;
          ped_status = status;
    }
        public Pedidos(int codigo, int codigoColaborador, int codigoCliente, string cor, string tecido, string formato, string gola, string tecnica, byte [] estampa, int tamP, int tamM, int tamG, int disponibilizadoCliente, int quantdisponibilizado, int totalCamisetas, DateTime dataInicial, DateTime dataEntrega, decimal valor_unitario, decimal valor_total, decimal valor_entrada, decimal valor_aberto, string formaPagamentoEntrada, string formaPagamentoFinal, string status)
        {
            ped_codigo = codigo;
            colab_codigo = codigoColaborador;
            cli_codigo = codigoCliente;
            ped_cor = cor;
            ped_tecido = tecido;
            ped_formato = formato;
            ped_gola = gola;
            ped_tecnica = tecnica;
            ped_estampa = estampa;
            ped_tamP = tamP;
            ped_tamM = tamM;
            ped_tamG = tamG;
            ped_disponibilizadoCli = disponibilizadoCliente;
            ped_quantDisponibilizado = quantdisponibilizado;
            ped_totalCamisetas = totalCamisetas;
            ped_Datainicial = dataInicial;
            ped_DataEntrega = dataEntrega;
            ped_valorUnitario = valor_unitario;
            ped_valorTotal = valor_total;
            ped_valorEntrada = valor_entrada;
            ped_valorAberto = valor_aberto;
            ped_formaPagamentoEntrada = formaPagamentoEntrada;
            ped_formaPagamentoFinal = formaPagamentoFinal;
            ped_status = status;
        }



    }

}
