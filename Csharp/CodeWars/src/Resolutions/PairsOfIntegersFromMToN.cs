namespace CodeWars.Resolutions;

public class PairsOfIntegersFromMToN
{
    public static IEnumerable<(int, int)> GeneratePairs(int m, int n)
    {
        for (int i = m; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
                yield return (i, j);
        }
    }
}