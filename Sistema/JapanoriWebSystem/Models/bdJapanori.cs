﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JapanoriWebSystem.Models
{
#pragma warning disable IDE1006 // Estilos de Nomenclatura
    public class bdJapanori { }
#pragma warning restore IDE1006 // Estilos de Nomenclatura

    [Table("tbComanda")]
    public class Comanda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None),DisplayName("Código da Comanda")]
        public int ID { get; set; }

        [DisplayName("Situação")]
        public string Situacao { get; set; }

        public virtual ICollection<ComandaProduto> Produtos { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

    }

    [Table("tbProduto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Desc { get; set; }
        public double Preco { get; set; }

        [DisplayName("Itens do Estoque")]
        public virtual ICollection<ProdutoEstoque> EstoqueItens { get; set; }
        public string Status { get; set; }
        
    }

    [Table("tbComandaProduto")]
    public class ComandaProduto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComandaProdutoID { get; set; }

        [ForeignKey("Comanda")]
        public int ComandaID { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoID { get; set; }

        public virtual Comanda Comanda { get; set; }
        public virtual Produto Produto { get; set; }
    }

    public enum TipoQuantidade
    {
        Unidades, Quilos, Gramas, Miligramas, Litros, Mililitros, Centímetros, Metros
    }

    [Table("tbEstoque")]
    public class Estoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstoqueID { get; set; }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public TipoQuantidade? TipoQuantidade { get; set; }
        public DateTime UltimoCarregamento { get; set; }
        public string Status { get; set; }
    }

    [Table("tbProdutoEstoque")]
    public class ProdutoEstoque 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoEstoqueID { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoID { get; set; }

        [ForeignKey("Estoque")]
        public int EstoqueID { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual Estoque Estoque { get; set; }
    }

    
}