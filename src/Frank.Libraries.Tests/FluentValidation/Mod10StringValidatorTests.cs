﻿using Frank.Libraries.FluentValidation;
using Frank.Libraries.Tests.TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.FluentValidation;

public class Mod10StringValidatorTests : TestBase
{
    public Mod10StringValidatorTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    //[Fact]
    public void TestMethod1()
    {
        // Arrange
        var mod10StringValidator = new Mod10StringValidator();

        // Act


        // Assert
    }
}