namespace CodeWars.src;

public class ProductOfMaximumsOfArrayArraySeries2
{
    public static int MaxProduct(int[] arr, int size) => arr
           .OrderBy(n => n)
           .TakeLast(size)
           .Aggregate(1, (product, value) => product * value);
}
