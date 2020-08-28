using System.Text.Json.Serialization;

namespace CryptocurrencyExchange.App.ViewModels
{
    public class CoinViewModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("nameid")]
        public string Nameid { get; set; }
        [JsonPropertyName("rank")]
        public int Rank { get; set; }
        [JsonPropertyName("price_usd")]
        public string PriceUsd { get; set; }
        [JsonPropertyName("percent_change_24h")]
        public string PercentChange24h { get; set; }
        [JsonPropertyName("percent_change_1h")]
        public string PercentChange1h { get; set; }
        [JsonPropertyName("percent_change_7d")]
        public string PercentChange7d { get; set; }
        [JsonPropertyName("market_cap_usd")]
        public string MarketCapUsd { get; set; }
        [JsonPropertyName("volume24")]
        public string Volume24 { get; set; }
        [JsonPropertyName("volume24_native")]
        public string Volume24Native { get; set; }
        [JsonPropertyName("csupply")]
        public string Csupply { get; set; }
        [JsonPropertyName("price_btc")]
        public string PriceBtc { get; set; }
        [JsonPropertyName("tsupply")]
        public string Tsupply { get; set; }
        [JsonPropertyName("msupply")]
        public string Msupply { get; set; }
    }
}
