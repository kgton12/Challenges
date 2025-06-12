namespace CodeWars.src.Resolutions;

public class SortArrayByStringLength
{
    public static string[] SortByLength(string[] array) => [.. array.OrderBy(x => x.Length)];
}
