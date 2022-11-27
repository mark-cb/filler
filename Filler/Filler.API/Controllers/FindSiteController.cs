using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filler.API.Controllers
{
    [Route("api/v1[controller]")]
    [ApiController]
    public class FindSiteController : BaseController
    {
        // GET: api/<FindSiteController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FindSiteController>/GUID
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "value";
        }
    }
}
