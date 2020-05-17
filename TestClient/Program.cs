using LoginApiClientV3;
using LoginApiClientV3.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestClient
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World!");
            var obj = new Program();
            var result =  obj.CallClientAsync().Result;
        }

        public async Task<IEnumerable<BookingDetailsDTO>> CallClientAsync()
        {
            var client = new LoginClient();

            var result = await client.GetBookingDetailsAsync(5);

            return result;
        }
    }
}
