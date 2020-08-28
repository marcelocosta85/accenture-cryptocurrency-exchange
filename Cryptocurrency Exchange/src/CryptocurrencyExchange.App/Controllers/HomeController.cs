using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CryptocurrencyExchange.App.Models;
using CryptocurrencyExchange.App.ViewModels;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CryptocurrencyExchange.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Coin()
        {
            CoinViewModel coin = new CoinViewModel();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.coinlore.net/api/ticker/?id=90"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    apiResponse = apiResponse.Trim('[').Trim(']');
                    coin = JsonSerializer.Deserialize<CoinViewModel>(apiResponse);
                    //JsonDocument document = JsonDocument.Parse(apiResponse.Trim('[').Trim(']'));
                    //coin = new CoinViewModel
                    //{
                    //    Id = document.RootElement.GetProperty("id").ToString(),
                    //    Symbol = document.RootElement.GetProperty("symbol").ToString(),
                    //    Name = document.RootElement.GetProperty("name").ToString(),
                    //    Nameid = document.RootElement.GetProperty("nameid").ToString(),
                    //    Rank = document.RootElement.GetProperty("rank").GetInt32(),
                    //    PriceUsd = document.RootElement.GetProperty("price_usd").ToString(),
                    //    PercentChange24h = document.RootElement.GetProperty("percent_change_24h").ToString(),
                    //    PercentChange1h = document.RootElement.GetProperty("percent_change_1h").ToString(),
                    //    PercentChange7d = document.RootElement.GetProperty("percent_change_7d").ToString(),
                    //    MarketCapUsd = document.RootElement.GetProperty("market_cap_usd").ToString(),
                    //    Volume24 = document.RootElement.GetProperty("volume24").ToString(),
                    //    Volume24Native = document.RootElement.GetProperty("volume24_native").ToString(),
                    //    Csupply = document.RootElement.GetProperty("csupply").ToString(),
                    //    PriceBtc = document.RootElement.GetProperty("price_btc").ToString(),
                    //    Tsupply = document.RootElement.GetProperty("tsupply").ToString(),
                    //    Msupply = document.RootElement.GetProperty("msupply").ToString()

                    //};
                }
            }
            return View(coin);

            
        }

        public async Task<IActionResult> Exchange()
        {
            ExchangeViewModel exchange = new ExchangeViewModel();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.coinlore.net/api/exchange/?id=5"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    exchange = JsonSerializer.Deserialize<ExchangeViewModel>(apiResponse);
                }
            }
            return View(exchange);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
