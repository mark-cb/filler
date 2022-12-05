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
    //[Authorize]
    public class FindSiteController : BaseController
    {        
        private const string NoSitesFoundMsg = "No sites found.";        

        public FindSiteController(IFuelRepo fuelRepo) : base(fuelRepo)
        {            
        }
    


    // GET: api/<FindSiteController>
    [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]        
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results<BadRequest<string>, Ok<List<Site>>>> Get()
        {
            // configure await false as not executing on UI thread
            var result = await _fuelRepo.GetSitesAsync().ConfigureAwait(false);

            if (result == null)
                return TypedResults.BadRequest<string>(NoSitesFoundMsg);
            else
                return TypedResults.Ok<List<Site>>(result);
        }

        // GET api/<FindSiteController>/int
        [HttpGet("{siteId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results<BadRequest<string>, Ok<Site>>> Get(int siteId)
        {
            // logging here Log.Info($"Starting {nameof(Get)}.);

            Site? site = await _fuelRepo.GetSiteAsync(siteId).ConfigureAwait(false);
            if (site == null)
            {
                return TypedResults.BadRequest<string>($"Site with {nameof(siteId)} {siteId} not found.");
            }
            else
            {
                return TypedResults.Ok<Site>(site);
            }

        }
    }
}
