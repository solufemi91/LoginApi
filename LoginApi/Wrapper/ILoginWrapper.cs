using LoginApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Wrapper
{
    public interface ILoginWrapper
    {
        IEnumerable<LoginDetails> ValidUser(LoginRequest loginRequest);

        IEnumerable<BookingDetails> GetBookingDetails(int id);
    }
}
