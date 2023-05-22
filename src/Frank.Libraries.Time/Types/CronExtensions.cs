namespace Frank.Libraries.Time.Types;

public static class CronExtensions
{
    public static DateTime GetNextOccurrence(this Cron cron, DateTime dateTime) => cron.Expression.GetNextOccurrence(dateTime);
}