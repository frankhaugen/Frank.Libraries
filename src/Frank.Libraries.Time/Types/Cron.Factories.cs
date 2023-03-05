using System;

namespace Frank.Libraries.Time.Providers;

public readonly partial record struct Cron
{
    public static Cron EveryMinute() => "0 * * * *";
    public static Cron EveryHour() => "0 0 * * *";
    public static Cron EveryDay() => "0 0 0 * *";
    public static Cron EveryWeek() => "0 0 0 * * 0";
    public static Cron EveryMonth() => "0 0 0 1 *";
    public static Cron EveryYear() => "0 0 0 1 1";
    public static Cron EveryWeekday() => "0 0 0 * * 1-5";
    public static Cron EveryWeekend() => "0 0 0 * * 0,6";
    public static Cron EveryMonday() => "0 0 0 * * 1";
    public static Cron EveryTuesday() => "0 0 0 * * 2";
    public static Cron EveryWednesday() => "0 0 0 * * 3";
    public static Cron EveryThursday() => "0 0 0 * * 4";
    public static Cron EveryFriday() => "0 0 0 * * 5";
    public static Cron EverySaturday() => "0 0 0 * * 6";
    public static Cron EverySunday() => "0 0 0 * * 0";
    public static Cron EveryDayAt(int hour, int minute) => $"0 {minute} {hour} * *";
    public static Cron EveryWeekAt(int hour, int minute, DayOfWeek dayOfWeek) => $"0 {minute} {hour} * * {(int)dayOfWeek}";
    public static Cron EveryMonthAt(int hour, int minute, int day) => $"0 {minute} {hour} {day} *";
    public static Cron EveryYearAt(int hour, int minute, int day, int month) => $"0 {minute} {hour} {day} {month}";
    public static Cron EveryDayAt(int hour, int minute, int second) => $"{second} {minute} {hour} * *";
    public static Cron EveryWeekAt(int hour, int minute, int second, DayOfWeek dayOfWeek) => $"{second} {minute} {hour} * * {(int)dayOfWeek}";
    public static Cron EveryMonthAt(int hour, int minute, int second, int day) => $"{second} {minute} {hour} {day} *";
    public static Cron EveryYearAt(int hour, int minute, int second, int day, int month) => $"{second} {minute} {hour} {day} {month}";
}