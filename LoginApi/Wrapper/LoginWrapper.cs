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

        public IEnumerable<LoginDetails> ValidUser(LoginRequest loginRequest)
        {
            var result = _loginRepository.GetLogin(loginRequest);

            return result;
        }

        public IEnumerable<BookingDetails> GetBookingDetails(int id)
        {
            var result = _loginRepository.GetBookingDetails(id);

            return result;
        }
    }
}
