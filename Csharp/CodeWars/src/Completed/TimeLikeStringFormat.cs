namespace CodeWars.Completed;

public class TimeLikeStringFormat
{
    public static string FormatTime(int hour)
    {
        if (hour < 100 || hour > 9999)
            throw new ArgumentException();

        return $"{hour:##:##}";
    }
}
