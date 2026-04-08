namespace CodeWars.Completed;

public static class ColorOfTheMoment
{
    public static string HexToTime(string hex)
    {
        int hour = Convert.ToInt32(hex[1..3], 16);
        int minute = Convert.ToInt32(hex[3..5], 16);
        int second = Convert.ToInt32(hex[5..7], 16);

        if (hour > 23 || minute > 59 || second > 59)
            throw new Exception("Thats not a valid time!");

        return new TimeSpan(hour, minute, second).ToString(@"hh\:mm\:ss");
    }
}