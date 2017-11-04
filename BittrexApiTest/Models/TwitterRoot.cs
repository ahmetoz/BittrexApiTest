using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BittrexApiTest
{
    public class TwitterRoot  
    {
        [JsonProperty("created_at")]
        public DateTime CreatedDateTime { get; set; }

        [JsonProperty("favorite_count")]
        public int FavoriteCount { get; set; }

        [JsonProperty("retweet_count")]
        public int RetweetCount { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("user")]
        public TwitterUser User { get; set; }
    }
}
