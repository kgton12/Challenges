namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1002
{
    public static void CircleArea()
    {
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = 3.14159 * Math.Pow(radius, 2);
        Console.WriteLine($"A={area:F4}");
    }
}

