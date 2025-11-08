using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("emails")]
        public string[] Emails { get; set; }

        [JsonProperty("phones")]
        public object[] Phones { get; set; }

        [JsonProperty("places")]
        public string[] Places { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
