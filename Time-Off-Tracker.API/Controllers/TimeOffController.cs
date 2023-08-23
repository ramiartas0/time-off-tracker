using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Time_Off_Tracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeOffController : ControllerBase
    {
        [HttpGet]
        public IActionResult TimeOffList()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult TimeOffAdd()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult TimeOffDelete()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult TimeOffUpdate()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult TimeOffGet()
        {
            return Ok();
        }
    }
}
