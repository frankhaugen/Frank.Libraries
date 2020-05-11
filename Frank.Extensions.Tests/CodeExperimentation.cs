using FluentAssertions;
using System;
using System.Data;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Extensions.Tests
{
    public class CodeExperimentation
    {
        private string csv = "Name;age;DOB\n" +
                             "Bob;28;2000-01-01\n" +
                             "Ross;77;2000-01-01\n" +
                             "Dave;11;2000-01-01\n" +
                             "carl;10;2000-01-01";

        private class Dude
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string DOB { get; set; }
        }

        private ITestOutputHelper _outputHelper;

        public CodeExperimentation(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        public void TestCsvToDataTable()
        {
            var testLines = csv.Split('\n');
            var headerLine = testLines[0];
            var dataTable = new DataTable();

            foreach (var propertyInfo in typeof(Dude).GetProperties(BindingFlags.Public | BindingFlags.SetProperty))
            {
                //dataTable.Columns.Add(propertyInfo.)
            }
        }

        [Fact]
        public void TestIdentify()
        {
            var decimalValue = "10,10";
            var decimalResult = Identify(decimalValue);
            decimalResult.Should().BeOfType<TypeCode>();
        }

        private TypeCode Identify(string value)
        {
            if (decimal.TryParse(value, out _))
            {
                return TypeCode.Decimal;
            }

            throw new ArgumentException();
        }
    }
}