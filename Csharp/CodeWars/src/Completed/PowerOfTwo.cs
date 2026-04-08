using System.Numerics;

namespace CodeWars.Completed;

public class PowerOfTwoClass
{
    public static bool PowerOfTwo(int n) =>
        new BigInteger(n).IsPowerOfTwo;
}
