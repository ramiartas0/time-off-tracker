using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Time_Off_Tracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult UserList()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult UserAdd()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult UserDelete()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UserUpdate()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult UserGet()
        {
            return Ok();
        }
    }
}
