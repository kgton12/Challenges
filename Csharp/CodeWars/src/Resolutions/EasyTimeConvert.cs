namespace CodeWars.src.Resolutions;

public class EasyTimeConvert
{
    public static string TimeConvert(int num)
    {
        if (num <= 0) return "00:00";

        string hours = (num / 60).ToString("00");
        string minutes = (num % 60).ToString("00");
        return $"{hours}:{minutes}";
    }
}
