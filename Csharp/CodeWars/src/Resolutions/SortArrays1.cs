namespace CodeWars.src.Resolutions;

public class SortArrays1
{
    public static string[] SortMe(string[] names) =>
        [.. names.OrderBy(x => x)];
}
