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
        IEnumerable<Receipt> receipts = new List<Receipt> {
            new Receipt { Id = 1, FuelType = FuelType.Petrol, Litres = 43, Total = 78.69, UserId = "e5aa6b6b-dc73-4e36-b9c4-17933d459358", FillTime = DateTime.UtcNow },
            new Receipt { Id = 2, FuelType = FuelType.Diesel, Litres = 21, Total = 38.43, UserId = "e5aa6b6b-dc73-4e36-b9c4-17933d459358", FillTime = DateTime.UtcNow.AddDays(-1) },
            new Receipt { Id = 3, FuelType = FuelType.Petrol, Litres = 55, Total = 100.65, UserId = "e5aa6b6b-dc73-4e36-b9c4-17933d459358", FillTime = DateTime.UtcNow.AddDays(-7) }};

        // GET: api/<ReceiptController>
        [HttpGet(Name="GetMyReceipts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Receipt> Get()
        {
            return receipts;
        }       
    }
}
