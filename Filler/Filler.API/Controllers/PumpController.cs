using Filler.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filler.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PumpController : BaseController
    {
        IEnumerable<Pump> pumps = new List<Pump> { new Pump { PumpId = 1, Number = 4 } };

        // GET api/v1/<PumpController>
        [HttpGet(Name = "GetListOfPumps")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Pump> Get([FromRoute] int siteId)
        {         
            // todo repo and pass site id
            return pumps;
        }


        // POST api/v1/<PumpController>
        [HttpPost(Name = "Unlock a pump")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Pump Post([FromBody] int pumpId)
        {
            // is user authenticated? are they allowed to unlock this pump?

            // yes
            Pump pump = pumps.FirstOrDefault(p => p.PumpId == pumpId);
            if (pump == null)
            {
                throw new ArgumentNullException($"{nameof(pumpId)} not found.");
            }
            else
            {
                // is user authenticated? are they allowed to unlock this pump?
                // yes
                pump.UnLocked = true;
                return pump;
            }
        }


    }
}
