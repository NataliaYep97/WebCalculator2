using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiController : ControllerBase
    {
        // GET: api/Multi
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Multi/5
        [HttpGet("{a}/{b}", Name = "Multi")]
        public int Multi(int a, int b)
        {
            return a * b;
        }

        // POST: api/Multi
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Multi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
