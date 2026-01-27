namespace CodeWars.Resolutions;

public class ReverseTheBitsInAnInteger
{
    public static long ReverseBits(long n) =>
        Convert.ToInt64(string.Concat(Convert.ToString(n, 2).Reverse()), 2);
}