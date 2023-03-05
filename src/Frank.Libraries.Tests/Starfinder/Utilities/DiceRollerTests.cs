using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Gaming.Starfinder.Characters.Models.Enums;
using Frank.Libraries.Gaming.Starfinder.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Starfinder.Utilities;

public class DiceRollerTests
{
    private readonly ITestOutputHelper _outputHelper;

    public DiceRollerTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Fact]
    public void Roll_Default_Should()
    {
        // Arrange
        var dice = Dice.D20;

        // Act
        var result = DiceRoller.Roll(dice);

        // Assert
        _outputHelper.WriteLine(result);
        result.Should()
              .BeInRange(1, 40);
    }

    [Fact]
    public void Roll_Should1()
    {
        // Arrange
        var dice = Dice.D20;
        var count = 2;

        // Act
        var result = DiceRoller.Roll(dice, count);

        // Assert
        _outputHelper.WriteLine(result);
        result.Should()
              .BeInRange(2, 40);
    }
}