namespace Frank.Libraries.Time.Providers;

public interface ITimeProvider
{
    DateTime GetUtcNow();
    DateOnly GetDate();
    TimeOnly GetTime();
}