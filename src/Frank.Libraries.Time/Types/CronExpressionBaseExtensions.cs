using System;

namespace Frank.Libraries.Time.Providers;

internal static class CronExpressionBaseExtensions
{
    public static DateTime GetNextOccurrence(this CronExpressionBase cronExpression, DateTime dateTime) => dateTime;
}