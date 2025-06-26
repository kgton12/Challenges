namespace CodeWars.src.Resolutions;

public class ArrayDiffClass
{
    public static int[] ArrayDiff(int[] a, int[] b) =>
        [.. a.Where(x => !b.Contains(x))];
}
