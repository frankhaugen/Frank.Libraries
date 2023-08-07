namespace Frank.Libraries.DataProcessing.Workflows;

public class ActivityResult
{
    internal ActivityResult()
    {
    }

    internal ActivityResult(bool isSuccess, object? data)
    {
        IsSuccess = isSuccess;
        Data = data;
    }

    public bool IsSuccess { get; }
    public object? Data { get; }
}