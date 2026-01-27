namespace CodeWars.Resolutions;

public class PersistentBugger
{
    public static int Persistence(long n)
    {
        int result = 0;
        long valueAux = n;
        while (valueAux > 9)
        {
            valueAux = MultiplyDigits(valueAux);
            result++;
        }

        return result;
    }

    private static int MultiplyDigits(long n) =>
        n.ToString()
        .Select(c => (int)char.GetNumericValue(c))
        .Aggregate(1, (acc, digit) => acc * digit);
}
