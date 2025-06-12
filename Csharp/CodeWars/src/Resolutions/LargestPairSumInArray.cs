namespace CodeWars.src.Resolutions;

public class LargestPairSumInArray
{
    public static int LargestPairSum(int[] numbers) => numbers.OrderByDescending(x => x).Take(2).Sum();
}
