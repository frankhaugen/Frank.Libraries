using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Time
{
    public class WeekTimeTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public WeekTimeTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void ToString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var instant = WeekTime.Now;

            // Act
            var result = instant.ToString();

            // Assert
            _outputHelper.WriteLine(result);
        }
    }
}
