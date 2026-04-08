namespace CodeWars.Completed;

public class SortAndStar
{
    public static string TwoSort(string[] s) =>
        string.Join("***",
            s
            .OrderBy(x => x, StringComparer.Ordinal)
            .First()
            .Select(x => x));
}
