namespace CodeWars.Resolutions;

public class DrawStairsClass
{
    public static string DrawStairs(int n) =>
        string.Join("\n", Enumerable
            .Range(0, n)
            .Select(x => $"{new string(' ', x)}I"));
}
