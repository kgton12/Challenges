namespace CodeWars.Completed;

public class HowManyConsecutiveNumbersAreNeeded
{
    public static int Consecutive(int[] arr) =>
        arr.Length > 0 ? arr.Max() - arr.Min() - arr.Length + 1 : 0;
}