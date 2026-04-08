namespace CodeWars.Completed;

public class SumOfTwoLowestPositiveIntegers
{
    public static int SumTwoSmallestNumbers(int[] numbers) =>
        numbers.OrderBy(x => x).Take(2).Sum();
}
