using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Fiken.Clients;
using Frank.Libraries.Fiken.Models;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Frank.Libraries.Fiken;
using Microsoft.Extensions.Options;
using RestSharp;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Fiken.Clients;

public class AccountsClientTests
{
    private readonly IAuthenticationClient _iAuthenticationClient;
    private readonly ITestOutputHelper _outputHelper;

    public AccountsClientTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        var options = Options.Create(new FikenConfiguration() { BaseUrl = "https://api.fiken.no/api/v2", Token = "2533846533.kmvokDzs3vStSIxq17VDV0xSsH1KrbTv", Timeout = -1});
        _iAuthenticationClient = new AuthenticationClient(options, new RestClient());
        _sutAccountsClient = new AccountsClient(_iAuthenticationClient);
    }

    private readonly AccountsClient _sutAccountsClient;


    [Fact]
    public async Task GetAccountAsyncTest()
    {
        // Arrange
        var accountCode = 1001;

        // Act
        var result = await _sutAccountsClient.GetAccountAsync(accountCode);

        // Assert
        _outputHelper.WriteLine(result);
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task GetAccountsAsyncTest()
    {
        // Arrange
        var fromAccount = default(Int64);
        var toAccount = default(Int64);
        var page = default(Int32);
        var pageSize = default(Int32);

        // Act
        var result = await _sutAccountsClient.GetAccountsAsync();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task GetAccountBalanceTest()
    {
        // Arrange
        var accountCode = default(String);
        var date = DateTime.UtcNow.AddYears(-1);

        // Act
        var result = _sutAccountsClient.GetAccountBalance(accountCode, date);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task GetAccountBalancesTest()
    {
        // Arrange
        var date = DateTime.UtcNow.AddYears(-1);
        var fromAccount = default(Int64);
        var toAccount = default(Int64);
        var page = default(Int32);
        var pageSize = default(Int32);

        // Act
        var result = _sutAccountsClient.GetAccountBalances(date);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }
}
