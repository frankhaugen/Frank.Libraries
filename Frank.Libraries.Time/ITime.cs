namespace Frank.Libraries
{
    public interface ITime
    {
        /// <summary>
        /// The year
        /// </summary>
        int Year { get; }

        /// <summary>
        /// The week of the year
        /// </summary>
        int Week { get; }

        /// <summary>
        /// The day of the week
        /// </summary>
        int Day { get; }

        /// <summary>
        /// The hour of the 24-hour day 
        /// </summary>
        int Hour { get; }

        /// <summary>
        /// The minute of the hour
        /// </summary>
        int Minute { get; }

        /// <summary>
        /// The second of the minute
        /// </summary>
        int Second { get; }

        /// <summary>
        /// The millisecond of the second
        /// </summary>
        int Millisecond { get; }

        /// <summary>
        /// Is the time in test-mode
        /// </summary>
        bool TestMode { get; }

        /// <summary>
        /// Is the time in test-mode
        /// </summary>
        WeekTime Now { get; }

        /// <summary>
        /// Get the instant in a friendly string
        /// </summary>
        /// <returns>YYYY-WW-DD HH:MM:SS:FFF</returns>
        string ToString();

        /// <summary>
        /// Starts testmode
        /// </summary>
        /// <exception cref="InvalidOperationException">Testmode is already activated</exception>
        void StartTestMode();

        /// <summary>
        /// Stoppes test mode
        /// </summary>
        /// <exception cref="InvalidOperationException">Testmode is not activated</exception>
        void StopTestMode();

        /// <summary>
        /// Sets the time to be used for testing purposes
        /// </summary>
        /// <exception cref="InvalidOperationException">Testmode is not activated</exception>
        void SetTestTime(WeekTime instant);
    }
}