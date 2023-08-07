using Bogus.DataSets;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.Extensions;
using Xunit.Abstractions;

namespace Frank.Libraries.CodeGeneration.Tests.Generators;

public class TestGeneratorTests
{
    private const string Something = "Frank.Libraries.Tests";
    private readonly ITestOutputHelper _outputHelper;

    public TestGeneratorTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Theory]
    [InlineData(typeof(FluentCalculatorBasicOperations), false)]
    [InlineData(typeof(FluentCalculatorPrimitivesConversions), false)]
    [InlineData(typeof(AccountsClient), false)]
    [InlineData(typeof(UserClient), false)]
    [InlineData(typeof(CompaniesClient), false)]
    // [InlineData(typeof(XkcdClient), false)]
    [InlineData(typeof(StarshipSheet), false)]
    public async Task RunTestGenerator(Type type, bool writeFile)
    {
        var localNamespace = type.Namespace.Replace("Frank.Libraries.", "");
        var solutionDirectory = DirectoryInfoHelper.GetSolutionDirectory();

        var testProjectName = "Frank.Libraries.Tests";
        var testProjectDirectory = solutionDirectory.GetSubDirectory(testProjectName);

        var directories = localNamespace.Split(".");
        var allDirectories = directories.Prepend(testProjectDirectory.FullName)
                                        .ToArray();
        var namespaceDirectory = new DirectoryInfo(Path.Combine(allDirectories));

        var testFilename = type.Name + "Tests.cs";
        var testFilePath = Path.Combine(namespaceDirectory.FullName, testFilename);
        var testFile = new FileInfo(testFilePath);

        // var result = new TestGenerator().Generate(type.Namespace.Replace("Frank.Libraries.", "Frank.Libraries.Tests."), type, new List<string> { "ToString", "Equals", "GetHashCode", "GetType" });
        // _outputHelper.WriteLine(result);
        //
        // if (writeFile)
        // {
        //     namespaceDirectory.Create();
        //     await testFile.WriteAllTextAsync(result);
        //     _outputHelper.WriteLine(testFilename);
        //     _outputHelper.WriteLine(testFile.FullName);
        // }
    }
}

public class StarshipSheet
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public string CostInCredits { get; set; }
    public string Length { get; set; }
    public string MaxAtmospheringSpeed { get; set; }
    public string Crew { get; set; }
    public string Passengers { get; set; }
    public string CargoCapacity { get; set; }
    public string Consumables { get; set; }
    public string HyperdriveRating { get; set; }
    public string MGLT { get; set; }
    public string StarshipClass { get; set; }
    public List<string> Pilots { get; set; }
    public List<string> Films { get; set; }
    public string Created { get; set; }
    public string Edited { get; set; }
    public string Url { get; set; }
}

public class CompaniesClient
{
    public Task<Company> GetCompanyAsync(string id) => throw new NotImplementedException();
}

public class UserClient
{
    public Task<User> GetUserAsync(string id) => throw new NotImplementedException();
}

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class AccountsClient
{
    public Task<Account> GetAccountAsync(string id) => throw new NotImplementedException();
}

public class Account
{
    public string Id { get; set; }
    public string Name { get; set; }
}