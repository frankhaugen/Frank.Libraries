﻿using FluentAssertions;
using Frank.Libraries.Currency;
using Frank.Libraries.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Currencies;

public class CurrencyClientTests
{
    private readonly ICurrencyClient _currencyClient;
    private readonly ITestOutputHelper _outputHelper;

    public CurrencyClientTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        var services = new ServiceCollection();
        services.AddCurrencyClient();
        var serviceProvider = services.BuildServiceProvider();

        _currencyClient = serviceProvider.GetRequiredService<ICurrencyClient>();
    }

    [Fact]
    public async Task GetLatestRates_UsingDefaults_ShouldSucceed()
    {
        // Act
        var result = await _currencyClient.GetLatestRatesAsync();

        // Assert
        result.Should()
              .NotBeNull();
        // result.Success.Should().BeTrue();
        _outputHelper.WriteLine(result);
    }

    // [Fact]
    public async Task GetLatestRatesAsDictionary_UsingDefaults_ShouldSucceed()
    {
        // Act
        var result = await _currencyClient.GetLatestRatesAsync();

        // Assert
        result.Should()
              .NotBeNull();
        // result.Success.Should().BeTrue();
        _outputHelper.WriteLine(result);
    }

    //[Fact]
    public async Task Convert_UsingDefaults_ShouldReturnOne()
    {
        // Act
        var result = await _currencyClient.ConvertAsync();

        // Assert
        result.Should()
              .Be(1);
    }
}