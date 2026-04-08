namespace CodeWars.Completed;

public class AreTheNumbersInOrder
{
    public static bool IsAscOrder(int[] arr) =>
        arr.SequenceEqual(arr.OrderBy(x => x));
}
