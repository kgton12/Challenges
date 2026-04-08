namespace CodeWars.Completed;

public class Speedcode2ArrayMadness
{
    public static bool ArrayMadness(int[] a, int[] b) =>
        a.Select(x => Math.Pow(x, 2)).Sum() >
        b.Select(x => Math.Pow(x, 3)).Sum();
}