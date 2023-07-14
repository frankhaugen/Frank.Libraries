namespace Frank.Libraries.Gaming.Testing;

public class Simulator
{
    private readonly DateTime _started;
    private TimeSpan _runningTime = TimeSpan.Zero;

    private bool _stopSimulation;

    public Simulator() => _started = DateTime.UtcNow;

    public float SimulationSpeed { get; set; } = 5;

    public TimeSpan TimeIncrement { get; set; } = TimeSpan.FromSeconds(1);

    public void Stop() => _stopSimulation = true;

    public void Run(int iterations, Action<TimeSpan> action)
    {
        for (int i = 0; i < iterations; i++)
        {
            if (_stopSimulation)
            {
                _stopSimulation = false;
                break;
            }
            Run(action);
        }
    }

    public void Run(Action<TimeSpan> action)
    {
        _runningTime += TimeIncrement;
        Task.Delay(TimeIncrement / SimulationSpeed).Wait();
        action.Invoke(_runningTime);
    }
}