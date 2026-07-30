namespace CodeWars.Completed;

public class SequencesAndSeries
{
    public static long GetScore(long n)
    {
        long sum = 0;

        for (int i = 1; i <= n; i++)
            sum += i * 50;

        return sum;
    }
}