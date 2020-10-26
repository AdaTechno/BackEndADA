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

        public JapanoriContext() : base("JapanoriContext")
        {
        }

        public DbSet<tbComanda> Comandas { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}