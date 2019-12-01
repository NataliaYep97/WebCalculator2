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
    public class PlusController : ControllerBase
    {
        // GET: api/Plus
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Plus/5
        [HttpGet("{a}/{b}", Name = "Plus")]
        public int Plus(int a, int b)
        {
            return a + b;
        }

        // POST: api/Plus
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Plus/5
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
