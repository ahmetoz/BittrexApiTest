using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BittrexApiTest
{
    public class MarketHistoryRoot
    {
        public class MarketHistory
        {
            [JsonProperty("TimeStamp")]
            public DateTime TimeStamp { get; set; }

            [JsonProperty("Quantity")]
            public decimal Quantity { get; set; }

            [JsonProperty("Price")]
            public decimal Price { get; set; }

            [JsonProperty("Total")]
            public decimal Total { get; set; }

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
        public List<MarketHistory> Result { get; set; }

        public string ErrorMessage { get; set; }
    }

}
