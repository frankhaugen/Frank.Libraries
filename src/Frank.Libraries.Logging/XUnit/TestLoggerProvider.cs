using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Frank.Libraries.Logging.XUnit;

public class TestLoggerProvider : ILoggerProvider
{
    private readonly ITestOutputHelper _testOutputHelper;

    public TestLoggerProvider(ITestOutputHelper testOutputHelper) => _testOutputHelper = testOutputHelper;

    public ILogger CreateLogger(string categoryName) => new TestLogger(categoryName, _testOutputHelper);

    public void Dispose()
    {
    }
}