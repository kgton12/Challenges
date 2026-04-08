namespace CodeWars.Completed;

public class MaximumProduct
{
    public static int AdjacentElementsProduct(int[] array)
    {
        int result = int.MinValue;

        for (int index = 0; index < array.Length - 1; index++)
            result = Math.Max(result, array[index] * array[index + 1]);

        return result;
    }
}
