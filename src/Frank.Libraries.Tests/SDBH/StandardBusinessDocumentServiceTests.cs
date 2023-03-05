using System.IO;
using AutoBogus;
using FluentAssertions;
using Frank.Libraries.SBDH;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.SDBH;

public class StandardBusinessDocumentServiceTests
{
    private readonly ITestOutputHelper _outputHelper;

    public StandardBusinessDocumentServiceTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Fact]
    public void Deserialize_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = new StandardBusinessDocumentService();
        var pathToFile = Path.Combine(Directory.GetCurrentDirectory(), "TestingInfrastructure", "Files", "Xml", "StandardBusinessDocument.xml");
        File.Exists(pathToFile)
            .Should()
            .BeTrue();
        var xml = File.ReadAllText(pathToFile);

        // Act
        var result = service.Deserialize(xml);

        // Assert
        result.StandardBusinessDocumentHeader.Should()
              .NotBeNull();
    }

    [Fact]
    public void Serialize_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = new StandardBusinessDocumentService();
        var document = new AutoFaker<StandardBusinessDocument>().Generate();

        // Act
        var result = service.Serialize(document);

        // Assert
        _outputHelper.WriteLine(result);
    }
}