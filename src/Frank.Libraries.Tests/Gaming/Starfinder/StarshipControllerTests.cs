using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Gaming.Starfinder;
using Frank.Libraries.Gaming.Starfinder.Space;
using Frank.Libraries.Gaming.Starfinder.Space.Models.Enums;
using NSubstitute;
using System;
using System.Collections;
using System.Reflection;
using System.Threading.Tasks;
using AutoBogus;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Gaming.Starfinder;

public class StarshipControllerTests
{
    private readonly Starship _starship = new AutoFaker<Starship>().RuleFor(x => x.Name, faker => faker.Company.CompanyName()).Generate();
    private readonly ITestOutputHelper _outputHelper;

    public StarshipControllerTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _sutStarshipController = new StarshipSheet(_starship);
    }

    private readonly StarshipSheet _sutStarshipController;


    // [Fact]
    public async Task PilotingCheckTest()
    {
        // Arrange

        // Act
        var result = _sutStarshipController.PilotingCheck();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task AttackTest()
    {
        // Arrange
        var gunner = new AutoFaker<CrewMember>();
        var arc = Arc.Forward;
        var rollResult = 15;

        // Act
        var result = _sutStarshipController.Attack(gunner, arc, rollResult);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }
}
