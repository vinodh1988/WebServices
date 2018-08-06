using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRest.Controllers
{
    [RoutePrefix("tvs-api/test")]
    public class TestController : ApiController
    {
        // GET: api/Test
        [Route("read/all")]
        public IEnumerable<string> Get()
        {
            return new string[] { "John", "Naveen" };
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value is "+id;
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
