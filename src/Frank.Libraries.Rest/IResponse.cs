namespace Frank.Libraries.Rest;

public interface IResponse<out T> : IResponse
{
    T? Data { get; }
}