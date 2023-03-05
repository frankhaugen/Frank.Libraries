namespace Frank.Libraries.Tests.Fiken.Api;

public class AccountsClientTests
{
    // private readonly IOptions<FikenConfiguration> _options;
    // private readonly RestClient _restClient;
    // private readonly ITestOutputHelper _outputHelper;
    // private readonly IAuthenticationClient _authenticationClient;
    //
    // public AccountsClientTests(ITestOutputHelper outputHelper)
    // {
    //     _outputHelper = outputHelper;
    //     _options = Options.Create(new FikenConfiguration() { BaseUrl = "https://api.fiken.no/api/v2", Token = "2533846533.kmvokDzs3vStSIxq17VDV0xSsH1KrbTv", Timeout = -1});
    //     _authenticationClient = new AuthenticationClient(_options, _restClient;
    //     _sutAccountsClient = new AccountsClient(_authenticationClient);
    // }
    //
    // private readonly AccountsClient _sutAccountsClient;
    //
    // [Fact]
    // public async Task GetAccountAsyncTest()
    // {
    //     // Arrange
    //     var accountCode = 1001;
    //
    //     // Act
    //     var result = await _sutAccountsClient.GetAccountAsync(accountCode);
    //
    //     // Assert
    //     _outputHelper.WriteLine(result);
    //     result.ToString().Should().NotBeNullOrEmpty();
    // }
    //
    // [Fact]
    // public async Task GetAccountsAsyncTest()
    // {
    //     // Arrange
    //     var fromAccount = default(Int64);
    //     var toAccount = default(Int64);
    //     var page = default(Int32);
    //     var pageSize = default(Int32);
    //
    //     // Act
    //     var result = await _sutAccountsClient.GetAccountsAsync();
    //
    //     // Assert
    //     _outputHelper.WriteTable(result);
    //     result.Should().NotBeNull();
    // }
    //
    // // [Fact]
    // public async Task GetAccountBalanceTest()
    // {
    //     // Arrange
    //     var accountCode = default(String);
    //     var date = DateTime.UtcNow.AddYears(-1);
    //
    //     // Act
    //     var result = _sutAccountsClient.GetAccountBalance(accountCode, date);
    //
    //     // Assert
    //     _outputHelper.WriteLine(result);
    //     result.ToString().Should().NotBeNullOrEmpty();
    // }
    //
    // // [Fact]
    // public async Task GetAccountBalancesTest()
    // {
    //     // Arrange
    //     var date = DateTime.UtcNow.AddYears(-1);
    //     var fromAccount = default(Int64);
    //     var toAccount = default(Int64);
    //     var page = default(Int32);
    //     var pageSize = default(Int32);
    //
    //     // Act
    //     var result = _sutAccountsClient.GetAccountBalances(date);
    //
    //     // Assert
    //     _outputHelper.WriteLine(result);
    //     result.ToString().Should().NotBeNullOrEmpty();
    // }
}