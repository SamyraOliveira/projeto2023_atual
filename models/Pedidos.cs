using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Pedidos
    {
        //PROPRIEDADE
        public int ped_codigo;
        public int cli_codigo;
        public int colab_codigo;
        public int mat_codigo;
        public string ped_tipoGola;
        public string ped_corCamiseta;
        public int ped_tamanhoP;
        public int ped_tamanhoM;
        public int ped_tamanhoG;
        public int ped_quanTotal;
        public byte[] ped_estampaCamiseta;
        public string ped_nomeMaterial;
        public DateTime pedDataInicial;
        public decimal ped_valorUnit;
        public decimal ped_valorTotal;
        public decimal ped_valorEntrada;
        public string ped_nome;
        public bool ped_status;


        public Pedidos(int codigoCliente, int codigoColaborador, int codigoMaterial, string gola, string corCamiseta, int tamP, int tamM, int tamG, int quantidadeTam, byte [] estampa, string material, DateTime dataPedido, decimal valorUnitario, decimal valorTotal, decimal valorEntrada, string nome, bool status)
        {
            
            cli_codigo = codigoCliente;
            colab_codigo = codigoColaborador;
            mat_codigo = codigoMaterial;
            ped_tipoGola = gola;
            ped_corCamiseta = corCamiseta;
            ped_tamanhoP = tamP;
            ped_tamanhoM = tamM;
            ped_tamanhoG = tamG;
            ped_quanTotal = quantidadeTam;
            ped_estampaCamiseta = estampa;
            ped_nomeMaterial = material;
            pedDataInicial = dataPedido;
            ped_valorUnit = valorUnitario;
            ped_valorTotal = valorTotal;
            ped_valorEntrada = valorEntrada;
            ped_nome = nome;
            ped_status = status;
    }
        public Pedidos(int codigo, int codigoCliente, int codigoColaborador, int codigoMaterial, string gola, string corCamiseta, int tamP, int tamM, int tamG, int quantidadeTam, byte[] estampa, string material, DateTime dataPedido, decimal valorUnitario, decimal valorTotal, decimal valorEntrada, string nome, bool status)
        {
            ped_codigo = codigo;
            cli_codigo = codigoCliente;
            colab_codigo = codigoColaborador;
            mat_codigo = codigoMaterial;
            ped_tipoGola = gola;
            ped_corCamiseta = corCamiseta;
            ped_tamanhoP = tamP;
            ped_tamanhoM = tamM;
            ped_tamanhoG = tamG;
            ped_quanTotal = quantidadeTam;
            ped_estampaCamiseta = estampa;
            ped_nomeMaterial = material;
            pedDataInicial = dataPedido;
            ped_valorUnit = valorUnitario;
            ped_valorTotal = valorTotal;
            ped_valorEntrada = valorEntrada;
            ped_nome = nome;
            ped_status = status;
        }



    }

}
