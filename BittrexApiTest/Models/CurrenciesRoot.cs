using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexApiTest
{
    public class CurrenciesRoot
    {
        public class Currencies
        {
            [JsonProperty("Currency")]
            public string Currency { get; set; }

            [JsonProperty("CurrencyLong")]
            public string CurrencyLong { get; set; }

            [JsonProperty("TxFee")]
            public string TxFee { get; set; }

            [JsonProperty("MinConfirmation")]
            public string MinConfirmation { get; set; }

            [JsonProperty("IsActive")]
            public string IsActive { get; set; }

            [JsonProperty("CoinType")]
            public string CoinType { get; set; }

            [JsonProperty("BaseAdress")]
            public string BaseAdress { get; set; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public IEnumerable<Currencies> Result { get; set; }
    }
}
