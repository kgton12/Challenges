namespace CodeWars.Resolutions;

public class MaxDiffEasy
{
    public static int MaxDiff(int[] lst) => lst.Length > 1 ? Math.Abs(lst.Max() - lst.Min()) : 0;
}
