namespace CodeWars.Completed;

public static class TransformToPrime
{
    public static int MinimumNumber(int[] numbers)
    {
        int sum = numbers.Sum();
        return NextPrimeNumber(sum) - sum;
    }

    private static int NextPrimeNumber(int n)
    {
        while (true)
        {
            if (IsPrimeNumber(n)) return n;
            n++;
        }
    }

    private static bool IsPrimeNumber(int n)
    {
        if (n < 2) return false;

        int square = (int)Math.Truncate(Math.Sqrt(n));

        for (int index = 2; index <= square; index++)
            if (n % index == 0) return false;

        return true;
    }
}
