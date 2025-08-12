namespace CodeWars.src.Resolutions;

public class AreaOfACircle
{
    public static double CalculateAreaOfCircle(double radius) =>
        radius > 0
        ? Math.Round(Math.PI * radius * radius * 100) / 100
        : throw new ArgumentException();
}
