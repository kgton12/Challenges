namespace CodeWars.Resolutions;

public class GapInPrimes
{
    public static long[]? Gap(int gap, long startSearch, long endSearch)
    {
        List<long> output = [];

        for (var index = startSearch; index <= endSearch; index++)
        {
            long numberWithGap = index + gap;
            bool isValidNumber = true;

            if (IsPrimeNumber(index) && IsPrimeNumber(numberWithGap) && numberWithGap <= endSearch)
            {
                for (var j = index + 1; j < numberWithGap; j++)
                {
                    if (IsPrimeNumber(j))
                    {
                        isValidNumber = false;
                        break;
                    }
                }
                if (isValidNumber)
                    output.AddRange([index, numberWithGap]);
            }
        }

        return output.Count <= 0
            ? null
            : [.. output[0..2]];
    }

    private static bool IsPrimeNumber(long n)
    {
        if (n < 2)
            return false;

        var square = Math.Truncate(Math.Sqrt(n));

        for (var index = 2; index <= square; index++)
            if (n % index == 0) return false;

        return true;
    }
}