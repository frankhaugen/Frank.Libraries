using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions;
using System.Threading.Tasks;

namespace Frank.Libraries.Tests.TestingInfrastructure
{
    public abstract class TestBase
    {
        private readonly ITestOutputHelper _outputHelper;

        protected TestBase(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        protected void Output(string text) => _outputHelper.WriteLine(text);

    }
}
