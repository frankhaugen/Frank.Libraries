namespace Frank.Libraries.Extensions;

public static class TaskExtensions
{
    public static async Task<TaskResult<T>> RunTaskAsync<T>(this Task<T> task)
    {
        try
        {
            return new TaskResult<T>(false, await task, null);
        }
        catch (Exception e)
        {
            return new TaskResult<T>(false, default, e);
        }
    }
}