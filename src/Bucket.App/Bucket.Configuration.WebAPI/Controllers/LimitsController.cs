using Bucket.Configuration.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bucket.Configuration.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LimitsController : ControllerBase
    {
        List<LimitModel> _limits;
        public LimitsController()
        {
            _limits = new List<LimitModel>()
            {
                new LimitModel() { Name = "Limit 1", Id = 1 },
                new LimitModel() { Name = "Limit 2", Id = 2 },
                new LimitModel() { Name = "Limit 3", Id = 3 },
                new LimitModel() { Name = "Limit 4", Id = 4 }
            };
        }

        // GET api/limits
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_limits);
        }

        // GET api/limits/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_limits.Single(s => s.Id == id));
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
