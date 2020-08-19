using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyExchange.Business.Models
{
    public class Coin : Entity
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Nameid { get; set; }
        public int Rank { get; set; }
        public string PriceUsd { get; set; }
        public string PercentChange24h { get; set; }
        public string PercentChange1h { get; set; }
        public string PercentChange7d { get; set; }
        public string MarketCapUsd { get; set; }
        public string Volume24 { get; set; }
        public string Volume24Native { get; set; }
        public string Csupply { get; set; }
        public string PriceBtc { get; set; }
        public string Tsupply { get; set; }
        public string Msupply { get; set; }
    }
}
