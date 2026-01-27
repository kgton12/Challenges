namespace CodeWars.Resolutions;

public class CountingDuplicates
{
    public static int DuplicateCount(string str) =>
        str.ToLower()
        .GroupBy(g => g)
        .Where(s => s.Count() > 1)
        .Count();
}
