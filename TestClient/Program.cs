using LoginApiClientV3;
using LoginApiClientV3.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestClient
{
    public class Program
    {

        static async Task Main(string[] args)
        {
            var program = new Program();
            var result = await program.CallClientAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<BookingDetailsDTO>> CallClientAsync()
        {
            var client = new LoginClient();

            var result = await client.PostNewBooking(new FormDataRequestDTO { Date = "11/7/2020"});

            return result;
        }


    }


}
