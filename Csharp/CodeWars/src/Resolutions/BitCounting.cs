namespace CodeWars.Resolutions;

public class BitCounting
{
    public static int CountBits(int n) => Convert.ToString(n, 2).Count(x => x == '1');
}
