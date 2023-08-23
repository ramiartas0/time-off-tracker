using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Time_Off_Tracker.API.Controllers
{
    [Route("users")] // İstenilen URL yapısı
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UserUpdate(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
    
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateUser(int id)
        {
            return Ok();
        }

        [HttpPost("password-changes")]
        public IActionResult AddUser()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult UserList()
        {
            return Ok();
        }


    }
}
