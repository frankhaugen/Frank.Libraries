using System.Text.Json.Serialization;

namespace Frank.Libraries.DataProcessing.Tables;

public class Column
{
    public string? Name { get; set; }

    [JsonConverter(typeof(TypeJsonConverter))]
    public Type Type { get; set; }
}