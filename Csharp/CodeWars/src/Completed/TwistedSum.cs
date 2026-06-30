namespace CodeWars.Completed;

public class TwistedSum
{
    public static long Solution(long n)
    {
        long sum = 0;

        for (int i = 1; i <= n; i++)
            sum += (long)i.ToString().Sum(char.GetNumericValue);

        return sum;
    }
}
