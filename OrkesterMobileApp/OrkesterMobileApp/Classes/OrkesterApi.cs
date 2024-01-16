using Orkesterapp.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OrkesterMobileApp.Classes
{
    public class OrkesterApi
    {
        private readonly HttpClient _httpclient;

        public OrkesterApi()
        {
            _httpclient = new HttpClient();

            _httpclient.BaseAddress = new Uri("https://orkesterapp.azurewebsites.net/Data/");
            _httpclient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<User> GetUser(string email, string pass) 
        {
            var response = await _httpclient.GetAsync($"user?email={email}&pass={pass}");

            response.EnsureSuccessStatusCode();

            string resonsestring = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<User>(resonsestring);
        }
    }
}
