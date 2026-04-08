namespace CodeWars.Completed;

public class SquareNSumClass
{
    public static int SquareSum(int[] numbers) =>
        (int)numbers.Sum(x => Math.Pow(x, 2));
}
