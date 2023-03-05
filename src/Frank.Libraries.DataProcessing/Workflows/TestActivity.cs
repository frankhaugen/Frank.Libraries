namespace Frank.Libraries.DataProcessing.Workflows;

public class TestWorkflow : IWorkflow
{
    public string? Name { get; set; } = "TestWorkflow";
    public uint? Order { get; set; } = 0; // 0 is the first workflow to be executed

    public async Task<WorkflowResult> ExecuteAsync(WorkflowContext context)
    {
        ActivityResult result = null;

        foreach (var activity in context.Activities)
        {
            result = await activity.ExecuteAsync(new ActivityContext(result?.Data));
        }

        return new WorkflowResult();
    }

    public WorkflowContext BuildContext(IWorkflowContextBuilder builder) =>
        builder
            .WithActivity<TestActivity>()
            // .WithActivity<TestActivity2>()
            .Build();
}

public class TestActivity : Activity
{
    public new string? Name { get; set; } = "TestActivity";
    public new uint? Order { get; set; } = 0; // 0 is the first activity to be executed

    public override async Task<ActivityResult> ExecuteAsync(ActivityContext context) => GetSuccessResult("Hello World!");
}