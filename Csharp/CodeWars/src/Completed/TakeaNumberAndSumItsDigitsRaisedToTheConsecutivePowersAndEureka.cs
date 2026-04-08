namespace CodeWars.Completed;

public class TakeaNumberAndSumItsDigitsRaisedToTheConsecutivePowersAndEureka
{
    public static long[] SumDigPow(long a, long b)
    {
        List<long> result = [];
        for (long i = a; i < b; i++)
            if (IsEureka(i)) result.Add(i);

        return [.. result];

    }

    private static bool IsEureka(double n) =>
        n == n.ToString()
              .Select((value, index) => Math.Pow(char.GetNumericValue(value), index + 1))
              .Sum();
}
