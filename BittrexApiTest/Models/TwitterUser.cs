using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BittrexApiTest
{
    public class TwitterUser    
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("friends_count")]
        public int FriendsCount { get; set; }

        [JsonProperty("profile_image_url_https")]
        public string ProfileImage { get; set; }

        [JsonProperty("statuses_count")]
        public int StatusesCount { get; set; }

        [JsonProperty("favourites_count")]
        public int FavouritesCount { get; set; }
    }
}
