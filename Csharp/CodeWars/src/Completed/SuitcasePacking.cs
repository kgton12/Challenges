namespace CodeWars.Completed;

public class SuitcasePacking
{
    public static bool FitSquares(int a, int b, int m, int n) =>
        (a + b <= m && Math.Max(a, b) <= n) ||
        (a + b <= n && Math.Max(a, b) <= m);
}
