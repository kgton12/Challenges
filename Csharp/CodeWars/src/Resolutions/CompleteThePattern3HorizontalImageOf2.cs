namespace CodeWars.Resolutions;

public class CompleteThePattern3HorizontalImageOf2
{
    public static string Pattern(int n)
    {
        if (n < 0)
            return string.Empty;

        int[] p = [.. Enumerable.Range(1, n).Reverse()];
        List<string> result = [];

        for (int i = 1; i <= n; i++)
            result.Add(string.Concat(p.Take(i)));

        return string.Join('\n', result);
    }
}