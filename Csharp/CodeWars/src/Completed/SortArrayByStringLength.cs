namespace CodeWars.Completed;

public class SortArrayByStringLength
{
    public static string[] SortByLength(string[] array) => [.. array.OrderBy(x => x.Length)];
}
