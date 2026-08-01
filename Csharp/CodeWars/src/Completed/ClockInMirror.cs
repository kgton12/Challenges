namespace CodeWars.Completed;

public class ClockInMirror
{
    public static string WhatIsTheTime(string timeInMirror) =>
        DateTime.Parse("12:00").Subtract(TimeSpan.Parse(timeInMirror)).ToString("hh:mm");
}