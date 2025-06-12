namespace CodeWars.src;

public class SortOutTheMenFromBoys
{
    public static int[] MenFromBoys(int[] a)
    {
        var evenNumbers = a.Where(x => x % 2 == 0).Distinct().OrderBy(x => x);
        var oddNumbers = a.Where(x => x % 2 != 0).Distinct().OrderByDescending(x => x);
        return [.. evenNumbers, .. oddNumbers];
    }
}
