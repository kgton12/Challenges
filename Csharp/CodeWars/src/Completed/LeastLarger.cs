namespace CodeWars.Completed;

public class LeastLargerClass
{
    public static int LeastLarger(int[] a, int i) =>
        a.Select((value, index) => new { Value = value, Index = index })
         .OrderBy(x => x.Value)
         .Where(x => x.Value > a[i])
         .Select(x => x.Index)
         .FirstOrDefault(-1);
}