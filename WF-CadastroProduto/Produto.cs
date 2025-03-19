using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CadastroProduto
{
    public class Produto
    {
        public Produto(int codigo, string? nome, string? descricao, double? preco, string? categoria, DateTime? dataVencimento)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Categoria = categoria;
            DataVencimento = dataVencimento;
        }

        public Produto() { }

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public double? Preco { get; set; }
        public string? Categoria { get; set; }
        public DateTime? DataVencimento { get; set; }

        public static List<Produto> ListaProduto = new List<Produto>();


    }

    
}
