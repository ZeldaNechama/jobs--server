using Jobs_server.Interfaces;
using Jobs_server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jobs_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILoginService loginService;

        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpPost]
        public User GetUser(string name,string password)
        {
            return this.loginService.GetUser(name, password);
        }
    }
}
