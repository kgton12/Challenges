using System.Numerics;

namespace CodeWars;

public class StringIntegerGreaterThan
{
    public static bool StringIntGreaterThan(string a, string b)
    {
        if (BigInteger.TryParse(a, out BigInteger bIntA) &&
            BigInteger.TryParse(b, out BigInteger bIntB)
        )
            return bIntA > bIntB;

        return false;
    }
}