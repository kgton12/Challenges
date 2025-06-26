namespace CodeWars.src.Resolutions;

public class SumOfASequence
{
    public static int SequenceSum(int start, int end, int step)
    {
        if (start > end) return 0;

        return Enumerable.Range(0, (end - start) / step + 1)
                  .Select(i => start + i * step)
                  .Where(x => x <= end)
                  .Sum();
    }
}
