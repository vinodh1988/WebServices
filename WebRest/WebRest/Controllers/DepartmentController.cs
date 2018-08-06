using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRest.Controllers
{
    public class DepartmentController : ApiController
    {
        AdventureWorks2014Entities context = new AdventureWorks2014Entities();
        // GET: api/Department
        public IHttpActionResult Get()
        {

            var query = from department in context.Departments
                        select new
                        {
                            department.DepartmentID,
                            department.Name,
                            department.GroupName,
                            department.ModifiedDate
                        };
            return Ok(query);
        }

        // GET: api/Department/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Department
        public IHttpActionResult Post([FromBody]Department d)
        {
            try
            {
                context.Departments.Add(d);
                context.SaveChanges();
                return Ok(d);
            }
            catch (Exception e) {
                return InternalServerError();
            }
        }

        // PUT: api/Department/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Department/5
        public void Delete(int id)
        {
        }
    }
}
