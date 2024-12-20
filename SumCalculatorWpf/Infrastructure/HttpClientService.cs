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
using System.Windows.Documents;

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

        public async Task<string> DeleteAsync<T>(string url, string id)
        {
            string fullUri = url + "/" + id;
            var response = await _client.DeleteAsync(fullUri);
            Debug.WriteLine("message after ReadAsStringAsync()");
            var responseContent = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(responseContent);

            return responseContent;
        }

        public async Task<T> GetAsync<T>(string url)
        {
            var response = await _client.GetAsync(url);
            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(responseContent);
        }

        public async Task<T> PostAsync<T>(string url, object data)
        {
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(url, content);

            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(responseContent);
        }
    }
}
