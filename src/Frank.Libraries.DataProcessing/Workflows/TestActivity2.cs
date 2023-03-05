using Microsoft.Extensions.Logging;

namespace Frank.Libraries.DataProcessing.Workflows;

public class TestActivity2 : Activity
{
    private readonly ILogger<TestActivity2> _logger;

    public TestActivity2(ILogger<TestActivity2> logger) => _logger = logger;

    public new string? Name { get; set; } = "TestActivity";
    public new uint? Order { get; set; } = 0; // 0 is the first activity to be executed

    public override async Task<ActivityResult> ExecuteAsync(ActivityContext context)
    {
        var input = context.GetInput<string>();

        _logger.LogInformation("Input: {Input}", input);

        return GetSuccessResult();
    }
}