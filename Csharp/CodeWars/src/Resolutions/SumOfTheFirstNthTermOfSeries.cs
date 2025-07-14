namespace CodeWars.src.Resolutions;

public class SumOfTheFirstNthTermOfSeries
{
    public static string SeriesSum(int n)
    {
        double sum = 1;
        double term = 1;

        if (n <= 0) return "0.00";

        for (int index = 1; index < n; index++)
        {
            term += 3;
            sum += 1 / term;
        }
        return $"{sum:F2}";
    }
}
