namespace CodeWars.Resolutions;

public class FindTwins
{
    public static object? Elimination(int[] arr)
    {
        return arr is null || arr.Distinct().Count() == arr.Length
            ? null
            : arr
                .GroupBy(x => x)
                .Where(x => x.Count() == 2)
                .Select(x => x.Key)
                .FirstOrDefault();
    }
}
