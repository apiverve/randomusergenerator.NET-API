using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("gender")]
    public string gender { get; set; }

    [JsonProperty("username")]
    public string username { get; set; }

    [JsonProperty("email")]
    public string email { get; set; }

    [JsonProperty("password")]
    public string password { get; set; }

    [JsonProperty("registered")]
    public DateTime registered { get; set; }

    [JsonProperty("phone")]
    public string phone { get; set; }

    [JsonProperty("cell")]
    public string cell { get; set; }

    [JsonProperty("birthdate")]
    public DateTime birthdate { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data[] data { get; set; }

}

}
