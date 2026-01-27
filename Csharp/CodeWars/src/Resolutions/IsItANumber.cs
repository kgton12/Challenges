namespace CodeWars.Resolutions;

public class IsItANumber
{
    public static bool IsDigit(string s) => double.TryParse(s, out double _);
}
