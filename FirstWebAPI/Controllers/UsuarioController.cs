using FirstWebAPI.DAO;
using FirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        private UsuarioDAO dao = UsuarioDAO.getInstance();
        // GET: api/Usuario
        public IList<Usuario> Get()
        {
            return dao.getAll();
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public void Post([FromBody]Usuario usuario)
        {
            if (usuario != null)
                dao.insert(usuario);
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
