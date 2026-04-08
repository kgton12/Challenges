namespace CodeWars.Completed;

public class ProductOfLargestPair
{
    public static int MaxProduct(int[] array) =>
        array.OrderBy(x => -x).Take(2).Aggregate((a, b) => a * b);
}