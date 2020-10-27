using JapanoriWebSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace JapanoriWebSystem.DAL
{
    public class JapanoriContext : DbContext
    {

        public JapanoriContext() : base()
        {
        }

        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaProduto> ComandaProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoEstoque> ProdutoEstoques { get; set; }
        public DbSet<Estoque> Estoques { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}