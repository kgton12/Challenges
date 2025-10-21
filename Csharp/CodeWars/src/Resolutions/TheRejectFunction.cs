namespace CodeWars.src.Resolutions;

public class TheRejectFunction
{
    public static int[] Reject(int[] array, Func<int, bool> predicate) =>
        [.. array.Where(x => !predicate(x))];
}
