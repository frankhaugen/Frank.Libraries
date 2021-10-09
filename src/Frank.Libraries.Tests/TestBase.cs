using System.IO;
using System.Text.Json;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public abstract class TestBase
    {
        private readonly ITestOutputHelper _outputHelper;

        protected TestBase(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        protected void Output(FileInfo fileInfo, string text)
        {
            File.WriteAllText(fileInfo.FullName, text);
        }

        protected void Output(string text) => _outputHelper.WriteLine(text);

        protected void Output(object value) => _outputHelper.WriteLine(JsonSerializer.Serialize(value, new JsonSerializerOptions() { WriteIndented = true }));

        protected void Output<T>(T value) => _outputHelper.WriteLine(JsonSerializer.Serialize(value, new JsonSerializerOptions() { WriteIndented = true }));
    }
}