using Bucket.Transaction.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bucket.Transaction.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        List<TransactionModel> _transactions;
        public TransactionsController()
        {
            _transactions = new List<TransactionModel>()
            {
                new TransactionModel() { Name = "Transaction 1", Id = 1 },
                new TransactionModel() { Name = "Transaction 2", Id = 2 },
                new TransactionModel() { Name = "Transaction 3", Id = 3 },
                new TransactionModel() { Name = "Transaction 4", Id = 4 }
            };
        }

        // GET api/transactions
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_transactions);
        }

        // GET api/transactions/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_transactions.Single(s => s.Id == id));
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
