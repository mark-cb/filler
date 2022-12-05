using Filler.API.Models;
using Filler.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filler.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    // [Authorize]
    public class PumpController : BaseController
    {
        public PumpController(IFuelRepo fuelRepo) : base(fuelRepo)
        {
        }


        // GET api/v1/<PumpController>
        [HttpGet(Name = "GetListOfPumps")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Results<BadRequest<string>, Ok<List<Pump>>>> Get([FromRoute] int siteId)
        {
            var result = await this._fuelRepo.GetPumpsAsync(siteId).ConfigureAwait(false);
            if (result == null)
                return TypedResults.BadRequest<string>($"No pumps for Site with {nameof(siteId)}: {siteId} found.");
            else
                return TypedResults.Ok<List<Pump>>(result);
        }


        // POST api/v1/<PumpController>
        [HttpPost(Name = "Unlock a pump")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results<BadRequest<string>, Ok<Pump>>> Post([FromBody] int pumpId)
        {
            // is user authenticated? are they allowed to unlock this pump?
            // yes
            Pump pump = await _fuelRepo.GetPumpAsync(pumpId).ConfigureAwait(false);

            if (pump == null)
                return TypedResults.BadRequest<string>($"No pumps with {nameof(pump)}: {pumpId} found.");
            else
            {
                // is user authenticated? are they allowed to unlock this pump?
                // yes
                pump.UnLocked = true;
                // update pump in EF and save
                return TypedResults.Ok<Pump>(pump);
            }
        }


    }
}
