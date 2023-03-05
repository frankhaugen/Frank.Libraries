namespace Frank.Libraries.DataProcessing.Workflows;

public class WorkflowContextBuilder : IWorkflowContextBuilder
{
    private readonly Activities _activities = new();
    private object? _data;

    public IWorkflowContextBuilder WithData(object data)
    {
        _data = data;
        return this;
    }

    public IWorkflowContextBuilder WithActivity<T>() where T : class, IActivity, new()
    {
        _activities.Add(Activator.CreateInstance<T>());
        return this;
    }

    public WorkflowContext Build() => new WorkflowContext(_data, _activities);
}