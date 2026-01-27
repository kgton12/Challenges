namespace CodeWars.Resolutions;

public class ReturnTheFirstMMultiplesOfN
{
    public static double[] Multiples(int m, double n) => [.. Enumerable.Range(1, m).Select(x => x * n)];
}
