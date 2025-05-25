namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1011
{
    public static void Ball()
    {
        double radius = Convert.ToDouble(Console.ReadLine());

        double size = 4 / 3.0 * 3.14159 * Math.Pow(radius, 3);

        Console.WriteLine($"VOLUME = {size:F3}");
    }
}
