using _3dcartSampleActionApp.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace _3dcartSampleActionApp.Services
{
    public class _3dcartRestApiService : I3dcartRestApiService
    {
        private readonly IConfiguration _config;

        public _3dcartRestApiService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<T> MakeRequestAsync<T>(string endpoint, string token, int id, string storeSecureUrl)
        {
            var baseUrl = _config.GetValue<string>("ApplicationSettings:BaseRestApiUrl");
            var appPrivateKey = _config.GetValue<string>("ApplicationSettings:AppPrivateKey");

            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("SecureUrl", storeSecureUrl);
            client.DefaultRequestHeaders.Add("PrivateKey", appPrivateKey);
            client.DefaultRequestHeaders.Add("Token", token);
            using HttpResponseMessage response = await client.GetAsync($"{endpoint}/{id}");
            response.EnsureSuccessStatusCode();
            using HttpContent content = response.Content;
            var body = await content.ReadAsStringAsync();            
            return JsonSerializer.Deserialize<T>(body);
        }
    }
}
