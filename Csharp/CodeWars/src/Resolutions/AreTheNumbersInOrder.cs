namespace CodeWars.src.Resolutions;

public class AreTheNumbersInOrder
{
    public static bool IsAscOrder(int[] arr) =>
        arr.SequenceEqual(arr.OrderBy(x => x));
}
