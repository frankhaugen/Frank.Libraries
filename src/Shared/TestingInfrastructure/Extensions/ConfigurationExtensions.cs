using ConsoleTableExt;
using Microsoft.Extensions.Configuration;

namespace TestingInfrastructure.Extensions;

public static class ConfigurationExtensions
{

    public static string GetDebugView(this IConfiguration configuration)
    {
        var keyValues = new List<ConfigurationDebugView>();

        foreach (var section in configuration.GetChildren())
        {
            var key = section.Key;
            var value = section.Value;
            keyValues.Add(new ConfigurationDebugView(){Key = key, Value = value});
        }



        var table = ConsoleTableBuilder.From(keyValues)
                                       .WithFormat(ConsoleTableBuilderFormat.Minimal)
                                       .Export()
                                       .ToString();
        return table;
    }
}

public class ConfigurationDebugView
{
    public string Key { get; set; }
    public string Value { get; set; }
}