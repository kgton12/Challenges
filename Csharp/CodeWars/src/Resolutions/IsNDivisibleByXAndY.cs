namespace CodeWars.Resolutions;

public class IsNDivisibleByXAndY
{
    public static bool IsDivisible(int n, int x, int y) =>
        n % x == 0 && n % y == 0;
}
