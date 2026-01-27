namespace CodeWars.Resolutions;

public class AreTheNumbersInOrder
{
    public static bool IsAscOrder(int[] arr) =>
        arr.SequenceEqual(arr.OrderBy(x => x));
}
