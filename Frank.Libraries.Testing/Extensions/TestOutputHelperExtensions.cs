using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xunit.Abstractions;

namespace Frank.Libraries.Testing.Extensions
{
    public static class TestOutputHelperExtensions
    {
        public static void WriteLine<T>(this ITestOutputHelper outputHelper, T value)
        {
            try
            {
                var json = JsonSerializer.Serialize(value, new JsonSerializerOptions() { WriteIndented = true, ReferenceHandler = ReferenceHandler.Preserve });
                outputHelper.WriteLine(json);
            }
            catch (Exception e)
            {
                outputHelper.WriteLine(e.Message);
            }
        }
    }
}