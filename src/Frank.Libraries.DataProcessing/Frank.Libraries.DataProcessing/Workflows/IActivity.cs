namespace Frank.Libraries.DataProcessing.Workflows;

public interface IActivity
{
    public string? Name { get; set; }
    public uint? Order { get; set; }

    Task<ActivityResult> ExecuteAsync(ActivityContext context);
}