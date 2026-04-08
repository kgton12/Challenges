namespace CodeWars.Completed;

public class TwotoOne
{
    public static string Longest(string s1, string s2) =>
        string.Concat(string.Concat(s1, s2).Distinct().OrderBy(x => x));
}
