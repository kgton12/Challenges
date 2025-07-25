namespace CodeWars.src.Resolutions;

internal class DrawStairsClass
{
    public static string DrawStairs(int n) =>
        string.Join("\n", Enumerable
            .Range(0, n)
            .Select(x => $"{new string(' ', x)}I"));
}
