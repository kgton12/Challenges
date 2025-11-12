namespace CodeWars.src.Resolutions;

public class SimpleFun136MissingValues
{
    public static int MissingValues(int[] arr)
    {
        int x = NumberOfTimes(arr, 1);
        int y = NumberOfTimes(arr, 2);

        return x * x * y;
    }

    private static int NumberOfTimes(int[] arr, int n) =>
        arr
        .GroupBy(x => x)
        .First(x => x.Count() == n)
        .Key;
}