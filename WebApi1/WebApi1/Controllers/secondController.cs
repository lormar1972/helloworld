using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi1.Controllers
{
    public class secondController : ApiController
    {
        // GET: api/second
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/second/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/second
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/second/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/second/5
        public void Delete(int id)
        {
        }
    }
}
