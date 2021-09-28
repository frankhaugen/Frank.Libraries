using System;
using FluentAssertions;
using Frank.Libraries.Json;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Frank.Libraries.Xml;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Xml
{
    public class XmlExtensionsTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public XmlExtensionsTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void SerializeObjectToXml()
        {
            // Arrange
            var objectToSerialize = new XmlTestModel()
            {
                Name = "A name",
                DateOfBirth = DateTime.Today,
                Salary = 100000
            };

            // Act
            var result = objectToSerialize.SerializeObjectToXml();
            _outputHelper.WriteLine(result);

            // Assert
            result.Should().NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void DeserializeObjectFromXml()
        {
            // Arrange
            string xmlData = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<XmlTestModel xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Name>A name</Name>\r\n  <DateOfBirth>2020-05-18T00:00:00+02:00</DateOfBirth>\r\n  <Salary>100000</Salary>\r\n</XmlTestModel>";

            // Act
            var result = xmlData.DeserializeObjectFromXml<XmlTestModel>();
            _outputHelper.WriteLine(result!.ToJson());

            // Assert
            result?.Salary.Should().Be(100000);
        }
    }
}
