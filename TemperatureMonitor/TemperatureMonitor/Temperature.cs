using System;
using System.Text.Json.Serialization;

namespace TemperatureControlFunction;

public class Temperature 
{
    [JsonPropertyName("temp")]
    public int Temp { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("currently")]
    public string Currently { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("windspeedy")]
    public string WindSpeedy { get; set; }

    [JsonPropertyName("sunrise")]
    public string Sunrise { get; set; }

    [JsonPropertyName("sunset")]
    public string Sunset { get; set; }

    [JsonPropertyName("conditionslug")]
    public string ConditionSlug { get; set; }

    [JsonPropertyName("cityname")]
    public string CityName { get; set; }
       

    [JsonPropertyName("partitionkey")]
    public string PartitionKey { get; set; }

    [JsonPropertyName("rowkey")]
    public string RowKey { get; set; }

    public DateTimeOffset? Timestamp { get; set; }
    
}
