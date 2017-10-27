using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BittrexApiTest
{
    public class MarketSummaryRoot
    {
        public class MarketSummary
        {
            [JsonProperty("MarketName")]
            public string MarketName { get; set; }

            [JsonProperty("High")]
            public decimal High { get; set; }

            [JsonProperty("Low")]
            public decimal Low { get; set; }

            [JsonProperty("Last")]
            public decimal Last { get; set; }

            [JsonProperty("BaseVolume")]
            public decimal BaseVolume { get; set; }

            [JsonProperty("Volume")]
            public decimal Volume { get; set; }

            [JsonProperty("Bid")]
            public decimal Bid { get; set; }

            [JsonProperty("Ask")]
            public decimal Ask { get; set; }

            [JsonProperty("OpenBuyOrders")]
            public int OpenBuyOrders { get; set; }

            [JsonProperty("OpenSellOrders")]
            public int OpenSellOrders { get; set; }

            [JsonProperty("Created")]
            public DateTime Created { get; set; }

            [JsonProperty("PrevDay")]
            public decimal PrevDay { get; set; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public List<MarketSummary> Result { get; set; }

        public string ErrorMessage { get; set; }
    }
}
