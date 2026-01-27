namespace CodeWars.Resolutions;

public class ConsecutiveItems
{
    public static bool Consecutive(int[] arr, int a, int b) =>
        Math.Abs(Array.IndexOf(arr, a) - Array.IndexOf(arr, b)) == 1;
}
