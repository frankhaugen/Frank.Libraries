using System.Collections.Generic;
using FluentAssertions;
using Frank.Libraries.Gaming.Starfinder;
using Frank.Libraries.Gaming.Starfinder.Common;
using Frank.Libraries.Gaming.Starfinder.Models;
using Frank.Libraries.Gaming.Starfinder.Models.Enums;
using Xunit;

namespace Frank.Libraries.Tests.Starfinder
{
    public class StarshipControllerTests
    {
        private readonly Starship _starship;

        public StarshipControllerTests() => _starship = new Starship()
        {
            Name = "HMS Test 1",
            Frame = Frame.Explorer,
            Cost = 100,
            Size = Size.Medium,
            HitPoints = 100,
            Tier = 4,
            Mounts = new List<Mount>() {new Mount()
            {
                Arc = Arc.Turret,
                WeaponSize = WeaponSize.Light,
                Weapon = new Weapon()
                {
                    Damage = new Damage(2, 12)
                }
            }},
            Maneuverability = Maneuverability.Good,
            Pilot = new CrewMember() { Role = Role.Pilot },
            ShieldGenerator = new ShieldGenerator()
            {
                Cost = 150,
                Name = "edeee"
            }
        };

        [Fact]
        public void PilotingCheck_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var starshipController = new StarshipController(_starship);

            // Act
            var result = starshipController.PilotingCheck();

            // Assert
            result.Should().BePositive();
        }

        [Fact]
        public void Attack_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var starshipController = new StarshipController(_starship);
            CrewMember gunner = null;
            Arc arc = default(global::Frank.Libraries.Gaming.Starfinder.Models.Enums.Arc);
            RollResult rollResult = null;

            // Act
            var result = starshipController.Attack(
                gunner,
                arc,
                rollResult);

            // Assert
            Assert.True(false);
        }
    }
}