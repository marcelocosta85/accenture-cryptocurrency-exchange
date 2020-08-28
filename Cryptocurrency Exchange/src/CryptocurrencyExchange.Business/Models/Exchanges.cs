using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyExchange.Business.Models
{
    public class Exchanges
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NameId { get; set; }
        public decimal VolumeUSD { get; set; }
        public int ActivePairs { get; set; }
        public string Url { get; set; }
        public string Country { get; set; }
    }
}
