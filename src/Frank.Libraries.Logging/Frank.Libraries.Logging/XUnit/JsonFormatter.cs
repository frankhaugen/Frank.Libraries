using System.Text.Json;

namespace Frank.Libraries.Logging.XUnit;

internal class JsonFormatter
{
    public string Format<TState>(TState state) => JsonSerializer.Serialize(state, new JsonSerializerOptions { WriteIndented = true });
}