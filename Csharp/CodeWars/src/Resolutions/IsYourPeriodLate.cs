namespace CodeWars.src.Resolutions;

public class IsYourPeriodLate
{
    public static bool PeriodIsLate(DateTime last, DateTime today, int cycleLength) => last.AddDays(cycleLength) < today;
}
