using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexApiTest
{
    public class MarketSummaryRoot
    {
        public class MarketSummary
        {
            [JsonProperty("MarketName")]
            public string MarketName { get; set; }

            [JsonProperty("High")]
            public string High { get; set; }

            [JsonProperty("Low")]
            public string Low { get; set; }

            [JsonProperty("Last")]
            public string Last { get; set; }

            [JsonProperty("BaseVolume")]
            public string BaseVolume { get; set; }

            [JsonProperty("Volume")]
            public string Volume { get; set; }

            [JsonProperty("Bid")]
            public string Bid { get; set; }

            [JsonProperty("Ask")]
            public string Ask { get; set; }

            [JsonProperty("OpenBuyOrders")]
            public string OpenBuyOrders { get; set; }

            [JsonProperty("OpenSellOrders")]
            public string OpenSellOrders { get; set; }

            [JsonProperty("Created")]
            public string Created { get; set; }

            [JsonProperty("PrevDay")]
            public string PrevDay { get; set; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public IEnumerable<MarketSummary> Result { get; set; }
    }
}
