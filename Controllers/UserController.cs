using Microsoft.AspNetCore.Mvc;

namespace WindowsAuthentication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetCurrentUser")]
        public string GetCurrentUser()
        {
            return HttpContext.User.Identity.Name;
        }
    }
}
