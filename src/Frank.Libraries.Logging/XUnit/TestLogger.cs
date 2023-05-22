using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Frank.Libraries.Logging.XUnit;

public class TestLogger : ILogger
{
    private readonly string _categoryName;
    private readonly ITestOutputHelper _testOutputHelper;

    public TestLogger(string categoryName, ITestOutputHelper testOutputHelper)
    {
        _categoryName = categoryName;
        _testOutputHelper = testOutputHelper;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        _testOutputHelper.WriteLine($"{logLevel} - {eventId} - {_categoryName} - {exception.Message}");
        _testOutputHelper.WriteLine(formatter(state, exception));
        // _testOutputHelper.WriteLine(new JsonFormatter().Format(state));
        _testOutputHelper.WriteLine("");
    }

    public bool IsEnabled(LogLevel logLevel) => true;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => new Disposable();
}