namespace CodeWars.Completed;

public class MinimizeSumOfArrayArraySeries1
{
    public static int MinSum(int[] a)
    {
        int[] ordenedValues = [.. a.OrderBy(x => x)];
        int sum = 0;
        for (int i = 0; i < a.Length / 2; i++)
            sum += ordenedValues.Skip(i).Take(1).First() * ordenedValues.Skip(a.Length - i - 1).Take(1).First();

        return sum;
    }
}
