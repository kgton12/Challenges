namespace CodeWars.Completed;

public class AreaOfASquare
{
    public static double SquareArea(double A)
    {
        double r = 2 * A / Math.PI;
        double area = r * r;
        return Math.Round(area * 100) / 100;
    }
}
