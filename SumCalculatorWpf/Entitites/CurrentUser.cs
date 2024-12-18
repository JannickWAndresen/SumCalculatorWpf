using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SumCalculatorWpf.Entitites
{
    public class CurrentUser
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }
        [JsonPropertyName("user")]
        public UserInfo? User { get; set; }
    }
}
