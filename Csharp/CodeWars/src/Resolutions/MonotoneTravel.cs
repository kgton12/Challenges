namespace CodeWars.Resolutions;

public class MonotoneTravel
{
    public static bool IsMonotone(int[] arr) =>
        arr.SequenceEqual([.. arr.OrderBy(x => x)]);
}
