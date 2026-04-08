namespace CodeWars.Completed;

public class SumOfMultiples
{
    public static int SumMul(int n, int m)
    {
        if (m <= n || n <= 0) throw new ArgumentException("");

        int sum = 0;
        for (int i = 1; i * n < m; i++)
            sum += i * n;

        return sum;
    }
}
