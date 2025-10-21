namespace CodeWars.src.Resolutions;

public class CountingInTheAmazon
{
    public static string CountArara(int n)
    {
        return n % 2 == 0
            ? BuildRepeatArara(n / 2)
            : (BuildRepeatArara((n - 1) / 2) + " anane").Trim();
    }

    private static string BuildRepeatArara(int n) =>
        string.Join(" ", Enumerable.Repeat("adak", n));
}
