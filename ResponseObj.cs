using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class places
{
}

public class data
{
    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("emails")]
    public string[] emails { get; set; }

    [JsonProperty("phones")]
    public object[] phones { get; set; }

    [JsonProperty("places")]
    public places places { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
