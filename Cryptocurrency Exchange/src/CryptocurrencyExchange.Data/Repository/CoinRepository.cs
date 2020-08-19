using CryptocurrencyExchange.Business.Interfaces;
using CryptocurrencyExchange.Business.Models;
using CryptocurrencyExchange.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyExchange.Data.Repository
{
    public class CoinRepository : Repository<Coin>, ICoinRepository
    {
        public CoinRepository(CryptocurrencyDbContext context) : base(context)
        {

        }
        
    }
}
