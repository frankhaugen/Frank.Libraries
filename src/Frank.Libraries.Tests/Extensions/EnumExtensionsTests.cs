using FluentAssertions;
using Frank.Libraries.Extensions;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;
using Xunit;

namespace Frank.Libraries.Tests.Extensions;

public class EnumExtensionsTests
{
    [Theory]
    [InlineData(PlatformOperatingSystem.Windows, "Windows")]
    [InlineData(PlatformOperatingSystem.Unix, "Unix")]
    [InlineData(PlatformOperatingSystem.OSX, "OSX")]
    public void AsString(PlatformOperatingSystem enumValue, string expected)
    {
        // Arrange

        // Act
        var result = enumValue.AsString();

        // Assert
        result.Should()
              .Be(expected);
    }

    [Theory]
    [InlineData(PlatformOperatingSystem.Windows, 0)]
    [InlineData(PlatformOperatingSystem.Unix, 1)]
    [InlineData(PlatformOperatingSystem.OSX, 2)]
    public void AsInteger(PlatformOperatingSystem enumValue, int expected)
    {
        // Arrange

        // Act
        var result = enumValue.AsInteger();

        // Assert
        result.Should()
              .Be(expected);
    }

    //[Theory]
    //public void GetLocalName(string expected)
    //{
    //    // Arrange

    //    // Act
    //    var result = enumValue.GetLocalName();

    //    // Assert
    //    result.Should().Be(expected);
    //}
}