namespace CodeWars.Resolutions;

public static class SimpleStringReversalIi
{
    public static string Solve(string s, int a, int b)
    {
        b = Math.Min(b, s.Length - 1);

        return string.Concat(
            s.Select((ch, i) =>
                i >= a && i <= b
                    ? s[a + b - i]
                    : ch
            )
        );
    }
}