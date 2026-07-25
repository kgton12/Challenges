namespace CodeWars.Completed;

public class ClockyMcClockFace
{
    public static string WhatTimeIsIt(double angle)
    {
        return DateTime.Today.Add(TimeSpan.FromHours((angle / 360) * 12)).ToString("hh:mm");
    }
}