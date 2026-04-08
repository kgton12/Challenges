namespace CodeWars.Completed;

public class AllStarCodeChallenge22
{
    public static string ToTime(int seconds)
    {
        double hours = Math.Floor(seconds / 3600.0);
        double minutes = Math.Floor(seconds % 3600.0 / 60);
        return $"{hours} hour(s) and {minutes} minute(s)";
    }
}