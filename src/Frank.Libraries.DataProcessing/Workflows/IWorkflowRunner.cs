namespace Frank.Libraries.DataProcessing.Workflows;

public interface IWorkflowRunner
{
    public Task<WorkflowResult> RunAsync<T>() where T : IWorkflow;
}