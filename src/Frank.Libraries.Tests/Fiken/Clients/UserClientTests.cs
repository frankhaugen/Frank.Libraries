using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Fiken.Clients;
using NSubstitute;
using System.Threading.Tasks;
using Frank.Libraries.Fiken;
using Microsoft.Extensions.Options;
using RestSharp;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Fiken.Clients;

public class UserClientTests
{
    private readonly IAuthenticationClient _iAuthenticationClient;
    private readonly ITestOutputHelper _outputHelper;

    public UserClientTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        var options = Options.Create(new FikenConfiguration() { BaseUrl = "https://api.fiken.no/api/v2", Token = "2533846533.kmvokDzs3vStSIxq17VDV0xSsH1KrbTv", Timeout = -1});
        _iAuthenticationClient = new AuthenticationClient(options, new RestClient());
        _sutUserClient = new UserClient(_iAuthenticationClient);
    }

    private readonly UserClient _sutUserClient;


    [Fact]
    public async Task GetUserTest()
    {
        // Arrange

        // Act
        var result = _sutUserClient.GetUser();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }
}
