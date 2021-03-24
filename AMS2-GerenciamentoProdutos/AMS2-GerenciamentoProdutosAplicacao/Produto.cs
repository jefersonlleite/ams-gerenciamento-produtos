using System;
using System.Collections.Generic;
using System.Text;

namespace AMS2_GerenciamentoProdutosAplicacao
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public int CategoriaId { get; set; }
        public string NomeProduto { get; set; }
        public string NomeFornecedor { get; set; }
        public string DescricaoProduto { get; set; }
        public DateTime DataValidade { get; set; }
        public int EstoqueProduto { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCompra { get; set; }
        public bool Ativo { get; set; }
    }
}
