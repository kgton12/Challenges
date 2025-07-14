namespace CodeWars.src.Resolutions;

public class TwoOldestAgesClass
{
    public static int[] TwoOldestAges(int[] ages) =>
        [.. ages.OrderBy(x => x).TakeLast(2)];
}
