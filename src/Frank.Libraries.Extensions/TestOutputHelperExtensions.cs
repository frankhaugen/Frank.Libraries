using System.Collections.Generic;
using System.Text.Json;
using ConsoleTables;
using Xunit.Abstractions;

namespace Frank.Libraries.Extensions;

public static class TestOutputHelperExtensions
{
    public static void WriteLine<T>(this ITestOutputHelper outputHelper, T value) => outputHelper.WriteLine(value?.ToString() ?? string.Empty);
    public static void WriteJson<T>(this ITestOutputHelper outputHelper, T value, bool indented = true) => outputHelper.WriteLine(JsonSerializer.Serialize(value, new JsonSerializerOptions() { WriteIndented = indented }));
    public static void WriteTable<T>(this ITestOutputHelper outputHelper, IEnumerable<T> values) => outputHelper.WriteLine(ConsoleTable.From(values).ToMinimalString());
    public static void WriteMarkdownTable<T>(this ITestOutputHelper outputHelper, IEnumerable<T> values) => outputHelper.WriteLine(ConsoleTable.From(values).ToMarkDownString());
}