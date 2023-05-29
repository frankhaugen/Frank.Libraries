﻿using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using NodaTime;
using NodaTime.Testing;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests;

public class DateServiceTests : TestBase
{
    private readonly IClock _subClock;

    public DateServiceTests(ITestOutputHelper outputHelper) : base(outputHelper) => _subClock = new FakeClock(new Instant());

    private DateService CreateService() =>
        new DateService(
            _subClock);

    [Fact]
    public void ToString_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = CreateService();

        // Act
        var result = service.ToString();

        // Assert
        Output(result);
    }
}