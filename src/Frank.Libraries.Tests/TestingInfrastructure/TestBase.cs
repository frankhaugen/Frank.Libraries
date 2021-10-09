using Xunit.Abstractions;

namespace Frank.Libraries.Tests.TestingInfrastructure
{
    public abstract class TestBase
    {
        private readonly ITestOutputHelper _outputHelper;

        protected TestBase(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        protected void Output(string text) => _outputHelper.WriteLine(text);

    }
}
