namespace CodeWars.Completed;

public class ArrayDiffClass
{
    public static int[] ArrayDiff(int[] a, int[] b) =>
        [.. a.Where(x => !b.Contains(x))];
}
