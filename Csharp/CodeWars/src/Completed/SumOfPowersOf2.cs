namespace CodeWars.Completed;

public class SumOfPowersOf2
{
    public static int[] Powers(int n) =>
         [.. Enumerable.Range(0, 31).Select(x => 1 << x).Where(b => (b & n) == b)];
}
