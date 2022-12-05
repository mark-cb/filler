using Filler.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Filler.API.Controllers
{

    /// <summary>
    /// Base controller to handle things like claims and service filters for all controllers. 
    /// </summary>
    /// [ServiceFilter(typeof(CustomHeaderFilterAttribute))] 
    public class BaseController : ControllerBase
    {
        protected readonly IFuelRepo _fuelRepo;

        public BaseController(IFuelRepo fuelRepo)
        {
            _fuelRepo = fuelRepo;
        }
    }
}