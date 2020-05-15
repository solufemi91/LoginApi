using System.Collections.Generic;
using LoginApi.Models;
using LoginApi.Wrapper;
using Microsoft.AspNetCore.Mvc;

namespace LoginApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginWrapper _loginWrapper;
        public LoginController(ILoginWrapper loginWrapper)
        {
            _loginWrapper = loginWrapper;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {  "100" };
        }

        [HttpPost]
        [Route("validuser")]
        public JsonResult Post([FromBody] LoginRequest loginRequest)
        {
            var result = _loginWrapper.ValidUser(loginRequest);
            return new JsonResult(result);
        }

    }
}
