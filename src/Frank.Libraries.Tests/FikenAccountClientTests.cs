using System.Threading.Tasks;
using Frank.Libraries.Fiken.Api;
using Frank.Libraries.Fiken.Client;
using Frank.Libraries.Tests.TestingInfrastructure;
using Microsoft.Extensions.Options;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests;

public class FikenAccountClientTests : TestBase
{
    public FikenAccountClientTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    // [Fact]
    public async Task GetAccounts()
    {
        // Arrange
        var client = new AccountsClient(new OptionsWrapper<Configuration>(new Configuration()));

        // Act
        var result = await client.GetAccountsAsync();

        // Assert
        Output(result);
    }
}