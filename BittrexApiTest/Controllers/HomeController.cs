using RestSharp;
using System.Web.Mvc;

namespace BittrexApiTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Coins()
        {
            var client = new RestClient("https://bittrex.com/api/v1.1/public/getcurrencies");
            var request = new RestRequest(Method.GET);
            var model = client.Execute<CurrenciesRoot>(request);
            return View(model.Data);
        }

        public ActionResult Markets()
        {
            var client = new RestClient("https://bittrex.com/api/v1.1/public/getmarkets");
            var request = new RestRequest(Method.GET);
            var model = client.Execute<MarketsRoot>(request);

            return View(model.Data);
        }

        public ActionResult MarketSummary(string coin = null)
        {
            var client = new RestClient("http://bittrex.com/api/v1.1/public/getmarketsummary?market=BTC-" + coin);
            var request = new RestRequest(Method.GET);
            var model = client.Execute<MarketSummaryRoot>(request);

            ViewBag.Coin = coin;
            return View(model.Data);
        }

        public ActionResult Orders(string orderType, string coin = null)
        {
            var client = new RestClient("https://bittrex.com/api/v1.1/public/getorderbook?market=BTC-" + coin);
            var request = new RestRequest(Method.GET).AddParameter("type", orderType);
            var model = client.Execute<OrderBookRoot>(request);
            
            ViewBag.Coin = coin;
            ViewBag.OrderType = orderType;
            return View(model.Data);
        }

        public ActionResult MarketHistory(string coin = null)
        {
            var client = new RestClient("https://bittrex.com/api/v1.1/public/getmarkethistory?market=BTC-" + coin);
            var request = new RestRequest(Method.GET);
            var model = client.Execute<MarketHistoryRoot>(request);

            ViewBag.Coin = coin;
            return View(model.Data);
        }
    }
}
