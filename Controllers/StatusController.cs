using Microsoft.AspNetCore.Mvc;

namespace ITSM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("ITSM API is ready and online");
        }
    }
}
