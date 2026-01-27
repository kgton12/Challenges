namespace CodeWars.Resolutions;

public class CompleteSeriesClass
{
    public static int[] CompleteSeries(int[] arr) =>
        arr.Length != arr.Distinct().Count()
        ? [0]
        : [.. Enumerable.Range(0, arr.Max() + 1)];
}
