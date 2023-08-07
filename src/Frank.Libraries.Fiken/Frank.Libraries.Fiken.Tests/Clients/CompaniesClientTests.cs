namespace Frank.Libraries.Fiken.Tests.Clients;

public class CompaniesClientTests
{
    // private readonly IAuthenticationClient _iAuthenticationClient;
    // private readonly ITestOutputHelper _outputHelper;
    //
    // public CompaniesClientTests(ITestOutputHelper outputHelper)
    // {
    //     _outputHelper = outputHelper;
    //     var options = Options.Create(new FikenConfiguration() { BaseUrl = "https://api.fiken.no/api/v2", Token = "2533846533.kmvokDzs3vStSIxq17VDV0xSsH1KrbTv", Timeout = -1});
    //     _iAuthenticationClient = new AuthenticationClient(options, new RestClient());
    //     _sutCompaniesClient = new CompaniesClient(_iAuthenticationClient);
    // }
    //
    // private readonly CompaniesClient _sutCompaniesClient;
    //
    //
    // [Fact]
    // public async Task GetCompaniesTest()
    // {
    //     // Arrange
    //     var page = 0;
    //     var pageSize = 25;
    //     var sortBy = "";
    //
    //     // Act
    //     var result = _sutCompaniesClient.GetCompanies(page, pageSize, sortBy);
    //
    //     // Assert
    //     _outputHelper.WriteTable(result);
    //     result.ToString().Should().NotBeNullOrEmpty();
    // }
    //
    // [Fact]
    // public async Task GetCompanyTest()
    // {
    //     // Arrange
    //     var companySlug = _iAuthenticationClient.CompanySlug;
    //
    //     // Act
    //     var result = _sutCompaniesClient.GetCompany(companySlug);
    //
    //     // Assert
    //     _outputHelper.WriteLine(result);
    //     result.ToString().Should().NotBeNullOrEmpty();
    // }
}