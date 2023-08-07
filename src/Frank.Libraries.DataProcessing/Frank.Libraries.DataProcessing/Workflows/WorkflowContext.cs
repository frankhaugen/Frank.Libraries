namespace Frank.Libraries.DataProcessing.Workflows;

public class WorkflowContext
{
    private readonly object? _data;

    public WorkflowContext(object? data, Activities activities)
    {
        _data = data;
        Activities = activities;
    }

    public Activities Activities { get; }

    public T? GetInput<T>() where T : class => _data as T;
}