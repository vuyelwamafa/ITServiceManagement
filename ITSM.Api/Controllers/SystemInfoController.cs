using Microsoft.AspNetCore.Mvc;

namespace ITSM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemInfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("IT Service Management Platform \nVersion 1.0 \nStatus: Development");
        }
    }
}
