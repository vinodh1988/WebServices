using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRest.Controllers
{
    public class EmployeeController : ApiController
    {
        AdventureWorks2014Entities entities = new AdventureWorks2014Entities();
        // GET: api/Employee
        public IHttpActionResult Get()
        {
            
            return Ok(entities.Employees.ToList());
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public IHttpActionResult Put(int id, [FromBody]Employee emp)
        {
            //Employee e=entities.Employees.Single(x => x.BusinessEntityID == id);
            try
            {
                entities.uspUpdateEmployeePersonalInfo(id, emp.NationalIDNumber, emp.BirthDate, emp.MaritalStatus, emp.Gender);
                
                return Ok(emp);
            }
            catch {
                return NotFound();
            }
                

        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
