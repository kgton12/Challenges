namespace CodeWars;

public class CountTheDivisibleNumbers
{
    public static long DivisibleCount(long x, long y, long k)
    {
        if (x > y)
            return 0;

        return FloorDiv(y, k) - FloorDiv(x - 1, k);
    }
    private static long FloorDiv(long a, long b)
    {
        long q = a / b;
        if (a < 0 && a % b != 0)
            q--;
        return q;
    }
}
