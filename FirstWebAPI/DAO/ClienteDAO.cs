using FirstWebAPI.DAL;
using FirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebAPI.DAO
{
    public class ClienteDAO
    {
        private static ClienteDAO instance;
        private ClienteContext db;

        public ClienteDAO(ClienteContext context)
        {
            db = context;
        }

        public static ClienteDAO getInstance()
        {
            if (instance == null)
                instance = new ClienteDAO(ClienteContext.getInstance());

            return instance;
        }

        public void insert(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }

        public IList<Cliente> getAll()
        {
            return db.Clientes.ToList();
        }
    }
}