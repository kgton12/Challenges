namespace CodeWars.src.Resolutions;

public class SortedYesNoHow
{
    public static string IsSortedAndHow(int[] array)
    {
        if (array.SequenceEqual([.. array.OrderBy(x => x)])) return "yes, ascending";
        else if (array.SequenceEqual([.. array.OrderByDescending(x => x)])) return "yes, descending";
        else return "no";
    }
}
