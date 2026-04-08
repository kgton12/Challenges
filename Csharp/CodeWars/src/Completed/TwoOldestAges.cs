namespace CodeWars.Completed;

public class TwoOldestAgesClass
{
    public static int[] TwoOldestAges(int[] ages) =>
        [.. ages.OrderBy(x => x).TakeLast(2)];
}
