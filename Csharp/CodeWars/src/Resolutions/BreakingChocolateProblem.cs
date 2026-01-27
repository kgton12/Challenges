namespace CodeWars.Resolutions;

public class BreakingChocolateProblem
{
    public static int BreakChocolate(int n, int m) =>
        m <= 0 || n <= 0 ? 0 : n * m - 1;
}
