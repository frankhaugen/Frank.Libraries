using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WorkflowCore.Interface;
using WorkflowCore.Models;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.DataProcessing.Workflows;

public class WorkflowCoreTests
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ITestOutputHelper _testOutputHelper;

    public WorkflowCoreTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;

        var services = new ServiceCollection();

        services.AddLogging(x => x.ClearProviders()
                                  .AddXunit(_testOutputHelper));

        services.AddWorkflow();
        services.AddTransient<TestStep>();
        services.AddTransient<TestStep2>();

        _serviceProvider = services.BuildServiceProvider(new ServiceProviderOptions { ValidateOnBuild = true, ValidateScopes = true });
    }

    [Fact]
    public async Task TestTheWorkflow()
    {
        var host = _serviceProvider.GetService<IWorkflowHost>();
        host.RegisterWorkflow<TestWorkflow, Data>();
        await host.StartAsync(CancellationToken.None);

        await host.StartWorkflow("MyVeryOwnWorkflow");
    }


    public class TestWorkflow : IWorkflow<Data>
    {
        public void Build(IWorkflowBuilder<Data> builder)
            => builder.StartWith<TestStep>()
                      .Output(data => data.Message, data => data.Output)
                      .Then<TestStep2>()
                      .Input(step => step.Input, data => data.Message);


        public string Id { get; } = "MyVeryOwnWorkflow";
        public int Version { get; }
    }

    public class Data
    {
        public string Message { get; set; }
    }

    public class TestStep : StepBody
    {
        public string Output { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Output = "Hello World!";
            return ExecutionResult.Next();
        }
    }

    public class TestStep2 : StepBody
    {
        private readonly ILogger<TestStep2> _logger;

        public TestStep2(ILogger<TestStep2> logger) => _logger = logger;

        public string Input { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            _logger.LogError("Input: {Input}", Input);
            return ExecutionResult.Next();
        }
    }
}