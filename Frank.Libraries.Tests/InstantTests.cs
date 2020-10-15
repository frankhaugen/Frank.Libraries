using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class InstantTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public InstantTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void ToString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var instant = Instant.Now;

            // Act
            var result = instant.ToString();

            // Assert
            _outputHelper.WriteLine(result);
        }
    }
}
