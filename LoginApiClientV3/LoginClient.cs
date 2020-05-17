using LoginApiClientV3.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LoginApiClientV3
{
    public class LoginClient : ILoginClient
    {
        private static string _baseURL = "http://dev.loginapi.com/api/login";
        private string _url = $"{_baseURL}/validuser";
        HttpClient _client = new HttpClient();

        public async Task<LoginResponseDTO> PostValidUserAsync(LoginRequestDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_url, data);
            var content = await response.Content.ReadAsAsync<LoginResponseDTO>();
            return content;
        }

        public async Task<IEnumerable<BookingDetailsDTO>> GetBookingDetailsAsync(int? id)
        {
            var request = $"{_baseURL}/{id}";
            var response = await _client.GetAsync(request);
            var content = await response.Content.ReadAsAsync<IEnumerable<BookingDetailsDTO>>();
            return content;
        }
    }

}
