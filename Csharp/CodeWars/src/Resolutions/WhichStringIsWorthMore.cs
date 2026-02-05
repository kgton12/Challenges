namespace CodeWars.Resolutions;

public class WhichStringIsWorthMore
{
    public static string HighestValue(string a, string b) =>
        a.Sum(a => a) >= b.Sum(b => b)
            ? a
            : b;
}