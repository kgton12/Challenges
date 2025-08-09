namespace CodeWars.src.Resolutions;

public class GeometryBasicsCircleAreaIn2D
{
    public static double CircleArea(Circle circle) =>
        Math.PI * Math.Pow(circle.Radius, 2);
}
public class Circle(Point center, double radius)
{
    public Point Center { get; private set; } = center;
    public double Radius { get; private set; } = radius;
}

public class Point(double x, double y)
{
    public double X { get; private set; } = x;
    public double Y { get; private set; } = y;
}