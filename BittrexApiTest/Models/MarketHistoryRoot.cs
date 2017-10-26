using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexApiTest
{
    public class MarketHistoryRoot
    {
        public class MarketHistory
        {
            [JsonProperty("TimeStamp")]
            public string TimeStamp { get; set; }

            [JsonProperty("Quantity")]
            public string Quantity { get; set; }

            [JsonProperty("Price")]
            public string Price { get; set; }

            [JsonProperty("Total")]
            public string Total { get; set; }

            [JsonProperty("FillType")]
            public string FillType { get; set; }

            [JsonProperty("OrderType")]
            public string OrderType { get; set; }

        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public IList<MarketHistory> Result { get; set; }
    }

}
