using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vswebapi.Models;

namespace vswebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public static List<Customer> customers;
        public CustomerController()
        {
            customers = new List<Customer>()
            {
                new Customer() {Id = 4, Name = "Carlos", Birthday = Convert.ToDateTime("1995-12-05") },
                new Customer() {Id = 5, Name = "Antonio", Birthday = Convert.ToDateTime("1992-05-12") }
            };
        }
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return customers.Where(c => c.Id == id).FirstOrDefault();
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] Customer c)
        {
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer c)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
