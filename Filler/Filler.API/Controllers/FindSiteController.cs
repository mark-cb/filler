using Filler.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filler.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FindSiteController : BaseController
    {
        // for simplicity without introducing additional persitance layers are repos
        IEnumerable<Site> sites = new List<Site> { new Site { SiteId = 1, Latitude = 54.589752, Longitude = -1.350426, Name = "BP Durham Road", NumberOfPumps = 6 },
            new Site { SiteId = 2, Latitude = 54.589752, Longitude = -1.350426, Name = "BP London", NumberOfPumps = 4 },
            new Site { SiteId = 3, Latitude = 51.483875, Longitude = -0.000862, Name = "BP Trafalgar Road", NumberOfPumps = 12 }};

        // GET: api/<FindSiteController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Site> Get()
        {
            return sites;
        }

        // GET api/<FindSiteController>/GUID
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Site Get(int id)
        {
            // logging here Log.Info($"Starting {nameof(Get)}.);

            // better to create a UUID class to handle ToString as this will get repetitive
            Site site = sites.FirstOrDefault(s => s.SiteId == id);
            if (site == null)
            {
                throw new ArgumentNullException($"{nameof(id)} not found.");
            }
            else
            {
                return site;
            }

        }
    }
}
