using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVersion()
        {
            return Ok($"Bugünün Tarihi: {DateTime.Now}");
        }
    }
}
