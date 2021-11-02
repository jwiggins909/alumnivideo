using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Model;
using api.Data;
using Microsoft.AspNetCore.Cors;


namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class personController : ControllerBase
    {
        // GET: api/person
        [EnableCors("OtherPolicy")]
        [HttpGet]
        public List<Person> Get()
        {
            IPersonDataHandler dataHandler = new PersonDataHandler();
            return dataHandler.Select();
        }
        

        // GET: api/person/5
        [EnableCors("OtherPolicy")]

        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/person
        [HttpPost]
        public void Post([FromBody] Person value)
        {
            value.dataHandler.Insert(value);
        }

        // PUT: api/person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person value)
        {
            System.Console.WriteLine("Get FirstName");
            value.dataHandler.Update(value);
        }

        // DELETE: api/person/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
