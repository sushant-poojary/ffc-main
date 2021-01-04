using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ffc_backend.FccDBApi;
using ffc_backend.Model.collection;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ffc_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Services : ControllerBase
    {

        private readonly DBConnectionService mDatabaseService;

        public Services(DBConnectionService bookService)
        {
            mDatabaseService = bookService;
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
        [HttpPost("register-user")]
        public void PostRegisterUser([FromBody] User user)
        {
            mDatabaseService.RegisterUser(user.username, user.password, user.name);
        }

        //[HttpPost("register-user")]
        //public void PostRegisterUser([FromBody] string username, [FromBody] string password, [FromBody] string name)
        //{
        //    mDatabaseService.RegisterUser(username, password, name);
        //}

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
