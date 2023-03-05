namespace Frank.Libraries.DataProcessing.Workflows;

public class ActivityContext
{
    private readonly object? _data;

    public ActivityContext(object? data = null) => _data = data;

    public T? GetInput<T>() where T : class => _data as T;
}