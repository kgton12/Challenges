namespace CodeWars.Completed;

public class SumOfPositive
{
    public static int PositiveSum(int[] arr) =>
        arr.Sum(x => x > 0 ? x : 0);
}
