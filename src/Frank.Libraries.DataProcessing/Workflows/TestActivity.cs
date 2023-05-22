namespace Frank.Libraries.DataProcessing.Workflows;

public class TestActivity : Activity
{
    public new string? Name { get; set; } = "TestActivity";
    public new uint? Order { get; set; } = 0; // 0 is the first activity to be executed

    public override async Task<ActivityResult> ExecuteAsync(ActivityContext context) => GetSuccessResult("Hello World!");
}