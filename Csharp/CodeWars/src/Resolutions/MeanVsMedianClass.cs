namespace CodeWars.Resolutions;

public static class MeanVsMedianClass
{
    public static string MeanVsMedian(int[] numbers)
    {
        double avg = numbers.Average();
        double median = numbers.OrderBy(e => e).ElementAt(numbers.Length / 2);

        return (avg, median) switch
        {
            var (x, y) when x > y => "mean",
            var (x, y) when x < y => "median",
            _ => "same"
        };
    }
}