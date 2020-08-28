using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptocurrencyExchange.App.ViewModels
{
    public class ExchangesViewModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("name_id")]
        public string NameId { get; set; }
        [JsonPropertyName("volume_usd")]
        public decimal VolumeUSD { get; set; }
        [JsonPropertyName("active_pairs")]
        public int ActivePairs { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
