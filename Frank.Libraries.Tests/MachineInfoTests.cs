using System.Text.Json;
using Frank.Libraries.Machine;
using Xunit;
using Xunit.Abstractions;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Frank.Libraries.Tests
{
    public abstract class TestBase
    {
        private readonly ITestOutputHelper _outputHelper;

        protected TestBase(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        protected void Output(string text) => _outputHelper.WriteLine(text);

        protected void Output(object value) => _outputHelper.WriteLine(JsonSerializer.Serialize(value, new JsonSerializerOptions() { WriteIndented = true }));

        protected void Output<T>(T value) => _outputHelper.WriteLine(JsonSerializer.Serialize(value, new JsonSerializerOptions() { WriteIndented = true }));
    }

    public class MachineInfoTests : TestBase
    {
        public MachineInfoTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void GetName_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var machineInfo = new MachineInfo();

            // Act
            var result = machineInfo.GetName();

            // Assert
            Output(result);
        }
    }
}