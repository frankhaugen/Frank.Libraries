using System.Globalization;
using Cronos;
using FluentAssertions;
using Frank.Libraries.Enums.Countries;
using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Time
{
    public class CronServiceTests : TestBase
    {
        public CronServiceTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        //[Fact]
        public void IsValid_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new CronService();
            var expression = "* * * * *";
            var format = CronFormat.IncludeSeconds;

            // Act
            var result = service.IsValid(expression, format);

            // Assert
            result.Should()
                  .BeTrue();
        }

        //[Fact]
        public void Parse_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new CronService();
            var expression = "* * * * *";
            var format = CronFormat.IncludeSeconds;

            // Act
            var result = service.Parse(expression, format);

            // Assert
        }

        [Fact]
        public void TryParse_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new CronService();
            var expression = "* * * * *";
            ;
            CronExpression? cronExpression = null;
            CronFormat format = CronFormat.IncludeSeconds;

            // Act
            var result = service.TryParse(
                expression,
                out cronExpression,
                format);

            // Assert
        }

        [Fact]
        public void GetDescription_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new CronService();
            var expression = "* * * * *";
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;

            // Act
            var result = service.GetDescription(
                expression,
                cultureInfo);

            // Assert
        }

        //[Fact]
        public void GetDescription_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var service = new CronService();
            CronExpression expression = null;
            CultureInfo cultureInfo = null;

            // Act
            var result = service.GetDescription(
                expression,
                cultureInfo);

            // Assert
        }

        [Fact]
        public void GetDescription_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var service = new CronService();
            var expression = "* * * * * *";
            var culture = Culture.NB;

            // Act
            var result = service.GetDescription(expression, culture);

            // Assert
            Output(result);
        }

        //[Fact]
        public void GetDescription_StateUnderTest_ExpectedBehavior3()
        {
            // Arrange
            var service = new CronService();
            CronExpression expression = null;
            Culture culture = default(global::Frank.Libraries.Enums.Countries.Culture);

            // Act
            var result = service.GetDescription(
                expression,
                culture);

            // Assert
        }
    }
}