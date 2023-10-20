using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class Categoria
    {
            public int codigo_categoria { get; set; }
            public string Nome_categoria { get; set; }
            public string Descricao_categoria { get; set; }
            public int status_categoria { get; set; }


            public Categoria(int id, string nomecate, string desc, int status)
            {

                codigo_categoria = id;
                Nome_categoria = nomecate;
                Descricao_categoria = desc;
                status_categoria = status;

            }

            public Categoria(string nomecate, string desc, int status)
            {

                Nome_categoria = nomecate;
                Descricao_categoria = desc;
                status_categoria = status;
            }
    }
}
