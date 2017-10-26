using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexApiTest
{
    public class OrderBookRoot
    {
        public class OrderBook
        {
            [JsonProperty("Quantity")]
            public string Quantity { get; set; }

            [JsonProperty("Rate")]
            public string Rate { get; set; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public IEnumerable<OrderBook> Result { get; set; }
    }
}
