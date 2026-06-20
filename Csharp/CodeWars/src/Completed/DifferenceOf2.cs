namespace CodeWars.Completed;

public class DifferenceOf2
{
    public static (int, int)[] TwosDifference(int[] array)
    {
        var arraySet = new HashSet<int>(array).OrderBy(x => x);
        List<(int, int)> result = [];

        foreach (var value in arraySet)
        {
            if (arraySet.Contains(value + 2))
                result.Add((value, value + 2));
        }

        return [.. result];
    }
}