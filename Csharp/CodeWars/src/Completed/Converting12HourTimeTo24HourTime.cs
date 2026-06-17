namespace CodeWars.Completed;

public class Converting12HourTimeTo24HourTime
{
    public static string Convert12hTo24h(int hours, int minutes, string period) =>
        TimeOnly.Parse($"{hours}:{minutes}{period}").ToString("HHmm");
}