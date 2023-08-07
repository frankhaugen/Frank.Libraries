namespace Frank.Libraries.DataProcessing.Workflows;

public interface IWorkflowContextBuilder
{
    public IWorkflowContextBuilder WithData(object data);
    public IWorkflowContextBuilder WithActivity<T>() where T : class, IActivity, new();

    public WorkflowContext Build();
}