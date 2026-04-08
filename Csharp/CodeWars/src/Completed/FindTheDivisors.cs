namespace CodeWars.Completed;

public class FindTheDivisors
{
    public static int[]? Divisors(int n) =>
       IsPrimeNumber(n)
        ? null
        : [.. Enumerable.Range(2, (int)Math.Ceiling((double)n / 2)).Where(x => n % x == 0)];

    private static bool IsPrimeNumber(int n)
    {
        if (n < 2) return false;

        var square = Math.Truncate(Math.Sqrt(n));

        for (int index = 2; index <= square; index++)
            if (n % index == 0) return false;

        return true;
    }
}
