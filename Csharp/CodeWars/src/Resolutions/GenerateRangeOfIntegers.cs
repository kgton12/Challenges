namespace CodeWars.src.Resolutions;

public class GenerateRangeOfIntegers
{
    public static int[] GenerateRange(int min, int max, int step)
    {
        var result = new List<int>();
        for (int i = min; i <= max; i += step)
            result.Add(i);

        return [.. result];
    }
}
