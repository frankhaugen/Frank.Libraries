namespace Frank.Libraries.DataProcessing.Workflows;

public class ActivityContextBuilder : IActivityContextBuilder
{
    private object? _data;

    public IActivityContextBuilder WithInput(object input)
    {
        _data = input;
        return this;
    }

    public ActivityContext Build() => new(_data);
}