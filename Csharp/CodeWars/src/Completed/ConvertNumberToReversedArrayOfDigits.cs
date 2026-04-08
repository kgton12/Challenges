namespace CodeWars.Completed;

public static class ConvertNumberToReversedArrayOfDigits
{
    public static long[] Digitize(long n) =>
        [.. n.ToString()
             .Select(x => (long)char.GetNumericValue(x))
             .Reverse()];

}
