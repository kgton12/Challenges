namespace CodeWars.Completed;

public class TheRejectFunction
{
    public static int[] Reject(int[] array, Func<int, bool> predicate) =>
        [.. array.Where(x => !predicate(x))];
}
