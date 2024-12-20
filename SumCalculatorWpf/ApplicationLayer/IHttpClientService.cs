using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWpf.ApplicationLayer
{
    internal interface IHttpClientService
    {
        Task<T> GetAsync<T>(string url);
        Task<T> PostAsync<T>(string url, object data);
        Task<string> DeleteAsync<T>(string url, string id);
    }
}
