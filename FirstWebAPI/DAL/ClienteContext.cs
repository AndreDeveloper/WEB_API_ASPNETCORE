using FirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstWebAPI.DAL
{
    public class ClienteContext : DbContext
    {
        private static ClienteContext instance;

        public static ClienteContext getInstance()
        {
            if (instance == null)
                instance = new ClienteContext();

            return instance;
        }
        public ClienteContext()
            :base("Clientes")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}