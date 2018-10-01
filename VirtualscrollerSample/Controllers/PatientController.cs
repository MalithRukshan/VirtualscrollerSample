using VirtualscrollerSample.Model;
using VirtualscrollerSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace VirtualscrollerSample.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        private IDataServices _services;
        public PatientController(IDataServices _services)
        {
            this._services = _services;
        }
   
        [HttpGet]
        public IActionResult Get(SearchRequest searchRequest)
        {
            return Ok(_services.PatientSearch(searchRequest));
        }

    }
}
