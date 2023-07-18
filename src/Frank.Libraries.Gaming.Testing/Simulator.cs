namespace Frank.Libraries.Gaming.Testing;

/// <summary>
/// Simulates a game loop and allows for the simulation speed to be adjusted and the simulation to be stopped
/// </summary>
public class Simulator
{
    private bool _stopSimulation;

    /// <summary>
    /// The total running time of the simulation
    /// </summary>
    public TimeSpan TotalRunningTime { get; private set; } = TimeSpan.Zero;

    /// <summary>
    /// The speed of the simulation (1 = realtime), 0 and below is infinite speed
    /// </summary>
    public float SimulationSpeed { get; set; } = 5;

    /// <summary>
    /// The time between each iteration
    /// </summary>
    public TimeSpan TimeIncrement { get; set; } = TimeSpan.FromSeconds(1);

    /// <summary>
    /// Stops the simulation
    /// </summary>
    public void Stop() => _stopSimulation = true;

    /// <summary>
    /// Runs the simulation for the specified number of iterations
    /// </summary>
    /// <param name="iterations"></param>
    /// <param name="action"></param>
    public void Run(int iterations, Action<TimeSpan> action)
    {
        for (var i = 0; i < iterations; i++)
        {
            if (_stopSimulation)
            {
                _stopSimulation = false;
                break;
            }
            Run(action);
        }
    }

    /// <summary>
    /// Runs the simulation for the specified time
    /// </summary>
    /// <param name="timeSpan"></param>
    /// <param name="action"></param>
    public void Run(TimeSpan timeSpan, Action<TimeSpan> action)
    {
        while (TotalRunningTime < timeSpan)
        {
            if (_stopSimulation)
            {
                _stopSimulation = false;
                break;
            }
            Run(action);
        }
    }

    /// <summary>
    /// Runs one iteration of the simulation and increments the time by the TimeIncrement
    /// </summary>
    /// <param name="action"></param>
    public void Run(Action<TimeSpan> action)
    {
        TotalRunningTime += TimeIncrement;
        if (SimulationSpeed > 0)
        {
            Task.Delay(TimeIncrement / SimulationSpeed).Wait();
        }
        action.Invoke(TotalRunningTime);
    }
}