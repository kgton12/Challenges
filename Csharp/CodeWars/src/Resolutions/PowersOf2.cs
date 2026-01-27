using System.Numerics;

namespace CodeWars.Resolutions;

public class PowersOf2
{
    public static BigInteger[] PowersOfTwo(int n) =>
        [.. Enumerable.Range(0, n + 1).Select(x => (BigInteger)Math.Pow(2, x))];
}
