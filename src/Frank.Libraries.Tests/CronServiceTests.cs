using System.Globalization;
using Cronos;
using Frank.Libraries.Enums.Countries;
using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class CronServiceTests : TestBase
    {
        public CronServiceTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        private CronService CreateService() => new();

        [Fact]
        public void IsValid_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string expression = "* * * * * *";
            CronFormat format = CronFormat.IncludeSeconds;

            // Act
            var result = service.IsValid(
                expression,
                format);

            // Assert
            Output(result);
        }

        [Fact]
        public void Parse_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string expression = "* * * * * *";
            CronFormat format = CronFormat.IncludeSeconds;

            // Act
            var result = service.Parse(
                expression,
                format);

            // Assert
            Output(result);
        }

        //[Fact]
        public void TryParse_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string expression = "* * * * * *";
            CronFormat format = CronFormat.IncludeSeconds;
            CronExpression? cronExpression = CronExpression.Parse(expression);

            // Act
            var result = service.TryParse(
                expression,
                out cronExpression,
                format);

            // Assert
            Output(result);
        }

        [Fact]
        public void GetDescription_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string expression = "* * * * * *";
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;

            // Act
            var result = service.GetDescription(
                expression,
                cultureInfo);

            // Assert
            Output(result);
        }

        //[Fact]
        public void GetDescription_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var service = this.CreateService();
            CronExpression expression = CronExpression.Parse("* * * * * *");
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;

            // Act
            var result = service.GetDescription(
                expression,
                cultureInfo);

            // Assert
            Output(result);
        }

        [Fact]
        public void GetDescription_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var service = this.CreateService();
            string expression = "* * * * * *";
            Culture culture = Culture.AM;

            // Act
            var result = service.GetDescription(
                expression,
                culture);

            // Assert
            Output(result);
        }

        //[Fact]
        public void GetDescription_StateUnderTest_ExpectedBehavior3()
        {
            // Arrange
            var service = this.CreateService();
            CronExpression expression = CronExpression.Parse("* * * * * *");
            Culture culture = Culture.AA;

            // Act
            var result = service.GetDescription(
                expression,
                culture);

            // Assert
            Output(result);
        }
    }
}