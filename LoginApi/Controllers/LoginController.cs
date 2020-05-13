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

        // GET: api/Login
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Login
        [HttpPost]
        public JsonResult Post([FromBody] LoginRequest loginRequest)
        {
            var result = _loginWrapper.ValidUser(loginRequest);
            return new JsonResult(result);
        }

    }
}
