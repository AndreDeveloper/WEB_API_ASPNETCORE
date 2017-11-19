using FirstWebAPI.DAL;
using FirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebAPI.DAO
{
    public class UsuarioDAO
    {
        private static UsuarioDAO instance;
        private ClienteContext db;

        public UsuarioDAO(ClienteContext context)
        {
            db = context;
        }

        public static UsuarioDAO getInstance()
        {
            if (instance == null)
                instance = new UsuarioDAO(ClienteContext.getInstance());

            return instance;
        }

        public void insert(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }

        public Boolean authorize(Usuario usuario)
        {
            if (db.Usuarios.Where(u => u.userName.Equals(usuario.userName) && u.passWord.Equals(usuario.passWord)).FirstOrDefault() == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public IList<Usuario> getAll()
        {
            return db.Usuarios.ToList();
        }
    }
}