﻿using Conectar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UsuarioApi.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<Usuarios> Get()
        {
            using (LaHueseraEntities objUsuario= new LaHueseraEntities())
            {
                return objUsuario.Usuarios.ToList();
            }
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
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
