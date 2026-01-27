namespace CodeWars.Resolutions;

public class BeginnerSeries3SumOfNumbers
{
    public static int GetSum(int a, int b)
    {
        int init = Math.Min(a, b);
        int end = Math.Max(a, b);
        int sum = 0;

        for (int i = init; i <= end; i++)
            sum += i;
        return sum;
    }
}
