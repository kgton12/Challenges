namespace CodeWars.Completed;

public class SortedUnion
{
    public static object[] UniteUnique(object[][] array) =>
        [.. array.SelectMany(x => x).Distinct()];
}