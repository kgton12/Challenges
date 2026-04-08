namespace CodeWars.Completed;

public class ReturnTheDay
{
    public static string WhatDay(int n) => n < 1 || n > 7 ? "Wrong, please enter a number between 1 and 7" : ((DayOfWeek)n - 1).ToString();
}
