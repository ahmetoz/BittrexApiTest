using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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
            public decimal MinTradeSize { get; set; }

            [JsonProperty("MarketName")]
            public string MarketName { get; set; }

            [JsonProperty("IsActive")]
            public bool IsActive { get; set; }

            [JsonProperty("Created")]
            public DateTime Created { get; set; }

            [JsonProperty("LogoUrl")]
            public string LogoUrl { get; set; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public List<Markets> Result { get; set; }

        public string ErrorMessage { get; set; }
    }
}
