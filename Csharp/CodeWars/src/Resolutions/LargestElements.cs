namespace CodeWars.Resolutions;

public class LargestElements
{
    public static List<int> Largest(int n, List<int> xs) => [.. xs.OrderByDescending(x => x).Take(n).Reverse()];
}
