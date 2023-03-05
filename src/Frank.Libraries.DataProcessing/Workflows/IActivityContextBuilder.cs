namespace Frank.Libraries.DataProcessing.Workflows;

public interface IActivityContextBuilder
{
    public IActivityContextBuilder WithInput(object input);

    public ActivityContext Build();
}