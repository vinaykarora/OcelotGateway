using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bucket.Transaction.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        // GET api/transaction
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "transaction1", "transaction2" };
        }

        // GET api/transaction/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "transaction";
        }

        // POST api/transaction
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT api/transaction/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string value)
        {
            return value;
        }

        // DELETE api/transaction/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Accepted();
        }
    }
}
