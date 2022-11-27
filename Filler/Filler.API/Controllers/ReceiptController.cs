using Filler.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filler.API.Controllers
{

    // versioning api    
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        //Enumerable<Receipt> receipts = new List<Receipt> { new Receipt { Id = Guid.Parse("e5aa6b6b-dc73-4e36-b9c4-17933d459358"), FuelType.Petrol, Litres = 43,  };

        // GET: api/<ReceiptController>
        [HttpGet(Name="GetMyReceipts")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }       
    }
}
