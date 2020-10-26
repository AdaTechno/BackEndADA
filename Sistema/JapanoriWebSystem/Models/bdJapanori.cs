using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JapanoriWebSystem.Models
{
    public class bdJapanori { }

    public class Comanda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Situacao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ComandaProduto> ComandaProdutos { get; set; }

    }
    public class ComandaProduto
    {
        public int ComandaProdutoID { get; set; }
        public int ComandaID { get; set; }
        public int ProdutoID { get; set; }
        public virtual Comanda Comanda { get; set; }
        public virtual Produto Produto { get; set; }
    }
    public class Produto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Desc { get; set; }
        public double Preco { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ComandaProduto> ComandaProdutos { get; set; }

    }
    public class ProdutoEstoque 
    {
        public int ProdutoEstoqueID { get; set; }
        public int ProdutoID { get; set; }
        public int EstoqueID { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Estoque Estoque { get; set; }

    }
    public enum TipoQuantidade
    {
        Unidades, Quilos, Gramas, Miligramas, Litros, Mililitros, Centímetros, Metros 
    }
    public class Estoque
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstoqueID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public TipoQuantidade? TipoQuantidade { get; set; }
        public DateTime UltimoCarregamento { get; set; }
        public string Status { get; set; }

    }
}