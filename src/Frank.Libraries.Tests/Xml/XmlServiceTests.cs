using FluentAssertions;
using Frank.Libraries.Xml;
using Xunit;

namespace Frank.Libraries.Tests.Xml;

public class XmlServiceTests
{
    [Fact]
    public void Validate_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = new XmlService();
        var pathToXsdFiles = Path.Combine(Directory.GetCurrentDirectory(), "TestingInfrastructure", "Files", "Xsd");
        var xsdFiles = Directory.GetFiles(pathToXsdFiles);
        var xsds = new List<string>();

        foreach (var xsdFile in xsdFiles)
        {
            File.Exists(xsdFile)
                .Should()
                .BeTrue();
            var xsd = File.ReadAllText(xsdFile);
            xsds.Add(xsd);
        }

        var pathToXmlFile = Path.Combine(Directory.GetCurrentDirectory(), "TestingInfrastructure", "Files", "Xml", "Invoice1.xml");
        File.Exists(pathToXmlFile)
            .Should()
            .BeTrue();
        var xml = File.ReadAllText(pathToXmlFile);

        // Act
        var result = service.Validate(xml, xsds.ToArray());

        // Assert
        result.Should()
              .BeNullOrEmpty();
    }
}