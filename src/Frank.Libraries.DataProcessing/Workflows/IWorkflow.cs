namespace Frank.Libraries.DataProcessing.Workflows;

public interface IWorkflow
{
    public string? Name { get; set; }
    public uint? Order { get; set; }

    Task<WorkflowResult> ExecuteAsync(WorkflowContext context);

    public WorkflowContext BuildContext(IWorkflowContextBuilder builder);
}