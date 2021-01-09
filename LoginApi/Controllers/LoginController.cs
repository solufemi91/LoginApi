﻿using System.Collections.Generic;
using System.Linq;
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
            var result = _loginWrapper.ValidUser(loginRequest).ToList().FirstOrDefault();
            return new JsonResult(result);
        }


        [HttpPost]
        [Route("addBooking")]
        public JsonResult PostNewBooking([FromBody] FormDataRequest formDataRequest)
        {
            var result = _loginWrapper.PostNewBooking(formDataRequest);
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public JsonResult GetBookingDetails(int id)
        {
            var result = _loginWrapper.GetBookingDetails(id);
            return new JsonResult(result);
        }

    }
}
