namespace CodeWars.Resolutions;

public static class Pandemia
{
    public static double Infected(string s)
    {
        string[] peoples = ["0", "1"];

        if (!s.Contains('1') && !s.Contains('0')) return 0.0;

        var currentSituation = string.Concat(s.Split('X').Select(x => x.Contains('1') ? x.Replace('0', '1') : x));

        return 100.00 * currentSituation.Count(x => x == '1') / currentSituation.Length;
    }
}