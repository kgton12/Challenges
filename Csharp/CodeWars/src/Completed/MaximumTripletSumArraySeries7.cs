namespace CodeWars.Completed;

public class MaximumTripletSumArraySeries7
{
    public static int MaxTriSum(int[] a) =>
        a.Distinct().OrderByDescending(x => x).Take(3).Sum();
}
