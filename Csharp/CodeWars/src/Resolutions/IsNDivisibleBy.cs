namespace CodeWars.Resolutions;

public static class IsNDivisibleBy
{
    public static bool IsDivisible(params int[] args) =>
        args.All(x => args[0] % x == 0);
}
