using Filler.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filler.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PumpController : BaseController
    {
        IEnumerable<Pump> pumps = new List<Pump> { new Pump { Id = Guid.Parse("1da50a1a-9999-4643-9406-ac731b5775df"), Number = 4 } };

        // GET api/v1/<PumpController>
        [HttpGet(Name = "GetListOfPumps")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Pump> Get()
        {
            // better to create a UUID class to handle ToString as this will get repetitive
            return pumps;
        }


        // POST api/v1/<PumpController>
        [HttpPost(Name = "Unlock a pump")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Pump Post([FromBody] Guid pumpID)
        {
            // is user authenticated? are they allowed to unlock this pump?

            // yes
            Pump pump = pumps.FirstOrDefault(p => p.Id == pumpID);
            if (pump == null)
            {
                throw new ArgumentNullException($"{nameof(pumpID)} not found.");
            }
            else
            {
                // is user authenticated? are they allowed to unlock this pump?
                // yes
                pump.Locked = true;
                return pump;
            }
        }


    }
}
