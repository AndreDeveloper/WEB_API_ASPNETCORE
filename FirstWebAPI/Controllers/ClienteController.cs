using FirstWebAPI.DAO;
using FirstWebAPI.Filters;
using FirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPI.Controllers
{
    [AuthenticationFilter]
    public class ClienteController : ApiController
    {
        private ClienteDAO dao = ClienteDAO.getInstance();


        // GET: api/Cliente
        public IList<Cliente> Get()
        {
            return dao.getAll();
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cliente
        public void Post([FromBody]Cliente cliente)
        {
            if (cliente != null)
                dao.insert(cliente);
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
