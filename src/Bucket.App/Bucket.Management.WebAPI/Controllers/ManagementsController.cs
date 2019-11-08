using Bucket.Management.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bucket.Management.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementsController : ControllerBase
    {
        List<ManagementModel> _managements;
        public ManagementsController()
        {
            _managements = new List<ManagementModel>()
            {
                new ManagementModel() { Name = "Management 1", Id = 1 },
                new ManagementModel() { Name = "Management 2", Id = 2 },
                new ManagementModel() { Name = "Management 3", Id = 3 },
                new ManagementModel() { Name = "Management 4", Id = 4 }
            };
        }

        // GET api/managements
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_managements);
        }

        // GET api/managements/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_managements.Single(s => s.Id == id));
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
