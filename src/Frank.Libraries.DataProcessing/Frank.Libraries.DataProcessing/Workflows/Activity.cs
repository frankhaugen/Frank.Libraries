namespace Frank.Libraries.DataProcessing.Workflows;

public abstract class Activity : IActivity
{
    public string? Name { get; set; }
    public uint? Order { get; set; }

    public abstract Task<ActivityResult> ExecuteAsync(ActivityContext context);

    protected ActivityResult GetSuccessResult(object? data = null) => new(true, data);

    protected ActivityResult GetFailureResult(object? data = null) => new(false, data);
}