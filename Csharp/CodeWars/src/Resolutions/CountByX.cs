namespace CodeWars.Resolutions;

public class CountByX
{
    public static int[] CountBy(int x, int n) =>
        [.. Enumerable.Range(1, n).Select(s => s * x)];
}
