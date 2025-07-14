namespace CodeWars.src.Resolutions;

public class ConvertNumberToReversedArrayOfDigits
{
    public static long[] Digitize(long n) =>
        [.. n.ToString()
             .Select(x => (long)char.GetNumericValue(x))
             .Reverse()];

}
