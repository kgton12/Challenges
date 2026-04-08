namespace CodeWars.Completed;

public class SumOfTriangularNumbers
{
    public static int SumTriangularNumbers(int n)
    {
        if (n < 1) return 0;

        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i * (i + 1) / 2;

        return sum;
    }
}
