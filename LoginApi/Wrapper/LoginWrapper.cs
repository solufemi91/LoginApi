using LoginApi.Models;
using LoginApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Wrapper
{
    public class LoginWrapper : ILoginWrapper
    {
        private readonly ILoginRepository _loginRepository;
        public LoginWrapper(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool ValidUser(LoginRequest loginRequest)
        {
            var result = _loginRepository.GetLogin(loginRequest);

            return result.ToList().Count > 0;
        }
    }
}
