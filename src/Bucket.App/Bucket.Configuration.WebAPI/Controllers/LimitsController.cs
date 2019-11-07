using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bucket.Configuration.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LimitsController : ControllerBase
    {
        // GET api/limits
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "limit1", "limit2" };
        }

        // GET api/limits/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "limit";
        }

        // POST api/limits
        [HttpPost]
        public void Post([FromBody] string limit)
        {
        }

        // PUT api/limits/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string limit)
        {
        }

        // DELETE api/limits/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
