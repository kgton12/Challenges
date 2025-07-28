namespace CodeWars.src.Resolutions;

public class EvensTimesLast
{
    public static int EvenTimesLast(int[] arr) =>
        arr.Length == 0
        ? 0
        : arr
        .Where((_, index) => index % 2 == 0)
        .Sum(x => x * arr.Last());
}
