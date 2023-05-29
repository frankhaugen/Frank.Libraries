using Frank.Libraries.DataProcessing.Workflows;
using Frank.Libraries.Logging.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.DataProcessing.Workflows;

public class WorkflowsTests
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ITestOutputHelper _testOutputHelper;

    public WorkflowsTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;

        var services = new ServiceCollection();

        services.AddLogging(x => x.AddTestLogger(_testOutputHelper));

        services.AddWorkflowDependencies();
        services.AddWorkflow<TestWorkflow>();
        services.AddActivity<TestActivity>();
        services.AddActivity<TestActivity2>();

        _serviceProvider = services.BuildServiceProvider();
    }

    [Fact]
    public async Task TestWorkflow()
    {
        var runner = _serviceProvider.GetRequiredService<IWorkflowRunner>();
        await runner.RunAsync<TestWorkflow>();
    }
}