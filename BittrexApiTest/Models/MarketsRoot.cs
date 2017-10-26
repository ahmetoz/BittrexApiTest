using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexApiTest
{
    public class MarketsRoot
    {
        public class Markets
        {
            [JsonProperty("MarketCurrency")]
            public string MarketCurrency { get; set; }

            [JsonProperty("BaseCurrency")]
            public string BaseCurrency { get; set; }

            [JsonProperty("MarketCurrencyLong")]
            public string MarketCurrencyLong { get; set; }

            [JsonProperty("BaseCurrencyLong")]
            public string BaseCurrencyLong { get; set; }

            [JsonProperty("MinTradeSize")]
            public string MinTradeSize { get; set; }

            [JsonProperty("MarketName")]
            public string MarketName { get; set; }

            [JsonProperty("IsActive")]
            public string IsActive { get; set; }

            [JsonProperty("Created")]
            public string Created { get; set; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public IEnumerable<Markets> Result { get; set; }
    }
}
