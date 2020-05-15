﻿using LoginApiClientV3.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LoginApiClientV3
{
    public class LoginClient : ILoginClient
    {
        private string _url = "http://dev.loginapi.com/api/login/validuser";
        HttpClient _client = new HttpClient();

        public async Task<bool> PostValidUserAsync(LoginRequestDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_url, data);
            var content = await response.Content.ReadAsAsync<bool>();
            return content;
        }
    }

}