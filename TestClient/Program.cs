using LoginApiClientV3;
using LoginApiClientV3.Models;
using System;
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

        public async Task<LoginResponseDTO> CallClientAsync()
        {
            var client = new LoginClient();

            var request = new LoginRequestDTO { UserName = "Solufemi91", Password = "Password" };

            var result = await client.PostValidUserAsync(request);

            return result;
        }
    }
}
