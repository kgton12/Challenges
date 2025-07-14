namespace CodeWars.src.Resolutions;

public class HowGoodAreYouReally
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints) =>
        YourPoints > ClassPoints.Average();
}
