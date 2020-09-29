using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ffc_backend.FccDBApi;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ffc_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Services : ControllerBase
    {

        private readonly DBConnectionService _bookService;

        public Services(DBConnectionService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/<Services>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Services>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Services>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //MongoDB.Driver.Builders<Conta
        }

        // PUT api/<Services>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Services>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
