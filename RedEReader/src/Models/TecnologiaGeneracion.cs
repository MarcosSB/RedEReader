using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedEReader.src.Models
{
    public class Attributes
    {
        public string title { get; set; }
        [JsonProperty("last-update")]
        public DateTime LastUpdate { get; set; }
        public object description { get; set; }
        public string color { get; set; }
        public string type { get; set; }
        public object magnitude { get; set; }
        public bool composite { get; set; }
        public List<Value> values { get; set; }
    }

    public class CacheControl
    {
        public string cache { get; set; }
        public DateTime expireAt { get; set; }
    }

    public class Meta
    {
        [JsonProperty("cache-control")]
        public CacheControl CacheControl { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public string id { get; set; }
        public Attributes attributes { get; set; }
        public Meta meta { get; set; }
    }

    public class Value
    {
        public double value { get; set; }
        public double percentage { get; set; }
        public DateTime datetime { get; set; }
    }

    public class Included
    {
        public string type { get; set; }
        public string id { get; set; }
        public string groupId { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
        public List<Included> included { get; set; }
    }


}
