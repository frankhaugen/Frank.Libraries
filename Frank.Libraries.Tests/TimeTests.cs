using Xunit;

namespace Frank.Libraries.Tests
{
    public class TimeTests
    {
        [Fact]
        public void ToString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var time = new Time();

            // Act
            var result = time.ToString();

            // Assert
            //Assert.True(false);
        }
    }
}
