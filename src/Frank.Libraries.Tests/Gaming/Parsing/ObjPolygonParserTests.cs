using System.Text;
using Frank.Libraries.Extensions;
using Frank.Libraries.Gaming.Core.FileProviders;
using Frank.Libraries.Gaming.Core.Parsers.ObjParsing;
using Microsoft.Extensions.FileProviders;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Gaming.Parsing;

public class ObjPolygonParserTests
{
    private readonly ITestOutputHelper _outputHelper;

    public ObjPolygonParserTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void Parse()
    {
        // Arrange
        var parser = new ObjPolygonParser();
        var assembly = parser.GetType().Assembly;
        var manifestResourceNames = assembly.GetManifestResourceNames();
        var existingResourceName = manifestResourceNames.FirstOrDefault(x => x.Contains("teapot.obj"));
        using var existingResource = assembly.GetManifestResourceStream(existingResourceName);
        var memoryStream = new MemoryStream();
        existingResource!.CopyTo(memoryStream);
        var bytes = memoryStream.ToArray();

        // Act
        var result = parser.GetPolygon(bytes);

        // Assert
        _outputHelper.WriteLine(result);
    }
}