using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bucket.Management.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementsController : ControllerBase
    {
        // GET api/managements
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "management1", "management2" };
        }

        // GET api/managements/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "management";
        }

        // POST api/managements
        [HttpPost]
        public void Post([FromBody] string management)
        {
        }

        // PUT api/managements/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string management)
        {
        }

        // DELETE api/managements/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
