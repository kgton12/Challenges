namespace CodeWars.Completed;

public class FindTheOddInt
{
    public static int FindIt(int[] seq) =>
        seq.GroupBy(g => g)
        .Select(z => new { z.Key, Value = z.Count() })
        .Where(w => w.Value % 2 != 0)
        .First().Key;
}
