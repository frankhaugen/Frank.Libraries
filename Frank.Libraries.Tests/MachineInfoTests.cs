using Frank.Libraries.Machine;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
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