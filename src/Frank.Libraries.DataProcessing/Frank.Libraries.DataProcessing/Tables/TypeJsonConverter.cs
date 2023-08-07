using System.Text.Json;
using System.Text.Json.Serialization;

namespace Frank.Libraries.DataProcessing.Tables;

public class TypeJsonConverter : JsonConverter<Type>
{
    public override Type Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "System.String"         => typeof(string),
            "System.Int32"          => typeof(int),
            "System.Int64"          => typeof(long),
            "System.Double"         => typeof(double),
            "System.Decimal"        => typeof(decimal),
            "System.DateTime"       => typeof(DateTime),
            "System.Boolean"        => typeof(bool),
            "System.Guid"           => typeof(Guid),
            "System.Byte"           => typeof(byte),
            "System.Byte[]"         => typeof(byte[]),
            "System.Char"           => typeof(char),
            "System.TimeSpan"       => typeof(TimeSpan),
            "System.DateTimeOffset" => typeof(DateTimeOffset),
            "System.SByte"          => typeof(sbyte),
            "System.UInt16"         => typeof(ushort),
            _                       => throw new NotImplementedException()
        };
    }

    public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.FullName);
}