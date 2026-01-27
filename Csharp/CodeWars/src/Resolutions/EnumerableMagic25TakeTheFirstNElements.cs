namespace CodeWars.Resolutions;

public class EnumerableMagic25TakeTheFirstNElements
{
    public static int[] Take(int[] arr, int n) => [.. arr.Take(n)];
}
