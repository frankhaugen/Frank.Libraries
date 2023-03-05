namespace Frank.Libraries.DataProcessing.Workflows;

public class WorkflowRunner : IWorkflowRunner
{
    private readonly IEnumerable<IWorkflow> _workflows;

    public WorkflowRunner(IEnumerable<IWorkflow> workflows) => _workflows = workflows;

    public async Task<WorkflowResult> RunAsync<T>() where T : IWorkflow
    {
        var workflow = _workflows.FirstOrDefault(x => x is T);

        var context = workflow.BuildContext(new WorkflowContextBuilder());

        return await workflow.ExecuteAsync(context);
    }
}