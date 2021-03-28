using System;

// ReSharper disable once CheckNamespace
namespace Frank.Libraries
{
    /// <summary>
    /// A testable (injectable) implementation of time, using only UTC as a base, and operates in
    /// the concept of Y-W-D HHmmssfff
    /// </summary>
    public class Time : ITime
    {
        private static WeekTime _testTime;

        private WeekTime GetNow() => TestMode ? _testTime : WeekTime.Now;

        private void EnsureTestMode()
        {
            if (!TestMode)
            {
                throw new InvalidOperationException("Testmode is not activated!");
            }
        }

        /// <summary>
        /// The year
        /// </summary>
        public int Year => GetNow().Year;

        /// <summary>
        /// The week of the year
        /// </summary>
        public int Week => GetNow().Week;

        /// <summary>
        /// The day of the week
        /// </summary>
        public int Day => GetNow().Day;

        /// <summary>
        /// The hour of the 24-hour day
        /// </summary>
        public int Hour => GetNow().Hour;

        /// <summary>
        /// The minute of the hour
        /// </summary>
        public int Minute => GetNow().Minute;

        /// <summary>
        /// The second of the minute
        /// </summary>
        public int Second => GetNow().Second;

        /// <summary>
        /// The millisecond of the second
        /// </summary>
        public int Millisecond => GetNow().Millisecond;

        /// <summary>
        /// Is the time in test-mode
        /// </summary>
        public bool TestMode { get; private set; }

        /// <summary>
        /// Is the time in test-mode
        /// </summary>
        public WeekTime Now => GetNow();

        /// <summary>
        /// Get the instant in a friendly string
        /// </summary>
        /// <returns>YYYY-WW-DD HH:MM:SS:FFF</returns>
        public override string ToString() => $"{Year:0000}-{Week:00}-{Day} {Hour:00}:{Minute:00}:{Second:00}:{Millisecond:000}";

        /// <summary>
        /// Starts testmode
        /// </summary>
        /// <exception cref="InvalidOperationException">Testmode is already activated</exception>
        public void StartTestMode() => TestMode = !TestMode ? true : throw new InvalidOperationException("Already in testmode");

        /// <summary>
        /// Stoppes test mode
        /// </summary>
        /// <exception cref="InvalidOperationException">Testmode is not activated</exception>
        public void StopTestMode()
        {
            EnsureTestMode();
            TestMode = false;
            _testTime = WeekTime.Now;
        }

        /// <summary>
        /// Sets the time to be used for testing purposes
        /// </summary>
        /// <exception cref="InvalidOperationException">Testmode is not activated</exception>
        public void SetTestTime(WeekTime instant)
        {
            EnsureTestMode();
            _testTime = instant;
        }
    }
}