namespace Frank.Libraries.Time.Types;

internal static class CronExpressionBaseExtensions
{
    public static DateTime GetNextOccurrence(this CronExpressionBase cronExpression, DateTime dateTime) => dateTime;
}