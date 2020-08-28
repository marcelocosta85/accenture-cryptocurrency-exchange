using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyExchange.Business.Models
{
    public class Pair
    {
        public string Base { get; set; }
        public string Quote { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public decimal PriceUSD { get; set; }
        public int Time { get; set; }
    }
}
