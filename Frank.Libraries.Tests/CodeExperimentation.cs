using FluentAssertions;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class CodeExperimentation
    {
        private readonly string _csv = "Name;age;DOB\n" +
                                       "Bob;28;2000-01-01\n" +
                                       "Ross;77;2000-01-01\n" +
                                       "Dave;11;2000-01-01\n" +
                                       "carl;10;2000-01-01";

        private readonly ITestOutputHelper _outputHelper;

        public CodeExperimentation(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void TestIdentify()
        {
            var decimalValue = "10,10";
            var decimalResult = Identify(decimalValue);
            decimalResult.Should().BeOfType<TypeCode>();

            _outputHelper.WriteLine(AppDomain.CurrentDomain.FriendlyName);
        }

        private TypeCode Identify(string value)
        {
            if (decimal.TryParse(value, out _))
            {
                return TypeCode.Decimal;
            }

            throw new ArgumentException(_csv);
        }
    }
}
