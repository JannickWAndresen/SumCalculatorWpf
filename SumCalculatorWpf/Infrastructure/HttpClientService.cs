using SumCalculatorWpf.ApplicationLayer;
using SumCalculatorWpf.Entitites;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SumCalculatorWpf.Infrastructure
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _client;

        public HttpClientService (string baseUrl = null)
        {
            _client = new HttpClient();
            if (baseUrl != null)
            {
                _client.BaseAddress = new Uri(baseUrl);
            }
        }

        public Task<T> GetAsync<T>(string url)
        {
            throw new NotImplementedException();
        }

        public async Task<T> PostAsync<T>(string url, object data)
        {
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(url, content);

            var responseContent = await response.Content.ReadAsStringAsync();

            Debug.WriteLine(responseContent);

            return JsonSerializer.Deserialize<T>(responseContent);
        }
    }
}
