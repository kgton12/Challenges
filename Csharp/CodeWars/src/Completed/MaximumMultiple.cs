namespace CodeWars.Completed;

public class MaximumMultiple
{
    public static int MaxMultiply(int divisor, int bound) =>
        Enumerable.Range(1, bound).Where(x => x % divisor == 0).Max();
}
