using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyExchange.Business.Models
{
    public class Exchange : Entity
    {
        public ExchangeInfo Info { get; set; }
        public List<Pair> Pairs { get; set; }
    }

    public class ExchangeInfo
    {
        public string Name { get; set; }
        public string DateLive { get; set; }
        public string Url { get; set; }
    }
}
