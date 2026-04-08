namespace CodeWars.Completed;

public class IsANumberPrime
{
    public static bool IsPrime(int n)
    {
        if (n < 2) return false;

        var square = Math.Truncate(Math.Sqrt(n));

        for (int index = 2; index <= square; index++)
            if (n % index == 0) return false;

        return true;
    }
}
