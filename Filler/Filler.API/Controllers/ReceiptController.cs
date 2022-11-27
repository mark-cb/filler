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
            new Receipt { Id = Guid.Parse("e5aa6b6b-dc73-4e36-b9c4-17933d459358"), FuelType = FuelType.Petrol, Litres = 43, Total = 78.69, UserId = Guid.Parse("e5aa6b6b-dc73-4e36-b9c4-17933d459358"), FillTime = DateTime.UtcNow },
            new Receipt { Id = Guid.Parse("31f8cb43-a968-4df2-9416-9c358ce66131"), FuelType = FuelType.Diesel, Litres = 21, Total = 38.43, UserId = Guid.Parse("e5aa6b6b-dc73-4e36-b9c4-17933d459358"), FillTime = DateTime.UtcNow.AddDays(-1) },
            new Receipt { Id = Guid.Parse("1da50a1a-9999-4643-9406-ac731b5775df"), FuelType = FuelType.Petrol, Litres = 55, Total = 100.65, UserId = Guid.Parse("e5aa6b6b-dc73-4e36-b9c4-17933d459358"), FillTime = DateTime.UtcNow.AddDays(-7) }};

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
