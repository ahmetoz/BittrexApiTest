using Newtonsoft.Json;
using System.Collections.Generic;

namespace BittrexApiTest
{
    public class OrderBookRoot
    {
        public class OrderBook
        {
            [JsonProperty("Quantity")]
            public decimal Quantity { get; set; }

            [JsonProperty("Rate")]
            public decimal Rate { get; set; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public List<OrderBook> Result { get; set; }

        public string ErrorMessage { get; set; }
    }
}
