namespace CodeWars.Resolutions;

public class RoundBy05Steps
{
    public static double Solution(double n) =>
        Math.Round(n * 2, MidpointRounding.AwayFromZero) / 2.0;
}