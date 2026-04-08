namespace CodeWars.Completed;

public class BeginnerSeries5TriangularNumbers
{
    public static bool IsTriangular(long T)
    {
        long d = 1 + 8 * T;
        var r = Math.Sqrt(d);

        return r % 1 == 0;
    }
}