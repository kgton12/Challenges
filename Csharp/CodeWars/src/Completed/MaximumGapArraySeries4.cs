namespace CodeWars.Completed;

public class MaximumGapArraySeries4
{
    public static int MaxGap(int[] numbers)
    {
        if (numbers == null || numbers.Length < 2)
            return 0;

        var sorted = numbers.OrderBy(x => x).ToArray();
        var max = 0;

        for (int i = 0; i < sorted.Length - 1; i++)
        {
            var gap = sorted[i + 1] - sorted[i];
            if (gap > max)
                max = gap;
        }

        return max;
    }
}