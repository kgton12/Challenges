namespace CodeWars.Resolutions;

public static class SumOfNumbersFrom0ToN
{
    public static string ShowSequence(int n)
    {
        if (n == 0)
            return "0=0";
        else if (n < 0)
            return $"{n}<0";

        IEnumerable<int> nuns = Enumerable.Range(0, n + 1);

        return $"{string.Join("+", nuns.Select(x => x))} = {nuns.Sum()}";
    }
}
