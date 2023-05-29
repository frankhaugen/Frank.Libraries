namespace Frank.Libraries.Json;

public class JsonConfiguration
{
    public string Folder { get; set; } = Path.Combine(AppContext.BaseDirectory, "Data");
}