namespace CodeWars.Resolutions;

public class MostValuableCharacter
{
    public static char Solve(string s)
    {
        if (s.Length == s.Distinct().Count()) return s[0];

        return s
            .Distinct()
            .Select(x => (Result: Max(s, x) - Min(s, x), Char: x))
            .OrderByDescending(x => x.Result)
            .ThenBy(x => x.Char)
            .First()
            .Char;
    }
    private static int Max(string str, char c) =>
        str
        .Select((v, i) => new { Value = v, Index = i })
        .Where(x => x.Value == c)
        .Max(x => x.Index);

    private static int Min(string str, char c) =>
        str
        .Select((v, i) => new { Value = v, Index = i })
        .Where(x => x.Value == c)
        .Min(x => x.Index);
}