namespace CodeWars.Completed;

public class RowOfTheOddTriangle
{
    public static long[] OddRow(int n)
    {
        long start = ((long)n * n) - n + 1;
        return [.. Enumerable.Range(0, n).Select(i => start + 2L * i)];
    }
}