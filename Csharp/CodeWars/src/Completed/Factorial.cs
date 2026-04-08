namespace CodeWars.Completed;

public static class FactorialClass
{
    public static ulong Factorial(int N)
    {
        if (N == 0 || N == 1)
            return 1;

        ulong factorial = 1;
        for (int i = N; i > 1; i--)
            factorial *= (ulong)i;

        return factorial;
    }
}
