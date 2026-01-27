namespace CodeWars.Resolutions;

public class Fibonacci
{
    public static int Fib(int n) =>
        CalculateFibonacci(n);

    private static int CalculateFibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int a = 0, b = 1, c = 0;

        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
}
