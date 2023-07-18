using Frank.Libraries.Gaming.Testing;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Gaming.Physics;

public class PhysicsTests
{
    private  readonly ITestOutputHelper _outputHelper;

    public PhysicsTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void Test1()
    {
        var simulator = new Simulator();

        // var cannonSimulator = new CannonSimulator();

        simulator.Run(100, time => { });


    }
}