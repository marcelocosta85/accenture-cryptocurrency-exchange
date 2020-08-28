using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptocurrencyExchange.App.ViewModels
{
    public class PairViewModel
    {
        [JsonPropertyName("base")]
        public string Base { get; set; }
        [JsonPropertyName("quote")]
        public string Quote { get; set; }
        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        [JsonPropertyName("price_usd")]
        public decimal PriceUSD { get; set; }
        [JsonPropertyName("time")]
        public int Time { get; set; }
    }
}
