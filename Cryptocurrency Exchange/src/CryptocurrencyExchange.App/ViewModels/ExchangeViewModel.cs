using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptocurrencyExchange.App.ViewModels
{
    public class ExchangeViewModel
    {
        [JsonPropertyName("0")]
        public ExchangeInfo Info { get; set; }
        [JsonPropertyName("pairs")]
        public List<PairViewModel> Pairs { get; set; }
    }

    public class ExchangeInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("date_live")]
        public string DateLive { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
