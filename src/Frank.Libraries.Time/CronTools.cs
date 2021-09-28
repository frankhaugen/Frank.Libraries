// ReSharper disable CheckNamespace

using Cronos;
using NodaTime;

namespace Frank.Libraries
{
    public class CronTools
    {
        public void NextOccurence(string cronExpression = "* * * * *", Instant? instant = null, DateTimeZone? timeZone = null)
        {
            instant ??= new Instant();
            timeZone ??= DateTimeZone.Utc;

            var expression = CronExpression.Parse(cronExpression, CronFormat.Standard);

            //expression.GetNextOccurrence(instant.Value.ToDateTimeUtc(), timeZone.in)
        }
    }
}