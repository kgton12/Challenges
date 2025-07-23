using System.Numerics;

namespace CodeWars.src.Resolutions;

public class PowerOfTwoClass
{
    public static bool PowerOfTwo(int n) =>
        new BigInteger(n).IsPowerOfTwo;
}
