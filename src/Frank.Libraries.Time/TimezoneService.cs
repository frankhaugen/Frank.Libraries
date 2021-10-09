using System;
using System.Collections.Generic;
using System.Linq;
using NodaTime;
using NodaTime.Extensions;

namespace Frank.Libraries.Time
{
    public class TimezoneService : TimeBaseService
    {
        public TimezoneService(IClock clock) : base(clock)
        {
        }

        /// <summary>
        /// Get a list of all timezones
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<DateTimeZone> GetTimezones() => DateTimeZoneProviders.Tzdb.GetAllZones().ToList();

        /// <summary>
        /// Get a list of timezones that apply to a UTC offset
        /// </summary>
        /// <returns>A readomnly list of timezones</returns>
        public IReadOnlyList<DateTimeZone> GetTimezones(Offset offset) => DateTimeZoneProviders.Tzdb.GetAllZones().Where(x => x.GetUtcOffset(Clock.GetCurrentInstant()).Minus(offset) == Offset.Zero).ToList();

        /// <summary>
        /// Get a list of timezone names
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<string> GetTimezoneNames() => DateTimeZoneProviders.Tzdb.GetAllZones().Select(x => x.Id).ToList();

        /// <summary>
        /// Get the timezone of the system
        /// </summary>
        /// <returns></returns>
        public DateTimeZone GetSystemTimezone() => DateTimeZoneProviders.Tzdb.GetSystemDefault();

        /// <summary>
        /// Takes the IANA name and returns the actual zone type
        /// </summary>
        /// <param name="ianaName"></param>
        /// <returns>Returnes a timezone or null</returns>
        public DateTimeZone ParseTimeZone(string ianaName)
        {
            if (DateTimeZoneProviders.Tzdb.GetZoneOrNull(ianaName) == null) throw new TimeZoneNotFoundException($"The timezone '{ianaName}' does not exist");
            var dateTimeZone = DateTimeZoneProviders.Tzdb.GetZoneOrNull(ianaName);
            if (dateTimeZone == null) throw new TimeZoneNotFoundException($"The timezone '{ianaName}' does not exist");
            return dateTimeZone;
        }

        /// <summary>
        /// Takes the IANA name and returns a bool indicating if it exist
        /// </summary>
        /// <param name="ianaName"></param>
        /// <returns>Returns a bool indicating timezone's exisitamce</returns>
        public bool TimeZoneExist(string ianaName) => DateTimeZoneProviders.Tzdb.GetZoneOrNull(ianaName) != null;

        public ZonedDateTime NowZonedDateTime(DateTimeZone timeZone) => Clock.GetCurrentInstant().InZone(timeZone);
        public ZonedDateTime NowZonedDateTime(string ianaTimezone) => Clock.GetCurrentInstant().InZone(DateTimeZoneProviders.Tzdb[ianaTimezone]);
        public ZonedDateTime ToZonedDateTime(string ianaTimezone, DateTime dateTime) => Instant.FromDateTimeUtc(dateTime).InZone(DateTimeZoneProviders.Tzdb[ianaTimezone]);

        public override string ToString() => GetSystemTimezone().ToString();
    }
}