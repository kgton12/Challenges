namespace CodeWars.Resolutions;

public class DistanceFromTheAverage
{
    public static double[] DistancesFromAverage(int[] input) =>
        [.. input.Select(x =>
            Math.Round(input.Average() - x, 2)
        )];
}