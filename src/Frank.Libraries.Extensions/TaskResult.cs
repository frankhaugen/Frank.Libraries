namespace Frank.Libraries.Extensions;

public record TaskResult<T>(bool Success, T? Value, Exception? Exception);